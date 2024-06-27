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
    public partial class Attendance : Form
    {
        private string mysql = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True");
        public Attendance()
        {
            InitializeComponent();
          //  LoadSupervisors();
           // LoadEmployees();
        }

       /* private void LoadSupervisors()
        {
            try
            { 
                using (SqlConnection conn = new SqlConnection(mysql))
                {
                    conn.Open();
                    string query = "SELECT Supervisor_Name FROM Supervisor ORDER BY Name";
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
                  MessageBox.Show("Supervisors Loaded ");
              } 
        } */
       /*
        private void LoadEmployees()
        {
            string query = "SELECT EmployeeID, NameInitial, NIC, DoB, FirstName, LastName, MiddleName, Position FROM Employee ORDER BY NameInitial";

            using (SqlConnection conn = new SqlConnection(mysql))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    AttendanceSheetDataGrid.DataSource = dt;

                }
            }
        }
       */
        private void buttonTimeIn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(mysql))
                {
                    conn.Open();
                    foreach (DataGridViewRow row in AttendanceSheetDataGrid.Rows)
                    {
                        if (row.Cells["Status"].Value != DBNull.Value)
                        {
                            string query = $"INSERT INTO Attendance (EmployeeID, Date, Status, Time_In ,Time_Out) VALUES (@EmployeeID, @Date, @Status, @Time_In, @Time_Out)";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@EmployeeID", row.Cells["EmployeeID"].Value);
                                cmd.Parameters.AddWithValue("@Date", AttendanceSheetdateTimePicker.Value);
                                cmd.Parameters.AddWithValue("@Time_In", dateTimePickerforTInTOut.Value);
                                cmd.Parameters.AddWithValue("@Time_Out", row.Cells["Time_Out"].Value);
                                cmd.Parameters.AddWithValue("@Status", (bool)row.Cells["Status"].Value ? "Present" : "Absent");
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    MessageBox.Show("Attendance recorded successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to record attendance: " + ex.Message);
            }


        }

        private void addnewemployeebtn_Click(object sender, EventArgs e)
        {
            Add_New_Employees new_Employees = new Add_New_Employees();
            new_Employees.Show();
        }

        private void addnewsupervisorbtn_Click(object sender, EventArgs e)
        {
            Add_New_Supervisors new_Supervisor = new Add_New_Supervisors();
            new_Supervisor.Show();
        }

        private void buttonTimeOut_Click(object sender, EventArgs e)
        {
            if (AttendanceSheetDataGrid.CurrentRow == null)
            {
                MessageBox.Show("Add Time In First.");
                return;
            }

            int employeeId = Convert.ToInt32(AttendanceSheetDataGrid.CurrentRow.Cells["EmployeeID"].Value);
            DateTime timeOut = dateTimePickerforTInTOut.Value;

            string connectionString = mysql;
            string query = "UPDATE Attendance SET Time_Out = @TimeOut WHERE EmployeeID = @EmployeeID AND Date = CONVERT(DATE, @Date)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Time_Out", timeOut);
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                        cmd.Parameters.AddWithValue("@Date", dateTimePickerforTInTOut.Value.Date);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Time Out recorded successfully.");

                            AttendanceSheetDataGrid.CurrentRow.Cells["Time_Out"].Value = timeOut.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Time Out not recorded.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to record Time Out: " + ex.Message);
            }
        }

        private void AttendanceSheetdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            AttendanceSheetdateTimePicker.Format = DateTimePickerFormat.Custom;
            AttendanceSheetdateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet15.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.database1DataSet15.Employee);

        }

        private void comboBoxSupervisorName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AttendanceSheetDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        /*   private void buttonPrint_Click(object sender, EventArgs e)
           {
               Print();
           }

            private void Print()
           {
               DGVPrinter printer = new DGVPrinter();
               printer.Title = "Attendance Sheet";
               printer.SubTitle = $"{comboBoxSupervisorName.Text}\nDate: {AttendanceSheetdateTimePicker.Text}";
               printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
               printer.PageNumbers = true;
               printer.PageNumberInHeader = false;
               printer.PorportionalColumns = true;
               printer.HeaderCellAlignment = StringAlignment.Near;
               printer.Footer = "Filling Station Software";
               printer.FooterSpacing = 15;
               printer.PrintDataGridView(AttendanceSheetDataGrid);
           }*/


    }
}
