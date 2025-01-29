using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace RebusQueue
{
    public partial class Form1 : Form
    {
        private string connectionString;
        private string RebusQueueName = "defaultRebusQueue";  // Example default values
        private string DeadletterQueueName = "defaultDeadletterQueue";
        private string SagaDataTableName = "defaultSagaDataTable";
        private string SagaIndexTableName = "defaultSagaIndexTable";
        List<QueueMessage> decodedData = new List<QueueMessage>();
        List<SagaData> sagaData = new List<SagaData>();

        public Form1()
        {
            InitializeComponent();
            InitializeMenu();
            UpdateStatusBar();
            LoadDataToDataGridView();
        }

        private void InitializeMenu()
        {
            MenuStrip menuStrip = new MenuStrip();

            ToolStripMenuItem settingsMenu = new ToolStripMenuItem("Settings");
            ToolStripMenuItem menuOpenSettings = new ToolStripMenuItem("Open Settings", null, menuOpenSettings_Click);

            settingsMenu.DropDownItems.Add(menuOpenSettings);
            menuStrip.Items.Add(settingsMenu);

            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }

        private List<QueueMessage> GetDecodedData()
        {
            List<QueueMessage> decodedData = new List<QueueMessage>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = $"SELECT * FROM {RebusQueueName} WITH (NOLOCK)";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        QueueMessage data = new QueueMessage
                        {
                            Id = Convert.ToInt32(row["id"]),
                            Priority = Convert.ToInt32(row["priority"]),
                            // Convert DateTimeOffset to DateTime
                            Expiration = ((DateTimeOffset)row["expiration"]).DateTime,
                            Visible = ((DateTimeOffset)row["visible"]).DateTime,
                            Headers = row["headers"] != DBNull.Value ? (byte[])row["headers"] : null,
                            Body = row["body"] != DBNull.Value ? (byte[])row["body"] : null,
                            BodyDecoded = null,
                            HeadersDecoded = null
                        };

                        // Decode 'headers' if it's not null and decode byte array to JSON
                        if (data.Headers != null)
                        {
                            string headerString = Encoding.UTF8.GetString(data.Headers);
                            try
                            {

                                // Parse dan format ulang dengan indentasi
                                var parsedJson = JToken.Parse(headerString);
                                string formattedJson = parsedJson.ToString(Formatting.Indented);
                                data.MessageType = parsedJson["rbs2-msg-type"]?.ToString() ?? ""; 
                                data.HeadersDecoded = formattedJson;  // Parse JSON object from string
                            }
                            catch (Exception)
                            {
                                data.HeadersDecoded = null;  // If it's not valid JSON, just leave it as null
                            }
                        }

                        // Decode 'body' if it's not null and decode byte array to JSON
                        if (data.Body != null)
                        {
                            string bodyString = Encoding.UTF8.GetString(data.Body);
                            try
                            {
                                // Parse dan format ulang dengan indentasi
                                var parsedJson = JToken.Parse(bodyString);
                                string formattedJson = parsedJson.ToString(Formatting.Indented);
                                data.BodyDecoded = formattedJson;  // Parse JSON object from string
                            }
                            catch (Exception)
                            {
                                data.BodyDecoded = null;  // If it's not valid JSON, just leave it as null
                            }
                        }

                        decodedData.Add(data);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return decodedData;
        }

        private List<SagaData> GetSagaData()
        {
            List<SagaData> decodedData = new List<SagaData>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = $"SELECT * FROM {SagaDataTableName} WITH (NOLOCK)";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        SagaData data = new SagaData
                        {
                            Id = Guid.Parse(row["id"]?.ToString()),
                            Revision = Convert.ToInt32(row["revision"]),
                            // Convert DateTimeOffset to DateTime
                            Data = row["data"] != DBNull.Value ? (byte[])row["data"] : null,
                        };

                        // Decode 'headers' if it's not null and decode byte array to JSON
                        if (data.Data != null)
                        {
                            string headerString = Encoding.UTF8.GetString(data.Data);
                            try
                            {

                                // Parse dan format ulang dengan indentasi
                                var parsedJson = JToken.Parse(headerString);
                                string formattedJson = parsedJson.ToString(Formatting.Indented);
                                data.DataDecoded = formattedJson;  // Parse JSON object from string
                            }
                            catch (Exception)
                            {
                                data.DataDecoded = null;  // If it's not valid JSON, just leave it as null
                            }
                        }

                        

                        decodedData.Add(data);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return decodedData;
        }


        // ✅ Klik Button untuk Load Data Manual
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                MessageBox.Show("⚠️ Connection string belum diatur. Silakan atur terlebih dahulu di menu Settings.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Clear existing data from DataGridViews
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;

            // Optionally clear any selection or reset column definitions
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            LoadDataToDataGridView();
        }

        private void UpdateStatusBar()
        {
            statusLabel.Text = string.IsNullOrWhiteSpace(connectionString)
                ? "⚠️ Connection String: Not Set"
                : $"✅ Connection String: {connectionString}";
        }

        private void menuOpenSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(connectionString, RebusQueueName, DeadletterQueueName, SagaDataTableName, SagaIndexTableName);
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                connectionString = settingsForm.ConnectionString;
                RebusQueueName = settingsForm.RebusQueueName;
                DeadletterQueueName = settingsForm.DeadletterQueueName;
                SagaDataTableName = settingsForm.SagaDataTableName;
                SagaIndexTableName = settingsForm.SagaIndexTableName;

                // Optionally update the status bar or display any confirmation
                UpdateStatusBar();
            }
        }

        // Fungsi untuk mengonversi hex ke string
        private string DecodeHexToString(string hex)
        {
            int length = hex.Length;
            byte[] bytes = new byte[length / 2];
            for (int i = 0; i < length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return Encoding.UTF8.GetString(bytes);
        }
    }



    public class QueueMessage
    {
        public int Id { get; set; }
        public int Priority { get; set; }

        public string MessageType { get; set; }

        public DateTime Expiration { get; set; }
        public DateTime Visible { get; set; }
        public byte[] Headers { get; set; }
        public string HeadersDecoded { get; set; }  // Store decoded headers as JSON object
        public byte[] Body { get; set; }
        public string BodyDecoded { get; set; }  // Store decoded body as JSON object
    }

    public class SagaData
    {
        public Guid Id { get; set; }
        public int Revision { get; set; }
        public byte[] Data { get; set; }
        public string DataDecoded { get; set; }  // Store decoded headers as JSON object
    }
}
