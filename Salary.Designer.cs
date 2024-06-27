namespace Software_for_Filling_Station
{
    partial class Salary
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
            this.dateTimePickerEmployeeSalary = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSalaryReset = new System.Windows.Forms.Button();
            this.buttonSalaryCalculate = new System.Windows.Forms.Button();
            this.buttonsalarySubmit = new System.Windows.Forms.Button();
            this.checkBoxEPF = new System.Windows.Forms.CheckBox();
            this.checkBoxETF = new System.Windows.Forms.CheckBox();
            this.textBoxNetSalary = new System.Windows.Forms.TextBox();
            this.textBoxEPF = new System.Windows.Forms.TextBox();
            this.textBoxETF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBasicSalary = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.textBoxWorkedDays = new System.Windows.Forms.TextBox();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.comboBoxEmployeeID = new System.Windows.Forms.ComboBox();
            this.comboAccountantName = new System.Windows.Forms.ComboBox();
            this.labelBasicSalary = new System.Windows.Forms.Label();
            this.labelWorkedDays = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.labelAccountantName = new System.Windows.Forms.Label();
            this.database1DataSet16 = new Software_for_Filling_Station.Database1DataSet16();
            this.employeeSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_SalaryTableAdapter = new Software_for_Filling_Station.Database1DataSet16TableAdapters.Employee_SalaryTableAdapter();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameInitialsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workedDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTFAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePFAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountantNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerEmployeeSalary
            // 
            this.dateTimePickerEmployeeSalary.Location = new System.Drawing.Point(520, 93);
            this.dateTimePickerEmployeeSalary.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerEmployeeSalary.Name = "dateTimePickerEmployeeSalary";
            this.dateTimePickerEmployeeSalary.Size = new System.Drawing.Size(324, 22);
            this.dateTimePickerEmployeeSalary.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSalaryReset);
            this.groupBox1.Controls.Add(this.buttonSalaryCalculate);
            this.groupBox1.Controls.Add(this.buttonsalarySubmit);
            this.groupBox1.Controls.Add(this.checkBoxEPF);
            this.groupBox1.Controls.Add(this.checkBoxETF);
            this.groupBox1.Controls.Add(this.textBoxNetSalary);
            this.groupBox1.Controls.Add(this.textBoxEPF);
            this.groupBox1.Controls.Add(this.textBoxETF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(520, 158);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(787, 316);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Calculation";
            // 
            // buttonSalaryReset
            // 
            this.buttonSalaryReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalaryReset.Location = new System.Drawing.Point(640, 258);
            this.buttonSalaryReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalaryReset.Name = "buttonSalaryReset";
            this.buttonSalaryReset.Size = new System.Drawing.Size(124, 41);
            this.buttonSalaryReset.TabIndex = 13;
            this.buttonSalaryReset.Text = "RESET";
            this.buttonSalaryReset.UseVisualStyleBackColor = true;
            this.buttonSalaryReset.Click += new System.EventHandler(this.buttonSalaryReset_Click);
            // 
            // buttonSalaryCalculate
            // 
            this.buttonSalaryCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalaryCalculate.Location = new System.Drawing.Point(376, 258);
            this.buttonSalaryCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalaryCalculate.Name = "buttonSalaryCalculate";
            this.buttonSalaryCalculate.Size = new System.Drawing.Size(124, 41);
            this.buttonSalaryCalculate.TabIndex = 13;
            this.buttonSalaryCalculate.Text = "CALCULATE";
            this.buttonSalaryCalculate.UseVisualStyleBackColor = true;
            this.buttonSalaryCalculate.Click += new System.EventHandler(this.buttonSalaryCalculate_Click);
            // 
            // buttonsalarySubmit
            // 
            this.buttonsalarySubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsalarySubmit.Location = new System.Drawing.Point(508, 258);
            this.buttonsalarySubmit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsalarySubmit.Name = "buttonsalarySubmit";
            this.buttonsalarySubmit.Size = new System.Drawing.Size(124, 41);
            this.buttonsalarySubmit.TabIndex = 13;
            this.buttonsalarySubmit.Text = "SUBMIT";
            this.buttonsalarySubmit.UseVisualStyleBackColor = true;
            this.buttonsalarySubmit.Click += new System.EventHandler(this.buttonsalarySubmit_Click);
            // 
            // checkBoxEPF
            // 
            this.checkBoxEPF.AutoSize = true;
            this.checkBoxEPF.Location = new System.Drawing.Point(24, 92);
            this.checkBoxEPF.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxEPF.Name = "checkBoxEPF";
            this.checkBoxEPF.Size = new System.Drawing.Size(55, 20);
            this.checkBoxEPF.TabIndex = 0;
            this.checkBoxEPF.Text = "EPF";
            this.checkBoxEPF.UseVisualStyleBackColor = true;
            // 
            // checkBoxETF
            // 
            this.checkBoxETF.AutoSize = true;
            this.checkBoxETF.Location = new System.Drawing.Point(24, 39);
            this.checkBoxETF.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxETF.Name = "checkBoxETF";
            this.checkBoxETF.Size = new System.Drawing.Size(55, 20);
            this.checkBoxETF.TabIndex = 0;
            this.checkBoxETF.Text = "ETF";
            this.checkBoxETF.UseVisualStyleBackColor = true;
            // 
            // textBoxNetSalary
            // 
            this.textBoxNetSalary.Location = new System.Drawing.Point(24, 226);
            this.textBoxNetSalary.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNetSalary.Multiline = true;
            this.textBoxNetSalary.Name = "textBoxNetSalary";
            this.textBoxNetSalary.Size = new System.Drawing.Size(324, 36);
            this.textBoxNetSalary.TabIndex = 12;
            // 
            // textBoxEPF
            // 
            this.textBoxEPF.Location = new System.Drawing.Point(233, 76);
            this.textBoxEPF.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEPF.Multiline = true;
            this.textBoxEPF.Name = "textBoxEPF";
            this.textBoxEPF.Size = new System.Drawing.Size(324, 36);
            this.textBoxEPF.TabIndex = 12;
            // 
            // textBoxETF
            // 
            this.textBoxETF.Location = new System.Drawing.Point(233, 25);
            this.textBoxETF.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxETF.Multiline = true;
            this.textBoxETF.Name = "textBoxETF";
            this.textBoxETF.Size = new System.Drawing.Size(324, 36);
            this.textBoxETF.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "EPF Amount :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "ETF Amount :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Net Salary :";
            // 
            // textBoxBasicSalary
            // 
            this.textBoxBasicSalary.Location = new System.Drawing.Point(77, 438);
            this.textBoxBasicSalary.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBasicSalary.Multiline = true;
            this.textBoxBasicSalary.Name = "textBoxBasicSalary";
            this.textBoxBasicSalary.Size = new System.Drawing.Size(324, 36);
            this.textBoxBasicSalary.TabIndex = 23;
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(77, 232);
            this.textBoxEmployeeName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmployeeName.Multiline = true;
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(324, 36);
            this.textBoxEmployeeName.TabIndex = 24;
            // 
            // textBoxWorkedDays
            // 
            this.textBoxWorkedDays.Location = new System.Drawing.Point(77, 326);
            this.textBoxWorkedDays.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWorkedDays.Multiline = true;
            this.textBoxWorkedDays.Name = "textBoxWorkedDays";
            this.textBoxWorkedDays.Size = new System.Drawing.Size(324, 36);
            this.textBoxWorkedDays.TabIndex = 25;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AutoGenerateColumns = false;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.nameInitialsDataGridViewTextBoxColumn,
            this.workedDaysDataGridViewTextBoxColumn,
            this.basicSalaryDataGridViewTextBoxColumn,
            this.eTFAmountDataGridViewTextBoxColumn,
            this.ePFAmountDataGridViewTextBoxColumn,
            this.netSalaryDataGridViewTextBoxColumn,
            this.accountantNameDataGridViewTextBoxColumn});
            this.dataGridViewEmployee.DataSource = this.employeeSalaryBindingSource;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(77, 498);
            this.dataGridViewEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1243, 335);
            this.dataGridViewEmployee.TabIndex = 22;
            // 
            // comboBoxEmployeeID
            // 
            this.comboBoxEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployeeID.FormattingEnabled = true;
            this.comboBoxEmployeeID.Location = new System.Drawing.Point(77, 129);
            this.comboBoxEmployeeID.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEmployeeID.Name = "comboBoxEmployeeID";
            this.comboBoxEmployeeID.Size = new System.Drawing.Size(324, 24);
            this.comboBoxEmployeeID.TabIndex = 20;
            this.comboBoxEmployeeID.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployeeID_SelectedIndexChanged);
            // 
            // comboAccountantName
            // 
            this.comboAccountantName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccountantName.FormattingEnabled = true;
            this.comboAccountantName.Location = new System.Drawing.Point(980, 97);
            this.comboAccountantName.Margin = new System.Windows.Forms.Padding(4);
            this.comboAccountantName.Name = "comboAccountantName";
            this.comboAccountantName.Size = new System.Drawing.Size(324, 24);
            this.comboAccountantName.TabIndex = 21;
            // 
            // labelBasicSalary
            // 
            this.labelBasicSalary.AutoSize = true;
            this.labelBasicSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBasicSalary.Location = new System.Drawing.Point(73, 396);
            this.labelBasicSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBasicSalary.Name = "labelBasicSalary";
            this.labelBasicSalary.Size = new System.Drawing.Size(216, 20);
            this.labelBasicSalary.TabIndex = 15;
            this.labelBasicSalary.Text = "Basic Salary (Per Day) :";
            // 
            // labelWorkedDays
            // 
            this.labelWorkedDays.AutoSize = true;
            this.labelWorkedDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkedDays.Location = new System.Drawing.Point(73, 284);
            this.labelWorkedDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWorkedDays.Name = "labelWorkedDays";
            this.labelWorkedDays.Size = new System.Drawing.Size(133, 20);
            this.labelWorkedDays.TabIndex = 16;
            this.labelWorkedDays.Text = "Worked Days :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Employee Name :";
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeID.Location = new System.Drawing.Point(73, 93);
            this.labelEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(127, 20);
            this.labelEmployeeID.TabIndex = 18;
            this.labelEmployeeID.Text = "Employee ID :";
            // 
            // labelAccountantName
            // 
            this.labelAccountantName.AutoSize = true;
            this.labelAccountantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountantName.Location = new System.Drawing.Point(976, 61);
            this.labelAccountantName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAccountantName.Name = "labelAccountantName";
            this.labelAccountantName.Size = new System.Drawing.Size(163, 20);
            this.labelAccountantName.TabIndex = 19;
            this.labelAccountantName.Text = "Accountant Name:";
            // 
            // database1DataSet16
            // 
            this.database1DataSet16.DataSetName = "Database1DataSet16";
            this.database1DataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeSalaryBindingSource
            // 
            this.employeeSalaryBindingSource.DataMember = "Employee_Salary";
            this.employeeSalaryBindingSource.DataSource = this.database1DataSet16;
            // 
            // employee_SalaryTableAdapter
            // 
            this.employee_SalaryTableAdapter.ClearBeforeFill = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameInitialsDataGridViewTextBoxColumn
            // 
            this.nameInitialsDataGridViewTextBoxColumn.DataPropertyName = "NameInitials";
            this.nameInitialsDataGridViewTextBoxColumn.HeaderText = "NameInitials";
            this.nameInitialsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameInitialsDataGridViewTextBoxColumn.Name = "nameInitialsDataGridViewTextBoxColumn";
            this.nameInitialsDataGridViewTextBoxColumn.Width = 125;
            // 
            // workedDaysDataGridViewTextBoxColumn
            // 
            this.workedDaysDataGridViewTextBoxColumn.DataPropertyName = "WorkedDays";
            this.workedDaysDataGridViewTextBoxColumn.HeaderText = "WorkedDays";
            this.workedDaysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workedDaysDataGridViewTextBoxColumn.Name = "workedDaysDataGridViewTextBoxColumn";
            this.workedDaysDataGridViewTextBoxColumn.Width = 125;
            // 
            // basicSalaryDataGridViewTextBoxColumn
            // 
            this.basicSalaryDataGridViewTextBoxColumn.DataPropertyName = "BasicSalary";
            this.basicSalaryDataGridViewTextBoxColumn.HeaderText = "BasicSalary";
            this.basicSalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.basicSalaryDataGridViewTextBoxColumn.Name = "basicSalaryDataGridViewTextBoxColumn";
            this.basicSalaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // eTFAmountDataGridViewTextBoxColumn
            // 
            this.eTFAmountDataGridViewTextBoxColumn.DataPropertyName = "ETFAmount";
            this.eTFAmountDataGridViewTextBoxColumn.HeaderText = "ETFAmount";
            this.eTFAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eTFAmountDataGridViewTextBoxColumn.Name = "eTFAmountDataGridViewTextBoxColumn";
            this.eTFAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // ePFAmountDataGridViewTextBoxColumn
            // 
            this.ePFAmountDataGridViewTextBoxColumn.DataPropertyName = "EPFAmount";
            this.ePFAmountDataGridViewTextBoxColumn.HeaderText = "EPFAmount";
            this.ePFAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ePFAmountDataGridViewTextBoxColumn.Name = "ePFAmountDataGridViewTextBoxColumn";
            this.ePFAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // netSalaryDataGridViewTextBoxColumn
            // 
            this.netSalaryDataGridViewTextBoxColumn.DataPropertyName = "NetSalary";
            this.netSalaryDataGridViewTextBoxColumn.HeaderText = "NetSalary";
            this.netSalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.netSalaryDataGridViewTextBoxColumn.Name = "netSalaryDataGridViewTextBoxColumn";
            this.netSalaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountantNameDataGridViewTextBoxColumn
            // 
            this.accountantNameDataGridViewTextBoxColumn.DataPropertyName = "AccountantName";
            this.accountantNameDataGridViewTextBoxColumn.HeaderText = "AccountantName";
            this.accountantNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountantNameDataGridViewTextBoxColumn.Name = "accountantNameDataGridViewTextBoxColumn";
            this.accountantNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 895);
            this.Controls.Add(this.dateTimePickerEmployeeSalary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxBasicSalary);
            this.Controls.Add(this.textBoxEmployeeName);
            this.Controls.Add(this.textBoxWorkedDays);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.comboBoxEmployeeID);
            this.Controls.Add(this.comboAccountantName);
            this.Controls.Add(this.labelBasicSalary);
            this.Controls.Add(this.labelWorkedDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelEmployeeID);
            this.Controls.Add(this.labelAccountantName);
            this.Name = "Salary";
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerEmployeeSalary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSalaryReset;
        private System.Windows.Forms.Button buttonSalaryCalculate;
        private System.Windows.Forms.Button buttonsalarySubmit;
        private System.Windows.Forms.CheckBox checkBoxEPF;
        private System.Windows.Forms.CheckBox checkBoxETF;
        private System.Windows.Forms.TextBox textBoxNetSalary;
        private System.Windows.Forms.TextBox textBoxEPF;
        private System.Windows.Forms.TextBox textBoxETF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBasicSalary;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.TextBox textBoxWorkedDays;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.ComboBox comboBoxEmployeeID;
        private System.Windows.Forms.ComboBox comboAccountantName;
        private System.Windows.Forms.Label labelBasicSalary;
        private System.Windows.Forms.Label labelWorkedDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelEmployeeID;
        private System.Windows.Forms.Label labelAccountantName;
        private Database1DataSet16 database1DataSet16;
        private System.Windows.Forms.BindingSource employeeSalaryBindingSource;
        private Database1DataSet16TableAdapters.Employee_SalaryTableAdapter employee_SalaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameInitialsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workedDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTFAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePFAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountantNameDataGridViewTextBoxColumn;
    }
}