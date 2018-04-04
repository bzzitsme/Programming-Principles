using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        static double n1 = 0, n2 = 0, MS = 0;
        string op;
        bool operation = false;
        bool text = false;
        int testForZero = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btn("1");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btn("2");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btn("3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btn("5");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn("6");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn("7");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn("8");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn("9");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            btn("0");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if(!display.Text.Contains(","))
            {
                display.Text += ",";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(display.Text);
            op = "+";
            operation = false;
            text = false;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(display.Text);
            op = "-";
            operation = false;
            text = false;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(display.Text);
            op = "*";
            operation = false;
            text = false;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(display.Text);
            op = "/";
            operation = false;
            text = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(display.Text);
            op = "%";
            operation = false;
            text = false;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(display.Text) >= 0)
                display.Text = Math.Sqrt(double.Parse(display.Text)).ToString();
            else
            {
                MessageBox.Show("Impossible");
                n1 = 0;
                n2 = 0;
                display.Text = "0";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            display.Text = "0";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string s = display.Text;
            if(s.Length <= 1)
            {
                display.Text = "0";
            }
            else
            {
                string S = "";
                for(int i = 0; i < s.Length - 1; i++)
                {
                    S += s[i];
                }
                s = S;
                display.Text = s;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            display.Text = (double.Parse(display.Text) * double.Parse(display.Text)) + "";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            display.Text = (1 / double.Parse(display.Text)) + "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!operation)
            {
                n2 = double.Parse(display.Text);
                switch (op)
                {
                    case "+":
                        display.Text = n1 + n2 + "";
                        testForZero = 0;
                        break;
                    case "-":
                        display.Text = n1 - n2 + "";
                        testForZero = 0;
                        break;
                    case "*":
                        display.Text = n1 * n2 + "";
                        testForZero = 0;
                        break;
                    case "/":
                        if(n2 == 0)
                        {
                            MessageBox.Show("Impossible");
                        }
                        else display.Text = n1 / n2 + "";
                        testForZero = 0;
                        break;
                    case "%":
                        display.Text = (n1 * n2 / 100) + "";
                        testForZero = 0;
                        break;
                    case "Mod":
                        display.Text = n1 % n2 + "";
                        testForZero = 0;
                        break;
                    case "x^y":
                        display.Text = Math.Pow(n1, n2) + "";
                        testForZero = 0;
                        break;
                    case "sqrt(x)^y":
                        if (n2 == 0)
                        {
                            MessageBox.Show("Impossible");
                        }
                        else
                        {
                            display.Text = Math.Pow(n1, 1 / n2) + "";
                            testForZero = 0;
                        }
                        break;
                }
                operation = true;
            }
            else
            {
                n1 = double.Parse(display.Text);
                switch (op)
                {
                    case "+":
                        n1 = n1 + n2;
                        display.Text = n1 + "";
                        testForZero = 0;
                        break;
                    case "-":
                        n1 = n1 - n2;
                        display.Text = n1 + "";
                        testForZero = 0;
                        break;
                    case "*":
                        n1 = n1 * n2;
                        display.Text = n1 + "";
                        testForZero = 0;
                        break;
                    case "/":
                        n1 = n1 / n2;
                        display.Text = n1 + "";
                        testForZero = 0;
                        break;
                    case "%":
                        n1 = n1 * n2 / 100;
                        display.Text = n1 + "";
                        testForZero = 0;
                        break;
                    case "Mod":
                        n1 = n1 % n2;
                        display.Text = n1 + "";
                        testForZero = 0;
                        break;
                    case "x^y":
                        n1 = Math.Pow(n1, n2);
                        display.Text = n1 + "";
                        testForZero = 0;
                        break;
                    case "sqrt(x)^y":
                        if (n2 == 0)
                        {
                            MessageBox.Show("Impossible");
                            testForZero = 0;
                        }
                        else
                        {
                            n1 = Math.Pow(n1, 1 / n2);
                            display.Text = n1 + "";
                            testForZero = 0;
                        }
                        break;
                }
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            display.Text = (Math.Tan(double.Parse(display.Text) * Math.PI / 180)) + "";
            testForZero = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            display.Text = double.Parse(display.Text) * (-1) + "";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(display.Text);
            op = "Mod";
            operation = false;
            text = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            display.Text = 1 / Math.Tan(double.Parse(display.Text) * Math.PI / 180) + "";
            testForZero = 0;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            display.Text = Math.Sin(double.Parse(display.Text) * Math.PI / 180) + "";
            testForZero = 0;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if(double.Parse(display.Text) == 90)
            {
                display.Text = "0";
            }
            else display.Text = Math.Cos(double.Parse(display.Text) * Math.PI / 180) + "";
            testForZero = 0;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            int factorial = 1;
            for(int i = 1; i <= double.Parse(display.Text); i++)
            {
                factorial *= i;
            }
            display.Text = factorial + "";
            testForZero = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            display.Text = Math.PI + "";
            testForZero = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(display.Text);
            op = "x^y";
            operation = false;
            text = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            display.Text = Math.Pow(double.Parse(display.Text), 3) + "";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(display.Text);
            op = "sqrt(x)^y";
            operation = false;
            text = false;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if(double.Parse(display.Text) <= 0)
            {
                MessageBox.Show("Impossible");
                testForZero = 0;
            }
            else display.Text = Math.Log(double.Parse(display.Text)) + "";
            testForZero = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            display.Text = Math.Exp(double.Parse(display.Text)) + "";
            testForZero = 0;
        }

        private void btn(string s)
        {
            if(testForZero == 0)
            {
                display.Clear();
                testForZero = 2;
            }
            if (display.Text == "0" || text == false)
            {
                display.Text = s;
                text = true;
            }
            else
            {
                display.Text += s;
            }
        }

        private void memory_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string p = btn.Text;
            switch (p)
            {
                case "MC":
                    MS = 0;
                    break;
                case "MR":
                    display.Text = MS + "";
                    break;
                case "M+":
                    MS += double.Parse(display.Text);
                    break;
                case "M-":
                    MS -= double.Parse(display.Text);
                    break;
                case "MS":
                    MS = double.Parse(display.Text);
                    break;
            }
        }
    }
}
