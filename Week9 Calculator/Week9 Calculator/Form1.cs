using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9_Calculator
{
    public partial class Form1 : Form
    {
        public static double firstNum = 0, secondNum = 0, result = 0;
        public static double lmao = 0;
        public static string operation = "";
        public static string incursio = "";
        int test = 0;
        public Form1()
        {
            InitializeComponent();
            label.Text = "0";
            incursio = "1";
        }
        public static void p(double a, double b)
        {
            result = a + b;
        }
        public static void min(double a, double b)
        {
            result = a - b;
        }
        public static void multi(double a, double b)
        {
            result = a * b;
        }
        public static void div(double a, double b)
        {
            result = a / b;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(lmao == 1)
            {
                label.Text = "";
                lmao = 0;
            }
            if(incursio == "1")
            {
                label.Text = "";
                incursio = "";
            }
            Button btn = sender as Button;
            label.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lmao == 1)
            {
                label.Text = "";
                lmao = 0;
            }
            if (incursio == "1")
            {
                label.Text = "";
                incursio = "";
            }
            Button btn = sender as Button;
            label.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lmao == 1)
            {
                label.Text = "";
                lmao = 0;
            }
            if (incursio == "1")
            {
                label.Text = "";
                incursio = "";
            }
            Button btn = sender as Button;
            label.Text += btn.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (label.Text == "0")
            {
                incursio = "1";
            }
            else if (label.Text != "0")
            {
                label.Text += btn.Text;
            }
            if(test == 1)
            {
                label.Text = "";
                label.Text += btn.Text;
                test = 0;
            }
            
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lmao == 1)
            {
                label.Text = "";
                lmao = 0;
            }
            if (incursio == "1")
            {
                label.Text = "";
                incursio = "";
            }
            Button btn = sender as Button;
            label.Text += btn.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lmao == 1)
            {
                label.Text = "";
                lmao = 0;
            }
            if (incursio == "1")
            {
                label.Text = "";
                incursio = "";
            }
            Button btn = sender as Button;
            label.Text += btn.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lmao == 1)
            {
                label.Text = "";
                lmao = 0;
            }
            if (incursio == "1")
            {
                label.Text = "";
                incursio = "";
            }
            Button btn = sender as Button;
            label.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lmao == 1)
            {
                label.Text = "";
                lmao = 0;
            }
            if (incursio == "1")
            {
                label.Text = "";
                incursio = "";
            }
            Button btn = sender as Button;
            label.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lmao == 1)
            {
                label.Text = "";
                lmao = 0;
            }
            if (incursio == "1")
            {
                label.Text = "";
                incursio = "";
            }
            Button btn = sender as Button;
            label.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lmao == 1)
            {
                label.Text = "";
                lmao = 0;
            }
            if (incursio == "1")
            {
                label.Text = "";
                incursio = "";
            }
            Button btn = sender as Button;
            label.Text += btn.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(label.Text);
            operation = "p";
            lmao = 1;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(label.Text);
            operation = "min";
            lmao = 1;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            secondNum = double.Parse(label.Text);
            if(operation == "div" && label.Text == "0")
            {
                label.Text = "Деление на ноль невозможно";
            }
            if(operation == "min")
            {
                min(firstNum, secondNum);
            }
            if(operation == "p")
            {
                p(firstNum, secondNum);
            }
            if(operation == "multi")
            {
                multi(firstNum, secondNum);
            }
            if(operation == "div")
            {
                div(firstNum, secondNum);
            }
            if (result >= 0)
            {
                label.Text = Convert.ToString(result);
            }
            incursio = "1";
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void ce_Click(object sender, EventArgs e)
        {
            label.Text = "";
            incursio = "";
            if(label.Text == "")
            {
                label.Text = "0";
            }
            incursio = "1";
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(label.Text);
            firstNum = Math.Sqrt(firstNum);
            label.Text = Convert.ToString(firstNum);
            incursio = "1";
        }

        private void btnxsquare_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(label.Text);
            firstNum = Math.Pow(firstNum, 2);
            label.Text = Convert.ToString(firstNum);
            incursio = "1";
        }

        private void btnpercent_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(label.Text);
            firstNum = firstNum / 100;
            label.Text = Convert.ToString(firstNum);
            incursio = "1";
        }

        private void btn1divx_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(label.Text);
            firstNum = 1 / firstNum;
            label.Text = Convert.ToString(firstNum);
            incursio = "1";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (!label.Text.Contains(",")) ;
            {
                label.Text += ",";
                incursio = "";
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(label.Text.Length == 1)
            {
                label.Text = "0";
            }
            else if(label.Text.Length > 1)
            {
                label.Text = label.Text.Remove(label.Text.Length - 1, 1);
            }
            incursio = "1";
        }

        private void c_Click(object sender, EventArgs e)
        {
            if(operation == "div" || operation == "multi" || operation == "p" || operation == "min")
            {
                secondNum = double.Parse(label.Text);
            }
            label.Text = "";
            if (label.Text == "")
            {
                label.Text = "0";
            }
            incursio = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label.Text == "0")
            {
                incursio = "1";
            }
            else if (label.Text != "0")
            {
                
            }
            label.Text = "-" + label.Text;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(label.Text);
            operation = "multi";
            lmao = 1;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(label.Text);
            operation = "div";
            lmao = 1;
            test = 1;
        }
    }
}
