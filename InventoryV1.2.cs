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
            try
            {

                string selectedTankNo = tankNoDrop.SelectedItem?.ToString();

            
                if (!string.IsNullOrEmpty(selectedTankNo))
                {
           
                    string query = "SELECT todayDip FROM Inventory2 WHERE tankNo = @TankNo";

         
                    using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
                    {
                        SqlCommand command = new SqlCommand(query, sql);

                        command.Parameters.AddWithValue("@TankNo", selectedTankNo);

                        sql.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string todayDip = reader["todayDip"].ToString();
                            prevDipText.Text = todayDip;
                        }
                        else
                        {
                            prevDipText.Text = "No previous dip found for the selected tank.";
                        }
                        reader.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a tank number.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

        }


        private void InventoryV1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet10.Inventory2' table. You can move, or remove it, as needed.
            this.inventory2TableAdapter.Fill(this.database1DataSet10.Inventory2);
            // TODO: This line of code loads data into the 'database1DataSet7.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.database1DataSet7.Inventory);

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            string prevDip = prevDipText.Text;
            string todayDip = todayDipText.Text;
            DateTime date = dateTimePicker.Value;
            string dipSale = dipSaleText.Text;
            string tankNo = tankNoDrop.SelectedItem?.ToString();


            using (SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    conn.Open();

                    string query = $"INSERT INTO Inventory2 (date, prevDip, todayDip, dipSale, tankNo) VALUES (@date, @prevDip, @todayDip, @dipSale, @tankNo)";
                    SqlCommand command = new SqlCommand(query, conn);

                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@prevDip", prevDip);
                    command.Parameters.AddWithValue("@todayDip", todayDip);
                    command.Parameters.AddWithValue("@dipSale", dipSale);
                    command.Parameters.AddWithValue("@tankNo", tankNo);


                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successful!");
                    }
                    else
                    {
                        MessageBox.Show("failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error " + ex.Message);
                }
            }
        }
    }
}
