namespace Software_for_Filling_Station
{
    partial class Attendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMarkAttendance = new System.Windows.Forms.TabPage();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.addnewsupervisorbtn = new System.Windows.Forms.Button();
            this.addnewemployeebtn = new System.Windows.Forms.Button();
            this.buttonTimeOut = new System.Windows.Forms.Button();
            this.buttonTimeIn = new System.Windows.Forms.Button();
            this.AttendanceSheetDataGrid = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_Out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxSupervisorName = new System.Windows.Forms.ComboBox();
            this.dateTimePickerforTInTOut = new System.Windows.Forms.DateTimePicker();
            this.AttendanceSheetdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelSupervisorName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMarkAttendance = new System.Windows.Forms.Label();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet15 = new Software_for_Filling_Station.Database1DataSet15();
            this.employeeTableAdapter = new Software_for_Filling_Station.Database1DataSet15TableAdapters.EmployeeTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPageMarkAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceSheetDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPageMarkAttendance);
            this.tabControl1.Location = new System.Drawing.Point(49, 29);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1425, 869);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageMarkAttendance
            // 
            this.tabPageMarkAttendance.Controls.Add(this.buttonPrint);
            this.tabPageMarkAttendance.Controls.Add(this.addnewsupervisorbtn);
            this.tabPageMarkAttendance.Controls.Add(this.addnewemployeebtn);
            this.tabPageMarkAttendance.Controls.Add(this.buttonTimeOut);
            this.tabPageMarkAttendance.Controls.Add(this.buttonTimeIn);
            this.tabPageMarkAttendance.Controls.Add(this.AttendanceSheetDataGrid);
            this.tabPageMarkAttendance.Controls.Add(this.comboBoxSupervisorName);
            this.tabPageMarkAttendance.Controls.Add(this.dateTimePickerforTInTOut);
            this.tabPageMarkAttendance.Controls.Add(this.AttendanceSheetdateTimePicker);
            this.tabPageMarkAttendance.Controls.Add(this.labelSupervisorName);
            this.tabPageMarkAttendance.Controls.Add(this.label1);
            this.tabPageMarkAttendance.Controls.Add(this.labelDate);
            this.tabPageMarkAttendance.Controls.Add(this.labelMarkAttendance);
            this.tabPageMarkAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMarkAttendance.Location = new System.Drawing.Point(4, 4);
            this.tabPageMarkAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageMarkAttendance.Name = "tabPageMarkAttendance";
            this.tabPageMarkAttendance.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageMarkAttendance.Size = new System.Drawing.Size(1417, 840);
            this.tabPageMarkAttendance.TabIndex = 0;
            this.tabPageMarkAttendance.Text = "Mark Attendance";
            this.tabPageMarkAttendance.UseVisualStyleBackColor = true;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.Location = new System.Drawing.Point(973, 754);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(65, 43);
            this.buttonPrint.TabIndex = 7;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // addnewsupervisorbtn
            // 
            this.addnewsupervisorbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addnewsupervisorbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewsupervisorbtn.Location = new System.Drawing.Point(345, 756);
            this.addnewsupervisorbtn.Margin = new System.Windows.Forms.Padding(4);
            this.addnewsupervisorbtn.Name = "addnewsupervisorbtn";
            this.addnewsupervisorbtn.Size = new System.Drawing.Size(269, 41);
            this.addnewsupervisorbtn.TabIndex = 6;
            this.addnewsupervisorbtn.Text = "Add New Supervisor";
            this.addnewsupervisorbtn.UseVisualStyleBackColor = true;
            this.addnewsupervisorbtn.Click += new System.EventHandler(this.addnewsupervisorbtn_Click);
            // 
            // addnewemployeebtn
            // 
            this.addnewemployeebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addnewemployeebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewemployeebtn.Location = new System.Drawing.Point(49, 754);
            this.addnewemployeebtn.Margin = new System.Windows.Forms.Padding(4);
            this.addnewemployeebtn.Name = "addnewemployeebtn";
            this.addnewemployeebtn.Size = new System.Drawing.Size(269, 41);
            this.addnewemployeebtn.TabIndex = 6;
            this.addnewemployeebtn.Text = "Add New Employer";
            this.addnewemployeebtn.UseVisualStyleBackColor = true;
            this.addnewemployeebtn.Click += new System.EventHandler(this.addnewemployeebtn_Click);
            // 
            // buttonTimeOut
            // 
            this.buttonTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeOut.Location = new System.Drawing.Point(1185, 754);
            this.buttonTimeOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTimeOut.Name = "buttonTimeOut";
            this.buttonTimeOut.Size = new System.Drawing.Size(115, 41);
            this.buttonTimeOut.TabIndex = 6;
            this.buttonTimeOut.Text = "Time Out";
            this.buttonTimeOut.UseVisualStyleBackColor = true;
            this.buttonTimeOut.Click += new System.EventHandler(this.buttonTimeOut_Click);
            // 
            // buttonTimeIn
            // 
            this.buttonTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeIn.Location = new System.Drawing.Point(1063, 754);
            this.buttonTimeIn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTimeIn.Name = "buttonTimeIn";
            this.buttonTimeIn.Size = new System.Drawing.Size(115, 41);
            this.buttonTimeIn.TabIndex = 6;
            this.buttonTimeIn.Text = "Time In";
            this.buttonTimeIn.UseVisualStyleBackColor = true;
            this.buttonTimeIn.Click += new System.EventHandler(this.buttonTimeIn_Click);
            // 
            // AttendanceSheetDataGrid
            // 
            this.AttendanceSheetDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.AttendanceSheetDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AttendanceSheetDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttendanceSheetDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AttendanceSheetDataGrid.BackgroundColor = System.Drawing.Color.Gray;
            this.AttendanceSheetDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendanceSheetDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.EmployeeID,
            this.Time_In,
            this.Time_Out});
            this.AttendanceSheetDataGrid.GridColor = System.Drawing.Color.White;
            this.AttendanceSheetDataGrid.Location = new System.Drawing.Point(49, 203);
            this.AttendanceSheetDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.AttendanceSheetDataGrid.Name = "AttendanceSheetDataGrid";
            this.AttendanceSheetDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.AttendanceSheetDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.AttendanceSheetDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceSheetDataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.AttendanceSheetDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttendanceSheetDataGrid.Size = new System.Drawing.Size(1284, 519);
            this.AttendanceSheetDataGrid.TabIndex = 5;
            this.AttendanceSheetDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendanceSheetDataGrid_CellContentClick);
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EmployeeID
            // 
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            // 
            // Time_In
            // 
            this.Time_In.HeaderText = "Time In";
            this.Time_In.MinimumWidth = 6;
            this.Time_In.Name = "Time_In";
            // 
            // Time_Out
            // 
            this.Time_Out.HeaderText = "Time Out";
            this.Time_Out.MinimumWidth = 6;
            this.Time_Out.Name = "Time_Out";
            // 
            // comboBoxSupervisorName
            // 
            this.comboBoxSupervisorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupervisorName.FormattingEnabled = true;
            this.comboBoxSupervisorName.Location = new System.Drawing.Point(867, 124);
            this.comboBoxSupervisorName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSupervisorName.Name = "comboBoxSupervisorName";
            this.comboBoxSupervisorName.Size = new System.Drawing.Size(324, 26);
            this.comboBoxSupervisorName.TabIndex = 4;
            this.comboBoxSupervisorName.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupervisorName_SelectedIndexChanged);
            // 
            // dateTimePickerforTInTOut
            // 
            this.dateTimePickerforTInTOut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerforTInTOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerforTInTOut.Location = new System.Drawing.Point(391, 126);
            this.dateTimePickerforTInTOut.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerforTInTOut.Name = "dateTimePickerforTInTOut";
            this.dateTimePickerforTInTOut.Size = new System.Drawing.Size(120, 24);
            this.dateTimePickerforTInTOut.TabIndex = 3;
            this.dateTimePickerforTInTOut.Value = new System.DateTime(2024, 4, 24, 18, 32, 19, 0);
            // 
            // AttendanceSheetdateTimePicker
            // 
            this.AttendanceSheetdateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceSheetdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AttendanceSheetdateTimePicker.Location = new System.Drawing.Point(49, 126);
            this.AttendanceSheetdateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.AttendanceSheetdateTimePicker.Name = "AttendanceSheetdateTimePicker";
            this.AttendanceSheetdateTimePicker.Size = new System.Drawing.Size(268, 24);
            this.AttendanceSheetdateTimePicker.TabIndex = 3;
            this.AttendanceSheetdateTimePicker.Value = new System.DateTime(2024, 4, 24, 18, 32, 19, 0);
            this.AttendanceSheetdateTimePicker.ValueChanged += new System.EventHandler(this.AttendanceSheetdateTimePicker_ValueChanged);
            // 
            // labelSupervisorName
            // 
            this.labelSupervisorName.AutoSize = true;
            this.labelSupervisorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupervisorName.Location = new System.Drawing.Point(863, 89);
            this.labelSupervisorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSupervisorName.Name = "labelSupervisorName";
            this.labelSupervisorName.Size = new System.Drawing.Size(159, 20);
            this.labelSupervisorName.TabIndex = 2;
            this.labelSupervisorName.Text = "Supervisor Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(45, 89);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(61, 20);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date :";
            // 
            // labelMarkAttendance
            // 
            this.labelMarkAttendance.AutoSize = true;
            this.labelMarkAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMarkAttendance.Location = new System.Drawing.Point(8, 33);
            this.labelMarkAttendance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMarkAttendance.Name = "labelMarkAttendance";
            this.labelMarkAttendance.Size = new System.Drawing.Size(180, 25);
            this.labelMarkAttendance.TabIndex = 0;
            this.labelMarkAttendance.Text = "Attendance Sheet :";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.database1DataSet15;
            // 
            // database1DataSet15
            // 
            this.database1DataSet15.DataSetName = "Database1DataSet15";
            this.database1DataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 1029);
            this.Controls.Add(this.tabControl1);
            this.Name = "Attendance";
            this.ShowIcon = false;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMarkAttendance.ResumeLayout(false);
            this.tabPageMarkAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceSheetDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet15)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMarkAttendance;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button addnewsupervisorbtn;
        private System.Windows.Forms.Button addnewemployeebtn;
        private System.Windows.Forms.Button buttonTimeOut;
        private System.Windows.Forms.Button buttonTimeIn;
        private System.Windows.Forms.DataGridView AttendanceSheetDataGrid;
        private System.Windows.Forms.ComboBox comboBoxSupervisorName;
        private System.Windows.Forms.DateTimePicker dateTimePickerforTInTOut;
        private System.Windows.Forms.DateTimePicker AttendanceSheetdateTimePicker;
        private System.Windows.Forms.Label labelSupervisorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMarkAttendance;
        private Database1DataSet15 database1DataSet15;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Database1DataSet15TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_In;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_Out;
    }
}