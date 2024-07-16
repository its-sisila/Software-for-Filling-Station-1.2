using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using Xamarin.Forms;

namespace Software_for_Filling_Station
{
    public partial class Attendance : Form
    {
       
        public Attendance()
        {
            InitializeComponent();
            LoadEmployeeId();
            LoadSupervisors();
            comboBoxEmployeeID.SelectedIndexChanged += new EventHandler(comboBoxEmployeeID_SelectedIndexChanged);
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            LoadData();
            shiftcheckedListBox.Items.Add("7.00AM (DAY)");
            shiftcheckedListBox.Items.Add("7.00PM (NIGHT)");
            AttendanceSheetdateTimePicker.Value = DateTime.Now;
            dateTimePickerforTInTOut.Value = DateTime.Now;
            
        }

        private void LoadData()
        {
            string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Software-for-Filling-Station-1.2\\Database1.mdf;Integrated Security=True";

            string query = "SELECT * FROM Attendances ";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlDataAdapter dataadapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataadapter.Fill(dataTable);
                AttendanceSheetDataGrid.DataSource = dataTable;
            }
        }

        private void Attendance2_Load1(object sender, EventArgs e)
        {
            
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
            if (comboBoxEmployeeID.SelectedItem != null)
            {
                int Employee_id = int.Parse(comboBoxEmployeeID.SelectedItem.ToString());
                LoadEmployeeName(Employee_id);
            }
        }

        private void Attendance2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet20.Attendances' table. You can move, or remove it, as needed.
            this.attendancesTableAdapter1.Fill(this.database1DataSet20.Attendances);
            // TODO: This line of code loads data into the 'database1DataSet18.Attendances' table. You can move, or remove it, as needed.
            //this.attendancesTableAdapter.Fill(this.database1DataSet18.Attendances);

        }

        private void LoadEmployeeName(int Employee_id)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Software-for-Filling-Station-1.2\Database1.mdf;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT Name_initial FROM Employees WHERE Employee_id = @Employee_id ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Employee_id", Employee_id);

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

        private void LoadEmployeeId()
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
                    MessageBox.Show("Error :" +ex.Message);
                }
            }
        }

        private void LoadSupervisors()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Software-for-Filling-Station-1.2\Database1.mdf;Integrated Security=True"))
            {
                try
                {
                    conn.Open();

                    string query = $"SELECT Name_initial FROM Supervisors";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxSupervisorName.Items.Add(reader["Name_initial"].ToString());
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

        private void buttonTimeIn_Click_1(object sender, EventArgs e)
        {

            string EmployeeId = comboBoxEmployeeID.SelectedItem.ToString();
            string EmployeeName = textBoxEmployeeName.Text;
            string Date = AttendanceSheetdateTimePicker.Value.ToString("yyyy-MM-dd");
            string Time = dateTimePickerforTInTOut.Value.ToString("HH:mm:ss");
            string SupervisorName = comboBoxSupervisorName.SelectedItem.ToString();
            string shift = "";
            if (shiftcheckedListBox.CheckedItems.Count > 0)
            {
                shift = shiftcheckedListBox.CheckedItems[0].ToString();
            }
            string Status = checkBoxmarkAttendance.Checked ? "Present" : "Absent";

            // Check if SupervisorName is null or empty
            if (string.IsNullOrWhiteSpace(SupervisorName))
            {
                MessageBox.Show("Please select a Supervisor before recording.");
                return; // Exit the method if SupervisorName is not selected
            }


            if (string.IsNullOrWhiteSpace(EmployeeId) ||
                string.IsNullOrWhiteSpace(EmployeeName) ||
                string.IsNullOrWhiteSpace(Date) ||
                string.IsNullOrWhiteSpace(Status) ||
                string.IsNullOrWhiteSpace(Time) ||
                string.IsNullOrWhiteSpace(shift))
            {
                MessageBox.Show("Please fill in all required fields.");
                return; 
            }

            using (SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Software-for-Filling-Station-1.2\Database1.mdf;Integrated Security=True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO  Attendances (Employee_id, Name_initial, Date, Status, Shift, Time_in, Supervisor_name) VALUES (@Employee_id, @Name_initial, @Date, @Status, @Shift, @Time_in, @Supervisor_name)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@Employee_id", EmployeeId);
                    command.Parameters.AddWithValue("@Name_initial", EmployeeName);
                    command.Parameters.AddWithValue("@Date", Date);
                    command.Parameters.AddWithValue("@Status", Status);
                    command.Parameters.AddWithValue("@Shift",shift);
                    command.Parameters.AddWithValue("@Time_in", Time);
                    command.Parameters.AddWithValue("@Supervisor_name", SupervisorName);
                    

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Time-In hase been Recorded successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Record Time-In");
                    }
                    if (
               string.IsNullOrWhiteSpace(comboBoxSupervisorName.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Select Supervisor");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            
            if (string.IsNullOrWhiteSpace(comboBoxEmployeeID.SelectedItem.ToString()) ||
                string.IsNullOrWhiteSpace(textBoxEmployeeName.Text) ||
                string.IsNullOrWhiteSpace(AttendanceSheetdateTimePicker.Value.ToString("yyyy-MM-dd")) ||
                string.IsNullOrWhiteSpace(checkBoxmarkAttendance.Checked ? "Present" : "Absent") ||
                string.IsNullOrWhiteSpace(dateTimePickerforTInTOut.Value.ToString("HH:mm:ss")) ||
                string.IsNullOrWhiteSpace(comboBoxSupervisorName.SelectedItem.ToString()))
            {
                MessageBox.Show("Empty field");
            }


           LoadData();
            
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
            AttendanceSheetdateTimePicker.CustomFormat = "yyyy-MM-dd";
        }

        private void buttonTimeOut_Click_1(object sender, EventArgs e)
        {
            string EmployeeId = comboBoxEmployeeID.SelectedItem.ToString();
            string Time = dateTimePickerforTInTOut.Value.ToString("HH:mm:ss");

           
            if (string.IsNullOrWhiteSpace(EmployeeId) || string.IsNullOrWhiteSpace(Time))
            {
                MessageBox.Show("Please select an Employee and provide Time-Out before recording.");
                return; 
            }


            using (SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Software-for-Filling-Station-1.2\Database1.mdf;Integrated Security=True"))
            {
                try
                {
                    sql.Open();

                    string query = $"UPDATE  Attendances SET Time_out = @Time_out WHERE Employee_id = @Employee_id AND Time_in = (SELECT MAX (Time_in) FROM Attendances WHERE Employee_id = @Employee_id)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@Employee_id", EmployeeId);
                    command.Parameters.AddWithValue("@Time_out", Time);


                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Time-Out hase been Recorded successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Record Time-Out");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            if (string.IsNullOrWhiteSpace(comboBoxEmployeeID.SelectedItem.ToString()) ||
                string.IsNullOrWhiteSpace(dateTimePickerforTInTOut.Value.ToString("HH:mm:ss")))
            {
                MessageBox.Show("Empty field");
            }


            LoadData();
        }

        private void addnewaccountantbtn_Click(object sender, EventArgs e)
        {
            Add_New_Accountant add_New_Accountant = new Add_New_Accountant();
            add_New_Accountant.Show();
        }

        private void checkBoxmarkAttendance_CheckedChanged(object sender, EventArgs e)
        {
            string status = checkBoxmarkAttendance.Checked ? "Present" : "Absent";
        }
    }
}
