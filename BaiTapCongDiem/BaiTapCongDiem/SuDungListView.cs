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
    public partial class SuDungListView : Form
    {
        public SuDungListView()
        {
            InitializeComponent();
        }

        private void SuDungListView_Load(object sender, EventArgs e)
        {
            ColumnHeader hdMSSV = new ColumnHeader();
            hdMSSV.Text = "Mã số sinh viên";
            ColumnHeader hdHT = new ColumnHeader();
            hdHT.Text = "Họ tên sinh viên";
            listView1.Columns.Add(hdMSSV);
            listView1.Columns.Add(hdHT);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = textBox1.Text;
            ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();
            subitem.Text = textBox2.Text;
            item.SubItems.Add(subitem);
            listView1.Items.Add(item);
        }

        private void SuDungListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection ds = listView1.SelectedIndices;
            if (ds.Count > 0)
                button2.Enabled = true;
            else
                button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection ds = listView1.SelectedIndices;
            //Xoa
            foreach(int i in ds)
            {
                listView1.Items.RemoveAt(i);
                ListViewItem item = new ListViewItem();
                item.Text = textBox1.Text;

                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();
                subitem.Text = textBox2.Text;
                item.SubItems.Add(subitem);

                listView1.Items.Insert(i, item);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
