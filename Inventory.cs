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
    public partial class Inventory: Form
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
    }
}
