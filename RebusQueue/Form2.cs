using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RebusQueue
{
    public partial class SettingsForm : Form
    {
        public string ConnectionString { get; set; }
        public string RebusQueueName { get; set; }
        public string DeadletterQueueName { get; set; }
        public string SagaDataTableName { get; set; }
        public string SagaIndexTableName { get; set; }

        public SettingsForm(string connectionString, string rebusQueue, string deadletterQueue,
                            string sagaDataTableName, string sagaIndexTableName)
        {
            InitializeComponent();

            // Set current values
            txtConnectionString.Text = connectionString;
            txtRebusQueue.Text = rebusQueue;
            txtDeadletterQueue.Text = deadletterQueue;
            txtSagaDataTableName.Text = sagaDataTableName;
            txtSagaIndexTableName.Text = sagaIndexTableName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save the updated values
            ConnectionString = txtConnectionString.Text;
            RebusQueueName = txtRebusQueue.Text;
            DeadletterQueueName = txtDeadletterQueue.Text;
            SagaDataTableName = txtSagaDataTableName.Text;
            SagaIndexTableName = txtSagaIndexTableName.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
