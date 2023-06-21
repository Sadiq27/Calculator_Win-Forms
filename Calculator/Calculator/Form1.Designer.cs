namespace Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_sum = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_fullClear = new System.Windows.Forms.Button();
            this.button_comma = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.history_label = new System.Windows.Forms.Label();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.HistoryListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(568, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 73);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(408, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 73);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(488, 392);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 73);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(568, 392);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 73);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(408, 313);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 73);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(488, 313);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 73);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(568, 313);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 73);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button_division
            // 
            this.button_division.Location = new System.Drawing.Point(647, 313);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(74, 73);
            this.button_division.TabIndex = 9;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.operation_Click);
            // 
            // button_CE
            // 
            this.button_CE.Location = new System.Drawing.Point(727, 313);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(74, 73);
            this.button_CE.TabIndex = 10;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = true;
            // 
            // button_sum
            // 
            this.button_sum.Location = new System.Drawing.Point(647, 550);
            this.button_sum.Name = "button_sum";
            this.button_sum.Size = new System.Drawing.Size(74, 73);
            this.button_sum.TabIndex = 11;
            this.button_sum.Text = "+";
            this.button_sum.UseVisualStyleBackColor = true;
            this.button_sum.Click += new System.EventHandler(this.operation_Click);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(647, 471);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(74, 73);
            this.button_minus.TabIndex = 12;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.operation_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.Location = new System.Drawing.Point(648, 392);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(74, 73);
            this.button_multiply.TabIndex = 13;
            this.button_multiply.Text = "*";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.operation_Click);
            // 
            // button_fullClear
            // 
            this.button_fullClear.Location = new System.Drawing.Point(728, 392);
            this.button_fullClear.Name = "button_fullClear";
            this.button_fullClear.Size = new System.Drawing.Size(74, 73);
            this.button_fullClear.TabIndex = 14;
            this.button_fullClear.Text = "C";
            this.button_fullClear.UseVisualStyleBackColor = true;
            this.button_fullClear.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_comma
            // 
            this.button_comma.Location = new System.Drawing.Point(568, 550);
            this.button_comma.Name = "button_comma";
            this.button_comma.Size = new System.Drawing.Size(74, 73);
            this.button_comma.TabIndex = 16;
            this.button_comma.Text = ",";
            this.button_comma.UseVisualStyleBackColor = true;
            this.button_comma.Click += new System.EventHandler(this.button_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(408, 550);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(154, 73);
            this.button0.TabIndex = 17;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // button_equal
            // 
            this.button_equal.Location = new System.Drawing.Point(727, 471);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(74, 152);
            this.button_equal.TabIndex = 19;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // history_label
            // 
            this.history_label.AutoSize = true;
            this.history_label.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.history_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.history_label.Location = new System.Drawing.Point(422, 201);
            this.history_label.Name = "history_label";
            this.history_label.Size = new System.Drawing.Size(0, 31);
            this.history_label.TabIndex = 21;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(408, 259);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(393, 27);
            this.textBox_Result.TabIndex = 22;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HistoryListBox
            // 
            this.HistoryListBox.FormattingEnabled = true;
            this.HistoryListBox.ItemHeight = 20;
            this.HistoryListBox.Location = new System.Drawing.Point(167, 179);
            this.HistoryListBox.Name = "HistoryListBox";
            this.HistoryListBox.Size = new System.Drawing.Size(221, 444);
            this.HistoryListBox.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 661);
            this.Controls.Add(this.HistoryListBox);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.history_label);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button_comma);
            this.Controls.Add(this.button_fullClear);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_sum);
            this.Controls.Add(this.button_CE);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button_division;
        private Button button_CE;
        private Button button_sum;
        private Button button_minus;
        private Button button_multiply;
        private Button button_fullClear;
        private Button button_comma;
        private Button button0;
        private Button button_equal;
        private Label history_label;
        private TextBox textBox_Result;
        private ListBox HistoryListBox;
    }
}