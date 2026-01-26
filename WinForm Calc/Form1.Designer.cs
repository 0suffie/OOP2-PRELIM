namespace WinForm_Calc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11Clear = new Button();
            button12deci = new Button();
            button13plus = new Button();
            button14minus = new Button();
            button15multiply = new Button();
            button16divide = new Button();
            button17equals = new Button();
            button18negate = new Button();
            button19move = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(396, 230);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(264, 32);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(450, 421);
            button1.Name = "button1";
            button1.Size = new Size(48, 45);
            button1.TabIndex = 1;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += numbers;
            // 
            // button2
            // 
            button2.Location = new Point(396, 370);
            button2.Name = "button2";
            button2.Size = new Size(48, 45);
            button2.TabIndex = 2;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += numbers;
            // 
            // button3
            // 
            button3.Location = new Point(450, 370);
            button3.Name = "button3";
            button3.Size = new Size(48, 45);
            button3.TabIndex = 3;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += numbers;
            // 
            // button4
            // 
            button4.Location = new Point(504, 370);
            button4.Name = "button4";
            button4.Size = new Size(48, 45);
            button4.TabIndex = 4;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += numbers;
            // 
            // button5
            // 
            button5.Location = new Point(396, 319);
            button5.Name = "button5";
            button5.Size = new Size(48, 45);
            button5.TabIndex = 5;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += numbers;
            // 
            // button6
            // 
            button6.Location = new Point(450, 319);
            button6.Name = "button6";
            button6.Size = new Size(48, 45);
            button6.TabIndex = 6;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += numbers;
            // 
            // button7
            // 
            button7.Location = new Point(504, 319);
            button7.Name = "button7";
            button7.Size = new Size(48, 45);
            button7.TabIndex = 7;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += numbers;
            // 
            // button8
            // 
            button8.Location = new Point(396, 268);
            button8.Name = "button8";
            button8.Size = new Size(48, 45);
            button8.TabIndex = 8;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += numbers;
            // 
            // button9
            // 
            button9.Location = new Point(450, 268);
            button9.Name = "button9";
            button9.Size = new Size(48, 45);
            button9.TabIndex = 9;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += numbers;
            // 
            // button10
            // 
            button10.Location = new Point(504, 268);
            button10.Name = "button10";
            button10.Size = new Size(48, 45);
            button10.TabIndex = 10;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            button10.Click += numbers;
            // 
            // button11Clear
            // 
            button11Clear.Location = new Point(396, 421);
            button11Clear.Name = "button11Clear";
            button11Clear.Size = new Size(48, 45);
            button11Clear.TabIndex = 11;
            button11Clear.Text = "C";
            button11Clear.UseVisualStyleBackColor = true;
            button11Clear.Click += button11Clear_Click;
            // 
            // button12deci
            // 
            button12deci.Location = new Point(504, 421);
            button12deci.Name = "button12deci";
            button12deci.Size = new Size(48, 45);
            button12deci.TabIndex = 12;
            button12deci.Text = ".";
            button12deci.UseVisualStyleBackColor = true;
            button12deci.Click += button12deci_Click;
            // 
            // button13plus
            // 
            button13plus.Location = new Point(558, 421);
            button13plus.Name = "button13plus";
            button13plus.Size = new Size(48, 45);
            button13plus.TabIndex = 13;
            button13plus.Text = "+";
            button13plus.UseVisualStyleBackColor = true;
            button13plus.Click += operators;
            // 
            // button14minus
            // 
            button14minus.Location = new Point(558, 370);
            button14minus.Name = "button14minus";
            button14minus.Size = new Size(48, 45);
            button14minus.TabIndex = 14;
            button14minus.Text = "-";
            button14minus.UseVisualStyleBackColor = true;
            button14minus.Click += operators;
            // 
            // button15multiply
            // 
            button15multiply.Location = new Point(558, 319);
            button15multiply.Name = "button15multiply";
            button15multiply.Size = new Size(48, 45);
            button15multiply.TabIndex = 15;
            button15multiply.Text = "*";
            button15multiply.UseVisualStyleBackColor = true;
            button15multiply.Click += operators;
            // 
            // button16divide
            // 
            button16divide.Location = new Point(612, 319);
            button16divide.Name = "button16divide";
            button16divide.Size = new Size(48, 45);
            button16divide.TabIndex = 16;
            button16divide.Text = "/";
            button16divide.UseVisualStyleBackColor = true;
            button16divide.Click += operators;
            // 
            // button17equals
            // 
            button17equals.Location = new Point(612, 370);
            button17equals.Name = "button17equals";
            button17equals.Size = new Size(48, 96);
            button17equals.TabIndex = 17;
            button17equals.Text = "=";
            button17equals.UseVisualStyleBackColor = true;
            button17equals.Click += button17equals_Click;
            // 
            // button18negate
            // 
            button18negate.Location = new Point(558, 268);
            button18negate.Name = "button18negate";
            button18negate.Size = new Size(48, 45);
            button18negate.TabIndex = 18;
            button18negate.Text = "+/-";
            button18negate.UseVisualStyleBackColor = true;
            button18negate.Click += button18negate_Click;
            // 
            // button19move
            // 
            button19move.Location = new Point(612, 268);
            button19move.Name = "button19move";
            button19move.Size = new Size(48, 45);
            button19move.TabIndex = 19;
            button19move.Text = "->";
            button19move.UseVisualStyleBackColor = true;
            button19move.Click += button19move_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 650);
            Controls.Add(button19move);
            Controls.Add(button18negate);
            Controls.Add(button17equals);
            Controls.Add(button16divide);
            Controls.Add(button15multiply);
            Controls.Add(button14minus);
            Controls.Add(button13plus);
            Controls.Add(button12deci);
            Controls.Add(button11Clear);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += numbers;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11Clear;
        private Button button12deci;
        private Button button13plus;
        private Button button14minus;
        private Button button15multiply;
        private Button button16divide;
        private Button button17equals;
        private Button button18negate;
        private Button button19move;
    }
}
