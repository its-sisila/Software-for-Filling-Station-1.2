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
    public partial class Sales : Form
    {
        public Sales()
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
            checkBox9.Checked = true;
            checkBox10.Checked = true;
            checkBox11.Checked = true;
            checkBox12.Checked = true;
            checkBox13.Checked = true;
            checkBox14.Checked = true;
            checkBox15.Checked = true;
            checkBox16.Checked = true;
        }

        private void debitPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pumpLP92_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pumpNoL_Click(object sender, EventArgs e)
        {

        }

        private void LP92_1_endLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void LP92_1_startLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void LP92_1_salesLiterText_TextChanged(object sender, EventArgs e)
        {

        }

        private void LP92_1_salesLiterLabel_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }

        private void endMeterLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerLP92_1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLP92_1.Format = DateTimePickerFormat.Custom;
            dateTimePickerLP92_1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {


            string meterStart = LP92_1_startLabel.Text;
            string meterEnd = LP92_1_endLabel.Text;
            string salesLiters = LP92_1_salesLiterText.Text;
            string salesLKR = LP92_1_salesLKRText.Text;
            DateTime date = dateTimePickerLP92_1.Value;
            DateTime shift = shiftTimePickerLP92_1.Value;
            string nozzel = LP_92_1_Label.Text;


            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO Sales (date, shift, meterStart, meterEnd, salesLiters, salesLKR, nozzel) VALUES (@date, @shift, @meterStart, @meterEnd, @salesLiters, @salesLKR, @nozzel)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@meterStart", meterStart);
                    command.Parameters.AddWithValue("@meterEnd", meterEnd);
                    command.Parameters.AddWithValue("@salesLiters", salesLiters);
                    command.Parameters.AddWithValue("@salesLKR", salesLKR);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@shift", shift);
                    command.Parameters.AddWithValue("@nozzel", nozzel);



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

        private void label71_Click(object sender, EventArgs e)
        {

        }

        private void label72_Click(object sender, EventArgs e)
        {

        }

        private void LP92_3_Label_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerLP92_3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLP92_3.Format = DateTimePickerFormat.Custom;
            dateTimePickerLP92_3.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerLP92_3_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePickerLP92_3.Format = DateTimePickerFormat.Custom;
            dateTimePickerLP92_3.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void submitButton92_3_Click(object sender, EventArgs e)
        {

            string meterStart = LP92_1_startLabel.Text;
            string meterEnd = LP92_1_endLabel.Text;
            string salesLiters = LP92_1_salesLiterText.Text;
            string salesLKR = LP92_1_salesLKRText.Text;
            DateTime date = dateTimePickerLP92_1.Value;
            DateTime shift = shiftTimePickerLP92_1.Value;


            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO Sales (date, shift, meterStart, meterEnd, salesLiters, salesLKR) VALUES (@date, @shift, @meterStart, @meterEnd, @salesLiters, @salesLKR)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@meterStart", meterStart);
                    command.Parameters.AddWithValue("@meterEnd", meterEnd);
                    command.Parameters.AddWithValue("@salesLiters", salesLiters);
                    command.Parameters.AddWithValue("@salesLKR", salesLKR);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@shift", shift);



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

        private void submitButton92_2_Click(object sender, EventArgs e)
        {


            string meterStart = LP92_1_startLabel.Text;
            string meterEnd = LP92_1_endLabel.Text;
            string salesLiters = LP92_1_salesLiterText.Text;
            string salesLKR = LP92_1_salesLKRText.Text;
            DateTime date = dateTimePickerLP92_1.Value;
            DateTime shift = shiftTimePickerLP92_1.Value;


            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO Sales (date, shift, meterStart, meterEnd, salesLiters, salesLKR) VALUES (@date, @shift, @meterStart, @meterEnd, @salesLiters, @salesLKR)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@meterStart", meterStart);
                    command.Parameters.AddWithValue("@meterEnd", meterEnd);
                    command.Parameters.AddWithValue("@salesLiters", salesLiters);
                    command.Parameters.AddWithValue("@salesLKR", salesLKR);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@shift", shift);



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

        private void submitButton92_4_Click(object sender, EventArgs e)
        {


            string meterStart = LP92_1_startLabel.Text;
            string meterEnd = LP92_1_endLabel.Text;
            string salesLiters = LP92_1_salesLiterText.Text;
            string salesLKR = LP92_1_salesLKRText.Text;
            DateTime date = dateTimePickerLP92_1.Value;
            DateTime shift = shiftTimePickerLP92_1.Value;


            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO Sales (date, shift, meterStart, meterEnd, salesLiters, salesLKR) VALUES (@date, @shift, @meterStart, @meterEnd, @salesLiters, @salesLKR)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@meterStart", meterStart);
                    command.Parameters.AddWithValue("@meterEnd", meterEnd);
                    command.Parameters.AddWithValue("@salesLiters", salesLiters);
                    command.Parameters.AddWithValue("@salesLKR", salesLKR);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@shift", shift);



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

        private void submitButton92_5_Click(object sender, EventArgs e)
        {


            string meterStart = LP92_1_startLabel.Text;
            string meterEnd = LP92_1_endLabel.Text;
            string salesLiters = LP92_1_salesLiterText.Text;
            string salesLKR = LP92_1_salesLKRText.Text;
            DateTime date = dateTimePickerLP92_1.Value;
            DateTime shift = shiftTimePickerLP92_1.Value;


            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO Sales (date, shift, meterStart, meterEnd, salesLiters, salesLKR) VALUES (@date, @shift, @meterStart, @meterEnd, @salesLiters, @salesLKR)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@meterStart", meterStart);
                    command.Parameters.AddWithValue("@meterEnd", meterEnd);
                    command.Parameters.AddWithValue("@salesLiters", salesLiters);
                    command.Parameters.AddWithValue("@salesLKR", salesLKR);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@shift", shift);



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

        private void submitButton92_6_Click(object sender, EventArgs e)
        {


            string meterStart = LP92_1_startLabel.Text;
            string meterEnd = LP92_1_endLabel.Text;
            string salesLiters = LP92_1_salesLiterText.Text;
            string salesLKR = LP92_1_salesLKRText.Text;
            DateTime date = dateTimePickerLP92_1.Value;
            DateTime shift = shiftTimePickerLP92_1.Value;


            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO Sales (date, shift, meterStart, meterEnd, salesLiters, salesLKR) VALUES (@date, @shift, @meterStart, @meterEnd, @salesLiters, @salesLKR)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@meterStart", meterStart);
                    command.Parameters.AddWithValue("@meterEnd", meterEnd);
                    command.Parameters.AddWithValue("@salesLiters", salesLiters);
                    command.Parameters.AddWithValue("@salesLKR", salesLKR);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@shift", shift);



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

        private void submitButton95_1_Click(object sender, EventArgs e)
        {


            string meterStart = LP92_1_startLabel.Text;
            string meterEnd = LP92_1_endLabel.Text;
            string salesLiters = LP92_1_salesLiterText.Text;
            string salesLKR = LP92_1_salesLKRText.Text;
            DateTime date = dateTimePickerLP92_1.Value;
            DateTime shift = shiftTimePickerLP92_1.Value;
            string nozzel = LP_95_1_Label.Text;


            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO Sales (date, shift, meterStart, meterEnd, salesLiters, salesLKR, nozzel) VALUES (@date, @shift, @meterStart, @meterEnd, @salesLiters, @salesLKR, @nozzel)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@meterStart", meterStart);
                    command.Parameters.AddWithValue("@meterEnd", meterEnd);
                    command.Parameters.AddWithValue("@salesLiters", salesLiters);
                    command.Parameters.AddWithValue("@salesLKR", salesLKR);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@shift", shift);
                    command.Parameters.AddWithValue("@nozzel", nozzel);



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

        private void submitButtonLSD_1_Click(object sender, EventArgs e)
        {


            string meterStart = LP92_1_startLabel.Text;
            string meterEnd = LP92_1_endLabel.Text;
            string salesLiters = LP92_1_salesLiterText.Text;
            string salesLKR = LP92_1_salesLKRText.Text;
            DateTime date = dateTimePickerLP92_1.Value;
            DateTime shift = shiftTimePickerLP92_1.Value;


            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO Sales (date, shift, meterStart, meterEnd, salesLiters, salesLKR) VALUES (@date, @shift, @meterStart, @meterEnd, @salesLiters, @salesLKR)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@meterStart", meterStart);
                    command.Parameters.AddWithValue("@meterEnd", meterEnd);
                    command.Parameters.AddWithValue("@salesLiters", salesLiters);
                    command.Parameters.AddWithValue("@salesLKR", salesLKR);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@shift", shift);



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

        private void submitButtonLAD_1_Click(object sender, EventArgs e)
        {


            string meterStart = LP92_1_startLabel.Text;
            string meterEnd = LP92_1_endLabel.Text;
            string salesLiters = LP92_1_salesLiterText.Text;
            string salesLKR = LP92_1_salesLKRText.Text;
            DateTime date = dateTimePickerLP92_1.Value;
            DateTime shift = shiftTimePickerLP92_1.Value;


            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO Sales (date, shift, meterStart, meterEnd, salesLiters, salesLKR) VALUES (@date, @shift, @meterStart, @meterEnd, @salesLiters, @salesLKR)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@meterStart", meterStart);
                    command.Parameters.AddWithValue("@meterEnd", meterEnd);
                    command.Parameters.AddWithValue("@salesLiters", salesLiters);
                    command.Parameters.AddWithValue("@salesLKR", salesLKR);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@shift", shift);



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

        private void submitButtonLAD_3_Click(object sender, EventArgs e)
        {


            string meterStart = LP92_1_startLabel.Text;
            string meterEnd = LP92_1_endLabel.Text;
            string salesLiters = LP92_1_salesLiterText.Text;
            string salesLKR = LP92_1_salesLKRText.Text;
            DateTime date = dateTimePickerLP92_1.Value;
            DateTime shift = shiftTimePickerLP92_1.Value;


            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO Sales (date, shift, meterStart, meterEnd, salesLiters, salesLKR) VALUES (@date, @shift, @meterStart, @meterEnd, @salesLiters, @salesLKR)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@meterStart", meterStart);
                    command.Parameters.AddWithValue("@meterEnd", meterEnd);
                    command.Parameters.AddWithValue("@salesLiters", salesLiters);
                    command.Parameters.AddWithValue("@salesLKR", salesLKR);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@shift", shift);



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

        private void submitButtonLAD_5_Click(object sender, EventArgs e)
        {


            string meterStart = LP92_1_startLabel.Text;
            string meterEnd = LP92_1_endLabel.Text;
            string salesLiters = LP92_1_salesLiterText.Text;
            string salesLKR = LP92_1_salesLKRText.Text;
            DateTime date = dateTimePickerLP92_1.Value;
            DateTime shift = shiftTimePickerLP92_1.Value;


            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO Sales (date, shift, meterStart, meterEnd, salesLiters, salesLKR) VALUES (@date, @shift, @meterStart, @meterEnd, @salesLiters, @salesLKR)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@meterStart", meterStart);
                    command.Parameters.AddWithValue("@meterEnd", meterEnd);
                    command.Parameters.AddWithValue("@salesLiters", salesLiters);
                    command.Parameters.AddWithValue("@salesLKR", salesLKR);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@shift", shift);



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

        private void submitButtonLAD_7_Click(object sender, EventArgs e)
        {


            string meterStart = LP92_1_startLabel.Text;
            string meterEnd = LP92_1_endLabel.Text;
            string salesLiters = LP92_1_salesLiterText.Text;
            string salesLKR = LP92_1_salesLKRText.Text;
            DateTime date = dateTimePickerLP92_1.Value;
            DateTime shift = shiftTimePickerLP92_1.Value;


            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO Sales (date, shift, meterStart, meterEnd, salesLiters, salesLKR) VALUES (@date, @shift, @meterStart, @meterEnd, @salesLiters, @salesLKR)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@meterStart", meterStart);
                    command.Parameters.AddWithValue("@meterEnd", meterEnd);
                    command.Parameters.AddWithValue("@salesLiters", salesLiters);
                    command.Parameters.AddWithValue("@salesLKR", salesLKR);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@shift", shift);



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

        private void submitButtonLAD_4_Click(object sender, EventArgs e)
        {


            string meterStart = LP92_1_startLabel.Text;
            string meterEnd = LP92_1_endLabel.Text;
            string salesLiters = LP92_1_salesLiterText.Text;
            string salesLKR = LP92_1_salesLKRText.Text;
            DateTime date = dateTimePickerLP92_1.Value;
            DateTime shift = shiftTimePickerLP92_1.Value;


            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO Sales (date, shift, meterStart, meterEnd, salesLiters, salesLKR) VALUES (@date, @shift, @meterStart, @meterEnd, @salesLiters, @salesLKR)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@meterStart", meterStart);
                    command.Parameters.AddWithValue("@meterEnd", meterEnd);
                    command.Parameters.AddWithValue("@salesLiters", salesLiters);
                    command.Parameters.AddWithValue("@salesLKR", salesLKR);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@shift", shift);



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

        private void submitButtonLAD_6_Click(object sender, EventArgs e)
        {


            string meterStart = LP92_1_startLabel.Text;
            string meterEnd = LP92_1_endLabel.Text;
            string salesLiters = LP92_1_salesLiterText.Text;
            string salesLKR = LP92_1_salesLKRText.Text;
            DateTime date = dateTimePickerLP92_1.Value;
            DateTime shift = shiftTimePickerLP92_1.Value;


            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO Sales (date, shift, meterStart, meterEnd, salesLiters, salesLKR) VALUES (@date, @shift, @meterStart, @meterEnd, @salesLiters, @salesLKR)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@meterStart", meterStart);
                    command.Parameters.AddWithValue("@meterEnd", meterEnd);
                    command.Parameters.AddWithValue("@salesLiters", salesLiters);
                    command.Parameters.AddWithValue("@salesLKR", salesLKR);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@shift", shift);



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

        private void submitButtonLAD_8_Click(object sender, EventArgs e)
        {


            string meterStart = LP92_1_startLabel.Text;
            string meterEnd = LP92_1_endLabel.Text;
            string salesLiters = LP92_1_salesLiterText.Text;
            string salesLKR = LP92_1_salesLKRText.Text;
            DateTime date = dateTimePickerLP92_1.Value;
            DateTime shift = shiftTimePickerLP92_1.Value;


            using (SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\NSBM - Academic\Year 01 Semester 03\C#\C# Final Project\Final Software\Software-for-Filling-Station\Database1.mdf'; Integrated Security = True"))
            {
                try
                {
                    sql.Open();

                    string query = $"INSERT INTO Sales (date, shift, meterStart, meterEnd, salesLiters, salesLKR) VALUES (@date, @shift, @meterStart, @meterEnd, @salesLiters, @salesLKR)";
                    SqlCommand command = new SqlCommand(query, sql);

                    command.Parameters.AddWithValue("@meterStart", meterStart);
                    command.Parameters.AddWithValue("@meterEnd", meterEnd);
                    command.Parameters.AddWithValue("@salesLiters", salesLiters);
                    command.Parameters.AddWithValue("@salesLKR", salesLKR);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@shift", shift);



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
    }
}
