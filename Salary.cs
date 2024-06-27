using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_for_Filling_Station
{
    public partial class Salary : Form
    {
        private string mysql = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True");

        public Salary()
        {
            InitializeComponent();
            LoadEmployees();
            LoadAccountance();
        }

        double basicsal, epf, etf, epfamount, etfamount, workeddays, netsal;

        private void comboBoxEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEmployeeID.SelectedIndex != -1)
            {
                string selectedEmployeeID = comboBoxEmployeeID.SelectedItem.ToString();
                LoadEmployeeName(selectedEmployeeID);
                LoadWorkedDays(selectedEmployeeID);
            }
        }

        private void LoadEmployeeName(string employeeID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(mysql))
                {
                    conn.Open();
                    string query = "SELECT NameInitial FROM Employee WHERE EmployeeID = @EmployeeID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            textBoxEmployeeName.Text = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Employee Name: " + ex.Message);
            }
        }

        private void LoadWorkedDays(string employeeID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(mysql))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Attendance WHERE EmployeeID = @EmployeeID AND Status = 'Present'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                        var result = cmd.ExecuteScalar();
                        textBoxWorkedDays.Text = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Worked Days: " + ex.Message);
            }
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet16.Employee_Salary' table. You can move, or remove it, as needed.
            this.employee_SalaryTableAdapter.Fill(this.database1DataSet16.Employee_Salary);

        }

        private void buttonSalaryCalculate_Click(object sender, EventArgs e)
        {

            basicsal = Double.Parse(textBoxBasicSalary.Text);
            workeddays = Double.Parse(textBoxWorkedDays.Text);

            if (checkBoxETF.Checked)
            {
                etfamount = basicsal * 3 / 100 * workeddays;
            }
            if (checkBoxEPF.Checked)
            {
                epfamount = basicsal * 8 / 100 * workeddays;
            }
            textBoxETF.Text = etfamount.ToString();
            textBoxEPF.Text = epfamount.ToString();

            netsal = basicsal - epfamount;
            textBoxNetSalary.Text = netsal.ToString();
        }

        private void buttonSalaryReset_Click(object sender, EventArgs e)
        {
            comboAccountantName.Text = "";
            comboBoxEmployeeID.SelectedIndex = 0;
            textBoxEmployeeName.Text = "";
            textBoxWorkedDays.Text = "";
            textBoxBasicSalary.Text = "";
            checkBoxEPF.Checked = false;
            checkBoxETF.Checked = false;
            textBoxETF.Text = "";
            textBoxEPF.Text = "";
            textBoxNetSalary.Text = "";
        }

        private void buttonsalarySubmit_Click(object sender, EventArgs e)
        {

            string date = dateTimePickerEmployeeSalary.Value.ToString("yyyy-MM-dd");
            string employeeID = comboBoxEmployeeID.SelectedItem.ToString();
            string nameInitials = textBoxEmployeeName.Text;
            string workedDays = textBoxWorkedDays.Text;
            string basicSalary = textBoxBasicSalary.Text;
            string etfAmount = textBoxETF.Text;
            string epfAmount = textBoxEPF.Text;
            string netSalary = textBoxNetSalary.Text;
            string accountantName = comboAccountantName.SelectedItem.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(mysql))
                {
                    conn.Open();
                    string query = @"INSERT INTO Employee_Salary (Date, EmployeeID, NameInitials, WorkedDays, BasicSalary, ETFAmount, EPFAmount, NetSalary, AccountantName)
                             VALUES (@Date, @EmployeeID, @NameInitials, @WorkedDays, @BasicSalary, @ETFAmount, @EPFAmount, @NetSalary, @AccountantName)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                        cmd.Parameters.AddWithValue("@NameInitials", nameInitials);
                        cmd.Parameters.AddWithValue("@WorkedDays", workedDays);
                        cmd.Parameters.AddWithValue("@BasicSalary", basicSalary);
                        cmd.Parameters.AddWithValue("@ETFAmount", etfAmount);
                        cmd.Parameters.AddWithValue("@EPFAmount", epfAmount);
                        cmd.Parameters.AddWithValue("@NetSalary", netSalary);
                        cmd.Parameters.AddWithValue("@AccountantName", accountantName);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data submitted successfully!");
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit data.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }

        }

        private void ClearForm()
        {

            textBoxBasicSalary.Clear();
            textBoxETF.Clear();
            textBoxEPF.Clear();
            textBoxNetSalary.Clear();
            textBoxWorkedDays.Clear();
            textBoxEmployeeName.Clear();


            if (comboBoxEmployeeID.Items.Count > 0)
                comboBoxEmployeeID.SelectedIndex = 0;
            if (comboAccountantName.Items.Count > 0)
                comboAccountantName.SelectedIndex = 0;


            checkBoxETF.Checked = false;
            checkBoxEPF.Checked = false;


            dateTimePickerEmployeeSalary.Value = DateTime.Now;
        }

        private void LoadEmployees()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(mysql))
                {
                    conn.Open();
                    string query = "SELECT EmployeeID FROM Attendance ORDER BY EmployeeID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        comboBoxEmployeeID.Items.Clear();
                        while (reader.Read())
                        {
                            comboBoxEmployeeID.Items.Add(reader["EmployeeID"].ToString());
                        }
                        if (comboBoxEmployeeID.Items.Count > 0)
                            comboBoxEmployeeID.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Employees ID: " + ex.Message);
            }
        }

        private void LoadAccountance()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(mysql))
                {
                    conn.Open();
                    string query = "SELECT NameInitial FROM Accountant ORDER BY NameInitial";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        comboAccountantName.Items.Clear();
                        while (reader.Read())
                        {
                            comboAccountantName.Items.Add(reader["NameInitial"].ToString());
                        }
                        if (comboAccountantName.Items.Count > 0)
                            comboAccountantName.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Accountant: " + ex.Message);
            }
        }
    }
}
