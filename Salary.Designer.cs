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
            this.labelBasicSalary = new System.Windows.Forms.Label();
            this.textBoxBasicSalary = new System.Windows.Forms.TextBox();
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
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.textBoxWorkedDays = new System.Windows.Forms.TextBox();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.database1DataSetSalariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetSalaries = new Software_for_Filling_Station.Database1DataSetSalaries();
            this.employeeSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet16 = new Software_for_Filling_Station.Database1DataSet16();
            this.comboBoxEmployeeID = new System.Windows.Forms.ComboBox();
            this.comboAccountantName = new System.Windows.Forms.ComboBox();
            this.labelWorkedDays = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.labelAccountantName = new System.Windows.Forms.Label();
            this.employee_SalaryTableAdapter = new Software_for_Filling_Station.Database1DataSet16TableAdapters.Employee_SalaryTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.AdvancetextBox = new System.Windows.Forms.TextBox();
            this.database1DataSet19 = new Software_for_Filling_Station.Database1DataSet19();
            this.salariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salariesTableAdapter = new Software_for_Filling_Station.Database1DataSet19TableAdapters.SalariesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetSalariesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetSalaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet16)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salariesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerEmployeeSalary
            // 
            this.dateTimePickerEmployeeSalary.Location = new System.Drawing.Point(428, 27);
            this.dateTimePickerEmployeeSalary.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerEmployeeSalary.Name = "dateTimePickerEmployeeSalary";
            this.dateTimePickerEmployeeSalary.Size = new System.Drawing.Size(257, 22);
            this.dateTimePickerEmployeeSalary.TabIndex = 27;
            this.dateTimePickerEmployeeSalary.Value = new System.DateTime(2024, 7, 12, 22, 44, 39, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelBasicSalary);
            this.groupBox1.Controls.Add(this.textBoxBasicSalary);
            this.groupBox1.Controls.Add(this.buttonSalaryReset);
            this.groupBox1.Controls.Add(this.dateTimePickerEmployeeSalary);
            this.groupBox1.Controls.Add(this.buttonSalaryCalculate);
            this.groupBox1.Controls.Add(this.buttonsalarySubmit);
            this.groupBox1.Controls.Add(this.checkBoxEPF);
            this.groupBox1.Controls.Add(this.checkBoxETF);
            this.groupBox1.Controls.Add(this.comboAccountantName);
            this.groupBox1.Controls.Add(this.textBoxNetSalary);
            this.groupBox1.Controls.Add(this.textBoxEPF);
            this.groupBox1.Controls.Add(this.labelAccountantName);
            this.groupBox1.Controls.Add(this.textBoxETF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(424, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(838, 435);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Calculation";
            // 
            // labelBasicSalary
            // 
            this.labelBasicSalary.AutoSize = true;
            this.labelBasicSalary.BackColor = System.Drawing.Color.White;
            this.labelBasicSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBasicSalary.Location = new System.Drawing.Point(8, 64);
            this.labelBasicSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBasicSalary.Name = "labelBasicSalary";
            this.labelBasicSalary.Size = new System.Drawing.Size(216, 20);
            this.labelBasicSalary.TabIndex = 15;
            this.labelBasicSalary.Text = "Basic Salary (Per Day) :";
            // 
            // textBoxBasicSalary
            // 
            this.textBoxBasicSalary.Location = new System.Drawing.Point(12, 106);
            this.textBoxBasicSalary.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBasicSalary.Multiline = true;
            this.textBoxBasicSalary.Name = "textBoxBasicSalary";
            this.textBoxBasicSalary.Size = new System.Drawing.Size(324, 36);
            this.textBoxBasicSalary.TabIndex = 23;
            // 
            // buttonSalaryReset
            // 
            this.buttonSalaryReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSalaryReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSalaryReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalaryReset.Location = new System.Drawing.Point(628, 374);
            this.buttonSalaryReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalaryReset.Name = "buttonSalaryReset";
            this.buttonSalaryReset.Size = new System.Drawing.Size(124, 41);
            this.buttonSalaryReset.TabIndex = 13;
            this.buttonSalaryReset.Text = "RESET";
            this.buttonSalaryReset.UseVisualStyleBackColor = false;
            this.buttonSalaryReset.Click += new System.EventHandler(this.buttonSalaryReset_Click);
            // 
            // buttonSalaryCalculate
            // 
            this.buttonSalaryCalculate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSalaryCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSalaryCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalaryCalculate.Location = new System.Drawing.Point(364, 374);
            this.buttonSalaryCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalaryCalculate.Name = "buttonSalaryCalculate";
            this.buttonSalaryCalculate.Size = new System.Drawing.Size(124, 41);
            this.buttonSalaryCalculate.TabIndex = 13;
            this.buttonSalaryCalculate.Text = "CALCULATE";
            this.buttonSalaryCalculate.UseVisualStyleBackColor = false;
            this.buttonSalaryCalculate.Click += new System.EventHandler(this.buttonSalaryCalculate_Click);
            // 
            // buttonsalarySubmit
            // 
            this.buttonsalarySubmit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonsalarySubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsalarySubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsalarySubmit.Location = new System.Drawing.Point(496, 374);
            this.buttonsalarySubmit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsalarySubmit.Name = "buttonsalarySubmit";
            this.buttonsalarySubmit.Size = new System.Drawing.Size(124, 41);
            this.buttonsalarySubmit.TabIndex = 13;
            this.buttonsalarySubmit.Text = "SUBMIT";
            this.buttonsalarySubmit.UseVisualStyleBackColor = false;
            this.buttonsalarySubmit.Click += new System.EventHandler(this.buttonsalarySubmit_Click);
            // 
            // checkBoxEPF
            // 
            this.checkBoxEPF.AutoSize = true;
            this.checkBoxEPF.Location = new System.Drawing.Point(12, 219);
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
            this.checkBoxETF.Location = new System.Drawing.Point(12, 166);
            this.checkBoxETF.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxETF.Name = "checkBoxETF";
            this.checkBoxETF.Size = new System.Drawing.Size(55, 20);
            this.checkBoxETF.TabIndex = 0;
            this.checkBoxETF.Text = "ETF";
            this.checkBoxETF.UseVisualStyleBackColor = true;
            // 
            // textBoxNetSalary
            // 
            this.textBoxNetSalary.Location = new System.Drawing.Point(12, 342);
            this.textBoxNetSalary.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNetSalary.Multiline = true;
            this.textBoxNetSalary.Name = "textBoxNetSalary";
            this.textBoxNetSalary.ReadOnly = true;
            this.textBoxNetSalary.Size = new System.Drawing.Size(324, 36);
            this.textBoxNetSalary.TabIndex = 12;
            // 
            // textBoxEPF
            // 
            this.textBoxEPF.Location = new System.Drawing.Point(221, 236);
            this.textBoxEPF.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEPF.Multiline = true;
            this.textBoxEPF.Name = "textBoxEPF";
            this.textBoxEPF.ReadOnly = true;
            this.textBoxEPF.Size = new System.Drawing.Size(324, 36);
            this.textBoxEPF.TabIndex = 12;
            // 
            // textBoxETF
            // 
            this.textBoxETF.Location = new System.Drawing.Point(221, 185);
            this.textBoxETF.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxETF.Multiline = true;
            this.textBoxETF.Name = "textBoxETF";
            this.textBoxETF.ReadOnly = true;
            this.textBoxETF.Size = new System.Drawing.Size(324, 36);
            this.textBoxETF.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 251);
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
            this.label1.Location = new System.Drawing.Point(81, 201);
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
            this.label3.Location = new System.Drawing.Point(8, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Net Salary :";
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(23, 166);
            this.textBoxEmployeeName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmployeeName.Multiline = true;
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.ReadOnly = true;
            this.textBoxEmployeeName.Size = new System.Drawing.Size(324, 36);
            this.textBoxEmployeeName.TabIndex = 24;
            // 
            // textBoxWorkedDays
            // 
            this.textBoxWorkedDays.Location = new System.Drawing.Point(23, 261);
            this.textBoxWorkedDays.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWorkedDays.Multiline = true;
            this.textBoxWorkedDays.Name = "textBoxWorkedDays";
            this.textBoxWorkedDays.ReadOnly = true;
            this.textBoxWorkedDays.Size = new System.Drawing.Size(324, 36);
            this.textBoxWorkedDays.TabIndex = 25;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(13, 500);
            this.dataGridViewEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1249, 304);
            this.dataGridViewEmployee.TabIndex = 22;
            // 
            // database1DataSetSalariesBindingSource
            // 
            this.database1DataSetSalariesBindingSource.DataSource = this.database1DataSetSalaries;
            this.database1DataSetSalariesBindingSource.Position = 0;
            // 
            // database1DataSetSalaries
            // 
            this.database1DataSetSalaries.DataSetName = "Database1DataSetSalaries";
            this.database1DataSetSalaries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeSalaryBindingSource
            // 
            this.employeeSalaryBindingSource.DataMember = "Employee_Salary";
            this.employeeSalaryBindingSource.DataSource = this.database1DataSet16;
            // 
            // database1DataSet16
            // 
            this.database1DataSet16.DataSetName = "Database1DataSet16";
            this.database1DataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxEmployeeID
            // 
            this.comboBoxEmployeeID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployeeID.FormattingEnabled = true;
            this.comboBoxEmployeeID.Location = new System.Drawing.Point(23, 64);
            this.comboBoxEmployeeID.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEmployeeID.Name = "comboBoxEmployeeID";
            this.comboBoxEmployeeID.Size = new System.Drawing.Size(324, 24);
            this.comboBoxEmployeeID.TabIndex = 20;
            this.comboBoxEmployeeID.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployeeID_SelectedIndexChanged);
            // 
            // comboAccountantName
            // 
            this.comboAccountantName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboAccountantName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccountantName.FormattingEnabled = true;
            this.comboAccountantName.Location = new System.Drawing.Point(428, 103);
            this.comboAccountantName.Margin = new System.Windows.Forms.Padding(4);
            this.comboAccountantName.Name = "comboAccountantName";
            this.comboAccountantName.Size = new System.Drawing.Size(324, 24);
            this.comboAccountantName.TabIndex = 21;
            // 
            // labelWorkedDays
            // 
            this.labelWorkedDays.AutoSize = true;
            this.labelWorkedDays.BackColor = System.Drawing.Color.White;
            this.labelWorkedDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkedDays.Location = new System.Drawing.Point(19, 219);
            this.labelWorkedDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWorkedDays.Name = "labelWorkedDays";
            this.labelWorkedDays.Size = new System.Drawing.Size(133, 20);
            this.labelWorkedDays.TabIndex = 16;
            this.labelWorkedDays.Text = "Worked Days :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Employee Name :";
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.BackColor = System.Drawing.Color.White;
            this.labelEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeID.Location = new System.Drawing.Point(19, 29);
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
            this.labelAccountantName.ForeColor = System.Drawing.Color.Black;
            this.labelAccountantName.Location = new System.Drawing.Point(424, 68);
            this.labelAccountantName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAccountantName.Name = "labelAccountantName";
            this.labelAccountantName.Size = new System.Drawing.Size(163, 20);
            this.labelAccountantName.TabIndex = 19;
            this.labelAccountantName.Text = "Accountant Name:";
            // 
            // employee_SalaryTableAdapter
            // 
            this.employee_SalaryTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelWorkedDays);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.AdvancetextBox);
            this.panel1.Controls.Add(this.labelEmployeeID);
            this.panel1.Controls.Add(this.comboBoxEmployeeID);
            this.panel1.Controls.Add(this.textBoxEmployeeName);
            this.panel1.Controls.Add(this.textBoxWorkedDays);
            this.panel1.Location = new System.Drawing.Point(13, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 435);
            this.panel1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Advance :";
            // 
            // AdvancetextBox
            // 
            this.AdvancetextBox.Location = new System.Drawing.Point(23, 367);
            this.AdvancetextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AdvancetextBox.Multiline = true;
            this.AdvancetextBox.Name = "AdvancetextBox";
            this.AdvancetextBox.ReadOnly = true;
            this.AdvancetextBox.Size = new System.Drawing.Size(324, 36);
            this.AdvancetextBox.TabIndex = 25;
            // 
            // database1DataSet19
            // 
            this.database1DataSet19.DataSetName = "Database1DataSet19";
            this.database1DataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salariesBindingSource
            // 
            this.salariesBindingSource.DataMember = "Salaries";
            this.salariesBindingSource.DataSource = this.database1DataSet19;
            // 
            // salariesTableAdapter
            // 
            this.salariesTableAdapter.ClearBeforeFill = true;
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1284, 895);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Salary";
            this.Text = "Salary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Salary_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetSalariesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetSalaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet16)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salariesBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.BindingSource database1DataSetSalariesBindingSource;
        private Database1DataSetSalaries database1DataSetSalaries;
        private System.Windows.Forms.Panel panel1;
        private Database1DataSet19 database1DataSet19;
        private System.Windows.Forms.BindingSource salariesBindingSource;
        private Database1DataSet19TableAdapters.SalariesTableAdapter salariesTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdvancetextBox;
    }
}