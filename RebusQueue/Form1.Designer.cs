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
			this.labelCount1 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.labelCount2 = new System.Windows.Forms.Label();
			this.logConsole = new System.Windows.Forms.TextBox();
			this.btnRetrieve = new System.Windows.Forms.Button();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.tableLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 23);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.treeView);

			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.tableLayout);
			this.splitContainer.Size = new System.Drawing.Size(284, 203);
			this.splitContainer.SplitterDistance = 94;
			this.splitContainer.TabIndex = 1;

			// 
			// treeView
			// 
			this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView.Location = new System.Drawing.Point(0, 0);
			this.treeView.Name = "treeView";
			this.treeView.Size = new System.Drawing.Size(94, 203);
			this.treeView.TabIndex = 0;
			this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);


			// 
			// tableLayout
			// 
			this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayout.Controls.Add(this.dataGridView1, 0, 0);
			this.tableLayout.Controls.Add(this.labelCount1, 0, 1);
			this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayout.Location = new System.Drawing.Point(0, 0);
			this.tableLayout.Name = "tableLayout";
			this.tableLayout.RowCount = 2;
			this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F)); // Row untuk label count1
			this.tableLayout.Size = new System.Drawing.Size(186, 203);
			this.tableLayout.TabIndex = 0;


			// 
			// labelCount1
			// 
			this.labelCount1 = new System.Windows.Forms.Label();
			this.labelCount1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCount1.Location = new System.Drawing.Point(3, 175);
			this.labelCount1.Name = "labelCount1";
			this.labelCount1.Size = new System.Drawing.Size(180, 20);
			this.labelCount1.TabIndex = 1;
			this.labelCount1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(180, 177);
			this.dataGridView1.TabIndex = 0;
			//// 
			//// dataGridView2
			//// 
			//this.dataGridView2.Location = new System.Drawing.Point(0, 0);
			//this.dataGridView2.Name = "dataGridView2";
			//this.dataGridView2.Size = new System.Drawing.Size(240, 150);
			//this.dataGridView2.TabIndex = 0;
			//// 
			//// labelCount2
			//// 
			//this.labelCount2.Location = new System.Drawing.Point(0, 0);
			//this.labelCount2.Name = "labelCount2";
			//this.labelCount2.Size = new System.Drawing.Size(100, 23);
			//this.labelCount2.TabIndex = 0;
			// 
			// logConsole
			// 
			this.logConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.logConsole.Location = new System.Drawing.Point(0, 226);
			this.logConsole.Multiline = true;
			this.logConsole.Name = "logConsole";
			this.logConsole.Size = new System.Drawing.Size(284, 35);
			this.logConsole.TabIndex = 2;
			// 
			// btnRetrieve
			// 
			this.btnRetrieve.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnRetrieve.Location = new System.Drawing.Point(0, 0);
			this.btnRetrieve.Name = "btnRetrieve";
			this.btnRetrieve.Size = new System.Drawing.Size(284, 23);
			this.btnRetrieve.TabIndex = 3;
			this.btnRetrieve.Text = "Retrieve Messages";
			this.btnRetrieve.Click += new System.EventHandler(this.button1_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 204);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(284, 22);
			this.statusStrip.TabIndex = 0;
			// 
			// statusLabel
			// 
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.logConsole);
			this.Controls.Add(this.btnRetrieve);
			this.Name = "Form1";
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.tableLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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

		private void LoadMessages()
		{
			List<QueueMessage> data = GetDecodedData();

			dataGridView1.DataSource = data;
			// Optional: Menyesuaikan kolom yang ditampilkan
			if (dataGridView1.Columns["Headers"] != null)
				dataGridView1.Columns["Headers"].Visible = false;  // Kolom asli, mungkin ingin disembunyikan
			if (dataGridView1.Columns["Body"] != null)
				dataGridView1.Columns["Body"].Visible = false;  // Kolom asli, mungkin ingin disembunyikan
																// ✅ Update jumlah data yang ditampilkan
																// Optional: Format kolom tanggal agar lebih mudah dibaca
			if (dataGridView1.Columns["Expiration"] != null)
				dataGridView1.Columns["Expiration"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
			if (dataGridView1.Columns["Visible"] != null)
				dataGridView1.Columns["Visible"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
			labelCount1.Text = $"Total Messages: {data.Count}";
		}

		private void LoadSagaData()
		{
			List<SagaData> sagaData = GetSagaData();


			dataGridView2.DataSource = sagaData;
			// Optional: Menyesuaikan kolom yang ditampilkan
			if (dataGridView1.Columns["Headers"] != null)
				dataGridView1.Columns["Headers"].Visible = false;  // Kolom asli, mungkin ingin disembunyikan
			if (dataGridView1.Columns["Body"] != null)
				dataGridView1.Columns["Body"].Visible = false;  // Kolom asli, mungkin ingin disembunyikan
																// ✅ Update jumlah data yang ditampilkan
			if (dataGridView1.Columns["Data"] != null)
				dataGridView1.Columns["Data"].Visible = false;  // Kolom asli, mungkin ingin disembunyikan
			labelCount2.Text = $"Total Saga Data: {sagaData.Count}";
		}

		private void LoadDeadLetters()
		{
			List<QueueMessage> deadLetterData = GetDeadLetterData();

			dataGridView1.DataSource = deadLetterData;
			// Optional: Menyesuaikan kolom yang ditampilkan
			if (dataGridView1.Columns["Headers"] != null)
				dataGridView1.Columns["Headers"].Visible = false;  // Kolom asli, mungkin ingin disembunyikan
			if (dataGridView1.Columns["Body"] != null)
				dataGridView1.Columns["Body"].Visible = false;  // Kolom asli, mungkin ingin disembunyikan
																// ✅ Update jumlah data yang ditampilkan
			labelCount1.Text = $"Total Dead Letters: {deadLetterData.Count}";
		}

		private void InitializeTreeView()
		{
			treeView.Nodes.Clear();

			TreeNode messagesNode = new TreeNode("Messages");
			TreeNode sagaDataNode = new TreeNode("Saga Data");
			TreeNode deadLetterNode = new TreeNode("Dead Letter");

			treeView.Nodes.Add(messagesNode);
			treeView.Nodes.Add(sagaDataNode);
			treeView.Nodes.Add(deadLetterNode);
		}
	}
}
