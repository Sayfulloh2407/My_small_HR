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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void f2exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void f2addcan_Click(object sender, EventArgs e)
        {
            try
            {
                AddCandidade p = new AddCandidade();
                p.name = f2name.Text;
                p.lastname = f2lastname.Text;
                p.id =Convert.ToInt32( f2id.Text);
                p.dateofbirth = f2date.Text;
                p.gender = f2gender.SelectedItem.ToString();
                p.email =f2email.Text;
                p.phonenumber =f2phonenumber.Text;
                p.expectedsalary =Convert.ToInt32(f2expectedsalary.Text);
                p.cv = f2cv.Text;
                if(checkBox2.Checked)
                {
                    p.typeofemployment ="FullTime" ;
                }
                else { p.typeofemployment = "HalfTime"; }

                FileStream fs = new FileStream("Candidates.txt", FileMode.Append, FileAccess.Write);

                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(p.Combine());

                sw.Close();
                fs.Close();
                f2name.Text = f2lastname.Text = f2id.Text = f2cv.Text=f2expectedsalary.Text= f2date.Text = f2email.Text = f2phonenumber.Text = "";
                f2gender.SelectedIndex = -1;
                if (checkBox1.Checked || checkBox2.Checked)
                {
                    checkBox2.Checked=checkBox1.Checked = false;
                }
                MessageBox.Show("A candidate named " + p.name+" "+p.lastname + " has been Added\n to the List of products!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                f2id.Enabled = false;
                f2id.Text = Randomid.RandomNumber(5);
            }
            else
            {
                f2id.Enabled = true;
                f2id.Text = "";
            }
        }
    }
}
