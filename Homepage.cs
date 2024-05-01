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
            // TODO: This line of code loads data into the 'database1DataSet9.salesTest' table. You can move, or remove it, as needed.
            this.salesTestTableAdapter1.Fill(this.database1DataSet9.salesTest);
            // TODO: This line of code loads data into the 'database1DataSet8.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.database1DataSet8.Inventory);
            // TODO: This line of code loads data into the 'database1DataSet6.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter3.Fill(this.database1DataSet6.Orders);
            // TODO: This line of code loads data into the 'database1DataSet5.Orders' table. You can move, or remove it, as needed.
            //this.ordersTableAdapter2.Fill(this.database1DataSet5.Orders);
            // TODO: This line of code loads data into the 'database1DataSet4.Orders' table. You can move, or remove it, as needed.
            //this.ordersTableAdapter1.Fill(this.database1DataSet4.Orders);
            // TODO: This line of code loads data into the 'database1DataSet3.Orders' table. You can move, or remove it, as needed.
            //this.ordersTableAdapter.Fill(this.database1DataSet3.Orders);
            // TODO: This line of code loads data into the 'database1DataSet2.salesTest' table. You can move, or remove it, as needed.
            this.salesTestTableAdapter.Fill(this.database1DataSet2.salesTest);
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

        private void orders_label_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
        }

        private void testLabel_Click(object sender, EventArgs e)
        {
            salesTest test = new salesTest();
            test.Show();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void testInventoryLabel_Click(object sender, EventArgs e)
        {
            InventoryV1 inventoryV1 = new InventoryV1();
            inventoryV1.Show();
        }

        private void ordersLabel_Click(object sender, EventArgs e)
        {

        }

        private void settingsLabel_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
    }
}
