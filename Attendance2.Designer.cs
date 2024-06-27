namespace Software_for_Filling_Station
{
    partial class Attendance2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPageMarkAttendance = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTimeIn = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.AttendanceSheetdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerforTInTOut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEmployeeID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.checkBoxmarkAttendance = new System.Windows.Forms.CheckBox();
            this.buttonTimeOut = new System.Windows.Forms.Button();
            this.labelSupervisorName = new System.Windows.Forms.Label();
            this.comboBoxSupervisorName = new System.Windows.Forms.ComboBox();
            this.AttendanceSheetDataGrid = new System.Windows.Forms.DataGridView();
            this.addnewsupervisorbtn = new System.Windows.Forms.Button();
            this.addnewemployeebtn = new System.Windows.Forms.Button();
            this.tabPageMarkAttendance.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceSheetDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageMarkAttendance
            // 
            this.tabPageMarkAttendance.Controls.Add(this.tabPage1);
            this.tabPageMarkAttendance.Location = new System.Drawing.Point(12, 12);
            this.tabPageMarkAttendance.Name = "tabPageMarkAttendance";
            this.tabPageMarkAttendance.SelectedIndex = 0;
            this.tabPageMarkAttendance.Size = new System.Drawing.Size(1556, 860);
            this.tabPageMarkAttendance.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addnewsupervisorbtn);
            this.tabPage1.Controls.Add(this.addnewemployeebtn);
            this.tabPage1.Controls.Add(this.AttendanceSheetDataGrid);
            this.tabPage1.Controls.Add(this.comboBoxSupervisorName);
            this.tabPage1.Controls.Add(this.labelSupervisorName);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1548, 831);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mark Attendance";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTimeOut);
            this.groupBox1.Controls.Add(this.checkBoxmarkAttendance);
            this.groupBox1.Controls.Add(this.textBoxEmployeeName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxEmployeeID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerforTInTOut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AttendanceSheetdateTimePicker);
            this.groupBox1.Controls.Add(this.labelDate);
            this.groupBox1.Controls.Add(this.buttonTimeIn);
            this.groupBox1.Location = new System.Drawing.Point(36, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(763, 357);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendance";
            // 
            // buttonTimeIn
            // 
            this.buttonTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeIn.Location = new System.Drawing.Point(367, 251);
            this.buttonTimeIn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTimeIn.Name = "buttonTimeIn";
            this.buttonTimeIn.Size = new System.Drawing.Size(115, 41);
            this.buttonTimeIn.TabIndex = 6;
            this.buttonTimeIn.Text = "Time In";
            this.buttonTimeIn.UseVisualStyleBackColor = true;
            this.buttonTimeIn.Click += new System.EventHandler(this.buttonTimeIn_Click_1);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(28, 32);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(61, 20);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "Date :";
            // 
            // AttendanceSheetdateTimePicker
            // 
            this.AttendanceSheetdateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceSheetdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AttendanceSheetdateTimePicker.Location = new System.Drawing.Point(120, 32);
            this.AttendanceSheetdateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.AttendanceSheetdateTimePicker.Name = "AttendanceSheetdateTimePicker";
            this.AttendanceSheetdateTimePicker.Size = new System.Drawing.Size(268, 22);
            this.AttendanceSheetdateTimePicker.TabIndex = 8;
            this.AttendanceSheetdateTimePicker.Value = new System.DateTime(2024, 4, 24, 18, 32, 19, 0);
            this.AttendanceSheetdateTimePicker.ValueChanged += new System.EventHandler(this.AttendanceSheetdateTimePicker_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Time :";
            // 
            // dateTimePickerforTInTOut
            // 
            this.dateTimePickerforTInTOut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerforTInTOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerforTInTOut.Location = new System.Drawing.Point(560, 32);
            this.dateTimePickerforTInTOut.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerforTInTOut.Name = "dateTimePickerforTInTOut";
            this.dateTimePickerforTInTOut.Size = new System.Drawing.Size(120, 22);
            this.dateTimePickerforTInTOut.TabIndex = 10;
            this.dateTimePickerforTInTOut.Value = new System.DateTime(2024, 4, 24, 18, 32, 19, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Employee ID :";
            // 
            // comboBoxEmployeeID
            // 
            this.comboBoxEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployeeID.FormattingEnabled = true;
            this.comboBoxEmployeeID.Location = new System.Drawing.Point(32, 124);
            this.comboBoxEmployeeID.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEmployeeID.Name = "comboBoxEmployeeID";
            this.comboBoxEmployeeID.Size = new System.Drawing.Size(324, 24);
            this.comboBoxEmployeeID.TabIndex = 12;
            this.comboBoxEmployeeID.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployeeID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(477, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Employee Name :";
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(417, 121);
            this.textBoxEmployeeName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmployeeName.Multiline = true;
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(324, 27);
            this.textBoxEmployeeName.TabIndex = 14;
            // 
            // checkBoxmarkAttendance
            // 
            this.checkBoxmarkAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxmarkAttendance.AutoSize = true;
            this.checkBoxmarkAttendance.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxmarkAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxmarkAttendance.Location = new System.Drawing.Point(303, 190);
            this.checkBoxmarkAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxmarkAttendance.Name = "checkBoxmarkAttendance";
            this.checkBoxmarkAttendance.Size = new System.Drawing.Size(157, 24);
            this.checkBoxmarkAttendance.TabIndex = 15;
            this.checkBoxmarkAttendance.Text = "Mark Attendance";
            this.checkBoxmarkAttendance.UseVisualStyleBackColor = true;
            // 
            // buttonTimeOut
            // 
            this.buttonTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeOut.Location = new System.Drawing.Point(565, 251);
            this.buttonTimeOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTimeOut.Name = "buttonTimeOut";
            this.buttonTimeOut.Size = new System.Drawing.Size(115, 41);
            this.buttonTimeOut.TabIndex = 16;
            this.buttonTimeOut.Text = "Time Out";
            this.buttonTimeOut.UseVisualStyleBackColor = true;
            this.buttonTimeOut.Click += new System.EventHandler(this.buttonTimeOut_Click_1);
            // 
            // labelSupervisorName
            // 
            this.labelSupervisorName.AutoSize = true;
            this.labelSupervisorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupervisorName.Location = new System.Drawing.Point(1074, 66);
            this.labelSupervisorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSupervisorName.Name = "labelSupervisorName";
            this.labelSupervisorName.Size = new System.Drawing.Size(159, 20);
            this.labelSupervisorName.TabIndex = 12;
            this.labelSupervisorName.Text = "Supervisor Name:";
            // 
            // comboBoxSupervisorName
            // 
            this.comboBoxSupervisorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupervisorName.FormattingEnabled = true;
            this.comboBoxSupervisorName.Location = new System.Drawing.Point(1078, 105);
            this.comboBoxSupervisorName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSupervisorName.Name = "comboBoxSupervisorName";
            this.comboBoxSupervisorName.Size = new System.Drawing.Size(324, 24);
            this.comboBoxSupervisorName.TabIndex = 13;
            // 
            // AttendanceSheetDataGrid
            // 
            this.AttendanceSheetDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            this.AttendanceSheetDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.AttendanceSheetDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttendanceSheetDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AttendanceSheetDataGrid.BackgroundColor = System.Drawing.Color.Gray;
            this.AttendanceSheetDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendanceSheetDataGrid.GridColor = System.Drawing.Color.White;
            this.AttendanceSheetDataGrid.Location = new System.Drawing.Point(36, 431);
            this.AttendanceSheetDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.AttendanceSheetDataGrid.Name = "AttendanceSheetDataGrid";
            this.AttendanceSheetDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.AttendanceSheetDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.AttendanceSheetDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceSheetDataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.AttendanceSheetDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttendanceSheetDataGrid.Size = new System.Drawing.Size(1456, 296);
            this.AttendanceSheetDataGrid.TabIndex = 14;
            // 
            // addnewsupervisorbtn
            // 
            this.addnewsupervisorbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addnewsupervisorbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewsupervisorbtn.Location = new System.Drawing.Point(364, 759);
            this.addnewsupervisorbtn.Margin = new System.Windows.Forms.Padding(4);
            this.addnewsupervisorbtn.Name = "addnewsupervisorbtn";
            this.addnewsupervisorbtn.Size = new System.Drawing.Size(269, 41);
            this.addnewsupervisorbtn.TabIndex = 15;
            this.addnewsupervisorbtn.Text = "Add New Supervisor";
            this.addnewsupervisorbtn.UseVisualStyleBackColor = true;
            this.addnewsupervisorbtn.Click += new System.EventHandler(this.addnewsupervisorbtn_Click_1);
            // 
            // addnewemployeebtn
            // 
            this.addnewemployeebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addnewemployeebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewemployeebtn.Location = new System.Drawing.Point(68, 757);
            this.addnewemployeebtn.Margin = new System.Windows.Forms.Padding(4);
            this.addnewemployeebtn.Name = "addnewemployeebtn";
            this.addnewemployeebtn.Size = new System.Drawing.Size(269, 41);
            this.addnewemployeebtn.TabIndex = 16;
            this.addnewemployeebtn.Text = "Add New Employer";
            this.addnewemployeebtn.UseVisualStyleBackColor = true;
            this.addnewemployeebtn.Click += new System.EventHandler(this.addnewemployeebtn_Click_1);
            // 
            // Attendance2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 895);
            this.Controls.Add(this.tabPageMarkAttendance);
            this.Name = "Attendance2";
            this.Text = "Attendance2";
            this.Load += new System.EventHandler(this.Attendance2_Load);
            this.tabPageMarkAttendance.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceSheetDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPageMarkAttendance;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonTimeIn;
        private System.Windows.Forms.ComboBox comboBoxEmployeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerforTInTOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker AttendanceSheetdateTimePicker;
        private System.Windows.Forms.DataGridView AttendanceSheetDataGrid;
        private System.Windows.Forms.ComboBox comboBoxSupervisorName;
        private System.Windows.Forms.Label labelSupervisorName;
        private System.Windows.Forms.Button buttonTimeOut;
        private System.Windows.Forms.CheckBox checkBoxmarkAttendance;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addnewsupervisorbtn;
        private System.Windows.Forms.Button addnewemployeebtn;
    }
}