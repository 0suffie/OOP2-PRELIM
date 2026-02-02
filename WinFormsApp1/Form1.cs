using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private (int Start, int Length, string Token) GetNumberTokenAt(int cursorPosition)
        {
            string text = textBox1.Text ?? string.Empty;
            cursorPosition = Math.Min(Math.Max(0, cursorPosition), text.Length);

            int start = cursorPosition;
            while (start > 0 && text[start - 1] != ' ' && text[start - 1] != '(' && text[start - 1] != ')')
                start--;

            int end = cursorPosition;
            while (end < text.Length && text[end] != ' ' && text[end] != '(' && text[end] != ')')
                end++;

            string token = (end > start) ? text.Substring(start, end - start) : string.Empty;
            return (start, end - start, token);
        }

        private void Numbers(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBox1.Text == "0" || textBox1.Text == "Error" || isOperationPerformed)
            {
                textBox1.Clear();
                isOperationPerformed = false;
            }

            int cursorPosition = textBox1.SelectionStart;
            var tokenInfo = GetNumberTokenAt(cursorPosition);

            if (!string.IsNullOrEmpty(tokenInfo.Token) && tokenInfo.Token == "0")
            {
                if (button.Text != "0")
                {
                    textBox1.Text = textBox1.Text.Remove(tokenInfo.Start, tokenInfo.Length).Insert(tokenInfo.Start, button.Text);
                    textBox1.SelectionStart = tokenInfo.Start + button.Text.Length;
                    textBox1.Focus();
                    textBox1.ScrollToCaret();
                    return;
                }
                else return;
            }

            textBox1.Text = textBox1.Text.Insert(cursorPosition, button.Text);
            textBox1.SelectionStart = cursorPosition + button.Text.Length;
            textBox1.Focus();
            textBox1.ScrollToCaret();
        }

        private void Operators(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string op = button.Text;
            if (op == "x") op = "*";
            if (op == "÷") op = "/";

            if (isOperationPerformed) isOperationPerformed = false;

            int cursorPosition = textBox1.SelectionStart;

            if (cursorPosition >= 3 && textBox1.Text.Substring(cursorPosition - 3, 3).StartsWith(" ") && textBox1.Text.Substring(cursorPosition - 3, 3).EndsWith(" "))
            {
                textBox1.Text = textBox1.Text.Remove(cursorPosition - 2, 1).Insert(cursorPosition - 2, op);
                textBox1.SelectionStart = cursorPosition;
            }
            else
            {
                string toInsert = " " + op + " ";
                textBox1.Text = textBox1.Text.Insert(cursorPosition, toInsert);
                textBox1.SelectionStart = cursorPosition + toInsert.Length;
            }
            textBox1.Focus();
            textBox1.ScrollToCaret();
        }

        private void Equals(object sender, EventArgs e)
        {
            try
            {
                string expression = textBox1.Text;
                if (string.IsNullOrWhiteSpace(expression)) return;

                expression = expression.Replace("π", Math.PI.ToString());
                expression = expression.Replace("%", "/100");

                if (expression.Contains("√"))
                {
                    int index = expression.IndexOf("√");
                    int start = index + 1;
                    int length = 0;
                    while (start + length < expression.Length && (char.IsDigit(expression[start + length]) || expression[start + length] == '.'))
                    {
                        length++;
                    }
                    string numberInside = expression.Substring(start, length);
                    double sqrtVal = Math.Sqrt(double.Parse(numberInside));
                    expression = expression.Replace("√" + numberInside, sqrtVal.ToString());
                }

                DataTable table = new DataTable();
                var result = table.Compute(expression, "");

                if (result.ToString() == "Infinity" || result.ToString() == "NaN")
                {
                    textBox1.Text = "Cannot divide by zero";
                }
                else
                {
                    double finalResult = Convert.ToDouble(result);
                    textBox1.Text = Math.Round(finalResult, 10).ToString();
                    resultValue = finalResult;
                }
                isOperationPerformed = true;
            }
            catch (Exception)
            {
                textBox1.Text = "Error";
                isOperationPerformed = true;
            }
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void Clear(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
            isOperationPerformed = false;
            textBox1.Focus();
        }

        private void Backspace(object sender, EventArgs e)
        {
            if (textBox1.Text == "Error" || textBox1.Text == "Syntax Error" || textBox1.Text.Contains("zero"))
            {
                textBox1.Text = "0";
                isOperationPerformed = false;
                textBox1.Focus();
                return;
            }

            int cursor = textBox1.SelectionStart;

            if (cursor > 0)
            {
                if (textBox1.Text.Substring(0, cursor).EndsWith(" ") && cursor >= 3)
                {
                    textBox1.Text = textBox1.Text.Remove(cursor - 3, 3);
                    textBox1.SelectionStart = cursor - 3;
                }
                else
                {
                    textBox1.Text = textBox1.Text.Remove(cursor - 1, 1);
                    textBox1.SelectionStart = cursor - 1;
                }
            }

            if (string.IsNullOrEmpty(textBox1.Text)) textBox1.Text = "0";

            textBox1.Focus();
            textBox1.ScrollToCaret();
        }

        private void Sqrt(object sender, EventArgs e)
        {
            int cursor = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(cursor, "√");
            textBox1.SelectionStart = cursor + 1;
            textBox1.Focus();
        }

        private void Squared(object sender, EventArgs e)
        {
            int cursor = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(cursor, " * ");
            int newCursor = textBox1.SelectionStart;
            var token = GetNumberTokenAt(cursor);
            textBox1.Text = textBox1.Text.Insert(newCursor, token.Token);
            textBox1.SelectionStart = newCursor + token.Token.Length;
            textBox1.Focus();
        }

        private void Pi(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOperationPerformed) textBox1.Clear();
            int cursor = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(cursor, "π");
            textBox1.SelectionStart = cursor + 1;
            isOperationPerformed = false;
            textBox1.Focus();
        }

        private void Negation(object sender, EventArgs e)
        {
            try
            {
                int cursorPosition = textBox1.SelectionStart;
                var tokenInfo = GetNumberTokenAt(cursorPosition);
                string token = tokenInfo.Token;

                if (string.IsNullOrEmpty(token) || token == "(" || token == ")") return;

                string newToken = token.StartsWith("-") ? token.Substring(1) : "-" + token;
                textBox1.Text = textBox1.Text.Remove(tokenInfo.Start, tokenInfo.Length).Insert(tokenInfo.Start, newToken);
                textBox1.SelectionStart = tokenInfo.Start + newToken.Length;
                textBox1.Focus();
                textBox1.ScrollToCaret();
            }
            catch { textBox1.Text = "Error"; }
        }

        private void Percent(object sender, EventArgs e)
        {
            int cursor = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(cursor, "%");
            textBox1.SelectionStart = cursor + 1;
            textBox1.Focus();
        }

        private void ParenthesisOpen(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOperationPerformed) textBox1.Clear();
            int cursor = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(cursor, "(");
            textBox1.SelectionStart = cursor + 1;
            isOperationPerformed = false;
            textBox1.Focus();
        }

        private void ParenthesisClose(object sender, EventArgs e)
        {
            int cursor = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(cursor, ")");
            textBox1.SelectionStart = cursor + 1;
            textBox1.Focus();
        }

        private void Period(object sender, EventArgs e)
        {
            int cursor = textBox1.SelectionStart;
            var token = GetNumberTokenAt(cursor);
            if (token.Token.Contains(".")) return;
            string toInsert = string.IsNullOrEmpty(token.Token) ? "0." : ".";
            textBox1.Text = textBox1.Text.Insert(cursor, toInsert);
            textBox1.SelectionStart = cursor + toInsert.Length;
            textBox1.Focus();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}