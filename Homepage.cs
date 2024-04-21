using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_for_Filling_Station
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            WebBrowser webBrowser1 = new WebBrowser
            {
                Location = new Point(0, 100) // Set the position
            };

            // Adding  webBrowser1 control to your form or container
            this.Controls.Add(webBrowser1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void inventoryLabel_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           /*bBrowser webBrowser1 = new WebBrowser
            {
                Location = new Point(0, 100) // this section be turned to a comment because the location have been moved to a different location
            };*/
        }

        private void accountsLabel_Click(object sender, EventArgs e)
        {

        }

        private void usersLabel_Click(object sender, EventArgs e)
        {
            Users users = new Users();

            users.Show();
        }

        private void logOutLabel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.FormClosed += (s, args) => this.Close();
            login.Show();

            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void attendanceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salesLabel_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }
    }
}
