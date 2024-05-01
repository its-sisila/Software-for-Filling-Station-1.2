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
    public partial class InventoryV1 : Form
    {
        public InventoryV1()
        {
            InitializeComponent();

            checkBox1.Checked = true;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void prevDipText_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectTankButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT previousDayDip FROM Inventory";
            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                SqlCommand command = new SqlCommand(query, sql);
                sql.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string previousDayDip = reader["previousDayDip"].ToString();

                    prevDipText.Text = previousDayDip;

                }
                reader.Close();
            }
        }


        private void InventoryV1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet10.Inventory2' table. You can move, or remove it, as needed.
            this.inventory2TableAdapter.Fill(this.database1DataSet10.Inventory2);
            // TODO: This line of code loads data into the 'database1DataSet7.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.database1DataSet7.Inventory);

        }
    }
}
