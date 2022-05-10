using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        float a, b;
        int count = 0 , k = 0;        
        bool sign = true;

        #region Basic Operations
        private void Calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                     break;   
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
            }
        }
        #endregion

        #region Num Buttons
        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }
        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }
        #endregion

        #region Basic Operation Buttons
        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a =float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label2.Text = a.ToString() + " + ";
            sign = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label2.Text = a.ToString() + " - ";
            sign = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label2.Text = a.ToString() + " * ";
            sign = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label2.Text = a.ToString() + " / ";
            sign = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            
            if (k == 0) {
                label2.Text = label2.Text + textBox1.Text;
                Calculate();
                k = 1;
            }
            else if (k == 1) {
                label2.Text = "";
                textBox1.Text = "";
                k = 0;
            }
            
        }
        #endregion

        #region Extended operations
        private void button1_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            label2.Text = a.ToString();
            a /= 100;
            textBox1.Text = a.ToString();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            a=float.Parse(textBox1.Text);
            textBox1.Clear();
            label2.Text = "Sqrt (" + a.ToString() + ")";
            b = (float)Math.Sqrt(a);
            textBox1.Text = b.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            label2.Text = "Pow (" +  a.ToString() + ")";
            b = (float)Math.Pow(a, 2);
            textBox1.Text =b.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            label2.Text = "1 / " + a.ToString() ;
            b = 1 / a;
            textBox1.Text = b.ToString();
        }
        #endregion

        #region Clear Buttons
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }
        #endregion


      

        private void button24_Click(object sender, EventArgs e)
        {
            if(sign == true)
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                a = 0-a;
                textBox1.Text = a.ToString();
                sign = false;
            }
            else if (sign == false)
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                a = 0-a;
                textBox1.Text = a.ToString();
                sign = true;
            }
        }

    }
}
