using System.Collections.Generic;
using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;

namespace MathSol
{
    public partial class Form1 : Form
    {
        double myAns = 0;
        public Form1()
        {
            InitializeComponent();
            /*this.Load += new EventHandler(MainForm_Load);
            inputText.Leave += new EventHandler(txtAlwaysFocused_Leave);*/


        }

        private void buttonCal_Click(object sender, EventArgs e)
        {
            try
            {
                outText.Text = "";
                String myCalFunc = inputText.Text;
                if (myCalFunc.Trim().Length == 0) { return; }

                double result = Normal_Caculation(myCalFunc);
                myAns = result;
                outText.Text += result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Phương trình tính toán không hợp lệ.");
            }

        }

        static int CalculateGCD(int a, int b)
        {
            if (a < b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }

        private double Normal_Caculation(string input)
        {
            string postfix = InfixToPostfix(input);
            double result = EvaluatePostfix(postfix);
            /*System.Diagnostics.Debug.WriteLine($"Result: {result}");*/
            return result;
        }

        static string InfixToPostfix(string infix)
        {
            Stack<char> operators = new Stack<char>();
            Queue<string> output = new Queue<string>();
            string numberBuffer = "";

            for (int i = 0; i < infix.Length; i++)
            {
                char c = infix[i];

                if (char.IsDigit(c) || c == '.')
                {
                    numberBuffer += c;
                }
                else
                {
                    if (!string.IsNullOrEmpty(numberBuffer))
                    {
                        output.Enqueue(numberBuffer);
                        numberBuffer = "";
                    }

                    if (c == ' ')
                        continue;

                    if (c == '(')
                    {
                        operators.Push(c);
                    }
                    else if (c == ')')
                    {
                        while (operators.Peek() != '(')
                        {
                            output.Enqueue(operators.Pop().ToString());
                        }
                        operators.Pop();
                    }
                    else if (c == '²')
                    {
                        // Directly handle the square operator
                        output.Enqueue("2");
                        operators.Push('^');
                    }
                    else if (c == '³')
                    {
                        // Directly handle the square operator
                        output.Enqueue("3");
                        operators.Push('^');
                    }else if(c== 'π')
                    {
                        output.Enqueue("3.14");
                        
                    }
                    else if (IsOperator(c))
                    {
                        while (operators.Count > 0 && Precedence(operators.Peek()) >= Precedence(c))
                        {
                            output.Enqueue(operators.Pop().ToString());
                        }
                        operators.Push(c);
                    }
                }
            }

            if (!string.IsNullOrEmpty(numberBuffer))
            {
                output.Enqueue(numberBuffer);
            }

            while (operators.Count > 0)
            {
                output.Enqueue(operators.Pop().ToString());
            }

            return string.Join(" ", output);
        }

        static bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/' || c == '^';
        }

        static int Precedence(char c)
        {
            switch (c)
            {
                case '^': return 3;
                case '*':
                case '/': return 2;
                case '+':
                case '-': return 1;
                default: return 0;
            }
        }

        static double EvaluatePostfix(string postfix)
        {
            Stack<double> stack = new Stack<double>();
            string[] tokens = postfix.Split(' ');

            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double number))
                {
                    stack.Push(number);
                }
                else if (IsOperator(token[0]))
                {
                    double rightOperand = stack.Pop();
                    double leftOperand = stack.Pop();

                    switch (token[0])
                    {
                        case '+': stack.Push(leftOperand + rightOperand); break;
                        case '-': stack.Push(leftOperand - rightOperand); break;
                        case '*': stack.Push(leftOperand * rightOperand); break;
                        case '/': stack.Push(leftOperand / rightOperand); break;
                        case '^': stack.Push(Math.Pow(leftOperand, rightOperand)); break;
                    }
                }
            }

            return stack.Pop();
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InsertTextAtCursor(TextBox textBox, string textToInsert)
        {
            int cursorPosition = textBox.SelectionStart;
            textBox.Text = textBox.Text.Insert(cursorPosition, textToInsert);
            textBox.SelectionStart = cursorPosition + textToInsert.Length;
            textBox.SelectionLength = 0;
        }
        private void changeInputTextWhenClick(Button myBtn)
        {
            InsertTextAtCursor(inputText, myBtn.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            inputText.Focus();
        }

        private void txtAlwaysFocused_Leave(object sender, EventArgs e)
        {
            inputText.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeInputTextWhenClick(button1);

        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            changeInputTextWhenClick(buttonMin);
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            changeInputTextWhenClick(buttonSub);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeInputTextWhenClick(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeInputTextWhenClick(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changeInputTextWhenClick(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            changeInputTextWhenClick(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            changeInputTextWhenClick(button6);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            changeInputTextWhenClick(button9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            changeInputTextWhenClick(button8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            changeInputTextWhenClick(button7);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            changeInputTextWhenClick(button0);
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            changeInputTextWhenClick(buttonDot);
        }


        private void buttonPow3_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor(inputText, "³");
        }

        private void buttonPow2_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor(inputText, "²");
        }


        private void buttonPlus_Click(object sender, EventArgs e)
        {
            changeInputTextWhenClick(buttonPlus);
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            changeInputTextWhenClick(buttonMul);
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            inputText.Text = "";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (inputText.Text.Length != 0)
            {
                int cursorPosition = inputText.SelectionStart;
                if (cursorPosition != 0)
                {
                    inputText.Text = inputText.Text.Remove(cursorPosition - 1, 1);
                    inputText.SelectionStart = cursorPosition - 1;
                    inputText.SelectionLength = 0;
                }
                else
                {
                    inputText.Text = inputText.Text.Remove(cursorPosition, 1);
                    inputText.SelectionStart = cursorPosition;
                    inputText.SelectionLength = 0;
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            changeInputTextWhenClick(buttonOpen);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            changeInputTextWhenClick(buttonClose);
        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            changeInputTextWhenClick(buttonPow);
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor(inputText, "3.14");
        }

        private void buttonANS_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor(inputText, myAns.ToString());
        }

        
    }
}
