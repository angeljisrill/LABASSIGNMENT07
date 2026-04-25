namespace LabAssignment07
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
            labelName = new Label();
            buttonClear = new Button();
            buttonDecimal = new Button();
            buttonDelete = new Button();
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
            button13 = new Button();
            button14 = new Button();
            textBox1 = new TextBox();
            button15 = new Button();
            SuspendLayout();

            // labelName
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            labelName.ForeColor = Color.Silver;
            labelName.Location = new Point(21, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(51, 23);
            labelName.TabIndex = 19;
            labelName.Text = "Angels";
            
            // textBox1 - Display (Enhanced for better visibility)
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold);
            textBox1.ForeColor = Color.Lime;
            textBox1.Location = new Point(21, 20);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(446, 55);
            textBox1.TabIndex = 14;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            
            // Row 1: 7, 8, 9, +
            button7.BackColor = Color.FromArgb(64, 64, 64);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(21, 90);
            button7.Name = "button7";
            button7.Size = new Size(100, 70);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            
            button8.BackColor = Color.FromArgb(64, 64, 64);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            button8.ForeColor = Color.White;
            button8.Location = new Point(131, 90);
            button8.Name = "button8";
            button8.Size = new Size(100, 70);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            
            button9.BackColor = Color.FromArgb(64, 64, 64);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            button9.ForeColor = Color.White;
            button9.Location = new Point(241, 90);
            button9.Name = "button9";
            button9.Size = new Size(100, 70);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            
            button10.BackColor = Color.Orange;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            button10.ForeColor = Color.White;
            button10.Location = new Point(351, 90);
            button10.Name = "button10";
            button10.Size = new Size(116, 70);
            button10.TabIndex = 9;
            button10.Text = "+";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            
            // Row 2: 4, 5, 6, -
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(21, 170);
            button4.Name = "button4";
            button4.Size = new Size(100, 70);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            
            button5.BackColor = Color.FromArgb(64, 64, 64);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(131, 170);
            button5.Name = "button5";
            button5.Size = new Size(100, 70);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            
            button6.BackColor = Color.FromArgb(64, 64, 64);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(241, 170);
            button6.Name = "button6";
            button6.Size = new Size(100, 70);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            
            button11.BackColor = Color.Orange;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            button11.ForeColor = Color.White;
            button11.Location = new Point(351, 170);
            button11.Name = "button11";
            button11.Size = new Size(116, 70);
            button11.TabIndex = 10;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            
            // Row 3: 1, 2, 3, /
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(21, 250);
            button1.Name = "button1";
            button1.Size = new Size(100, 70);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(131, 250);
            button2.Name = "button2";
            button2.Size = new Size(100, 70);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(241, 250);
            button3.Name = "button3";
            button3.Size = new Size(100, 70);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            
            button12.BackColor = Color.Orange;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            button12.ForeColor = Color.White;
            button12.Location = new Point(351, 250);
            button12.Name = "button12";
            button12.Size = new Size(116, 70);
            button12.TabIndex = 11;
            button12.Text = "/";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            
            // Row 4: 0, ., DEL, *
            button14.BackColor = Color.FromArgb(64, 64, 64);
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            button14.ForeColor = Color.White;
            button14.Location = new Point(21, 330);
            button14.Name = "button14";
            button14.Size = new Size(100, 70);
            button14.TabIndex = 13;
            button14.Text = "0";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            
            buttonDecimal.BackColor = Color.DimGray;
            buttonDecimal.FlatStyle = FlatStyle.Flat;
            buttonDecimal.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            buttonDecimal.ForeColor = Color.White;
            buttonDecimal.Location = new Point(131, 330);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(100, 70);
            buttonDecimal.TabIndex = 17;
            buttonDecimal.Text = ".";
            buttonDecimal.UseVisualStyleBackColor = false;
            buttonDecimal.Click += buttonDecimal_Click;
            
            buttonDelete.BackColor = Color.Crimson;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(241, 330);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 70);
            buttonDelete.TabIndex = 18;
            buttonDelete.Text = "DEL";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            
            button13.BackColor = Color.Orange;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            button13.ForeColor = Color.White;
            button13.Location = new Point(351, 330);
            button13.Name = "button13";
            button13.Size = new Size(116, 70);
            button13.TabIndex = 12;
            button13.Text = "*";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            
            // Row 5: C and =
            buttonClear.BackColor = Color.IndianRed;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(21, 410);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(100, 70);
            buttonClear.TabIndex = 16;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            
            button15.BackColor = Color.MediumSeaGreen;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            button15.ForeColor = Color.White;
            button15.Location = new Point(131, 410);
            button15.Name = "button15";
            button15.Size = new Size(336, 70);
            button15.TabIndex = 15;
            button15.Text = "=";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            
            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(488, 500);
            Controls.Add(labelName);
            Controls.Add(buttonDelete);
            Controls.Add(buttonDecimal);
            Controls.Add(buttonClear);
            Controls.Add(button15);
            Controls.Add(textBox1);
            Controls.Add(button14);
            Controls.Add(button13);
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
            KeyPreview = true;
            Name = "Form1";
            Text = "Angels Basic Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Button buttonClear;
        private Button buttonDecimal;
        private Button buttonDelete;
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
        private Button button13;
        private Button button14;
        private TextBox textBox1;
        private Button button15;
    }
}
