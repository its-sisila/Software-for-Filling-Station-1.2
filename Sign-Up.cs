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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Software_for_Filling_Station
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lNameLebel_Click(object sender, EventArgs e)
        {

        }

        private void fNameLebel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void confirmPassLebel_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string firstName = fNameText.Text;
            string lastName = lNameText.Text;
            string username = usernameText.Text;
            string password = passwordText.Text;
            string id = idText.Text;

            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            { 
                    try
            {
                sql.Open();
                
                string query = $"INSERT INTO Users (firstName, lastName, username, password, id) VALUES (@firstName, @lastName, @username, @password, @id)";
                SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@id", id);

                
                   
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
            if (passwordText.Text != confirmPassText.Text)
            {
                    MessageBox.Show("Password is not matching");
            }

            if (string.IsNullOrWhiteSpace(fNameText.Text) ||
                string.IsNullOrWhiteSpace(lNameText.Text) ||
                string.IsNullOrWhiteSpace(usernameText.Text) ||
                string.IsNullOrWhiteSpace(passwordText.Text) ||
                string.IsNullOrWhiteSpace(confirmPassText.Text))
            {
                MessageBox.Show("Empty field");
            }


            Homepage homepage = new Homepage();

            homepage.Show();
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            fNameText.Text = "";
            lNameText.Text = "";
            usernameText.Text = "";
            passwordText.Text = "";
            confirmPassText.Text = "";
        }

        private void fNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
