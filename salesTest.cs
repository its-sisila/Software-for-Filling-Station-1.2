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
using System.Xml.Linq;

namespace Software_for_Filling_Station
{
    public partial class salesTest : Form
    {
        public salesTest()
        {
            InitializeComponent();

            checkBox11.Checked = true;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            string startMeter = startMeterText.Text;
            string endMeter = endMeterText.Text;
            string salesLiters = salesLiterstxt.Text;
            string salesLKR = salesLKRtxt.Text;
            DateTime date = dateTimePicker1.Value;
            DateTime shift = dateTimePicker2.Value;
            string shiftDrop = shiftBox.SelectedItem?.ToString(); 
            string nozzel = nozzelText.SelectedItem?.ToString(); 

            if (string.IsNullOrEmpty(shiftDrop))
            {
                MessageBox.Show("Please select a shift.");
                return;
            }   



            string formattedDate = date.ToString("yyyy-MM-dd HH:mm:ss");

            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO salesTest (date, shift, startMeter, endMeter, salesLiters, salesLKR, nozzel, shiftDrop) VALUES (@date, @shift, @startMeter, @endMeter, @salesLiters, @salesLKR, @nozzel, @shiftDrop)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@startMeter", startMeter);
                    command.Parameters.AddWithValue("@endMeter", endMeter);
                    command.Parameters.AddWithValue("@salesLiters", salesLiters);
                    command.Parameters.AddWithValue("@salesLKR", salesLKR);
                    command.Parameters.AddWithValue("@date", formattedDate);
                    command.Parameters.AddWithValue("@shift", shift);
                    command.Parameters.AddWithValue("@nozzel", nozzel);
                    command.Parameters.AddWithValue("@shiftDrop", shiftDrop);



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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";  
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            
            string startMeterStr = startMeterText.Text;
            string endMeterStr = endMeterText.Text;
            string literPriceStr = literPriceText.Text;

          
            double startMeter, endMeter, literPrice;

            if (!double.TryParse(startMeterStr, out startMeter))
            {

                startMeter = 0; 
            }

            if (!double.TryParse(endMeterStr, out endMeter))
            {
  
                endMeter = 0; 
            }

            if (!double.TryParse(literPriceStr, out literPrice))
            {
   
                literPrice = 0; 
            }

            DateTime date = dateTimePicker1.Value; 
            string shift = shiftBox.SelectedItem.ToString();
            string nozzel = nozzelText.SelectedItem.ToString();

            
            double salesLiters = endMeter - startMeter;

           
            double salesLKR = salesLiters * literPrice;

            
            salesLiterstxt.Text = salesLiters.ToString();
            salesLKRtxt.Text = salesLKR.ToString();

          

            


        }

        private void nozzelText_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nozzel = Convert.ToString(nozzelText.SelectedItem);
        }

        private void shiftBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string shift = Convert.ToString(shiftBox.SelectedItem);
        }

        private void salesTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet14.salesTest' table. You can move, or remove it, as needed.
            this.salesTestTableAdapter.Fill(this.database1DataSet14.salesTest);

        }
    }
}