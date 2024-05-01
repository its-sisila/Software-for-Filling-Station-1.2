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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
          
                string query = "SELECT firstName, lastName, username, password, id FROM Users";
                using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
                {
                    SqlCommand command = new SqlCommand(query, sql);
                    sql.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string firstName = reader["firstName"].ToString();
                        string lastName = reader["lastName"].ToString();
                        string username = reader["username"].ToString();
                        string password = reader["password"].ToString();
                        string id = reader["id"].ToString();

                    
                        lNameLabel.Text = lastName;
                        fNameLabel.Text = firstName;
                        idLabel.Text = id;
                        usernameLabel.Text = username;
                        passwordLabel.Text = password;
                        
                    }
                    reader.Close();
                }

        }

        private void fNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet11.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.database1DataSet11.Users);

        }
    }
}
