using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_Test_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Finder finder = new Finder();

        private void button1_Click(object sender, EventArgs e)
        {
            finder.pressbtn_CALC("1");
            finder.pressbtn_CALC("2");
            finder.pressbtn_CALC("3");
            finder.pressbtn_CALC("4");
            finder.pressbtn_CALC("5");
            finder.pressbtn_CALC("6");
            finder.pressbtn_CALC("7");
            finder.pressbtn_CALC("8");
            finder.pressbtn_CALC("9");
            finder.pressbtn_CALC("0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            finder.pressbtn_CALC(textBox1.Text.ToString().Trim());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            finder.pressbtn_CALC("C");
            finder.pressbtn_CALC("+");
            finder.pressbtn_CALC("-");
            finder.pressbtn_CALC("*");
            finder.pressbtn_CALC("/");
            finder.pressbtn_CALC(".");
            finder.pressbtn_CALC("=");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            finder.pressbtn_CALC("EXIT");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                finder.pressbtn_CALC(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                finder.pressbtn_CALC("1");
                finder.pressbtn_CALC(i.ToString());
            }
                for (int i = 0; i < 10; i++)
            {
                finder.pressbtn_CALC("2");
                finder.pressbtn_CALC(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                finder.pressbtn_CALC("3");
                finder.pressbtn_CALC(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                finder.pressbtn_CALC("4");
                finder.pressbtn_CALC(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                finder.pressbtn_CALC("5");
                finder.pressbtn_CALC(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                finder.pressbtn_CALC("6");
                finder.pressbtn_CALC(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                finder.pressbtn_CALC("7");
                finder.pressbtn_CALC(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                finder.pressbtn_CALC("8");
                finder.pressbtn_CALC(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                finder.pressbtn_CALC("9");
                finder.pressbtn_CALC(i.ToString());
            }

            finder.pressbtn_CALC("100");
            finder.pressbtn_CALC("+");
            finder.pressbtn_CALC("1");
            finder.pressbtn_CALC("=");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                finder.pressbtn_CALC(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                finder.pressbtn_CALC("1");
                finder.pressbtn_CALC(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                finder.pressbtn_CALC("2");
                finder.pressbtn_CALC(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                finder.pressbtn_CALC("3");
                finder.pressbtn_CALC(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                finder.pressbtn_CALC("4");
                finder.pressbtn_CALC(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                finder.pressbtn_CALC("5");
                finder.pressbtn_CALC(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                finder.pressbtn_CALC("6");
                finder.pressbtn_CALC(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                finder.pressbtn_CALC("7");
                finder.pressbtn_CALC(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                finder.pressbtn_CALC("8");
                finder.pressbtn_CALC(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                finder.pressbtn_CALC("9");
                finder.pressbtn_CALC(i.ToString());
            }

            finder.pressbtn_CALC("100");
            finder.pressbtn_CALC("-");
            finder.pressbtn_CALC("1");
            finder.pressbtn_CALC("=");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                finder.pressbtn_CALC(i.ToString());
            }
            for (int i = 0; i < 3; i++)
            {
                finder.pressbtn_CALC("1");
                finder.pressbtn_CALC(i.ToString());
            }
            finder.pressbtn_CALC("1");
            finder.pressbtn_CALC("+");
            finder.pressbtn_CALC("1");
            finder.pressbtn_CALC("=");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            finder.pressbtn_CALC("C");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            finder.pressbtn_CALC("1");
            finder.pressbtn_CALC("+");
            finder.pressbtn_CALC("0");
            finder.pressbtn_CALC("=");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            finder.pressbtn_CALC("1");
            finder.pressbtn_CALC("-");
            finder.pressbtn_CALC("0");
            finder.pressbtn_CALC("=");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            finder.pressbtn_CALC("1");
            finder.pressbtn_CALC("*");
            finder.pressbtn_CALC("0");
            finder.pressbtn_CALC("=");

        }

        private void button12_Click(object sender, EventArgs e)
        {
            finder.pressbtn_CALC("1");
            finder.pressbtn_CALC("/");
            finder.pressbtn_CALC("0");
            finder.pressbtn_CALC("=");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            finder.pressbtn_CALC("1");
            finder.pressbtn_CALC("+");
            finder.pressbtn_CALC("2");
            finder.pressbtn_CALC("+");
            finder.pressbtn_CALC("3");
            finder.pressbtn_CALC("=");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            finder.pressbtn_CALC("-");
            finder.pressbtn_CALC("1");
            finder.pressbtn_CALC("+");
            finder.pressbtn_CALC("0");
            finder.pressbtn_CALC("=");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            finder.pressbtn_CALC(".");
            finder.pressbtn_CALC("7");
            finder.pressbtn_CALC("5");
            finder.pressbtn_CALC("+");
            finder.pressbtn_CALC("0");
            finder.pressbtn_CALC(".");
            finder.pressbtn_CALC("2");
            finder.pressbtn_CALC("4");
            finder.pressbtn_CALC("9");
            finder.pressbtn_CALC("=");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            finder.pressbtn_CALC(".");
            finder.pressbtn_CALC("=");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            finder.pressbtn_CALC("=");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            finder.pressbtn_CALC("0");
            finder.pressbtn_CALC("-");
            finder.pressbtn_CALC("1");
            finder.pressbtn_CALC("=");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            finder.pressbtn_CALC("0");
            finder.pressbtn_CALC(".");
            finder.pressbtn_CALC("1");
            finder.pressbtn_CALC(".");
            finder.pressbtn_CALC("2");
            finder.pressbtn_CALC(".");
            finder.pressbtn_CALC("3");
            finder.pressbtn_CALC("+");
            finder.pressbtn_CALC("4");
            finder.pressbtn_CALC("=");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            finder.pressbtn_CALC("0");
            finder.pressbtn_CALC(".");
            finder.pressbtn_CALC("1");
            finder.pressbtn_CALC(".");
            finder.pressbtn_CALC("2");
            finder.pressbtn_CALC("+");
            finder.pressbtn_CALC("3");
            finder.pressbtn_CALC("=");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string str = finder.start();
            string data = "";
            int flag = -1;
            char[] b = str.ToCharArray();
           // foreach (char x in b)
            for (int i = 0; i < b.Length;i++ )
            {
                if (b[i] == '/' && b[i+1] == '0' && b[i+2] == '=')
                {
                    flag = 1;
                }
                if (b[i] != 67)
                    data += b[i].ToString();
                if (b[i] == 67 && flag != 1)
                    data += finder.GetControlText() + "\n";
                if (b[i] == 67 && flag == 1)
                {
                    finder.pressbtn_CALC("C");
                    data += "\n";
                    flag = -1;
                }
                finder.pressbtn_CALC(b[i].ToString());
            }
            string[] dataarr = data.Split('\n');
            for (int i = 0; i < dataarr.Length; i++)
            {
                listBox1.Items.Add(dataarr[i].ToString());
            }
        }

    }
}
