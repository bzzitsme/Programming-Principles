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
        double firstNumber = 0, secondNumber = 0, result = 0;
        string operation = "";
        double etoRepchik = 0;
        string state = "";
        public Form1()
        {
            InitializeComponent();
            state = "FirstNumber";

        }
        private void btn_click(object sender, EventArgs e)
        {
            if(etoRepchik == 1)
            {
                display.Clear();
                etoRepchik = 0;
            }
            if (display.Text == "0") display.Clear();
            Button btn = sender as Button;
            switch (state)
            {
                case "FirstNumber":
                    state = "Operation";
                    break;
                case "SecondNumber":
                    state = "Result";
                    display.Text = "";
                    break;
            }
            if (btn.Text == ",")
            {
                if (!display.Text.Contains(",")) display.Text += btn.Text;
            }
            else display.Text += btn.Text;
        }
        private void operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(state == "Result")
            {
                secondNumber = double.Parse(display.Text);
                switch(operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        result = firstNumber / secondNumber;
                        break;
                    case "Mod":
                        result = firstNumber % secondNumber;
                        break;
                    case "%%":
                        result = firstNumber * secondNumber / 100;
                        break;
                    case "x^y":
                        result = Math.Pow(firstNumber, secondNumber);
                        break;
                    case "sqrt^x":
                        result = Math.Pow(secondNumber, 1 / firstNumber);
                        break;
                    case "logxy":
                        result = Math.Log10(secondNumber) / Math.Log10(firstNumber);
                        break;
                }
                display.Text = result + "";
                firstNumber = result;
            }
            operation = btn.Text;
            firstNumber = double.Parse(display.Text);
            state = "SecondNumber";
        }
        private void operationEqual_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(display.Text);
            switch(operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "Mod":
                    result = firstNumber % secondNumber;
                    break;
                case "%%":
                    result = firstNumber * secondNumber / 100;
                    break;
                case "x^y":
                    result = Math.Pow(firstNumber, secondNumber);
                    break;
                case "sqrt^x":
                    result = Math.Pow(secondNumber, 1 / firstNumber);
                    break;
                case "logxy":
                    result = Math.Log10(secondNumber) / Math.Log10(firstNumber);
                    break;
            }
            display.Text = result + "";
            firstNumber = result;

        }
        private void operationEqualOthers_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(display.Text);
            Button opera = sender as Button;
            string operat = opera.Text;
            switch(operat)
            {
                case "√":
                    secondNumber = Math.Sqrt(secondNumber);
                    etoRepchik = 1;
                    break;
                case "%":
                    secondNumber = secondNumber / 100;
                    etoRepchik = 1;
                    break;
                case "1/x":
                    secondNumber = 1 / secondNumber;
                    etoRepchik = 1;
                    break;
                case "+/-":
                    secondNumber = -(secondNumber);
                    etoRepchik = 0;
                    break;
                case "sinx":
                    secondNumber = Math.Sin(secondNumber);
                    etoRepchik = 1;
                    break;
                case "cosx":
                    secondNumber = Math.Cos(secondNumber);
                    etoRepchik = 1;
                    break;
                case "tanx":
                    secondNumber = Math.Tan(secondNumber);
                    etoRepchik = 1;
                    break;
                case "cotx":
                    secondNumber = 1 / Math.Tan(secondNumber);
                    etoRepchik = 1;
                    break;
                case "!":
                    int factorial = 1;
                    for(int i = 1; i <= secondNumber; i++)
                    {
                        factorial *= i;
                    }
                    secondNumber = factorial;
                    etoRepchik = 1;
                    break;
                case "lnx":
                    secondNumber = Math.Log(secondNumber);
                    etoRepchik = 1;
                    break;
                case "e^x":
                    secondNumber = Math.Exp(secondNumber);
                    etoRepchik = 1;
                    break;
                case "10^x":
                    secondNumber = Math.Pow(10, secondNumber);
                    etoRepchik = 1;
                    break;

                    
            }
            display.Text = secondNumber + "";
        }
        private void operationClear_Click(object sender, EventArgs e)
        {
            Button operationClearbtn = sender as Button;
            string operationClear = operationClearbtn.Text;
            switch(operationClear)
            {
                case "C":
                    display.Text = "0";
                    firstNumber = 0;
                    secondNumber = 0;
                    result = 0;
                    state = "FirstNumber";
                    break;
                case "Back":
                    if (display.Text.Length == 1) display.Text = "0";
                    else display.Text = display.Text.Remove(display.Text.Length - 1, 1);
                    break;
                case "CE":
                    display.Text = "0";
                    break;
            }
        }
    }
}
