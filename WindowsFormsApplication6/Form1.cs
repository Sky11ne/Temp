using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        static double a, rez;
        static string b;

        private void F1_CheckedChanged(object sender, EventArgs e)
        {
            if (F1.Checked == true)
            {
                C1.Enabled = false;
                K1.Enabled = false;
            }
            else
            {
                C1.Enabled = true;
                K1.Enabled = true;
            }
        }
        private void K1_CheckedChanged(object sender, EventArgs e)
        {
            if (K1.Checked == true)
            {
                C1.Enabled = false;
                F1.Enabled = false;
            }
            else
            {
                F1.Enabled = true;
                C1.Enabled = true;
            }
        }
        private void C1_CheckedChanged(object sender, EventArgs e)
        {
            if (C1.Checked == true)
            {
                F1.Enabled = false;
                K1.Enabled = false;
            }
            else
            {
                F1.Enabled = true;
                K1.Enabled = true;
            }
        }
        private void F_CheckedChanged(object sender, EventArgs e)
        {
            if (F.Checked == true)
            {
                C.Enabled = false;
                K.Enabled = false;
            }
            else
            {
                C.Enabled = true;
                K.Enabled = true;
            }
        }
        private void K_CheckedChanged(object sender, EventArgs e)
        {
            if (K.Checked == true)
            {
                F.Enabled = false;
                C.Enabled = false;
            }
            else
            {
                F.Enabled = true;
                C.Enabled = true;
            }
        }
        private void C_CheckedChanged(object sender, EventArgs e)
        {
            if (C.Checked == true)
            {
                F.Enabled = false;
                K.Enabled = false;
            }
            else
            {
                F.Enabled = true;
                K.Enabled = true;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            b = (textBox1.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(b);

            }
            catch
            {
                MessageBox.Show("Некорректный ввод данных");
            }
            finally
            {
                if ((C.Checked == true))
                {

                    if (C1.Checked == true)
                    {
                        rez = a;
                    }
                    if (K1.Checked == true)
                    {
                        rez = a + 273.15;
                    }
                    if (F1.Checked == true)
                    {
                        rez = a + ((9 / 5) + 32);
                    }
                }

                if (a < -273.15)
                {
                    MessageBox.Show("Некорректный ввод данных");
                    rez = 0;
                }

            }
            if ((K.Checked == true))
            {

                if (C1.Checked == true)
                {
                    rez = a - 273.15;
                }
                if (K1.Checked == true)
                {
                    rez = a;
                }
                if (F1.Checked == true)
                {
                    rez = a - 273.15 + ((9 / 5) + 32);
                }

                if (a < 0)
                {
                    MessageBox.Show("Некорректный ввод данных");
                    rez = 0;
                }
            }
            if ((F.Checked == true))
            {

                if (C1.Checked == true)
                {
                    rez = a - ((9 / 5) + 32);
                }
                if (K1.Checked == true)
                {
                    rez = a + 273.15 - ((9 / 5) + 32);
                }
                if (F1.Checked == true)
                {
                    rez = a;
                }

                if (a < -459.67)
                {
                    MessageBox.Show("Некорректный ввод данных");
                    rez = 0;
                }
            }
            Result.Text = Convert.ToString(rez);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}