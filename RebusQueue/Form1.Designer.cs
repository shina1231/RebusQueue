namespace RebusQueue
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.TreeView treeView;
		private System.Windows.Forms.TableLayoutPanel tableLayout;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.TextBox logConsole;
		private System.Windows.Forms.Button btnRetrieve;
		private System.Windows.Forms.Label labelCount1;
		private System.Windows.Forms.Label labelCount2;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel;
		private System.Windows.Forms.StatusStrip statusStrip;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.treeView = new System.Windows.Forms.TreeView();
			this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.logConsole = new System.Windows.Forms.TextBox();
			this.btnRetrieve = new System.Windows.Forms.Button();

			// ✅ SplitContainer untuk TreeView & DataGridView
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Panel1.Controls.Add(this.treeView);
			this.splitContainer.Panel2.Controls.Add(this.tableLayout);

			// ✅ Buat StatusStrip dan StatusLabel
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip.Items.Add(this.statusLabel);
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;

			// ✅ Tambahkan StatusStrip ke Form
			this.Controls.Add(this.statusStrip);


			// ✅ TreeView di sebelah kiri
			this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;

			// ✅ Label untuk menampilkan jumlah data di DataGridView1
			this.labelCount1 = new System.Windows.Forms.Label();
			this.labelCount1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCount1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

			// ✅ Label untuk menampilkan jumlah data di DataGridView2
			this.labelCount2 = new System.Windows.Forms.Label();
			this.labelCount2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCount2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

			// ✅ TableLayoutPanel untuk menampung 2 DataGridView
			this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayout.RowCount = 4;
			this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F)); // Row untuk label count1
			this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F)); // Row untuk label count2
			this.tableLayout.Controls.Add(this.dataGridView1, 0, 0);
			this.tableLayout.Controls.Add(this.labelCount1, 0, 1);
			this.tableLayout.Controls.Add(this.dataGridView2, 0, 2);
			this.tableLayout.Controls.Add(this.labelCount2, 0, 3);

			// ✅ DataGridView1 untuk RebusTenantSync
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None; // Jangan autosize
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Both; // Aktifkan scrollbar horizontal

			// ✅ DataGridView2 untuk RebusSagaData
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
			this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Both;

			// ✅ Log Console di bawah
			this.logConsole.Multiline = true;
			this.logConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.logConsole.Height = 100;

			// ✅ Button Retrieve di atas
			this.btnRetrieve.Text = "Retrieve Messages";
			this.btnRetrieve.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnRetrieve.Click += new System.EventHandler(this.button1_Click);

			// ✅ Tambahkan semua komponen ke Form
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.logConsole);
			this.Controls.Add(this.btnRetrieve);
		}

		private void LoadDataToDataGridView()
		{
			if (string.IsNullOrWhiteSpace(connectionString))
			{
				MessageBox.Show("⚠️ Connection string belum diatur. Silakan atur terlebih dahulu di menu Settings.",
								"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			// Ambil data yang sudah didecode
			List<QueueMessage> data = GetDecodedData();

			// Ambil data yang sudah didecode
			List<SagaData> sagaData = GetSagaData();

			// Set DataSource DataGridView ke list model
			dataGridView1.DataSource = data;

			// Optional: Menyesuaikan kolom yang ditampilkan
			dataGridView1.Columns["Headers"].Visible = false;  // Kolom asli, mungkin ingin disembunyikan
			dataGridView1.Columns["Body"].Visible = false;  // Kolom asli, mungkin ingin disembunyikan
															// ✅ Update jumlah data yang ditampilkan
			labelCount1.Text = $"Total Data: {data.Count}";
			labelCount2.Text = $"Total Data: {sagaData.Count}";

			// Optional: Format kolom tanggal agar lebih mudah dibaca
			if (dataGridView1.Columns["Expiration"] != null)
				dataGridView1.Columns["Expiration"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
			if (dataGridView1.Columns["Visible"] != null)
				dataGridView1.Columns["Visible"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";


			dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
			dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Both;

			dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
			dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Both;

			dataGridView1.AutoResizeRows();
			dataGridView1.AutoResizeRows();

			// Set DataSource DataGridView ke list model
			dataGridView2.DataSource = sagaData;

			// Optional: Menyesuaikan kolom yang ditampilkan
			dataGridView2.Columns["Data"].Visible = false;  // Kolom asli, mungkin ingin disembunyikan

			dataGridView2.AutoResizeRows();
			dataGridView2.AutoResizeRows();
		}
	}
}
