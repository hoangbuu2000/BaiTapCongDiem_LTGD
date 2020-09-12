using System;
using System.Collections;
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
    public partial class ColorEdit : Form
    {
        public ColorEdit()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //HScrollBar hs = (HScrollBar)sender;
            List<int> mau = new List<int>();
            foreach (Control ctr in this.Controls)
            {
                if(ctr.Name.Contains("hScrollBar"))
                {
                    HScrollBar hs = (HScrollBar)ctr;
                    mau.Add(hs.Value);

                    switch (hs.Name)
                    {
                        case "hScrollBar1":
                            textBox1.Text = hs.Value.ToString();
                            break;
                        case "hScrollBar2":
                            textBox2.Text = hs.Value.ToString();
                            break;
                        case "hScrollBar3":
                            textBox3.Text = hs.Value.ToString();
                            break;
                    }

                    button1.Focus();
                }
            }
            panel1.BackColor = Color.FromArgb(mau[2], mau[1], mau[0]);
        }

        private void ColorEdit_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Black;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //TextBox txt = (TextBox)sender;

            List<string> mau = new List<string>();
            foreach(Control ctr in this.Controls)
            {
                if(ctr.Name.Contains("textBox"))
                {
                    TextBox txt = (TextBox)ctr;
                    if (txt.Text == "")
                        txt.Text = "0";
                    mau.Add(txt.Text);
                    switch (txt.Name)
                    {
                        case "textBox1":
                            hScrollBar1.Value = int.Parse(txt.Text);
                            break;
                        case "textBox2":
                            hScrollBar2.Value = int.Parse(txt.Text);
                            break;
                        case "textBox3":
                            hScrollBar3.Value = int.Parse(txt.Text);
                            break;
                    }
                }
            }
            panel1.BackColor = Color.FromArgb(int.Parse(mau[2]), int.Parse(mau[1]), int.Parse(mau[0]));
        }
    }
}
