using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace My_small_HR
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            nc = new Dictionary<string, string>();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Dictionary<string, string> nc;
        static string x;
        private void f3sel_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Enabled = true;
                FileStream fs =
                    new FileStream("Candidates.txt", FileMode.Open, FileAccess.Read);

                StreamReader sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    label22.Text=sr.ReadLine();
                    int a = label22.Text.IndexOf("?");
                     string b=GetString(0,a);
                    string y = label22.Text.Remove(0, a + 1);
                    nc.Add(b, y);
                    listBox1.Items.Add(b);
                    label22.Text = "";
                }
                sr.Close();
                fs.Close();
                f3hc.Enabled = true;
                f3rc.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refresh.Enabled = false;
        }
        public string GetString(int breakpoint, int breakpointa)
        {
            string a = label22.Text.Substring(breakpoint, breakpointa);
            return a;
        }
        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                x=listBox1.SelectedItem.ToString();
                int b = 0;
                label22.Text = nc[x];
                for (int i = 0; i < 10; i++)
                {

                    b = label22.Text.IndexOf("?");
                    if (i == 0)
                    {
                        label11.Text = GetString(0, b);
                        label22.Text = label22.Text.Remove(0, b + 1);
                    }
                    else if (i == 1)
                    {
                        label12.Text = GetString(0, b);
                        label22.Text = label22.Text.Remove(0, b + 1);
                    }
                    else if (i == 2)
                    {
                        label13.Text = GetString(0, b);
                        label22.Text = label22.Text.Remove(0, b + 1);
                    }
                    else if (i == 3)
                    {
                        label14.Text = GetString(0, b);
                        label22.Text = label22.Text.Remove(0, b + 1);
                    }
                    else if (i == 4)
                    {
                        label15.Text = GetString(0, b);
                        label22.Text = label22.Text.Remove(0, b + 1);
                    }
                    else if (i == 5)
                    {
                        label16.Text = GetString(0, b);
                        label22.Text = label22.Text.Remove(0, b + 1);
                    }
                    else if (i == 6)
                    {
                        label17.Text = GetString(0, b);
                        label22.Text = label22.Text.Remove(0, b + 1);
                    }
                    else if (i == 7)
                    {
                        label18.Text = GetString(0, b);
                        label22.Text = label22.Text.Remove(0, b + 1);
                    }
                    else if (i == 8)
                    {
                        label21.Text = GetString(0, b);
                        label22.Text = label22.Text.Remove(0, b + 1);
                    }
                    else if (i == 9)
                    {
                        richTextBox1.Text = GetString(0, b);
                        label22.Text = label22.Text.Remove(0, b + 1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void f3hc_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs1 =
                    new FileStream("HiredCandidates.txt", FileMode.Append, FileAccess.Write);

                StreamWriter sw1 = new StreamWriter(fs1);
                sw1.WriteLine(label13.Text+"-"+label11.Text+" "+label12.Text+"?"+nc[x]);
                sw1.Close();
                fs1.Close();
                listBox1.Items.Remove(listBox1.SelectedItem);
                FileStream fs =
                    new FileStream("Candidates.txt", FileMode.Create, FileAccess.Write);

                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (string item in listBox1.Items)
                    {
                        sw.WriteLine(item+"?"+nc[item]);
                    }
                }
                fs.Close();
                label11.Text = label12.Text = label13.Text = label14.Text = label15.Text = label16.Text = label17.Text = label18.Text = label21.Text = richTextBox1.Text = "";
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void f3rc_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            FileStream fs =
                new FileStream("Candidates.txt", FileMode.Create, FileAccess.Write);

            using (StreamWriter sw = new StreamWriter(fs))
            {
                foreach (string item in listBox1.Items)
                {
                    sw.WriteLine(item + "?" + nc[item]);
                }
            }
            fs.Close();
            label11.Text = label12.Text = label13.Text = label14.Text = label15.Text = label16.Text = label17.Text = label18.Text = label21.Text = richTextBox1.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
