using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Custom_Calculator
{
    /// <summary>
    /// doubleeraction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void keyDownEvent(object sender, KeyEventArgs e)
        {
            switch(e.Key)
            {
                case Key.D0:
                    button0_Click(sender, e);
                    break;
                case Key.D1:
                    button1_Click(sender, e);
                    break;
                case Key.D2:
                    button2_Click(sender, e);
                    break;
                case Key.D3:
                    button3_Click(sender, e);
                    break;
                case Key.D4:
                    button4_Click(sender, e);
                    break;
                case Key.D5:
                    button5_Click(sender, e);
                    break;
                case Key.D6:
                    button6_Click(sender, e);
                    break;
                case Key.D7:
                    button7_Click(sender, e);
                    break;
                case Key.D8:
                    button8_Click(sender, e);
                    break;
                case Key.D9:
                    button9_Click(sender, e);
                    break;
                case Key.Escape:
                    buttonCE_Click(sender, e);
                    break;
                case Key.Back:
                    buttonC_Click(sender, e);
                    break;
                case Key.OemMinus:
                    buttonMinus_Click(sender, e);
                    break;
                case Key.Enter:
                    buttonEquals_Click(sender, e);
                    break;
                case Key.NumPad0:
                    button0_Click(sender, e);
                    break;
                case Key.NumPad1:
                    button1_Click(sender, e);
                    break;
                case Key.NumPad2:
                    button2_Click(sender, e);
                    break;
                case Key.NumPad3:
                    button3_Click(sender, e);
                    break;
                case Key.NumPad4:
                    button4_Click(sender, e);
                    break;
                case Key.NumPad5:
                    button5_Click(sender, e);
                    break;
                case Key.NumPad6:
                    button6_Click(sender, e);
                    break;
                case Key.NumPad7:
                    button7_Click(sender, e);
                    break;
                case Key.NumPad8:
                    button8_Click(sender, e);
                    break;
                case Key.NumPad9:
                    button9_Click(sender, e);
                    break;
                case Key.Decimal:
                    buttonPeriod_Click(sender, e);
                    break;
                case Key.OemPeriod:
                    buttonPeriod_Click(sender, e);
                    break;
                case Key.Divide:
                    buttonDivide_Click(sender, e);
                    break;
                case Key.OemPlus:
                    buttonPlus_Click(sender, e);
                    break;
                //todo
                default:
                    break;
                       
            }
        }
        private void textPut(string addNum)
        {
            string current = resultBar.Text;
            if (current == "0" || current == "+" || current == "-" || current == "x" || current == "/")
            {
                resultBar.Text = addNum;
            }
            else if(addNum == "neg")
            {
                resultBar.Text = "-" + current;
            }
            else if(addNum == ".")
            {
                resultBar.Text = current + ".";
            }
            else
            {
                resultBar.Text = current + addNum;
            }
        }
        public string uOperand;
        public double firstTerm;
        private void operandPut(string operand)
        {
            string current = resultBar.Text;
            // fix parse string error
            switch (operand)
            {
                case "C":
                    if(uOperand != null && uOperand == "*")
                    {
                        current = null;
                        resultBar.Text = "x";
                    }
                    else if(uOperand != null)
                    {
                        current = null;
                        resultBar.Text = uOperand;
                    }
                    else
                    {
                        firstTerm = 0;
                        resultBar.Text = "0";
                    }
                    break;
                case "+":
                    firstTerm = double.Parse(current);
                    uOperand = "+";
                    resultBar.Text = "+";
                    break;
                case "-":
                    firstTerm = double.Parse(current);
                    uOperand = "-";
                    resultBar.Text = "-";
                    break;
                case "*":
                    firstTerm = double.Parse(current);
                    uOperand = "*";
                    resultBar.Text = "x";
                    break;
                case "/":
                    firstTerm = double.Parse(current);
                    uOperand = "/";
                    resultBar.Text = "/";
                    break;
                case "=":
                    double currentNum = double.Parse(current);
                    if (uOperand == "+")
                    {
                        double result = firstTerm + currentNum;
                        resultBar.Text = result.ToString();
                    }
                    else if(uOperand == "-")
                    {
                        double result = firstTerm - currentNum;
                        resultBar.Text = result.ToString();
                    }
                    else if (uOperand == "*")
                    {
                        double result = firstTerm * currentNum;
                        resultBar.Text = result.ToString();
                    }
                    else if (uOperand == "/")
                    {
                        if(currentNum == 0)
                        {
                            resultBar.Text = "DIV BY 0";
                            System.Threading.Thread.Sleep(1000);
                            resultBar.Text = 0.ToString();
                        }
                        else
                        {
                            double result = firstTerm / currentNum;
                            resultBar.Text = result.ToString();
                        }
                    }

                    break;
                default:
                    break;
            }
        }
        private void commonTextRegister(string input)
        {
            switch(input)
            {
                case "1":
                    textPut("1");
                    break;
                case "2":
                    textPut("2");
                    break;
                case "3":
                    textPut("3");
                    break;
                case "4":
                    textPut("4");
                    break;
                case "5":
                    textPut("5");
                    break;
                case "6":
                    textPut("6");
                    break;
                case "7":
                    textPut("7");
                    break;
                case "8":
                    textPut("8");
                    break;
                case "9":
                    textPut("9");
                    break;
                case "0":
                    textPut("0");
                    break;
                case "+":
                    operandPut("+");
                    break;
                case "-":
                    operandPut("-");
                    break;
                case "*":
                    operandPut("*");
                    break;
                case "/":
                    operandPut("/");
                    break;
                case "=":
                    operandPut("=");
                    break;
                case "neg":
                    textPut("neg");
                    break;
                case ".":
                    textPut(".");
                    break;
                case "x2":
                    string x2s = resultBar.Text;
                    double x2n = double.Parse(x2s);
                    double x2r = x2n * x2n;
                    resultBar.Text = x2r.ToString();
                    break;
                case "C":
                    operandPut("C");
                    break;
                case "CE":
                    resultBar.Text = "0";
                    uOperand = "";
                    firstTerm = 0;
                    break;
                default:
                    break;

            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("9");
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("8");
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("7");
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("6");
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("5");
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("4");
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("3");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("2");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("1");
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("0");
        }

        private void buttonNeg_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("neg");
        }

        private void buttonCE_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("CE");
        }

        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("C");
        }

        private void buttonXSquared_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("x2");
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("-");
        }

        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("=");
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("*");
        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("/");
        }

        private void buttonPeriod_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister(".");
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            commonTextRegister("+");
        }
    }
}
