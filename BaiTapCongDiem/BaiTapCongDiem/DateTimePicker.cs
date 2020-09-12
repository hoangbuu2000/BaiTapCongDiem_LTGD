using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapCongDiem
{
    public partial class DateTimePicker : Form
    {
        public DateTimePicker()
        {
            InitializeComponent();
        }

        private void DateTimePicker_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dddd, MMMM dd, yyyy";
            textBox1.Text = dateTimePicker1.Value.Day.ToString();
            textBox2.Text = dateTimePicker1.Value.Month.ToString();
            textBox3.Text = dateTimePicker1.Value.Year.ToString();
            textBox4.Text = String.Format("{0:00}/{1:00}/{2}", 
                dateTimePicker1.Value.Day, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            int y = int.Parse(textBox3.Text);

            textBox4.Text = String.Format("{0:00}/{1:00}/{2}", d, m, y);
            DateTime dt = new DateTime(y, m, d);
            dateTimePicker1.Value = dt;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.Day.ToString();
            textBox2.Text = dateTimePicker1.Value.Month.ToString();
            textBox3.Text = dateTimePicker1.Value.Year.ToString();
            textBox4.Text = String.Format("{0:00}/{1:00}/{2}",
                dateTimePicker1.Value.Day, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
