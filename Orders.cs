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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            checkBox1.Checked = true;
        }

        private void receivedButton_Click(object sender, EventArgs e)
        {

            DateTime date = datePicker.Value;
           // DateTime time = timePicker.Value;
            string fuelType = fuelTypeDrop.SelectedItem.ToString();
            string tankNo = tankNoDrop.SelectedItem.ToString();
            string liters = litersText.Text;


            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO Orders (date, fuelType, tankNo, liters) VALUES (@date, @fuelType, @tankNo, @liters)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@fuelType", fuelType);
                    command.Parameters.AddWithValue("@tankNo", tankNo);
                    command.Parameters.AddWithValue("@liters", liters);



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
                    MessageBox.Show("Error: " + ex.Message);
                }

            }

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet11.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.database1DataSet11.Orders);

        }
    }
}
