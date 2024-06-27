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
    public partial class Attendance2 : Form
    {
        private string mysql = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True");

        public Attendance2()
        {
            InitializeComponent();
            LoadSupervisors();
            LoadEmployees();
        }


        private void LoadSupervisors()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(mysql))
                {
                    conn.Open();
                    string query = "SELECT NameInitials FROM Supervisor ORDER BY NameInitials";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        comboBoxSupervisorName.Items.Clear();
                        while (reader.Read())
                        {
                            comboBoxSupervisorName.Items.Add(reader["Supervisor_Name"].ToString());
                        }
                        if (comboBoxSupervisorName.Items.Count > 0)
                            comboBoxSupervisorName.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Supervisors: " + ex.Message);
            }
        }

        private void LoadEmployees()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(mysql))
                {
                    conn.Open();
                    string query = "SELECT EmployeeID FROM Employee ORDER BY EmployeeID";
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
                MessageBox.Show("Error loading Employee ID: " + ex.Message);
            }
        }


        private void Attendance2_Load1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void addnewsupervisorbtn_Click(object sender, EventArgs e)
        {

        }

        private void addnewemployeebtn_Click(object sender, EventArgs e)
        {

        }

        private void buttonTimeOut_Click(object sender, EventArgs e)
        {

        }

        private void AttendanceSheetdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonTimeIn_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Attendance2_Load(object sender, EventArgs e)
        {
   
        }

        private void buttonTimeIn_Click_1(object sender, EventArgs e)
        {

            string EmployeeId = comboBoxEmployeeID.SelectedItem.ToString();
            string EmployeeName = textBoxEmployeeName.Text;
            string Date = AttendanceSheetdateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string Time = dateTimePickerforTInTOut.Value.ToString("HH:mm:ss");
            string SupervisorName = comboBoxSupervisorName.SelectedItem.ToString();
            string Status = checkBoxmarkAttendance.Checked ? "Present" : "Absent";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\\NSBM - Academic\\Year 01 Semester 03\\C#\\C# Final Project\\Final Software\\Software-for-Filling-Station\\Database1.mdf';Integrated Security=True";

            string query = @"INSERT INTO Attendance (EmployeeID, Date, TimeIn, Status)
                           VALUES (@EmployeeID, @Date, @TimeIn, @Status)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", EmployeeId);
                        cmd.Parameters.AddWithValue("@Date", Date);
                        cmd.Parameters.AddWithValue("@TimeIn", Time);
                        cmd.Parameters.AddWithValue("@Status", Status);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Time In recorded successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to record time in.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to record Time In: " + ex.Message);
            }
        }

        private void addnewemployeebtn_Click_1(object sender, EventArgs e)
        {
            Add_New_Employees add_New_Employees = new Add_New_Employees();
            add_New_Employees.Show();
        }

        private void addnewsupervisorbtn_Click_1(object sender, EventArgs e)
        {
            Add_New_Supervisors add_New_supervisor = new Add_New_Supervisors();
            add_New_supervisor.Show();
        }

        private void AttendanceSheetdateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            AttendanceSheetdateTimePicker.Format = DateTimePickerFormat.Custom;
            AttendanceSheetdateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void buttonTimeOut_Click_1(object sender, EventArgs e)
        {

            if (comboBoxEmployeeID.SelectedItem == null)
            {
                MessageBox.Show("Please select an Employee ID.");
                return;
            }

            string employeeId = comboBoxEmployeeID.SelectedItem.ToString();
            DateTime timeOut = dateTimePickerforTInTOut.Value;

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\\NSBM - Academic\\Year 01 Semester 03\\C#\\C# Final Project\\Final Software\\Software-for-Filling-Station\\Database1.mdf';Integrated Security=True";

            string query = @" UPDATE Attendance  SET Time_Out = @TimeOut  WHERE EmployeeID = @EmployeeID  AND CONVERT(DATE, Date) = CONVERT(DATE, @Date)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TimeOut", timeOut);
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                        cmd.Parameters.AddWithValue("@Date", AttendanceSheetdateTimePicker.Value.Date);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Time Out recorded successfully.");

                        }
                        else
                        {
                            MessageBox.Show("Time Out not recorded. Make sure the time in entry exists.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to record Time Out: " + ex.Message);
            }
        }
    }
}
