﻿namespace Software_for_Filling_Station
{
    partial class salesTest
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
            this.panel11 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.shiftBox = new System.Windows.Forms.ComboBox();
            this.literPriceText = new System.Windows.Forms.TextBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.literPriceLabel = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nozzelText = new System.Windows.Forms.ComboBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.submitButton = new System.Windows.Forms.Button();
            this.salesLKRtxt = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.salesLiterstxt = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.endMeterText = new System.Windows.Forms.TextBox();
            this.startMeterText = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startMeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endMeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesLitersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesLKRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nozzelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDropDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet14 = new Software_for_Filling_Station.Database1DataSet14();
            this.salesTestTableAdapter = new Software_for_Filling_Station.Database1DataSet14TableAdapters.salesTestTableAdapter();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.dateTimePicker2);
            this.panel11.Controls.Add(this.shiftBox);
            this.panel11.Controls.Add(this.literPriceText);
            this.panel11.Controls.Add(this.checkBox11);
            this.panel11.Controls.Add(this.literPriceLabel);
            this.panel11.Controls.Add(this.insertButton);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Controls.Add(this.nozzelText);
            this.panel11.Controls.Add(this.label68);
            this.panel11.Controls.Add(this.label69);
            this.panel11.Controls.Add(this.dateTimePicker1);
            this.panel11.Controls.Add(this.submitButton);
            this.panel11.Controls.Add(this.salesLKRtxt);
            this.panel11.Controls.Add(this.label71);
            this.panel11.Controls.Add(this.salesLiterstxt);
            this.panel11.Controls.Add(this.label72);
            this.panel11.Controls.Add(this.label75);
            this.panel11.Controls.Add(this.endMeterText);
            this.panel11.Controls.Add(this.startMeterText);
            this.panel11.Controls.Add(this.label76);
            this.panel11.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel11.Location = new System.Drawing.Point(30, 33);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(467, 597);
            this.panel11.TabIndex = 37;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(153, 280);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(219, 26);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // shiftBox
            // 
            this.shiftBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftBox.FormattingEnabled = true;
            this.shiftBox.Items.AddRange(new object[] {
            "7:00 AM (Day)",
            "7:00 PM (Night)"});
            this.shiftBox.Location = new System.Drawing.Point(153, 240);
            this.shiftBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shiftBox.Name = "shiftBox";
            this.shiftBox.Size = new System.Drawing.Size(219, 28);
            this.shiftBox.TabIndex = 19;
            this.shiftBox.SelectedIndexChanged += new System.EventHandler(this.shiftBox_SelectedIndexChanged);
            // 
            // literPriceText
            // 
            this.literPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.literPriceText.Location = new System.Drawing.Point(153, 182);
            this.literPriceText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.literPriceText.Name = "literPriceText";
            this.literPriceText.Size = new System.Drawing.Size(222, 27);
            this.literPriceText.TabIndex = 22;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.Location = new System.Drawing.Point(82, 546);
            this.checkBox11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(291, 22);
            this.checkBox11.TabIndex = 16;
            this.checkBox11.Text = "I\'m accountable for above data I entered";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // literPriceLabel
            // 
            this.literPriceLabel.AutoSize = true;
            this.literPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.literPriceLabel.Location = new System.Drawing.Point(10, 190);
            this.literPriceLabel.Name = "literPriceLabel";
            this.literPriceLabel.Size = new System.Drawing.Size(87, 20);
            this.literPriceLabel.TabIndex = 21;
            this.literPriceLabel.Text = "Liter Price";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(206, 314);
            this.insertButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(84, 27);
            this.insertButton.TabIndex = 20;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nozzel";
            // 
            // nozzelText
            // 
            this.nozzelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nozzelText.FormattingEnabled = true;
            this.nozzelText.Items.AddRange(new object[] {
            "LP 92 - 1",
            "LP 92 - 2",
            "LP 92 - 3",
            "LP 92 - 4",
            "LP 92 - 5",
            "LP 92 - 6",
            "LAD - 1",
            "LAD - 2",
            "LAD - 3",
            "LAD - 4",
            "LAD - 5",
            "LAD - 6",
            "LAD - 7",
            "LAD - 8",
            "LP 95 - 1",
            "LSD - 1"});
            this.nozzelText.Location = new System.Drawing.Point(143, 12);
            this.nozzelText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nozzelText.Name = "nozzelText";
            this.nozzelText.Size = new System.Drawing.Size(232, 28);
            this.nozzelText.TabIndex = 17;
            this.nozzelText.SelectedIndexChanged += new System.EventHandler(this.nozzelText_SelectedIndexChanged);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(11, 240);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(115, 18);
            this.label68.TabIndex = 15;
            this.label68.Text = "Shift (Day/Night)";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(10, 63);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(45, 20);
            this.label69.TabIndex = 14;
            this.label69.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 58);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 24);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // submitButton
            // 
            this.submitButton.AutoSize = true;
            this.submitButton.BackColor = System.Drawing.Color.LightGray;
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.submitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.submitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(189, 455);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(101, 40);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // salesLKRtxt
            // 
            this.salesLKRtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesLKRtxt.Location = new System.Drawing.Point(150, 404);
            this.salesLKRtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salesLKRtxt.Name = "salesLKRtxt";
            this.salesLKRtxt.Size = new System.Drawing.Size(222, 27);
            this.salesLKRtxt.TabIndex = 8;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(28, 425);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(89, 20);
            this.label71.TabIndex = 7;
            this.label71.Text = "Sales LKR";
            // 
            // salesLiterstxt
            // 
            this.salesLiterstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesLiterstxt.Location = new System.Drawing.Point(153, 360);
            this.salesLiterstxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salesLiterstxt.Name = "salesLiterstxt";
            this.salesLiterstxt.Size = new System.Drawing.Size(222, 27);
            this.salesLiterstxt.TabIndex = 6;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(24, 368);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(93, 20);
            this.label72.TabIndex = 5;
            this.label72.Text = "Sales liters";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(10, 141);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(105, 20);
            this.label75.TabIndex = 4;
            this.label75.Text = "Meter at End";
            // 
            // endMeterText
            // 
            this.endMeterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endMeterText.Location = new System.Drawing.Point(153, 133);
            this.endMeterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endMeterText.Name = "endMeterText";
            this.endMeterText.Size = new System.Drawing.Size(221, 27);
            this.endMeterText.TabIndex = 3;
            // 
            // startMeterText
            // 
            this.startMeterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMeterText.Location = new System.Drawing.Point(153, 95);
            this.startMeterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startMeterText.Name = "startMeterText";
            this.startMeterText.Size = new System.Drawing.Size(221, 27);
            this.startMeterText.TabIndex = 2;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(10, 99);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(112, 20);
            this.label76.TabIndex = 1;
            this.label76.Text = "Meter at Start";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.startMeterDataGridViewTextBoxColumn,
            this.endMeterDataGridViewTextBoxColumn,
            this.salesLitersDataGridViewTextBoxColumn,
            this.salesLKRDataGridViewTextBoxColumn,
            this.nozzelDataGridViewTextBoxColumn,
            this.shiftDropDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesTestBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(528, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(943, 597);
            this.dataGridView1.TabIndex = 38;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "shift";
            this.shiftDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.Width = 125;
            // 
            // startMeterDataGridViewTextBoxColumn
            // 
            this.startMeterDataGridViewTextBoxColumn.DataPropertyName = "startMeter";
            this.startMeterDataGridViewTextBoxColumn.HeaderText = "startMeter";
            this.startMeterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startMeterDataGridViewTextBoxColumn.Name = "startMeterDataGridViewTextBoxColumn";
            this.startMeterDataGridViewTextBoxColumn.Width = 125;
            // 
            // endMeterDataGridViewTextBoxColumn
            // 
            this.endMeterDataGridViewTextBoxColumn.DataPropertyName = "endMeter";
            this.endMeterDataGridViewTextBoxColumn.HeaderText = "endMeter";
            this.endMeterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endMeterDataGridViewTextBoxColumn.Name = "endMeterDataGridViewTextBoxColumn";
            this.endMeterDataGridViewTextBoxColumn.Width = 125;
            // 
            // salesLitersDataGridViewTextBoxColumn
            // 
            this.salesLitersDataGridViewTextBoxColumn.DataPropertyName = "salesLiters";
            this.salesLitersDataGridViewTextBoxColumn.HeaderText = "salesLiters";
            this.salesLitersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salesLitersDataGridViewTextBoxColumn.Name = "salesLitersDataGridViewTextBoxColumn";
            this.salesLitersDataGridViewTextBoxColumn.Width = 125;
            // 
            // salesLKRDataGridViewTextBoxColumn
            // 
            this.salesLKRDataGridViewTextBoxColumn.DataPropertyName = "salesLKR";
            this.salesLKRDataGridViewTextBoxColumn.HeaderText = "salesLKR";
            this.salesLKRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salesLKRDataGridViewTextBoxColumn.Name = "salesLKRDataGridViewTextBoxColumn";
            this.salesLKRDataGridViewTextBoxColumn.Width = 125;
            // 
            // nozzelDataGridViewTextBoxColumn
            // 
            this.nozzelDataGridViewTextBoxColumn.DataPropertyName = "nozzel";
            this.nozzelDataGridViewTextBoxColumn.HeaderText = "nozzel";
            this.nozzelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nozzelDataGridViewTextBoxColumn.Name = "nozzelDataGridViewTextBoxColumn";
            this.nozzelDataGridViewTextBoxColumn.Width = 125;
            // 
            // shiftDropDataGridViewTextBoxColumn
            // 
            this.shiftDropDataGridViewTextBoxColumn.DataPropertyName = "shiftDrop";
            this.shiftDropDataGridViewTextBoxColumn.HeaderText = "shiftDrop";
            this.shiftDropDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shiftDropDataGridViewTextBoxColumn.Name = "shiftDropDataGridViewTextBoxColumn";
            this.shiftDropDataGridViewTextBoxColumn.Width = 125;
            // 
            // salesTestBindingSource
            // 
            this.salesTestBindingSource.DataMember = "salesTest";
            this.salesTestBindingSource.DataSource = this.database1DataSet14;
            // 
            // database1DataSet14
            // 
            this.database1DataSet14.DataSetName = "Database1DataSet14";
            this.database1DataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesTestTableAdapter
            // 
            this.salesTestTableAdapter.ClearBeforeFill = true;
            // 
            // salesTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1484, 722);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel11);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "salesTest";
            this.Text = "salesTest";
            this.Load += new System.EventHandler(this.salesTest_Load);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet14)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox salesLKRtxt;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox salesLiterstxt;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.TextBox endMeterText;
        private System.Windows.Forms.TextBox startMeterText;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nozzelText;
        private System.Windows.Forms.ComboBox shiftBox;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox literPriceText;
        private System.Windows.Forms.Label literPriceLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet14 database1DataSet14;
        private System.Windows.Forms.BindingSource salesTestBindingSource;
        private Database1DataSet14TableAdapters.salesTestTableAdapter salesTestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startMeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endMeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesLitersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesLKRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nozzelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDropDataGridViewTextBoxColumn;
    }
}