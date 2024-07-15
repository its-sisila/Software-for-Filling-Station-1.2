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
    public partial class Add_New_Accountant : Form
    {
        public Add_New_Accountant()
        {
            InitializeComponent();
        }

        private void accountantsubmitbtn_Click(object sender, EventArgs e)
        {
            string id = accountantid.Text;
            string firstName = accountantfname.Text;
            string lastName = accountantlname.Text;
            string namewin = accountantnamewin.Text;
            string nic = accountantnic.Text;
            string username = accountantusername.Text;
            string password = accountantpassword.Text;
            string cpassword = accountantpassword.Text;
            string dob = accountantdob.Text;


            using (SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Software-for-Filling-Station-1.2\Database1.mdf;Integrated Security=True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO  Accountants (Accountant_id, First_name, Last_name, Name_initial, NIC, Username, Password, DOB) VALUES (@Accountant_id, @First_name, @Last_name, @Name_initial, @NIC, @Username, @Password, @DOB)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@Accountant_id", id);
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
            if (accountantpassword.Text != accountantcpassword.Text)
            {
                MessageBox.Show("Password is not matching");
            }


            if (string.IsNullOrWhiteSpace(accountantid.Text) ||
                string.IsNullOrWhiteSpace(accountantfname.Text) ||
                string.IsNullOrWhiteSpace(accountantlname.Text) ||
                string.IsNullOrWhiteSpace(accountantnamewin.Text) ||
                string.IsNullOrWhiteSpace(accountantnic.Text) ||
                string.IsNullOrWhiteSpace(accountantusername.Text) ||
                string.IsNullOrWhiteSpace(accountantpassword.Text) ||
                string.IsNullOrWhiteSpace(accountantcpassword.Text) ||
                string.IsNullOrWhiteSpace(accountantdob.Text))
            {
                MessageBox.Show("Empty field");
            }


           
            this.Close();
        }

        private void accountantresetbtn_Click(object sender, EventArgs e)
        {
            accountantid.Text = "";
            accountantfname.Text = "";
            accountantlname.Text = "";
            accountantnamewin.Text = "";
            accountantnic.Text = "";
            accountantusername.Text = "";
            accountantpassword.Text = "";
            accountantcpassword.Text = "";
            accountantdob.Text = "";
        }
    }
}
