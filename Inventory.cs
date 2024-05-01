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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();

            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
            checkBox7.Checked = true;
            checkBox8.Checked = true;

        }

        private void todayDipText_TextChanged(object sender, EventArgs e)
        {

        }

        private void prevDipText_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeLP95_1_ValueChanged(object sender, EventArgs e)
        {
            dateTimeLP95_1.Format = DateTimePickerFormat.Custom;
            dateTimeLP95_1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void submitButton95_1_Click(object sender, EventArgs e)
        {  
            string prevDip = prevDipText.Text;
            string todayDip = todayDipText.Text;
            DateTime date = dateTimeLP95_1.Value;
            string dipSale = dipSaleLP95_1Txt.Text;


            using (SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    conn.Open();

                    string query = $"INSERT INTO Inventory2 (date, prevDip, todayDip, dipSale) VALUES (@date, @prevDip, @todayDip, @dipSale)";
                    SqlCommand command = new SqlCommand(query, conn);

                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@prevDip", prevDip);
                    command.Parameters.AddWithValue("@todayDip", todayDip);
                    command.Parameters.AddWithValue("@dipSale", dipSale);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error " + ex.Message);
                } 

                string previousDip = prevDipText.Text;
                string todaysDip = todayDipText.Text;


                double previousDayDip, todaysDayDip;


                if (!double.TryParse(previousDip, out previousDayDip))
                {

                    previousDayDip = 0;
                }

                if (!double.TryParse(todaysDip, out todaysDayDip))
                {

                    todaysDayDip = 0;
                }

                double todaysDipSale = previousDayDip - todaysDayDip;


                dipSaleLP95_1Txt.Text = todaysDipSale.ToString();

        }




    }

        private void realSubmitButton95_1_Click(object sender, EventArgs e)
        {
            string prevDip = prevDipText.Text;
            string todayDip = todayDipText.Text;
            DateTime date = dateTimeLP95_1.Value;
            string dipSale = dipSaleLP95_1Txt.Text;
            string tankNo = LP95_tank1_Label.Text;


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

        private void dateTimePickerLSD_1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLSD_1.Format = DateTimePickerFormat.Custom;
            dateTimePickerLSD_1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void dateTimePickerLAD2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLAD2.Format = DateTimePickerFormat.Custom;
            dateTimePickerLAD2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void dateTimePickerLAD_1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLAD_1.Format = DateTimePickerFormat.Custom;
            dateTimePickerLAD_1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void dateTimePickerLAD_3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLAD_3.Format = DateTimePickerFormat.Custom;
            dateTimePickerLAD_3.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void dateTimePickerLAD4_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLAD4.Format = DateTimePickerFormat.Custom;
            dateTimePickerLAD4.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void dateTimePickerLP92_2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLP92_2.Format = DateTimePickerFormat.Custom;
            dateTimePickerLP92_2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void dateTimePickerLP92_1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLP92_1.Format = DateTimePickerFormat.Custom;
            dateTimePickerLP92_1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void enterButtonLSD1_Click(object sender, EventArgs e)
        {
            string prevDip = prevDipLSD_1.Text;
            string todayDip = todayDipLSD1.Text;
            DateTime date = dateTimePickerLSD_1.Value;
            string dipSale = dipSaleLSD1.Text;


            using (SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    conn.Open();

                    string query = $"INSERT INTO Inventory2 (date, prevDip, todayDip, dipSale) VALUES (@date, @prevDip, @todayDip, @dipSale)";
                    SqlCommand command = new SqlCommand(query, conn);

                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@prevDip", prevDip);
                    command.Parameters.AddWithValue("@todayDip", todayDip);
                    command.Parameters.AddWithValue("@dipSale", dipSale);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error " + ex.Message);
                }

                string previousDip = prevDipLSD_1.Text;
                string todaysDip = todayDipLSD1.Text;


                double previousDayDip, todaysDayDip;


                if (!double.TryParse(previousDip, out previousDayDip))
                {

                    previousDayDip = 0;
                }

                if (!double.TryParse(todaysDip, out todaysDayDip))
                {

                    todaysDayDip = 0;
                }

                double todaysDipSale = previousDayDip - todaysDayDip;


                dipSaleLSD1.Text = todaysDipSale.ToString();
            }

        }

        private void submitButtonLSD1_Click(object sender, EventArgs e)
        {
            string prevDip = prevDipLSD_1.Text;
            string todayDip = todayDipLSD1.Text;
            DateTime date = dateTimePickerLSD_1.Value;
            string dipSale = dipSaleLSD1.Text;
            string tankNo = labelLSD_1.Text;


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

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet12.Inventory2' table. You can move, or remove it, as needed.
            this.inventory2TableAdapter.Fill(this.database1DataSet12.Inventory2);

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string previousDip = prevDipLAD_1.Text;
            string todaysDip = todayDipLAD_1.Text;


            double previousDayDip, todaysDayDip;


            if (!double.TryParse(previousDip, out previousDayDip))
            {

                previousDayDip = 0;
            }

            if (!double.TryParse(todaysDip, out todaysDayDip))
            {

                todaysDayDip = 0;
            }

            double todaysDipSale = previousDayDip - todaysDayDip;


            dipSaleLAD_1.Text = todaysDipSale.ToString();
        }

        private void submitButtonLAD_1_Click(object sender, EventArgs e)
        {

            string prevDip = prevDipLAD_1.Text;
            string todayDip = todayDipLAD_1.Text;
            DateTime date = dateTimePickerLAD_1.Value;
            string dipSale = dipSaleLAD_1.Text;
            string tankNo = labelLAD_1.Text;


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

        private void enterButtonLAD2_Click(object sender, EventArgs e)
        {

            string previousDip = prevDipLAD2.Text;
            string todaysDip = todayDipLAD2.Text;


            double previousDayDip, todaysDayDip;


            if (!double.TryParse(previousDip, out previousDayDip))
            {

                previousDayDip = 0;
            }

            if (!double.TryParse(todaysDip, out todaysDayDip))
            {

                todaysDayDip = 0;
            }

            double todaysDipSale = previousDayDip - todaysDayDip;


            dipSaleLAD2.Text = todaysDipSale.ToString();
        }

        private void submitButtonLAD2_Click(object sender, EventArgs e)
        {


            string prevDip = prevDipLAD2.Text;
            string todayDip = todayDipLAD2.Text;
            DateTime date = dateTimePickerLAD2.Value;
            string dipSale = dipSaleLAD2.Text;
            string tankNo = labelLAD2.Text;


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

        private void enterButtonLAD3_Click(object sender, EventArgs e)
        {


            string previousDip = prevDipLAD_3.Text;
            string todaysDip = todayDip_LAD3.Text;


            double previousDayDip, todaysDayDip;


            if (!double.TryParse(previousDip, out previousDayDip))
            {

                previousDayDip = 0;
            }

            if (!double.TryParse(todaysDip, out todaysDayDip))
            {

                todaysDayDip = 0;
            }

            double todaysDipSale = previousDayDip - todaysDayDip;


            dipSaleLAD3.Text = todaysDipSale.ToString();

        }

        private void submitButtonLAD3_Click(object sender, EventArgs e)
        {


            string prevDip = prevDipLAD_3.Text;
            string todayDip = todayDip_LAD3.Text;
            DateTime date = dateTimePickerLAD_3.Value;
            string dipSale = dipSaleLAD3.Text;
            string tankNo = labelLAD3.Text;


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

        private void enterButtonLAD4_Click(object sender, EventArgs e)
        {
            string previousDip = prevDipLAD4.Text;
            string todaysDip = todayDip4.Text;


            double previousDayDip, todaysDayDip;


            if (!double.TryParse(previousDip, out previousDayDip))
            {

                previousDayDip = 0;
            }

            if (!double.TryParse(todaysDip, out todaysDayDip))
            {

                todaysDayDip = 0;
            }

            double todaysDipSale = previousDayDip - todaysDayDip;


            dipSaleLAD4.Text = todaysDipSale.ToString();
        }

        private void submitButtonLAD4_Click(object sender, EventArgs e)
        {



            string prevDip = prevDipLAD4.Text;
            string todayDip = todayDip4.Text;
            DateTime date = dateTimePickerLAD4.Value;
            string dipSale = dipSaleLAD4.Text;
            string tankNo = labelLAD4.Text;


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

        private void enterButtonLP92_1_Click(object sender, EventArgs e)
        {

            string previousDip = prevDipLP92_1.Text;
            string todaysDip = todayDipLP92_1.Text;


            double previousDayDip, todaysDayDip;


            if (!double.TryParse(previousDip, out previousDayDip))
            {

                previousDayDip = 0;
            }

            if (!double.TryParse(todaysDip, out todaysDayDip))
            {

                todaysDayDip = 0;
            }

            double todaysDipSale = previousDayDip - todaysDayDip;


            dipSaleLP92_1.Text = todaysDipSale.ToString();

        }

        private void submitButtonLP92_1_Click(object sender, EventArgs e)
        {

            string prevDip = prevDipLP92_1.Text;
            string todayDip = todayDipLP92_1.Text;
            DateTime date = dateTimePickerLP92_1.Value;
            string dipSale = dipSaleLP92_1.Text;
            string tankNo = labelLP92_1.Text;


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

        private void enterButtonLP92_2_Click(object sender, EventArgs e)
        {


            string previousDip = prevDipLP92_2.Text;
            string todaysDip = todayDipLP92_2.Text;


            double previousDayDip, todaysDayDip;


            if (!double.TryParse(previousDip, out previousDayDip))
            {

                previousDayDip = 0;
            }

            if (!double.TryParse(todaysDip, out todaysDayDip))
            {

                todaysDayDip = 0;
            }

            double todaysDipSale = previousDayDip - todaysDayDip;


            dipSaleLP92_2.Text = todaysDipSale.ToString();


        }

        private void submitButtonLP92_2_Click(object sender, EventArgs e)
        {
            string prevDip = prevDipLP92_2.Text;
            string todayDip = todayDipLP92_2.Text;
            DateTime date = dateTimePickerLP92_2.Value;
            string dipSale = dipSaleLP92_2.Text;
            string tankNo = labelLP92_2.Text;


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
