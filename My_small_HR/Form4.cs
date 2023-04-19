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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            shc = new Dictionary<string, string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string GetString(int breakpoint, int breakpointa)
        {
            string a = label19.Text.Substring(breakpoint, breakpointa);
            return a;
        }
        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                x=listBox1.SelectedItem.ToString();
                int b = 0;
                label19.Text = shc[x];
                for (int i = 0; i < 10; i++)
                {

                    b = label19.Text.IndexOf("?");
                    if (i == 0)
                    {
                        label11.Text = GetString(0, b);
                        label19.Text = label19.Text.Remove(0, b + 1);
                    }
                    else if (i == 1)
                    {
                        label12.Text = GetString(0, b);
                        label19.Text = label19.Text.Remove(0, b + 1);
                    }
                    else if (i == 2)
                    {
                        label13.Text = GetString(0, b);
                        label19.Text = label19.Text.Remove(0, b + 1);
                    }
                    else if (i == 3)
                    {
                        label14.Text = GetString(0, b);
                        label19.Text = label19.Text.Remove(0, b + 1);
                    }
                    else if (i == 4)
                    {
                        label15.Text = GetString(0, b);
                        label19.Text = label19.Text.Remove(0, b + 1);
                    }
                    else if (i == 5)
                    {
                        label16.Text = GetString(0, b);
                        label19.Text = label19.Text.Remove(0, b + 1);
                    }
                    else if (i == 6)
                    {
                        label17.Text = GetString(0, b);
                        label19.Text = label19.Text.Remove(0, b + 1);
                    }
                    else if (i == 7)
                    {
                        label18.Text = GetString(0, b);
                        label19.Text = label19.Text.Remove(0, b + 1);
                    }
                    else if (i == 8)
                    {
                        label21.Text = GetString(0, b);
                        label19.Text = label19.Text.Remove(0, b + 1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Dictionary<string, string> shc;
        static string x;
        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("HiredCandidates.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    label19.Text = sr.ReadLine();
                    int a = label19.Text.IndexOf("?");
                    string b = GetString(0, a);
                    string y = label19.Text.Remove(0, a + 1);
                    shc.Add(b, y);
                    listBox1.Items.Add(b);
                    label19.Text = "";
                }
                sr.Close();
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
