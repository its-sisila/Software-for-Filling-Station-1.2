using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_for_Filling_Station
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string enteredUsername = usernameText.Text;
            string enteredPassword = passwordText.Text;

            string query = "SELECT COUNT(*) FROM Users WHERE username = @username AND password = @password";

            using (SqlConnection sql= new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                SqlCommand command = new SqlCommand(query, sql);
                command.Parameters.AddWithValue("@Username", enteredUsername);
                command.Parameters.AddWithValue("@Password", enteredPassword);

                sql.Open();

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Login successful!");


                    Homepage homepage = new Homepage();
                    homepage.FormClosed += (s, args) => this.Close();
                    homepage.Show();

                    // Login login = new Login(); closing method does not work. the whole app closes
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                    
                }
            }





            if (string.IsNullOrWhiteSpace(usernameText.Text) ||
                string.IsNullOrWhiteSpace(passwordText.Text))
            {
                MessageBox.Show("Empty field");
            }


           /* Homepage homepage = new Homepage();
            this.Close();
            homepage.Show();
             */   
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            usernameText.Text = "";
            passwordText.Text = "";
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void forPassLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
