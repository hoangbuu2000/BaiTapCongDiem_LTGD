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
    public partial class ComboListBox : Form
    {
        public ComboListBox()
        {
            InitializeComponent();
        }

        private void ComboListBox_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            listBox1.Sorted = true;
            listBox2.Sorted = true;
            comboBox1.Items.AddRange(new string[] { "red", "green", "blue" });
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection ds = listBox1.SelectedIndices;
            for(int i = ds.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Add(listBox1.Items[ds[i]]);
                listBox1.Items.RemoveAt(ds[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection ds = listBox2.SelectedIndices;
            for (int i = ds.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Add(listBox2.Items[ds[i]]);
                listBox2.Items.RemoveAt(ds[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if(listBox1.SelectedItem != null)
            {
                ListBox.SelectedIndexCollection ds = listBox1.SelectedIndices;
                for (int i = ds.Count - 1; i >= 0; i--)
                {
                    listBox1.Items.RemoveAt(ds[i]);
                }
            }
            if (listBox2.SelectedItem != null)
            {
                ListBox.SelectedIndexCollection ds = listBox2.SelectedIndices;
                for (int i = ds.Count - 1; i >= 0; i--)
                {
                    listBox2.Items.RemoveAt(ds[i]);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null)
            {
                switch (comboBox1.Text)
                {
                    case "red":
                        BackColor = Color.Red;
                        break;
                    case "blue":
                        BackColor = Color.Blue;
                        break;
                    case "green":
                        BackColor = Color.Green;
                        break;
                }
            }   
        }
    }
}
