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

         private void employeesubmitbtn_Click(object sender, EventArgs e)
        {
            string id = employeeid.Text;
            string firstName = employeefname.Text;
            string lastName = employeelname.Text;
            string namewin = employeenamewin.Text;
            string nic = employeenic.Text;
            string dob = employeedob.Text;


            using (SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Software-for-Filling-Station-1.2\Database1.mdf;Integrated Security=True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO  Employees (Employee_id, First_name, Last_name, Name_initial, NIC, DOB) VALUES (@Employee_id, @First_name, @Last_name, @Name_initial, @NIC, @DOB)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@Employee_id", id);
                    command.Parameters.AddWithValue("@First_name", firstName);
                    command.Parameters.AddWithValue("@Last_name", lastName);
                    command.Parameters.AddWithValue("@Name_initial", namewin);
                    command.Parameters.AddWithValue("@NIC", nic);
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


            if (string.IsNullOrWhiteSpace(employeeid.Text) ||
                string.IsNullOrWhiteSpace(employeefname.Text) ||
                string.IsNullOrWhiteSpace(employeelname.Text) ||
                string.IsNullOrWhiteSpace(employeenamewin.Text) ||
                string.IsNullOrWhiteSpace(employeenic.Text) ||
                string.IsNullOrWhiteSpace(employeedob.Text))
            {
                MessageBox.Show("Empty field");
            }


            
            this.Close();
        }

        private void employeeresetbtn_Click(object sender, EventArgs e)
        {
            employeeid.Text = "";
            employeefname.Text = "";
            employeelname.Text = "";
            employeenamewin.Text = "";
            employeenic.Text = "";
            employeedob.Text = "";
        }
    }
}
