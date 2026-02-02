namespace WinFormsApp1
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
            button11 = new Button();
            button12 = new Button();
            button26 = new Button();
            button23 = new Button();
            button22 = new Button();
            button24 = new Button();
            button25 = new Button();
            button20 = new Button();
            button27 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 84);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(72, 387);
            button1.Name = "button1";
            button1.Size = new Size(54, 51);
            button1.TabIndex = 1;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Numbers;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(12, 330);
            button2.Name = "button2";
            button2.Size = new Size(54, 51);
            button2.TabIndex = 2;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Numbers;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(72, 330);
            button3.Name = "button3";
            button3.Size = new Size(54, 51);
            button3.TabIndex = 3;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Numbers;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(132, 330);
            button4.Name = "button4";
            button4.Size = new Size(54, 51);
            button4.TabIndex = 4;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Numbers;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(12, 273);
            button5.Name = "button5";
            button5.Size = new Size(54, 51);
            button5.TabIndex = 5;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Numbers;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Popup;
            button6.Location = new Point(72, 273);
            button6.Name = "button6";
            button6.Size = new Size(54, 51);
            button6.TabIndex = 6;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Numbers;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Popup;
            button7.Location = new Point(132, 273);
            button7.Name = "button7";
            button7.Size = new Size(54, 51);
            button7.TabIndex = 7;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Numbers;
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Popup;
            button8.Location = new Point(12, 216);
            button8.Name = "button8";
            button8.Size = new Size(54, 51);
            button8.TabIndex = 8;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Numbers;
            // 
            // button9
            // 
            button9.FlatStyle = FlatStyle.Popup;
            button9.Location = new Point(72, 216);
            button9.Name = "button9";
            button9.Size = new Size(54, 51);
            button9.TabIndex = 9;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Numbers;
            // 
            // button10
            // 
            button10.FlatStyle = FlatStyle.Popup;
            button10.Location = new Point(132, 216);
            button10.Name = "button10";
            button10.Size = new Size(54, 51);
            button10.TabIndex = 10;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Numbers;
            // 
            // button11
            // 
            button11.FlatStyle = FlatStyle.Popup;
            button11.Location = new Point(12, 387);
            button11.Name = "button11";
            button11.Size = new Size(54, 51);
            button11.TabIndex = 11;
            button11.Text = "C";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Clear;
            // 
            // button12
            // 
            button12.FlatStyle = FlatStyle.Popup;
            button12.Location = new Point(132, 387);
            button12.Name = "button12";
            button12.Size = new Size(54, 51);
            button12.TabIndex = 12;
            button12.Text = ".";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Period;
            // 
            // button26
            // 
            button26.FlatStyle = FlatStyle.Popup;
            button26.Location = new Point(271, 292);
            button26.Name = "button26";
            button26.Size = new Size(70, 146);
            button26.TabIndex = 27;
            button26.Text = "=";
            button26.UseVisualStyleBackColor = true;
            button26.Click += Equals;
            // 
            // button23
            // 
            button23.FlatStyle = FlatStyle.Popup;
            button23.Location = new Point(192, 216);
            button23.Name = "button23";
            button23.Size = new Size(70, 68);
            button23.TabIndex = 28;
            button23.Text = "+";
            button23.UseVisualStyleBackColor = true;
            button23.Click += Operators;
            // 
            // button22
            // 
            button22.FlatStyle = FlatStyle.Popup;
            button22.Location = new Point(192, 292);
            button22.Name = "button22";
            button22.Size = new Size(70, 68);
            button22.TabIndex = 29;
            button22.Text = "-";
            button22.UseVisualStyleBackColor = true;
            button22.Click += Operators;
            // 
            // button24
            // 
            button24.FlatStyle = FlatStyle.Popup;
            button24.Location = new Point(192, 370);
            button24.Name = "button24";
            button24.Size = new Size(70, 68);
            button24.TabIndex = 30;
            button24.Text = "x";
            button24.UseVisualStyleBackColor = true;
            button24.Click += Operators;
            // 
            // button25
            // 
            button25.FlatStyle = FlatStyle.Popup;
            button25.Location = new Point(271, 216);
            button25.Name = "button25";
            button25.Size = new Size(70, 68);
            button25.TabIndex = 31;
            button25.Text = "/";
            button25.UseVisualStyleBackColor = true;
            button25.Click += Operators;
            // 
            // button20
            // 
            button20.FlatStyle = FlatStyle.Popup;
            button20.Location = new Point(264, 102);
            button20.Name = "button20";
            button20.Size = new Size(77, 51);
            button20.TabIndex = 32;
            button20.Text = "<--";
            button20.UseVisualStyleBackColor = true;
            button20.Click += Backspace;
            // 
            // button27
            // 
            button27.FlatStyle = FlatStyle.Popup;
            button27.Location = new Point(264, 159);
            button27.Name = "button27";
            button27.Size = new Size(77, 51);
            button27.TabIndex = 33;
            button27.Text = "+/-";
            button27.UseVisualStyleBackColor = true;
            button27.Click += Negation;
            // 
            // button13
            // 
            button13.FlatStyle = FlatStyle.Popup;
            button13.Location = new Point(181, 159);
            button13.Name = "button13";
            button13.Size = new Size(77, 51);
            button13.TabIndex = 34;
            button13.Text = ")";
            button13.UseVisualStyleBackColor = true;
            button13.Click += ParenthesisClose;
            // 
            // button14
            // 
            button14.FlatStyle = FlatStyle.Popup;
            button14.Location = new Point(181, 102);
            button14.Name = "button14";
            button14.Size = new Size(77, 51);
            button14.TabIndex = 35;
            button14.Text = "(";
            button14.UseVisualStyleBackColor = true;
            button14.Click += ParenthesisOpen;
            // 
            // button15
            // 
            button15.FlatStyle = FlatStyle.Popup;
            button15.Location = new Point(98, 102);
            button15.Name = "button15";
            button15.Size = new Size(77, 51);
            button15.TabIndex = 36;
            button15.Text = "x^2";
            button15.UseVisualStyleBackColor = true;
            button15.Click += Squared;
            // 
            // button16
            // 
            button16.FlatStyle = FlatStyle.Popup;
            button16.Location = new Point(98, 159);
            button16.Name = "button16";
            button16.Size = new Size(77, 51);
            button16.TabIndex = 37;
            button16.Text = "π";
            button16.UseVisualStyleBackColor = true;
            button16.Click += Pi;
            // 
            // button17
            // 
            button17.FlatStyle = FlatStyle.Popup;
            button17.Location = new Point(12, 102);
            button17.Name = "button17";
            button17.Size = new Size(77, 51);
            button17.TabIndex = 38;
            button17.Text = "%";
            button17.UseVisualStyleBackColor = true;
            button17.Click += Percent;
            // 
            // button18
            // 
            button18.FlatStyle = FlatStyle.Popup;
            button18.Location = new Point(12, 159);
            button18.Name = "button18";
            button18.Size = new Size(77, 51);
            button18.TabIndex = 39;
            button18.Text = "√";
            button18.UseVisualStyleBackColor = true;
            button18.Click += Sqrt;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 450);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button27);
            Controls.Add(button20);
            Controls.Add(button25);
            Controls.Add(button24);
            Controls.Add(button22);
            Controls.Add(button23);
            Controls.Add(button26);
            Controls.Add(button12);
            Controls.Add(button11);
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
        private Button button11;
        private Button button12;
        private Button button26;
        private Button button23;
        private Button button22;
        private Button button24;
        private Button button25;
        private Button button20;
        private Button button27;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
    }
}
