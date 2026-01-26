using System;
using System.Collections; 
using System.Windows.Forms;

namespace WinForm_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void operators(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + " " + btn.Text + " ";
        }

        private void numbers(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string num = btn.Text;

            if (textBox1.Text == "0")
            {
                textBox1.Text = num;
            }
            else
            {
                textBox1.Text = textBox1.Text + num;
            }
        }

        private void button17equals_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                ArrayList tokens = new ArrayList();
                tokens.AddRange(parts);

                for (int i = 0; i < tokens.Count; i++)
                {
                    string currentOp = tokens[i].ToString();

                    if (currentOp == "*" || currentOp == "/")
                    {
                        double left = Convert.ToDouble(tokens[i - 1]);
                        double right = Convert.ToDouble(tokens[i + 1]);
                        double result = 0;

                        if (currentOp == "*") result = left * right;
                        if (currentOp == "/") result = left / right;

                        tokens[i - 1] = result.ToString();
                        tokens.RemoveAt(i);
                        tokens.RemoveAt(i);

                        i--;
                    }
                }

                for (int i = 0; i < tokens.Count; i++)
                {
                    string currentOp = tokens[i].ToString();

                    if (currentOp == "+" || currentOp == "-")
                    {
                        double left = Convert.ToDouble(tokens[i - 1]);
                        double right = Convert.ToDouble(tokens[i + 1]);
                        double result = 0;

                        if (currentOp == "+") result = left + right;
                        if (currentOp == "-") result = left - right;

                        tokens[i - 1] = result.ToString();
                        tokens.RemoveAt(i);
                        tokens.RemoveAt(i);
                        i--;
                    }
                }

                textBox1.Text = tokens[0].ToString();
            }
            catch
            {
                MessageBox.Show("Syntax Error");
            }
        }

        private void button19move_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void button18negate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "-";
            }
            else
            {
                textBox1.Text = textBox1.Text + "-";
            }
        }

        private void button11Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button12deci_Click(object sender, EventArgs e)
        {
            string currentText = textBox1.Text;
            char[] mathSymbols = { '+', '-', '*', '/' };

            int lastSymbolIndex = currentText.LastIndexOfAny(mathSymbols);

            string currentNumber;
            if (lastSymbolIndex == -1)
            {
                currentNumber = currentText;
            }
            else
            {
                currentNumber = currentText.Substring(lastSymbolIndex + 1);
            }

            if (!currentNumber.Contains("."))
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }
    }
}