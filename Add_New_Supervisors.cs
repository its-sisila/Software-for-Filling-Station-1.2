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
using static Software_for_Filling_Station.Database1DataSet15;

namespace Software_for_Filling_Station
{
    public partial class Add_New_Supervisors : Form
    {
        public Add_New_Supervisors()
        {
            InitializeComponent();
        }

        private void supervisorsubmitbtn_Click(object sender, EventArgs e)
        {
            string id = supervisorid.Text;
            string firstName = supervisorfname.Text;
            string lastName = supervisorlname.Text;
            string namewin = supervisornamewin.Text;
            string nic = supervisornic.Text;
            string username = supervisorusername.Text;
            string password = supervisorpassword.Text;
            string cpassword = supervisorcpassword.Text;
            string dob = supervisordob.Text;


            using (SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Software-for-Filling-Station-1.2\Database1.mdf;Integrated Security=True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO  Supervisors (Supervisor_id, First_name, Last_name, Name_initial, NIC, Username, Password, DOB) VALUES (@Supervisor_id, @First_name, @Last_name, @Name_initial, @NIC, @Username, @Password, @DOB)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@Supervisor_id", id);
                    command.Parameters.AddWithValue("@First_name", firstName);
                    command.Parameters.AddWithValue("@Last_name", lastName);
                    command.Parameters.AddWithValue("@Name_initial", namewin);
                    command.Parameters.AddWithValue("@NIC", nic);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@DOB", dob);




                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful!");
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
            if (supervisorpassword.Text != supervisorcpassword.Text)
            {
                MessageBox.Show("Password is not matching");
            }


            if (string.IsNullOrWhiteSpace(supervisorid.Text) ||
                string.IsNullOrWhiteSpace(supervisorfname.Text) ||
                string.IsNullOrWhiteSpace(supervisorlname.Text) ||
                string.IsNullOrWhiteSpace(supervisornamewin.Text) ||
                string.IsNullOrWhiteSpace(supervisornic.Text) ||
                string.IsNullOrWhiteSpace(supervisorusername.Text) ||
                string.IsNullOrWhiteSpace(supervisorpassword.Text) ||
                string.IsNullOrWhiteSpace(supervisorcpassword.Text) ||
                string.IsNullOrWhiteSpace(supervisordob.Text))
            {
                MessageBox.Show("Empty field");
            }


            

            
            this.Close();
        }

        private void supervisorresetbtn_Click(object sender, EventArgs e)
        {
            supervisorid.Text = "";
            supervisorfname.Text = "";
            supervisorlname.Text = "";
            supervisornamewin.Text = "";
            supervisornic.Text = "";
            supervisorusername.Text = "";
            supervisorpassword.Text = "";
            supervisorcpassword.Text = "";
            supervisordob.Text = "";
        }
    }
}
