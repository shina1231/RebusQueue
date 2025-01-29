namespace RebusQueue
{
	partial class SettingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.TextBox txtRebusQueue;
        private System.Windows.Forms.TextBox txtDeadletterQueue;
        private System.Windows.Forms.TextBox txtSagaDataTableName;
        private System.Windows.Forms.TextBox txtSagaIndexTableName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        // Declare labels at the class level
        private Label lblConnectionString;
        private Label lblRebusQueue;
        private Label lblDeadletterQueue;
        private Label lblSagaDataTableName;
        private Label lblSagaIndexTableName;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.txtRebusQueue = new System.Windows.Forms.TextBox();
            this.txtDeadletterQueue = new System.Windows.Forms.TextBox();
            this.txtSagaDataTableName = new System.Windows.Forms.TextBox();
            this.txtSagaIndexTableName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            // 
            // lblConnectionString
            // 
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.lblConnectionString.Location = new System.Drawing.Point(12, 8);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(360, 23);
            this.lblConnectionString.Text = "Connection String:";
            this.Controls.Add(this.lblConnectionString);

            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(12, 28);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(360, 23);
            this.txtConnectionString.TabIndex = 0;

            // 
            // lblRebusQueue
            // 
            this.lblRebusQueue = new System.Windows.Forms.Label();
            this.lblRebusQueue.Location = new System.Drawing.Point(12, 60);
            this.lblRebusQueue.Name = "lblRebusQueue";
            this.lblRebusQueue.Size = new System.Drawing.Size(360, 23);
            this.lblRebusQueue.Text = "Rebus Queue:";
            this.Controls.Add(this.lblRebusQueue);

            // 
            // txtRebusQueue
            // 
            this.txtRebusQueue.Location = new System.Drawing.Point(12, 80);
            this.txtRebusQueue.Name = "txtRebusQueue";
            this.txtRebusQueue.Size = new System.Drawing.Size(360, 23);
            this.txtRebusQueue.TabIndex = 1;

            // 
            // lblDeadletterQueue
            // 
            this.lblDeadletterQueue = new System.Windows.Forms.Label();
            this.lblDeadletterQueue.Location = new System.Drawing.Point(12, 112);
            this.lblDeadletterQueue.Name = "lblDeadletterQueue";
            this.lblDeadletterQueue.Size = new System.Drawing.Size(360, 23);
            this.lblDeadletterQueue.Text = "Deadletter Queue:";
            this.Controls.Add(this.lblDeadletterQueue);

            // 
            // txtDeadletterQueue
            // 
            this.txtDeadletterQueue.Location = new System.Drawing.Point(12, 132);
            this.txtDeadletterQueue.Name = "txtDeadletterQueue";
            this.txtDeadletterQueue.Size = new System.Drawing.Size(360, 23);
            this.txtDeadletterQueue.TabIndex = 2;

            // 
            // lblSagaDataTableName
            // 
            this.lblSagaDataTableName = new System.Windows.Forms.Label();
            this.lblSagaDataTableName.Location = new System.Drawing.Point(12, 164);
            this.lblSagaDataTableName.Name = "lblSagaDataTableName";
            this.lblSagaDataTableName.Size = new System.Drawing.Size(360, 23);
            this.lblSagaDataTableName.Text = "Saga Data Table Name:";
            this.Controls.Add(this.lblSagaDataTableName);

            // 
            // txtSagaDataTableName
            // 
            this.txtSagaDataTableName.Location = new System.Drawing.Point(12, 184);
            this.txtSagaDataTableName.Name = "txtSagaDataTableName";
            this.txtSagaDataTableName.Size = new System.Drawing.Size(360, 23);
            this.txtSagaDataTableName.TabIndex = 3;

            // 
            // lblSagaIndexTableName
            // 
            this.lblSagaIndexTableName = new System.Windows.Forms.Label();
            this.lblSagaIndexTableName.Location = new System.Drawing.Point(12, 216);
            this.lblSagaIndexTableName.Name = "lblSagaIndexTableName";
            this.lblSagaIndexTableName.Size = new System.Drawing.Size(360, 23);
            this.lblSagaIndexTableName.Text = "Saga Index Table Name:";
            this.Controls.Add(this.lblSagaIndexTableName);

            // 
            // txtSagaIndexTableName
            // 
            this.txtSagaIndexTableName.Location = new System.Drawing.Point(12, 236);
            this.txtSagaIndexTableName.Name = "txtSagaIndexTableName";
            this.txtSagaIndexTableName.Size = new System.Drawing.Size(360, 23);
            this.txtSagaIndexTableName.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(216, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSagaIndexTableName);
            this.Controls.Add(this.txtSagaDataTableName);
            this.Controls.Add(this.txtDeadletterQueue);
            this.Controls.Add(this.txtRebusQueue);
            this.Controls.Add(this.txtConnectionString);
            this.Name = "SettingsForm";
            this.Text = "Settings";
        }
        #region Windows Form Designer generated code

		#endregion
	}
}