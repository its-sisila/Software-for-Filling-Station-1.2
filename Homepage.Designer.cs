namespace Software_for_Filling_Station
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.testLabel = new System.Windows.Forms.Label();
            this.orders_label = new System.Windows.Forms.Label();
            this.usersLabel = new System.Windows.Forms.Label();
            this.logOutLabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.accountsLabel = new System.Windows.Forms.Label();
            this.salesLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.attendanceLabel = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.attendanceGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.stockGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ordersLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.database1DataSet2 = new Software_for_Filling_Station.Database1DataSet2();
            this.salesTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTestTableAdapter = new Software_for_Filling_Station.Database1DataSet2TableAdapters.salesTestTableAdapter();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startMeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endMeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesLitersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesLKRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nozzelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.testLabel);
            this.panel1.Controls.Add(this.orders_label);
            this.panel1.Controls.Add(this.usersLabel);
            this.panel1.Controls.Add(this.logOutLabel);
            this.panel1.Controls.Add(this.settingsLabel);
            this.panel1.Controls.Add(this.accountsLabel);
            this.panel1.Controls.Add(this.salesLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.inventoryLabel);
            this.panel1.Controls.Add(this.attendanceLabel);
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // testLabel
            // 
            this.testLabel.BackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.testLabel, "testLabel");
            this.testLabel.ForeColor = System.Drawing.Color.White;
            this.testLabel.Name = "testLabel";
            this.testLabel.Click += new System.EventHandler(this.testLabel_Click);
            // 
            // orders_label
            // 
            this.orders_label.BackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.orders_label, "orders_label");
            this.orders_label.ForeColor = System.Drawing.Color.White;
            this.orders_label.Name = "orders_label";
            this.orders_label.Click += new System.EventHandler(this.orders_label_Click);
            // 
            // usersLabel
            // 
            this.usersLabel.BackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.usersLabel, "usersLabel");
            this.usersLabel.ForeColor = System.Drawing.Color.White;
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Click += new System.EventHandler(this.usersLabel_Click);
            // 
            // logOutLabel
            // 
            this.logOutLabel.BackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.logOutLabel, "logOutLabel");
            this.logOutLabel.ForeColor = System.Drawing.Color.White;
            this.logOutLabel.Name = "logOutLabel";
            this.logOutLabel.Click += new System.EventHandler(this.logOutLabel_Click);
            // 
            // settingsLabel
            // 
            this.settingsLabel.BackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.settingsLabel, "settingsLabel");
            this.settingsLabel.ForeColor = System.Drawing.Color.White;
            this.settingsLabel.Name = "settingsLabel";
            // 
            // accountsLabel
            // 
            this.accountsLabel.BackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.accountsLabel, "accountsLabel");
            this.accountsLabel.ForeColor = System.Drawing.Color.White;
            this.accountsLabel.Name = "accountsLabel";
            this.accountsLabel.Click += new System.EventHandler(this.accountsLabel_Click);
            // 
            // salesLabel
            // 
            this.salesLabel.BackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.salesLabel, "salesLabel");
            this.salesLabel.ForeColor = System.Drawing.Color.White;
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Click += new System.EventHandler(this.salesLabel_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.BackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.inventoryLabel, "inventoryLabel");
            this.inventoryLabel.ForeColor = System.Drawing.Color.White;
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Click += new System.EventHandler(this.inventoryLabel_Click);
            // 
            // attendanceLabel
            // 
            this.attendanceLabel.BackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.attendanceLabel, "attendanceLabel");
            this.attendanceLabel.ForeColor = System.Drawing.Color.White;
            this.attendanceLabel.Name = "attendanceLabel";
            // 
            // webBrowser1
            // 
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            resources.ApplyResources(this.webBrowser1, "webBrowser1");
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Url = new System.Uri("https://news.google.com/search?q=crude%20oil&hl=en-US&gl=US&ceid=US%3Aen", System.UriKind.Absolute);
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // attendanceGrid
            // 
            this.attendanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.attendanceGrid, "attendanceGrid");
            this.attendanceGrid.Name = "attendanceGrid";
            this.attendanceGrid.RowTemplate.Height = 28;
            this.attendanceGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attendanceGrid_CellContentClick);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // stockGrid
            // 
            this.stockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.stockGrid, "stockGrid");
            this.stockGrid.Name = "stockGrid";
            this.stockGrid.RowTemplate.Height = 28;
            this.stockGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // ordersLabel
            // 
            resources.ApplyResources(this.ordersLabel, "ordersLabel");
            this.ordersLabel.Name = "ordersLabel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.startMeterDataGridViewTextBoxColumn,
            this.endMeterDataGridViewTextBoxColumn,
            this.salesLitersDataGridViewTextBoxColumn,
            this.salesLKRDataGridViewTextBoxColumn,
            this.nozzelDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.salesTestBindingSource;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesTestBindingSource
            // 
            this.salesTestBindingSource.DataMember = "salesTest";
            this.salesTestBindingSource.DataSource = this.database1DataSet2;
            // 
            // salesTestTableAdapter
            // 
            this.salesTestTableAdapter.ClearBeforeFill = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            resources.ApplyResources(this.dateDataGridViewTextBoxColumn, "dateDataGridViewTextBoxColumn");
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "shift";
            resources.ApplyResources(this.shiftDataGridViewTextBoxColumn, "shiftDataGridViewTextBoxColumn");
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            // 
            // startMeterDataGridViewTextBoxColumn
            // 
            this.startMeterDataGridViewTextBoxColumn.DataPropertyName = "startMeter";
            resources.ApplyResources(this.startMeterDataGridViewTextBoxColumn, "startMeterDataGridViewTextBoxColumn");
            this.startMeterDataGridViewTextBoxColumn.Name = "startMeterDataGridViewTextBoxColumn";
            // 
            // endMeterDataGridViewTextBoxColumn
            // 
            this.endMeterDataGridViewTextBoxColumn.DataPropertyName = "endMeter";
            resources.ApplyResources(this.endMeterDataGridViewTextBoxColumn, "endMeterDataGridViewTextBoxColumn");
            this.endMeterDataGridViewTextBoxColumn.Name = "endMeterDataGridViewTextBoxColumn";
            // 
            // salesLitersDataGridViewTextBoxColumn
            // 
            this.salesLitersDataGridViewTextBoxColumn.DataPropertyName = "salesLiters";
            resources.ApplyResources(this.salesLitersDataGridViewTextBoxColumn, "salesLitersDataGridViewTextBoxColumn");
            this.salesLitersDataGridViewTextBoxColumn.Name = "salesLitersDataGridViewTextBoxColumn";
            // 
            // salesLKRDataGridViewTextBoxColumn
            // 
            this.salesLKRDataGridViewTextBoxColumn.DataPropertyName = "salesLKR";
            resources.ApplyResources(this.salesLKRDataGridViewTextBoxColumn, "salesLKRDataGridViewTextBoxColumn");
            this.salesLKRDataGridViewTextBoxColumn.Name = "salesLKRDataGridViewTextBoxColumn";
            // 
            // nozzelDataGridViewTextBoxColumn
            // 
            this.nozzelDataGridViewTextBoxColumn.DataPropertyName = "nozzel";
            resources.ApplyResources(this.nozzelDataGridViewTextBoxColumn, "nozzelDataGridViewTextBoxColumn");
            this.nozzelDataGridViewTextBoxColumn.Name = "nozzelDataGridViewTextBoxColumn";
            // 
            // Homepage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ordersLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stockGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.attendanceGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Homepage";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label attendanceLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView attendanceGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView stockGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label accountsLabel;
        private System.Windows.Forms.Label salesLabel;
        private System.Windows.Forms.Label logOutLabel;
        private System.Windows.Forms.Label ordersLabel;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label orders_label;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource salesTestBindingSource;
        private Database1DataSet2TableAdapters.salesTestTableAdapter salesTestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startMeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endMeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesLitersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesLKRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nozzelDataGridViewTextBoxColumn;
    }
}