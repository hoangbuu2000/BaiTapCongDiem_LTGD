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
    public partial class TuDien : Form
    {
        public TuDien()
        {
            InitializeComponent();
        }

        Dictionary<string, string> words;
        Dictionary<string, string> tuVung;
        private void TuDien_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "ANH - VIỆT";
            tabPage2.Text = "VIỆT - ANH";
            tabControl1.Font = new Font("Arial", 12, FontStyle.Regular);

            //ArrayList qs = new ArrayList();
            //string[] mang =
            //{
            //    "student", "teacher", "sad", "happy", "dog", "cat", 
            //    "bird", "fish", "mother", "father", "uncle", "umbrella",
            //    "boyfriend", "girlfriend", "interface", "language", "program",
            //    "love", "hate", "swimming"
            //};
            //qs.AddRange(mang);

            words = new Dictionary<string, string>();
            words.Add("student", "học sinh, sinh viên");
            words.Add("teacher", "giáo viên");
            words.Add("sad", "buồn");
            words.Add("happy", "vui vẻ, hạnh phúc");
            words.Add("dog", "con chó");
            words.Add("cat", "con mèo");
            words.Add("bird", "con chim non trên cành cây");
            words.Add("fish", "con cá");
            words.Add("mother", "mẹ hiền");
            words.Add("father", "ba nghiêm khắc");
            words.Add("uncle", "chú bủn xỉn");
            words.Add("umbrella", "chiếc ô hay còn gọi là cây dù");
            words.Add("boyfriend", "gấu");
            words.Add("girlfriend", "gấu cái");
            words.Add("interface", "giao diện");
            words.Add("program", "chương trình");
            words.Add("love", "thương");
            words.Add("hate", "ghét");
            words.Add("swimming", "bơi lội");
            words.Add("language", "ngôn ngữ");


            comboBox1.Items.AddRange(words.Keys.ToArray());
            comboBox1.AutoCompleteMode = AutoCompleteMode.Append;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void comboBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (e.KeyCode == Keys.Enter)
            {
                if (cmb.Name == "comboBox1")
                {
                    foreach (KeyValuePair<string, string> item in words)
                    {
                        if (item.Key == cmb.Text)
                        {
                            textBox1.Clear();
                            textBox1.Text = item.Value;
                            break;
                        }
                    } 
                }
                else if(cmb.Name == "comboBox2")
                {
                    foreach (KeyValuePair<string, string> item in tuVung)
                    {
                        if (item.Key == cmb.Text)
                        {
                            textBox2.Clear();
                            textBox2.Text = item.Value;
                            break;
                        }
                    }
                }    
            }
        }

        ArrayList duration = new ArrayList();
        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            //Tính thời gian giữa 2 lần click chuột
            if (e.Button == MouseButtons.Left)
            {
                DateTime dt = DateTime.Now;
                if (duration.Count < 2)
                    duration.Add(dt.Second);
                else
                {
                    duration.Clear();
                    duration.Add(dt.Second);
                } 
            }

            /*Cách này vẫn còn một lỗi là khi arraylist duration đã có 1 phần tử
              thì double click không có tác dụng*/

            if ((int.Parse(duration[1].ToString()) 
                    - int.Parse(duration[0].ToString())) <= 1)
            {
                int idx = cmb.SelectedIndex;

                if (cmb.Name == "comboBox1")
                {
                    textBox1.Clear();
                    foreach (KeyValuePair<string, string> item in words)
                    {
                        if (item.Key == comboBox1.Items[idx].ToString())
                            textBox1.Text = item.Value;
                    }  
                }
                else if(cmb.Name == "comboBox2")
                {
                    textBox2.Clear();
                    foreach (KeyValuePair<string, string> item in tuVung)
                    {
                        if (item.Key == comboBox2.Items[idx].ToString())
                            textBox2.Text = item.Value;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage tab = tabControl1.SelectedTab;
            if(tab.Name == "tabPage1")
            {
                comboBox2.Items.Clear();
                words = new Dictionary<string, string>();
                words.Add("student", "học sinh, sinh viên");
                words.Add("teacher", "giáo viên");
                words.Add("sad", "buồn");
                words.Add("happy", "vui vẻ, hạnh phúc");
                words.Add("dog", "con chó");
                words.Add("cat", "con mèo");
                words.Add("bird", "con chim non trên cành cây");
                words.Add("fish", "con cá");
                words.Add("mother", "mẹ hiền");
                words.Add("father", "ba nghiêm khắc");
                words.Add("uncle", "chú bủn xỉn");
                words.Add("umbrella", "chiếc ô hay còn gọi là cây dù");
                words.Add("boyfriend", "gấu");
                words.Add("girlfriend", "gấu cái");
                words.Add("interface", "giao diện");
                words.Add("program", "chương trình");
                words.Add("love", "thương");
                words.Add("hate", "ghét");
                words.Add("swimming", "bơi lội");
                words.Add("language", "ngôn ngữ");


                comboBox1.Items.AddRange(words.Keys.ToArray());
                comboBox1.AutoCompleteMode = AutoCompleteMode.Append;
                comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            else if(tab.Name == "tabPage2")
            {
                comboBox1.Items.Clear();
                tuVung = new Dictionary<string, string>();
                tuVung.Add("cô giáo em","teacher");
                tuVung.Add("cười xinh xinh", "smile");
                tuVung.Add("đôi mắt", "eyes");
                tuVung.Add("mẹ", "mother, mum, mamma, mammy");
                tuVung.Add("mệt mỏi", "tired, weary, exhausted");
                tuVung.Add("người lạ ơi", "stranger");
                tuVung.Add("chàng trai đô thị", "big city boy");
                tuVung.Add("túp lều lý tưởng", "hut");
                tuVung.Add("giao diện", "interface, display");
                tuVung.Add("lập trình", "program");
                tuVung.Add("con mèo", "cat, puss");
                tuVung.Add("tâm hồn", "soul");
                tuVung.Add("đẹp trai", "handsome, goodly");
                tuVung.Add("lướt sóng", "surf");
                tuVung.Add("con chim non", "bird");
                tuVung.Add("trên cành cây", "tree");
                tuVung.Add("hót líu lo", "sing");
                tuVung.Add("ngủ gật", "doze");
                tuVung.Add("nước tẩy trang", "make-up remover");

                comboBox2.Items.AddRange(tuVung.Keys.ToArray());
                comboBox2.AutoCompleteMode = AutoCompleteMode.Append;
                comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }
    }
}
