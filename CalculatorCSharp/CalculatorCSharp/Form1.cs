using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorCSharp
{
    public partial class Form1 : Form
    {
        private int num1;
        private int num2;
        private int ans;
        private String str = "";
        private char c;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text +  "1";
            str= str + "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            str = str + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            str = str + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            str = str + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            str = str + "5";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            str = str + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            str = str + "7";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            str = str + "8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            str = str + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            str = str + "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
            num1 = int.Parse(str);
            c = '+';
            str = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
            num1 = int.Parse(str);
            c = '-';
            str = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
            num1 = int.Parse(str);
            c = '*';
            str = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
            num1 = int.Parse(str);
            c = '/';
            str = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            str = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(str);
            if (c == '+') {
                ans = num1 + num2;
            }
            else if (c == '-') {
                ans = num1 - num2;
            }
            else if (c == '*') {
                ans = num1 * num2;
            }
            else if (c == '/') {
                ans = num1 / num2;
            }
            textBox1.Text = ans.ToString();
            str = ans.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
