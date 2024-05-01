namespace Software_for_Filling_Station
{
    partial class Orders
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tankNoDrop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label35 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.litersText = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.receivedButton = new System.Windows.Forms.Button();
            this.fuelTypeDrop = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.litersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tankNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet11 = new Software_for_Filling_Station.Database1DataSet11();
            this.ordersTableAdapter = new Software_for_Filling_Station.Database1DataSet11TableAdapters.OrdersTableAdapter();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.tankNoDrop);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.datePicker);
            this.panel9.Controls.Add(this.label35);
            this.panel9.Controls.Add(this.checkBox1);
            this.panel9.Controls.Add(this.litersText);
            this.panel9.Controls.Add(this.label33);
            this.panel9.Controls.Add(this.receivedButton);
            this.panel9.Controls.Add(this.fuelTypeDrop);
            this.panel9.Controls.Add(this.label34);
            this.panel9.Location = new System.Drawing.Point(33, 44);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(505, 417);
            this.panel9.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tank No.";
            // 
            // tankNoDrop
            // 
            this.tankNoDrop.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tankNoDrop.FormattingEnabled = true;
            this.tankNoDrop.Items.AddRange(new object[] {
            "Tank LP 95-01",
            "Tank LSD-01",
            "Tank LAD-01",
            "Tank LAD-02 ",
            "Tank LAD-03",
            "Tank LAD-04",
            "Tank LP 92-01",
            "Tank LP 92-02"});
            this.tankNoDrop.Location = new System.Drawing.Point(185, 248);
            this.tankNoDrop.Name = "tankNoDrop";
            this.tankNoDrop.Size = new System.Drawing.Size(246, 30);
            this.tankNoDrop.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(185, 103);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(246, 28);
            this.datePicker.TabIndex = 11;
            this.datePicker.Value = new System.DateTime(2024, 4, 27, 20, 29, 6, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(181, 15);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(86, 26);
            this.label35.TabIndex = 10;
            this.label35.Text = "Orders";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(123, 377);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(296, 22);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "I\'m accountable for above Data I Entered";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // litersText
            // 
            this.litersText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.litersText.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litersText.Location = new System.Drawing.Point(185, 196);
            this.litersText.Name = "litersText";
            this.litersText.Size = new System.Drawing.Size(246, 29);
            this.litersText.TabIndex = 4;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(52, 203);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(57, 22);
            this.label33.TabIndex = 3;
            this.label33.Text = "Liters";
            // 
            // receivedButton
            // 
            this.receivedButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedButton.Location = new System.Drawing.Point(207, 323);
            this.receivedButton.Name = "receivedButton";
            this.receivedButton.Size = new System.Drawing.Size(114, 36);
            this.receivedButton.TabIndex = 2;
            this.receivedButton.Text = "Received";
            this.receivedButton.UseVisualStyleBackColor = true;
            this.receivedButton.Click += new System.EventHandler(this.receivedButton_Click);
            // 
            // fuelTypeDrop
            // 
            this.fuelTypeDrop.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelTypeDrop.FormattingEnabled = true;
            this.fuelTypeDrop.Items.AddRange(new object[] {
            "LP 92",
            "LAD",
            "LP 95",
            "LSD"});
            this.fuelTypeDrop.Location = new System.Drawing.Point(185, 152);
            this.fuelTypeDrop.Name = "fuelTypeDrop";
            this.fuelTypeDrop.Size = new System.Drawing.Size(246, 30);
            this.fuelTypeDrop.TabIndex = 1;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(52, 160);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(93, 22);
            this.label34.TabIndex = 0;
            this.label34.Text = "Fuel Type";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.fuelTypeDataGridViewTextBoxColumn,
            this.litersDataGridViewTextBoxColumn,
            this.tankNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(616, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(664, 975);
            this.dataGridView1.TabIndex = 11;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // fuelTypeDataGridViewTextBoxColumn
            // 
            this.fuelTypeDataGridViewTextBoxColumn.DataPropertyName = "fuelType";
            this.fuelTypeDataGridViewTextBoxColumn.HeaderText = "fuelType";
            this.fuelTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fuelTypeDataGridViewTextBoxColumn.Name = "fuelTypeDataGridViewTextBoxColumn";
            this.fuelTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // litersDataGridViewTextBoxColumn
            // 
            this.litersDataGridViewTextBoxColumn.DataPropertyName = "Liters";
            this.litersDataGridViewTextBoxColumn.HeaderText = "Liters";
            this.litersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.litersDataGridViewTextBoxColumn.Name = "litersDataGridViewTextBoxColumn";
            this.litersDataGridViewTextBoxColumn.Width = 125;
            // 
            // tankNoDataGridViewTextBoxColumn
            // 
            this.tankNoDataGridViewTextBoxColumn.DataPropertyName = "tankNo";
            this.tankNoDataGridViewTextBoxColumn.HeaderText = "tankNo";
            this.tankNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tankNoDataGridViewTextBoxColumn.Name = "tankNoDataGridViewTextBoxColumn";
            this.tankNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.database1DataSet11;
            // 
            // database1DataSet11
            // 
            this.database1DataSet11.DataSetName = "Database1DataSet11";
            this.database1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel9);
            this.Name = "Orders";
            this.ShowIcon = false;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox litersText;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button receivedButton;
        private System.Windows.Forms.ComboBox fuelTypeDrop;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox tankNoDrop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet11 database1DataSet11;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Database1DataSet11TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn litersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tankNoDataGridViewTextBoxColumn;
    }
}