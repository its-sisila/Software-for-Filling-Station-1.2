using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Software_for_Filling_Station
{
    public partial class Add_New_Employees : Form
    {
        public Add_New_Employees()
        {
            InitializeComponent();
        }

        private void employeesubmitButton_Click(object sender, EventArgs e)
        {
            string Fname = fNameTextLbl.Text;
            string Lname = lastnameLbl.Text;
            string Mname = middleNameLbl.Text;
            string Initials = NameWithInitialLbl.Text;
            string Nic = NicLbl.Text;
            string DOB = DOBLbl.Text;
            string ID = EmployerIdLbl.Text;
            string Position = PositionLbl.Text;

            using (SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    conn.Open();

                    string query = $"INSERT INTO Employee (FirstName, LastName, MiddleName, NameInitial, NIC, DoB, EmployeeID, Position) VALUES (@Employee_FirstName, @Employee_LastName,  @Employee_MiddleName, @Employee_Name, @Employee_NIC, @Employee_DOB, @Employee_ID, @Employee_Position)";
                    SqlCommand command = new SqlCommand(query, conn);

                    command.Parameters.AddWithValue("@Employee_FirstName", Fname);
                    command.Parameters.AddWithValue("@Employee_LastName", Lname);
                    command.Parameters.AddWithValue("@Employee_MiddleName", Mname);
                    command.Parameters.AddWithValue("@Employee_Name", Initials);
                    command.Parameters.AddWithValue("@Employee_NIC", Nic);
                    command.Parameters.AddWithValue("@Employee_DOB", DOB);
                    command.Parameters.AddWithValue("@Employee_ID", ID);
                    command.Parameters.AddWithValue("@Employee_Position", Position);



                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New Employer Registration successful!");
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


            if (string.IsNullOrWhiteSpace(fNameTextLbl.Text) ||
                string.IsNullOrWhiteSpace(lastnameLbl.Text) ||
                string.IsNullOrWhiteSpace(middleNameLbl.Text) ||
                string.IsNullOrWhiteSpace(NameWithInitialLbl.Text) ||
                string.IsNullOrWhiteSpace(NicLbl.Text) ||
                string.IsNullOrWhiteSpace(DOBLbl.Text) ||
                string.IsNullOrWhiteSpace(EmployerIdLbl.Text) ||
                string.IsNullOrWhiteSpace(PositionLbl.Text))
            {
                MessageBox.Show("Empty field");
            }


            Attendance attendance_Sheet = new Attendance();

            attendance_Sheet.Show();
            this.Close();
        }

        private void employeeresetButton_Click(object sender, EventArgs e)
        {
            fNameTextLbl.Text = "";
            lastnameLbl.Text = "";
            middleNameLbl.Text = "";
            NameWithInitialLbl.Text = "";
            NicLbl.Text = "";
            DOBLbl.Text = "";
            EmployerIdLbl.Text = "";
            PositionLbl.Text = "";
        }
    }
}
