﻿namespace Calculator_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtBox = new TextBox();
            btn7 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn0 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btnPoint = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnEqual = new Button();
            btnC = new Button();
            btnCE = new Button();
            textBox1 = new TextBox();
            btnToggleTheme = new Button();
            lstHistory = new ListBox();
            btnClearHistory = new Button();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.BackColor = SystemColors.ActiveCaptionText;
            txtBox.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBox.ForeColor = Color.White;
            txtBox.Location = new Point(26, 50);
            txtBox.Margin = new Padding(5, 6, 5, 6);
            txtBox.Multiline = true;
            txtBox.Name = "txtBox";
            txtBox.ReadOnly = true;
            txtBox.Size = new Size(601, 160);
            txtBox.TabIndex = 0;
            txtBox.TabStop = false;
            txtBox.Text = "0";
            txtBox.TextAlign = HorizontalAlignment.Right;
            txtBox.TextChanged += txtBox_TextChanged;
            // 
            // btn7
            // 
            btn7.BackColor = Color.DimGray;
            btn7.FlatAppearance.BorderColor = Color.White;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btn7.ForeColor = SystemColors.ButtonHighlight;
            btn7.Location = new Point(28, 504);
            btn7.Margin = new Padding(5, 6, 5, 6);
            btn7.Name = "btn7";
            btn7.Size = new Size(137, 134);
            btn7.TabIndex = 1;
            btn7.TabStop = false;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.DimGray;
            btn4.FlatAppearance.BorderColor = Color.White;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btn4.ForeColor = SystemColors.ButtonHighlight;
            btn4.Location = new Point(26, 654);
            btn4.Margin = new Padding(5, 6, 5, 6);
            btn4.Name = "btn4";
            btn4.Size = new Size(137, 132);
            btn4.TabIndex = 2;
            btn4.TabStop = false;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.DimGray;
            btn1.FlatAppearance.BorderColor = Color.White;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btn1.ForeColor = SystemColors.ButtonHighlight;
            btn1.Location = new Point(29, 802);
            btn1.Margin = new Padding(5, 6, 5, 6);
            btn1.Name = "btn1";
            btn1.Size = new Size(137, 132);
            btn1.TabIndex = 3;
            btn1.TabStop = false;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.DimGray;
            btn0.FlatAppearance.BorderColor = Color.White;
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btn0.ForeColor = SystemColors.ButtonHighlight;
            btn0.Location = new Point(29, 950);
            btn0.Margin = new Padding(17, 20, 17, 20);
            btn0.Name = "btn0";
            btn0.Size = new Size(137, 132);
            btn0.TabIndex = 4;
            btn0.TabStop = false;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.DimGray;
            btn2.FlatAppearance.BorderColor = Color.White;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btn2.ForeColor = SystemColors.ButtonHighlight;
            btn2.Location = new Point(185, 802);
            btn2.Margin = new Padding(5, 6, 5, 6);
            btn2.Name = "btn2";
            btn2.Size = new Size(137, 132);
            btn2.TabIndex = 7;
            btn2.TabStop = false;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.DimGray;
            btn5.FlatAppearance.BorderColor = Color.White;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btn5.ForeColor = SystemColors.ButtonHighlight;
            btn5.Location = new Point(182, 654);
            btn5.Margin = new Padding(5, 6, 5, 6);
            btn5.Name = "btn5";
            btn5.Size = new Size(137, 132);
            btn5.TabIndex = 6;
            btn5.TabStop = false;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.DimGray;
            btn8.FlatAppearance.BorderColor = Color.White;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btn8.ForeColor = SystemColors.ButtonHighlight;
            btn8.Location = new Point(182, 504);
            btn8.Margin = new Padding(5, 6, 5, 6);
            btn8.Name = "btn8";
            btn8.Size = new Size(137, 134);
            btn8.TabIndex = 5;
            btn8.TabStop = false;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btnPoint
            // 
            btnPoint.BackColor = Color.DimGray;
            btnPoint.FlatAppearance.BorderColor = Color.White;
            btnPoint.FlatAppearance.BorderSize = 0;
            btnPoint.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnPoint.FlatStyle = FlatStyle.Flat;
            btnPoint.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnPoint.ForeColor = SystemColors.ButtonHighlight;
            btnPoint.Location = new Point(188, 951);
            btnPoint.Margin = new Padding(17, 20, 17, 20);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(137, 132);
            btnPoint.TabIndex = 12;
            btnPoint.TabStop = false;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = false;
            btnPoint.Click += btnPoint_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.DimGray;
            btn3.FlatAppearance.BorderColor = Color.White;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btn3.ForeColor = SystemColors.ButtonHighlight;
            btn3.Location = new Point(336, 802);
            btn3.Margin = new Padding(5, 6, 5, 6);
            btn3.Name = "btn3";
            btn3.Size = new Size(137, 132);
            btn3.TabIndex = 11;
            btn3.TabStop = false;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.DimGray;
            btn6.FlatAppearance.BorderColor = Color.White;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btn6.ForeColor = SystemColors.ButtonHighlight;
            btn6.Location = new Point(333, 654);
            btn6.Margin = new Padding(5, 6, 5, 6);
            btn6.Name = "btn6";
            btn6.Size = new Size(140, 132);
            btn6.TabIndex = 10;
            btn6.TabStop = false;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.DimGray;
            btn9.FlatAppearance.BorderColor = Color.White;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btn9.ForeColor = SystemColors.ButtonHighlight;
            btn9.Location = new Point(334, 504);
            btn9.Margin = new Padding(5, 6, 5, 6);
            btn9.Name = "btn9";
            btn9.Size = new Size(137, 134);
            btn9.TabIndex = 9;
            btn9.TabStop = false;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Orange;
            btnAdd.FlatAppearance.BorderColor = Color.White;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(339, 951);
            btnAdd.Margin = new Padding(17, 20, 17, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 132);
            btnAdd.TabIndex = 16;
            btnAdd.TabStop = false;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.Orange;
            btnSubtract.FlatAppearance.BorderColor = Color.Orange;
            btnSubtract.FlatAppearance.BorderSize = 0;
            btnSubtract.FlatAppearance.MouseOverBackColor = Color.Moccasin;
            btnSubtract.FlatStyle = FlatStyle.Flat;
            btnSubtract.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnSubtract.ForeColor = SystemColors.ButtonHighlight;
            btnSubtract.Location = new Point(489, 656);
            btnSubtract.Margin = new Padding(5, 6, 5, 6);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(135, 130);
            btnSubtract.TabIndex = 15;
            btnSubtract.TabStop = false;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.Orange;
            btnMultiply.FlatAppearance.BorderColor = Color.Orange;
            btnMultiply.FlatAppearance.BorderSize = 0;
            btnMultiply.FlatAppearance.MouseOverBackColor = Color.Moccasin;
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnMultiply.ForeColor = SystemColors.ButtonHighlight;
            btnMultiply.Location = new Point(489, 504);
            btnMultiply.Margin = new Padding(5, 6, 5, 6);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(135, 134);
            btnMultiply.TabIndex = 14;
            btnMultiply.TabStop = false;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.Orange;
            btnDivide.FlatAppearance.BorderColor = Color.Orange;
            btnDivide.FlatAppearance.BorderSize = 0;
            btnDivide.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnDivide.ForeColor = SystemColors.ButtonHighlight;
            btnDivide.Location = new Point(489, 358);
            btnDivide.Margin = new Padding(5, 6, 5, 6);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(138, 134);
            btnDivide.TabIndex = 13;
            btnDivide.TabStop = false;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.Orange;
            btnEqual.FlatAppearance.BorderColor = Color.Orange;
            btnEqual.FlatAppearance.BorderSize = 0;
            btnEqual.FlatAppearance.MouseOverBackColor = Color.Moccasin;
            btnEqual.FlatStyle = FlatStyle.Flat;
            btnEqual.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnEqual.ForeColor = SystemColors.ButtonHighlight;
            btnEqual.Location = new Point(489, 802);
            btnEqual.Margin = new Padding(17, 20, 17, 20);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(134, 281);
            btnEqual.TabIndex = 19;
            btnEqual.TabStop = false;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Orange;
            btnC.FlatAppearance.BorderColor = Color.Orange;
            btnC.FlatAppearance.BorderSize = 0;
            btnC.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnC.ForeColor = SystemColors.ButtonHighlight;
            btnC.Location = new Point(331, 358);
            btnC.Margin = new Padding(5, 6, 5, 6);
            btnC.Name = "btnC";
            btnC.Size = new Size(142, 134);
            btnC.TabIndex = 18;
            btnC.TabStop = false;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.Orange;
            btnCE.FlatAppearance.BorderColor = Color.Orange;
            btnCE.FlatAppearance.BorderSize = 0;
            btnCE.FlatAppearance.MouseOverBackColor = Color.Moccasin;
            btnCE.FlatStyle = FlatStyle.Flat;
            btnCE.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnCE.ForeColor = SystemColors.ButtonHighlight;
            btnCE.Location = new Point(25, 358);
            btnCE.Margin = new Padding(5, 6, 5, 6);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(294, 134);
            btnCE.TabIndex = 17;
            btnCE.TabStop = false;
            btnCE.Text = "AC";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnCE_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaptionText;
            textBox1.ForeColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(26, 219);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(603, 35);
            textBox1.TabIndex = 20;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnToggleTheme
            // 
            btnToggleTheme.Location = new Point(418, 279);
            btnToggleTheme.Name = "btnToggleTheme";
            btnToggleTheme.Size = new Size(211, 37);
            btnToggleTheme.TabIndex = 21;
            btnToggleTheme.Text = "Toggle Theme";
            btnToggleTheme.UseVisualStyleBackColor = true;
            btnToggleTheme.Click += btnToggleTheme_Click;
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.ItemHeight = 30;
            lstHistory.Location = new Point(25, 291);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(154, 64);
            lstHistory.TabIndex = 22;
            lstHistory.SelectedIndexChanged += lstHistory_SelectedIndexChanged;
            // 
            // btnClearHistory
            // 
            btnClearHistory.Location = new Point(25, 255);
            btnClearHistory.Name = "btnClearHistory";
            btnClearHistory.Size = new Size(154, 35);
            btnClearHistory.TabIndex = 16;
            btnClearHistory.Text = "Clear History";
            btnClearHistory.UseVisualStyleBackColor = true;
            btnClearHistory.Click += btnClearHistory_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(641, 1106);
            Controls.Add(btnClearHistory);
            Controls.Add(lstHistory);
            Controls.Add(btnToggleTheme);
            Controls.Add(textBox1);
            Controls.Add(btnEqual);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btnAdd);
            Controls.Add(btnSubtract);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnPoint);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(txtBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Calculator App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox;
        private Button btn7;
        private Button btn4;
        private Button btn1;
        private Button btn0;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private Button btnPoint;
        private Button btn3;
        private Button btn6;
        private Button btn9;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnEqual;
        private Button btnC;
        private Button btnCE;
        private TextBox textBox1;
        private Button btnToggleTheme;
        private ListBox lstHistory;
        private Button btnClearHistory;
    }
}
