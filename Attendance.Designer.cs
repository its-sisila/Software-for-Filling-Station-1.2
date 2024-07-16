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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPageMarkAttendance = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addnewaccountantbtn = new System.Windows.Forms.Button();
            this.addnewsupervisorbtn = new System.Windows.Forms.Button();
            this.addnewemployeebtn = new System.Windows.Forms.Button();
            this.AttendanceSheetDataGrid = new System.Windows.Forms.DataGridView();
            this.database1DataSetAttendancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetAttendances = new Software_for_Filling_Station.Database1DataSetAttendances();
            this.comboBoxSupervisorName = new System.Windows.Forms.ComboBox();
            this.labelSupervisorName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTimeOut = new System.Windows.Forms.Button();
            this.checkBoxmarkAttendance = new System.Windows.Forms.CheckBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEmployeeID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerforTInTOut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.AttendanceSheetdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonTimeIn = new System.Windows.Forms.Button();
            this.database1DataSet18 = new Software_for_Filling_Station.Database1DataSet18();
            this.attendancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendancesTableAdapter = new Software_for_Filling_Station.Database1DataSet18TableAdapters.AttendancesTableAdapter();
            this.database1DataSetAttendancesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet20 = new Software_for_Filling_Station.Database1DataSet20();
            this.attendancesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.attendancesTableAdapter1 = new Software_for_Filling_Station.Database1DataSet20TableAdapters.AttendancesTableAdapter();
            this.shiftcheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.tabPageMarkAttendance.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceSheetDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetAttendancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetAttendances)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetAttendancesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageMarkAttendance
            // 
            this.tabPageMarkAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPageMarkAttendance.Controls.Add(this.tabPage1);
            this.tabPageMarkAttendance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMarkAttendance.Location = new System.Drawing.Point(12, 12);
            this.tabPageMarkAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMarkAttendance.Name = "tabPageMarkAttendance";
            this.tabPageMarkAttendance.SelectedIndex = 0;
            this.tabPageMarkAttendance.Size = new System.Drawing.Size(1556, 860);
            this.tabPageMarkAttendance.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkRed;
            this.tabPage1.Controls.Add(this.addnewaccountantbtn);
            this.tabPage1.Controls.Add(this.AttendanceSheetDataGrid);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.addnewsupervisorbtn);
            this.tabPage1.Controls.Add(this.addnewemployeebtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1548, 828);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mark Attendance";
            // 
            // addnewaccountantbtn
            // 
            this.addnewaccountantbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addnewaccountantbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addnewaccountantbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addnewaccountantbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addnewaccountantbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewaccountantbtn.Location = new System.Drawing.Point(1172, 711);
            this.addnewaccountantbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addnewaccountantbtn.Name = "addnewaccountantbtn";
            this.addnewaccountantbtn.Size = new System.Drawing.Size(254, 41);
            this.addnewaccountantbtn.TabIndex = 15;
            this.addnewaccountantbtn.Text = "Add New Accountant";
            this.addnewaccountantbtn.UseVisualStyleBackColor = false;
            this.addnewaccountantbtn.Click += new System.EventHandler(this.addnewaccountantbtn_Click);
            // 
            // addnewsupervisorbtn
            // 
            this.addnewsupervisorbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addnewsupervisorbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addnewsupervisorbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addnewsupervisorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addnewsupervisorbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewsupervisorbtn.Location = new System.Drawing.Point(948, 711);
            this.addnewsupervisorbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addnewsupervisorbtn.Name = "addnewsupervisorbtn";
            this.addnewsupervisorbtn.Size = new System.Drawing.Size(201, 41);
            this.addnewsupervisorbtn.TabIndex = 15;
            this.addnewsupervisorbtn.Text = "Add New Supervisor";
            this.addnewsupervisorbtn.UseVisualStyleBackColor = false;
            this.addnewsupervisorbtn.Click += new System.EventHandler(this.addnewsupervisorbtn_Click_1);
            // 
            // addnewemployeebtn
            // 
            this.addnewemployeebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addnewemployeebtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addnewemployeebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addnewemployeebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addnewemployeebtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewemployeebtn.Location = new System.Drawing.Point(671, 711);
            this.addnewemployeebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addnewemployeebtn.Name = "addnewemployeebtn";
            this.addnewemployeebtn.Size = new System.Drawing.Size(201, 41);
            this.addnewemployeebtn.TabIndex = 16;
            this.addnewemployeebtn.Text = "Add New Employer";
            this.addnewemployeebtn.UseVisualStyleBackColor = false;
            this.addnewemployeebtn.Click += new System.EventHandler(this.addnewemployeebtn_Click_1);
            // 
            // AttendanceSheetDataGrid
            // 
            this.AttendanceSheetDataGrid.AllowUserToAddRows = false;
            this.AttendanceSheetDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Silver;
            this.AttendanceSheetDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.AttendanceSheetDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttendanceSheetDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AttendanceSheetDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.AttendanceSheetDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendanceSheetDataGrid.GridColor = System.Drawing.Color.White;
            this.AttendanceSheetDataGrid.Location = new System.Drawing.Point(455, 87);
            this.AttendanceSheetDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AttendanceSheetDataGrid.Name = "AttendanceSheetDataGrid";
            this.AttendanceSheetDataGrid.ReadOnly = true;
            this.AttendanceSheetDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.AttendanceSheetDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.AttendanceSheetDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceSheetDataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.AttendanceSheetDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttendanceSheetDataGrid.Size = new System.Drawing.Size(971, 597);
            this.AttendanceSheetDataGrid.TabIndex = 14;
            // 
            // database1DataSetAttendancesBindingSource
            // 
            this.database1DataSetAttendancesBindingSource.DataSource = this.database1DataSetAttendances;
            this.database1DataSetAttendancesBindingSource.Position = 0;
            // 
            // database1DataSetAttendances
            // 
            this.database1DataSetAttendances.DataSetName = "Database1DataSetAttendances";
            this.database1DataSetAttendances.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxSupervisorName
            // 
            this.comboBoxSupervisorName.BackColor = System.Drawing.Color.White;
            this.comboBoxSupervisorName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSupervisorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupervisorName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSupervisorName.FormattingEnabled = true;
            this.comboBoxSupervisorName.Location = new System.Drawing.Point(53, 206);
            this.comboBoxSupervisorName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSupervisorName.Name = "comboBoxSupervisorName";
            this.comboBoxSupervisorName.Size = new System.Drawing.Size(324, 28);
            this.comboBoxSupervisorName.TabIndex = 13;
            // 
            // labelSupervisorName
            // 
            this.labelSupervisorName.AutoSize = true;
            this.labelSupervisorName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelSupervisorName.ForeColor = System.Drawing.Color.Black;
            this.labelSupervisorName.Location = new System.Drawing.Point(51, 167);
            this.labelSupervisorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSupervisorName.Name = "labelSupervisorName";
            this.labelSupervisorName.Size = new System.Drawing.Size(154, 19);
            this.labelSupervisorName.TabIndex = 12;
            this.labelSupervisorName.Text = "Supervisor Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.shiftcheckedListBox);
            this.groupBox1.Controls.Add(this.buttonTimeOut);
            this.groupBox1.Controls.Add(this.checkBoxmarkAttendance);
            this.groupBox1.Controls.Add(this.textBoxEmployeeName);
            this.groupBox1.Controls.Add(this.comboBoxSupervisorName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelSupervisorName);
            this.groupBox1.Controls.Add(this.comboBoxEmployeeID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerforTInTOut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AttendanceSheetdateTimePicker);
            this.groupBox1.Controls.Add(this.labelDate);
            this.groupBox1.Controls.Add(this.buttonTimeIn);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(444, 824);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendance";
            // 
            // buttonTimeOut
            // 
            this.buttonTimeOut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonTimeOut.AutoSize = true;
            this.buttonTimeOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTimeOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTimeOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeOut.Location = new System.Drawing.Point(252, 709);
            this.buttonTimeOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTimeOut.Name = "buttonTimeOut";
            this.buttonTimeOut.Size = new System.Drawing.Size(115, 41);
            this.buttonTimeOut.TabIndex = 16;
            this.buttonTimeOut.Text = "Time Out";
            this.buttonTimeOut.UseVisualStyleBackColor = false;
            this.buttonTimeOut.Click += new System.EventHandler(this.buttonTimeOut_Click_1);
            // 
            // checkBoxmarkAttendance
            // 
            this.checkBoxmarkAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxmarkAttendance.AutoSize = true;
            this.checkBoxmarkAttendance.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxmarkAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxmarkAttendance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxmarkAttendance.Location = new System.Drawing.Point(53, 515);
            this.checkBoxmarkAttendance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxmarkAttendance.Name = "checkBoxmarkAttendance";
            this.checkBoxmarkAttendance.Size = new System.Drawing.Size(173, 23);
            this.checkBoxmarkAttendance.TabIndex = 15;
            this.checkBoxmarkAttendance.Text = "Mark Attendance";
            this.checkBoxmarkAttendance.UseVisualStyleBackColor = true;
            this.checkBoxmarkAttendance.CheckedChanged += new System.EventHandler(this.checkBoxmarkAttendance_CheckedChanged);
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeName.Location = new System.Drawing.Point(53, 447);
            this.textBoxEmployeeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEmployeeName.Multiline = true;
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.ReadOnly = true;
            this.textBoxEmployeeName.Size = new System.Drawing.Size(324, 27);
            this.textBoxEmployeeName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 412);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Employee Name :";
            // 
            // comboBoxEmployeeID
            // 
            this.comboBoxEmployeeID.BackColor = System.Drawing.Color.White;
            this.comboBoxEmployeeID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployeeID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmployeeID.FormattingEnabled = true;
            this.comboBoxEmployeeID.Location = new System.Drawing.Point(53, 322);
            this.comboBoxEmployeeID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEmployeeID.Name = "comboBoxEmployeeID";
            this.comboBoxEmployeeID.Size = new System.Drawing.Size(324, 28);
            this.comboBoxEmployeeID.TabIndex = 12;
            this.comboBoxEmployeeID.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployeeID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 285);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Employee ID :";
            // 
            // dateTimePickerforTInTOut
            // 
            this.dateTimePickerforTInTOut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerforTInTOut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerforTInTOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerforTInTOut.Location = new System.Drawing.Point(247, 112);
            this.dateTimePickerforTInTOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerforTInTOut.Name = "dateTimePickerforTInTOut";
            this.dateTimePickerforTInTOut.Size = new System.Drawing.Size(120, 26);
            this.dateTimePickerforTInTOut.TabIndex = 10;
            this.dateTimePickerforTInTOut.Value = new System.DateTime(2024, 4, 24, 18, 32, 19, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Time :";
            // 
            // AttendanceSheetdateTimePicker
            // 
            this.AttendanceSheetdateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceSheetdateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceSheetdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AttendanceSheetdateTimePicker.Location = new System.Drawing.Point(55, 112);
            this.AttendanceSheetdateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AttendanceSheetdateTimePicker.Name = "AttendanceSheetdateTimePicker";
            this.AttendanceSheetdateTimePicker.Size = new System.Drawing.Size(150, 26);
            this.AttendanceSheetdateTimePicker.TabIndex = 8;
            this.AttendanceSheetdateTimePicker.Value = new System.DateTime(2024, 4, 24, 18, 32, 19, 0);
            this.AttendanceSheetdateTimePicker.ValueChanged += new System.EventHandler(this.AttendanceSheetdateTimePicker_ValueChanged_1);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(51, 76);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(57, 19);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "Date :";
            // 
            // buttonTimeIn
            // 
            this.buttonTimeIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonTimeIn.AutoSize = true;
            this.buttonTimeIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTimeIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTimeIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTimeIn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeIn.Location = new System.Drawing.Point(53, 709);
            this.buttonTimeIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTimeIn.Name = "buttonTimeIn";
            this.buttonTimeIn.Size = new System.Drawing.Size(115, 41);
            this.buttonTimeIn.TabIndex = 6;
            this.buttonTimeIn.Text = "Time In";
            this.buttonTimeIn.UseVisualStyleBackColor = false;
            this.buttonTimeIn.Click += new System.EventHandler(this.buttonTimeIn_Click_1);
            // 
            // database1DataSet18
            // 
            this.database1DataSet18.DataSetName = "Database1DataSet18";
            this.database1DataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendancesBindingSource
            // 
            this.attendancesBindingSource.DataMember = "Attendances";
            this.attendancesBindingSource.DataSource = this.database1DataSet18;
            // 
            // attendancesTableAdapter
            // 
            this.attendancesTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSetAttendancesBindingSource1
            // 
            this.database1DataSetAttendancesBindingSource1.DataSource = this.database1DataSetAttendances;
            this.database1DataSetAttendancesBindingSource1.Position = 0;
            // 
            // database1DataSet20
            // 
            this.database1DataSet20.DataSetName = "Database1DataSet20";
            this.database1DataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendancesBindingSource1
            // 
            this.attendancesBindingSource1.DataMember = "Attendances";
            this.attendancesBindingSource1.DataSource = this.database1DataSet20;
            // 
            // attendancesTableAdapter1
            // 
            this.attendancesTableAdapter1.ClearBeforeFill = true;
            // 
            // shiftcheckedListBox
            // 
            this.shiftcheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.shiftcheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shiftcheckedListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shiftcheckedListBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.shiftcheckedListBox.FormattingEnabled = true;
            this.shiftcheckedListBox.Items.AddRange(new object[] {
            "7.00 AM (DAY)",
            "7.00 PM (NIGHT)"});
            this.shiftcheckedListBox.Location = new System.Drawing.Point(53, 579);
            this.shiftcheckedListBox.Margin = new System.Windows.Forms.Padding(0);
            this.shiftcheckedListBox.Name = "shiftcheckedListBox";
            this.shiftcheckedListBox.Size = new System.Drawing.Size(156, 84);
            this.shiftcheckedListBox.TabIndex = 17;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1468, 895);
            this.Controls.Add(this.tabPageMarkAttendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Attendance2_Load);
            this.tabPageMarkAttendance.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceSheetDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetAttendancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetAttendances)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetAttendancesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingSource1)).EndInit();
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
        private System.Windows.Forms.Button addnewaccountantbtn;
        private System.Windows.Forms.BindingSource database1DataSetAttendancesBindingSource;
        private Database1DataSetAttendances database1DataSetAttendances;
        private Database1DataSet18 database1DataSet18;
        private System.Windows.Forms.BindingSource attendancesBindingSource;
        private Database1DataSet18TableAdapters.AttendancesTableAdapter attendancesTableAdapter;
        private System.Windows.Forms.BindingSource database1DataSetAttendancesBindingSource1;
        private Database1DataSet20 database1DataSet20;
        private System.Windows.Forms.BindingSource attendancesBindingSource1;
        private Database1DataSet20TableAdapters.AttendancesTableAdapter attendancesTableAdapter1;
        private System.Windows.Forms.CheckedListBox shiftcheckedListBox;
    }
}