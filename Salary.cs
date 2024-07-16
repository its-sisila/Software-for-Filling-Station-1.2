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


        public Salary()
        {
            InitializeComponent();
            LoadEmployeeid();
            LoadAccountant();
            comboBoxEmployeeID.SelectedIndexChanged += new EventHandler(comboBoxEmployeeID_SelectedIndexChanged);
        }

        double basicsal, epf, etf, epfamount, etfamount, workeddays, netsal,Debit;

        private void comboBoxEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEmployeeID.SelectedIndex != -1)
            {
                string selectedEmployeeID = comboBoxEmployeeID.SelectedItem.ToString();
                LoadEmployeeName(selectedEmployeeID);
                LoadWorkedDays(selectedEmployeeID);
                LoadAdvance(selectedEmployeeID);
            }
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            LoadData();
            dateTimePickerEmployeeSalary.Value = DateTime.Now;
        }

        private void LoadData()
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Software-for-Filling-Station-1.2\Database1.mdf;Integrated Security=True";
            string query = "SELECT * FROM Salaries ";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlDataAdapter dataadapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataadapter.Fill(dataTable);
                dataGridViewEmployee.DataSource = dataTable;
            }
        }

        private void LoadEmployeeName(string employeeID)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Software-for-Filling-Station-1.2\Database1.mdf;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT Name_initial FROM Employees WHERE Employee_id = @Employee_id ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Employee_id", employeeID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBoxEmployeeName.Text = reader["Name_initial"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message);
                }
            }
        }

        private void Salary_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet19.Salaries' table. You can move, or remove it, as needed.
            //this.salariesTableAdapter.Fill(this.database1DataSet19.Salaries);

        }

        private void LoadWorkedDays(string employeeID)
        {

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Software-for-Filling-Station-1.2\Database1.mdf;Integrated Security=True"))
            {
                try
                {

                    conn.Open();

                    int currentYear = DateTime.Now.Year;
                    int currentMonth = DateTime.Now.Month;


                    string query = $"SELECT COUNT(*) FROM Attendances WHERE Employee_id = @Employee_id AND Shift IN ('7.00 AM (DAY)', '7.00 PM (NIGHT)') AND YEAR(Date) = @Year AND MONTH(Date) = @Month";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Employee_id", employeeID);
                        cmd.Parameters.AddWithValue("@Year", currentYear);
                        cmd.Parameters.AddWithValue("@Month", currentMonth);
                        
                        var result = cmd.ExecuteScalar();
                        textBoxWorkedDays.Text = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Worked Days: " + ex.Message);
                }
            }
        }

        private void LoadAdvance(string employeeID)
        {

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Software-for-Filling-Station-1.2\Database1.mdf;Integrated Security=True"))
            {
                try
                {

                    conn.Open();

                    int currentYear = DateTime.Now.Year;
                    int currentMonth = DateTime.Now.Month;


                    string query = $"SELECT ISNULL(SUM(Advance), 0) AS TotalAdvance FROM NewAccounts  WHERE Employee_id = @Employee_id  AND YEAR(Date) = @Year AND MONTH(Date) = @Month";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Employee_id", employeeID);
                        cmd.Parameters.AddWithValue("@Year", currentYear);
                        cmd.Parameters.AddWithValue("@Month", currentMonth);

                        var result = cmd.ExecuteScalar();
                        AdvancetextBox.Text = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Worked Days: " + ex.Message);
                }
            }
        }



        private void buttonSalaryCalculate_Click(object sender, EventArgs e)
        {

            basicsal = Double.Parse(textBoxBasicSalary.Text);
            workeddays = Double.Parse(textBoxWorkedDays.Text);
            Debit = Double.Parse(AdvancetextBox.Text);

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

            netsal = basicsal * workeddays - epfamount - Debit;
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

            if (string.IsNullOrWhiteSpace(accountantName))
            {
                MessageBox.Show("Please select an Accountant before submitting.");
                return;
            }

           
            if (string.IsNullOrWhiteSpace(date) ||
                string.IsNullOrWhiteSpace(employeeID) ||
                string.IsNullOrWhiteSpace(nameInitials) ||
                string.IsNullOrWhiteSpace(workedDays) ||
                string.IsNullOrWhiteSpace(basicSalary) ||
                string.IsNullOrWhiteSpace(etfAmount) ||
                string.IsNullOrWhiteSpace(epfAmount) ||
                string.IsNullOrWhiteSpace(netSalary))
            {
                MessageBox.Show("Please fill in all required fields.");
                return; 
            }



            using (SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Software-for-Filling-Station-1.2\Database1.mdf;Integrated Security=True"))
            {

                try
                {

                    sql.Open();
                    string query = $"INSERT INTO Salaries (Date, Employee_id, Name_initial, Work_days, Basic_salary, ETF_ammount, EPF_ammount, Net_salary, Accountant_name) VALUES (@Date, @Employee_id, @Name_initial, @Work_days, @Basic_salary, @ETF_ammount, @EPF_ammount, @Net_salary, @Accountant_name)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@Employee_id", employeeID);
                    command.Parameters.AddWithValue("@Name_initial", nameInitials);
                    command.Parameters.AddWithValue("@Work_days", workedDays);
                    command.Parameters.AddWithValue("@Basic_salary", basicSalary);
                    command.Parameters.AddWithValue("@ETF_ammount", etfAmount);
                    command.Parameters.AddWithValue("@EPF_ammount", epfAmount);
                    command.Parameters.AddWithValue("@Net_salary", netSalary);
                    command.Parameters.AddWithValue("@Accountant_name", accountantName);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Submition successful");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Submit Data");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }




            LoadData();
        }



        private void LoadEmployeeid()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Software-for-Filling-Station-1.2\Database1.mdf;Integrated Security=True"))
            {
                try
                {
                    conn.Open();

                    string query = $"SELECT Employee_id FROM Employees";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxEmployeeID.Items.Add(reader["Employee_id"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message);
                }
            }
        }

        private void LoadAccountant()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Software-for-Filling-Station-1.2\Database1.mdf;Integrated Security=True"))
            {
                try
                {
                    conn.Open();

                    string query = $"SELECT Name_initial FROM Accountants";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboAccountantName.Items.Add(reader["Name_initial"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message);
                }
            }
        }
    }
}
