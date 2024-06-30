namespace Software_for_Filling_Station
{
    partial class InventoryV1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectTankButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tankNoDrop = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dipSaleText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.todayDipText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prevDipText = new System.Windows.Forms.TextBox();
            this.LP95_tank1_Label = new System.Windows.Forms.Label();
            this.meterSale = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevDIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tankNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todayDipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dipSaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet10 = new Software_for_Filling_Station.Database1DataSet10();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet7 = new Software_for_Filling_Station.Database1DataSet7();
            this.inventoryTableAdapter = new Software_for_Filling_Station.Database1DataSet7TableAdapters.InventoryTableAdapter();
            this.inventory2TableAdapter = new Software_for_Filling_Station.Database1DataSet10TableAdapters.Inventory2TableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.selectTankButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tankNoDrop);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.dipSaleText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.submitButton);
            this.panel1.Controls.Add(this.todayDipText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.prevDipText);
            this.panel1.Controls.Add(this.LP95_tank1_Label);
            this.panel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 580);
            this.panel1.TabIndex = 1;
            // 
            // selectTankButton
            // 
            this.selectTankButton.BackColor = System.Drawing.Color.LightGray;
            this.selectTankButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.selectTankButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.selectTankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectTankButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTankButton.Location = new System.Drawing.Point(280, 157);
            this.selectTankButton.Name = "selectTankButton";
            this.selectTankButton.Size = new System.Drawing.Size(95, 38);
            this.selectTankButton.TabIndex = 22;
            this.selectTankButton.Text = "Select";
            this.selectTankButton.UseVisualStyleBackColor = false;
            this.selectTankButton.Click += new System.EventHandler(this.selectTankButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tank No.";
            // 
            // tankNoDrop
            // 
            this.tankNoDrop.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tankNoDrop.FormattingEnabled = true;
            this.tankNoDrop.Items.AddRange(new object[] {
            "LP 95 Tank 01",
            "LSD Tank 01",
            "LAD Tank 01",
            "Tank LAD-02 ",
            "Tank LAD-03",
            "Tank LAD-04",
            "Tank LP 92-01",
            "Tank LP 92-02"});
            this.tankNoDrop.Location = new System.Drawing.Point(185, 104);
            this.tankNoDrop.Name = "tankNoDrop";
            this.tankNoDrop.Size = new System.Drawing.Size(276, 30);
            this.tankNoDrop.TabIndex = 17;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(168, 51);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(293, 28);
            this.dateTimePicker.TabIndex = 9;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(110, 535);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(333, 26);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "I\'m accountable for above Data I Entered";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dipSaleText
            // 
            this.dipSaleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dipSaleText.Location = new System.Drawing.Point(245, 339);
            this.dipSaleText.Name = "dipSaleText";
            this.dipSaleText.Size = new System.Drawing.Size(215, 27);
            this.dipSaleText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Difference (Dip Sale)";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.LightGray;
            this.submitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.submitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(296, 400);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(110, 39);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // todayDipText
            // 
            this.todayDipText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDipText.Location = new System.Drawing.Point(245, 282);
            this.todayDipText.Name = "todayDipText";
            this.todayDipText.Size = new System.Drawing.Size(215, 27);
            this.todayDipText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Today\'s Day Dip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Previous Day Dip";
            // 
            // prevDipText
            // 
            this.prevDipText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevDipText.Location = new System.Drawing.Point(245, 223);
            this.prevDipText.Name = "prevDipText";
            this.prevDipText.Size = new System.Drawing.Size(215, 27);
            this.prevDipText.TabIndex = 1;
            this.prevDipText.TextChanged += new System.EventHandler(this.prevDipText_TextChanged);
            // 
            // LP95_tank1_Label
            // 
            this.LP95_tank1_Label.AutoSize = true;
            this.LP95_tank1_Label.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LP95_tank1_Label.Location = new System.Drawing.Point(209, 22);
            this.LP95_tank1_Label.Name = "LP95_tank1_Label";
            this.LP95_tank1_Label.Size = new System.Drawing.Size(103, 22);
            this.LP95_tank1_Label.TabIndex = 0;
            this.LP95_tank1_Label.Text = "Inventory";
            // 
            // meterSale
            // 
            this.meterSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meterSale.Location = new System.Drawing.Point(798, 716);
            this.meterSale.Name = "meterSale";
            this.meterSale.Size = new System.Drawing.Size(215, 27);
            this.meterSale.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(593, 681);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 57);
            this.label5.TabIndex = 19;
            this.label5.Text = "Expected Difference\r\nAccording to\r\nMeter Sale";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.prevDIp,
            this.tankNoDataGridViewTextBoxColumn,
            this.todayDipDataGridViewTextBoxColumn,
            this.dipSaleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventory2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(570, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(999, 753);
            this.dataGridView1.TabIndex = 2;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // prevDIp
            // 
            this.prevDIp.DataPropertyName = "prevDIp";
            this.prevDIp.HeaderText = "prevDIp";
            this.prevDIp.MinimumWidth = 6;
            this.prevDIp.Name = "prevDIp";
            this.prevDIp.Width = 125;
            // 
            // tankNoDataGridViewTextBoxColumn
            // 
            this.tankNoDataGridViewTextBoxColumn.DataPropertyName = "tankNo";
            this.tankNoDataGridViewTextBoxColumn.HeaderText = "tankNo";
            this.tankNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tankNoDataGridViewTextBoxColumn.Name = "tankNoDataGridViewTextBoxColumn";
            this.tankNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // todayDipDataGridViewTextBoxColumn
            // 
            this.todayDipDataGridViewTextBoxColumn.DataPropertyName = "todayDip";
            this.todayDipDataGridViewTextBoxColumn.HeaderText = "todayDip";
            this.todayDipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.todayDipDataGridViewTextBoxColumn.Name = "todayDipDataGridViewTextBoxColumn";
            this.todayDipDataGridViewTextBoxColumn.Width = 125;
            // 
            // dipSaleDataGridViewTextBoxColumn
            // 
            this.dipSaleDataGridViewTextBoxColumn.DataPropertyName = "dipSale";
            this.dipSaleDataGridViewTextBoxColumn.HeaderText = "dipSale";
            this.dipSaleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dipSaleDataGridViewTextBoxColumn.Name = "dipSaleDataGridViewTextBoxColumn";
            this.dipSaleDataGridViewTextBoxColumn.Width = 125;
            // 
            // inventory2BindingSource
            // 
            this.inventory2BindingSource.DataMember = "Inventory2";
            this.inventory2BindingSource.DataSource = this.database1DataSet10;
            // 
            // database1DataSet10
            // 
            this.database1DataSet10.DataSetName = "Database1DataSet10";
            this.database1DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.database1DataSet7;
            // 
            // database1DataSet7
            // 
            this.database1DataSet7.DataSetName = "Database1DataSet7";
            this.database1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // inventory2TableAdapter
            // 
            this.inventory2TableAdapter.ClearBeforeFill = true;
            // 
            // InventoryV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1574, 858);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.meterSale);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InventoryV1";
            this.ShowIcon = false;
            this.Text = "InventoryV1";
            this.Load += new System.EventHandler(this.InventoryV1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox dipSaleText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox todayDipText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prevDipText;
        private System.Windows.Forms.Label LP95_tank1_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tankNoDrop;
        private System.Windows.Forms.TextBox meterSale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button selectTankButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet7 database1DataSet7;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private Database1DataSet7TableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private Database1DataSet10 database1DataSet10;
        private System.Windows.Forms.BindingSource inventory2BindingSource;
        private Database1DataSet10TableAdapters.Inventory2TableAdapter inventory2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevDIp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tankNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn todayDipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dipSaleDataGridViewTextBoxColumn;
    }
}