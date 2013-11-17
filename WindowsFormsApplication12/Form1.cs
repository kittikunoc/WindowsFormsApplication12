using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d, f;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = 30 - a ;
            d = 10 - b;
            f = c + d;
            label3.Text = c.ToString();
            label4.Text = d.ToString();
            tol1.Text = f.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a12, b12, c12, d12, f12;
            a12 = double.Parse(textBox3.Text);
            b12 = double.Parse(textBox4.Text);
            c12 = 18 - a12;
            d12 = 15 - b12;
            f12 = c12+d12;
            manma12.Text = c12.ToString();
            yingma12.Text = d12.ToString();
            tol12.Text = f12.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a13, b13, c13, d13, f13;
            a13 = double.Parse(textBox5.Text);
            b13 = double.Parse(textBox6.Text);
            c13 = 15 - a13;
            d13 = 20 - b13;
            f13 = c13 + d13;
            manma13.Text = c13.ToString();
            yingma13.Text = d13.ToString();
            tol13.Text = f13.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a14, b14, c14, d14, f14;
            a14 = double.Parse(textBox7.Text);
            b14 = double.Parse(textBox8.Text);
            c14 = 15 - a14;
            d14 = 18 - b14;
            f14 = c14 + d14;
            manma14.Text = c14.ToString();
            yingma14.Text = d14.ToString();
            tol14.Text = f14.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a15, b15, c15, d15, f15;
            a15 = double.Parse(textBox9.Text);
            b15 = double.Parse(textBox10.Text);
            c15 = 13 - a15;
            d15 = 20 - b15;
            f15 = c15 + d15;
            manma15.Text = c15.ToString();
            yingma15.Text = d15.ToString();
            tol15.Text = f15.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a16, b16, c16, d16, f16;
            a16 = double.Parse(textBox11.Text);
            b16 = double.Parse(textBox12.Text);
            c16 = 15 - a16;
            d16 = 20 - b16;
            f16 = c16+ d16;
            manma16.Text = c16.ToString();
            yingma16.Text = d16.ToString();
            tol16.Text = f16.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double a17, b17, c17, d17, f17;
            a17 = double.Parse(textBox13.Text);
            b17 = double.Parse(textBox14.Text);
            c17 = 20 - a17;
            d17 = 17 - b17;
            f17 = c17 + d17;
            manma17.Text = c17.ToString();
            yingma17.Text = d17.ToString();
            tol17.Text = f17.ToString();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double a, b, a12, b12, a13, b13, a14, b14, a15, b15, a16, b16, a17, b17, cAll1, cAll2,h, i, h12, i12, h13, i13, h14, cAll3,j,k,l,m,n,o,p;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            a12 = double.Parse(textBox3.Text);
            b12 = double.Parse(textBox4.Text);
            a13 = double.Parse(textBox5.Text);
            b13 = double.Parse(textBox6.Text);
            a14 = double.Parse(textBox7.Text);
            b14 = double.Parse(textBox8.Text);
            a15 = double.Parse(textBox9.Text);
            b15 = double.Parse(textBox10.Text);
            a16 = double.Parse(textBox11.Text);
            b16 = double.Parse(textBox12.Text);
            a17 = double.Parse(textBox13.Text);
            b17 = double.Parse(textBox14.Text);
            cAll1 = a + a12 + a13 + a14 + a15 + a16 + a17;
            cAll2 = b + b12 + b13 + b14 + b15 + b16 + b17;
            tolAll.Text = cAll1.ToString();
            tolAll2.Text = cAll2.ToString();

                h = double.Parse(tol1.Text);
                i = double.Parse(tol12.Text);
                h12 = double.Parse(tol13.Text);
                i12 = double.Parse(tol14.Text);
                h13 = double.Parse(tol15.Text);
                i13 = double.Parse(tol16.Text);
                h14 = double.Parse(tol17.Text);
                cAll3 = h+ i+ h12 +i12+ h13+ i13+ h14 ;
                tolAll3.Text = cAll3.ToString();
                
            j = double.Parse(tolAll.Text);
            k = double.Parse(tolAll2.Text);
            l = 126 - j;
            m = 120 - k;
            manma.Text = l.ToString();
            yingma.Text = m.ToString();

            n = double.Parse(tolAll.Text);
            o = double.Parse(tolAll2.Text);
            p = n + o;
            tolma.Text = p.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "http://www.npru.ac.th");
            //system.diagnostics.process.start("http://www.npru.ac.th");
            linkLabel1.LinkVisited = true;
        }
    }
}

