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
    public partial class Add_New_Supervisors : Form
    {
        public Add_New_Supervisors()
        {
            InitializeComponent();
        }

        private void SupervisorsubmitButton_Click(object sender, EventArgs e)
        {
            String Fname = SfNameTextLbl.Text;
            String Lname = SlastnameLbl.Text;
            String Mname = SmiddleNameLbl.Text;
            String Iname = SNameWithInitialLbl.Text;
            String Nic = SNicLbl.Text;
            String Dob = SDOBLbl.Text;
            String Sid = SupervisorIdLbl.Text;
            String Ption = SupervisorPositionLbl.Text;

            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True")) 
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO Supervisor (FirstName, LastName, MiddleName, Name_Initial, NIC, DOB, EmployeeID, Position) VALUES (@Supervisor_FirstName, @Supervisor_LastName, @Supervisor_MiddleName, @SUpervisor_Name, @Supervisor_NIC, @Supervisor_DOB, @Supervisor_ID, @Supervisor_Position)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@Supervisor_FirstName", Fname);
                    command.Parameters.AddWithValue("@Supervisor_LastName", Lname);
                    command.Parameters.AddWithValue("@Supervisor_MiddleName", Mname);
                    command.Parameters.AddWithValue("@Supervisor_Name", Iname);
                    command.Parameters.AddWithValue("@Supervisor_NIC", Nic);
                    command.Parameters.AddWithValue("@Supervisor_DOB", Dob);
                    command.Parameters.AddWithValue("@Supervisor_ID", Sid);
                    command.Parameters.AddWithValue("@Supervisor_Position", Ption);



                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New Supervisor Registration successful!");
                    }
                    else
                    {
                        MessageBox.Show("Registration failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


            if (string.IsNullOrWhiteSpace(SfNameTextLbl.Text) ||
                string.IsNullOrWhiteSpace(SlastnameLbl.Text) ||
                string.IsNullOrWhiteSpace(SmiddleNameLbl.Text) ||
                string.IsNullOrWhiteSpace(SNameWithInitialLbl.Text) ||
                string.IsNullOrWhiteSpace(SNicLbl.Text) ||
                string.IsNullOrWhiteSpace(SDOBLbl.Text) ||
                string.IsNullOrWhiteSpace(SupervisorIdLbl.Text) ||
                string.IsNullOrWhiteSpace(SupervisorPositionLbl.Text))
            {
                MessageBox.Show("Empty field");
            }


            Attendance attendance_Sheet = new Attendance();

            attendance_Sheet.Show();
            this.Close();
        
        }

        private void SupervisorresetButton_Click(object sender, EventArgs e)
        {
            SfNameTextLbl.Text = "";
            SlastnameLbl.Text = "";
            SmiddleNameLbl.Text = "";
            SNameWithInitialLbl.Text = "";
            SNicLbl.Text = "";
            SDOBLbl.Text = "";
            SupervisorIdLbl.Text = "";
            SupervisorPositionLbl.Text = "";
        }
    }
}
