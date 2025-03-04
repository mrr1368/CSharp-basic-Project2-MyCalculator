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
            txtCalculator = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn00 = new Button();
            btnNoghteh = new Button();
            btn0 = new Button();
            btnMul = new Button();
            btnSub = new Button();
            btnSum = new Button();
            btnEqual = new Button();
            btnDiv = new Button();
            btnC = new Button();
            txtResult = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtCalculator
            // 
            txtCalculator.BackColor = Color.LightGray;
            txtCalculator.BorderStyle = BorderStyle.None;
            txtCalculator.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCalculator.Location = new Point(12, 20);
            txtCalculator.MaxLength = 15;
            txtCalculator.Multiline = true;
            txtCalculator.Name = "txtCalculator";
            txtCalculator.ReadOnly = true;
            txtCalculator.RightToLeft = RightToLeft.No;
            txtCalculator.Size = new Size(446, 61);
            txtCalculator.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Font = new Font("Tahoma", 9F);
            btn1.Location = new Point(12, 348);
            btn1.Name = "btn1";
            btn1.Size = new Size(107, 65);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Font = new Font("Tahoma", 9F);
            btn2.Location = new Point(125, 348);
            btn2.Name = "btn2";
            btn2.Size = new Size(107, 65);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Font = new Font("Tahoma", 9F);
            btn3.Location = new Point(238, 348);
            btn3.Name = "btn3";
            btn3.Size = new Size(107, 65);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Font = new Font("Tahoma", 9F);
            btn4.Location = new Point(12, 278);
            btn4.Name = "btn4";
            btn4.Size = new Size(107, 65);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Font = new Font("Tahoma", 9F);
            btn5.Location = new Point(125, 278);
            btn5.Name = "btn5";
            btn5.Size = new Size(107, 65);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Font = new Font("Tahoma", 9F);
            btn6.Location = new Point(238, 278);
            btn6.Name = "btn6";
            btn6.Size = new Size(107, 65);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Font = new Font("Tahoma", 9F);
            btn7.Location = new Point(12, 208);
            btn7.Name = "btn7";
            btn7.Size = new Size(107, 65);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Font = new Font("Tahoma", 9F);
            btn8.Location = new Point(125, 208);
            btn8.Name = "btn8";
            btn8.Size = new Size(107, 65);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Font = new Font("Tahoma", 9F);
            btn9.Location = new Point(238, 208);
            btn9.Name = "btn9";
            btn9.Size = new Size(107, 65);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn00
            // 
            btn00.Font = new Font("Tahoma", 9F);
            btn00.Location = new Point(12, 418);
            btn00.Name = "btn00";
            btn00.Size = new Size(107, 65);
            btn00.TabIndex = 10;
            btn00.Text = "00";
            btn00.UseVisualStyleBackColor = true;
            // 
            // btnNoghteh
            // 
            btnNoghteh.Font = new Font("Tahoma", 9F);
            btnNoghteh.Location = new Point(238, 418);
            btnNoghteh.Name = "btnNoghteh";
            btnNoghteh.Size = new Size(107, 65);
            btnNoghteh.TabIndex = 11;
            btnNoghteh.Text = ".";
            btnNoghteh.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Font = new Font("Tahoma", 9F);
            btn0.Location = new Point(125, 418);
            btn0.Name = "btn0";
            btn0.Size = new Size(107, 65);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnMul
            // 
            btnMul.Font = new Font("Tahoma", 9F);
            btnMul.Location = new Point(351, 208);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(107, 65);
            btnMul.TabIndex = 13;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Tahoma", 9F);
            btnSub.Location = new Point(351, 278);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(107, 65);
            btnSub.TabIndex = 14;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            // 
            // btnSum
            // 
            btnSum.Font = new Font("Tahoma", 9F);
            btnSum.Location = new Point(351, 348);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(107, 65);
            btnSum.TabIndex = 15;
            btnSum.Text = "+";
            btnSum.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Tahoma", 15F);
            btnEqual.Location = new Point(351, 418);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(107, 65);
            btnEqual.TabIndex = 16;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Tahoma", 9F);
            btnDiv.Location = new Point(351, 138);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(107, 65);
            btnDiv.TabIndex = 17;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Font = new Font("Tahoma", 9F);
            btnC.Location = new Point(12, 138);
            btnC.Name = "btnC";
            btnC.Size = new Size(220, 65);
            btnC.TabIndex = 18;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.LightGray;
            txtResult.BorderStyle = BorderStyle.None;
            txtResult.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(12, 77);
            txtResult.MaxLength = 15;
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.RightToLeft = RightToLeft.No;
            txtResult.Size = new Size(446, 55);
            txtResult.TabIndex = 21;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Tahoma", 9F);
            btnBack.Location = new Point(238, 138);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 65);
            btnBack.TabIndex = 22;
            btnBack.Text = "->";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = btnEqual;
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            CancelButton = btnC;
            ClientSize = new Size(476, 503);
            Controls.Add(btnBack);
            Controls.Add(txtResult);
            Controls.Add(btnC);
            Controls.Add(btnDiv);
            Controls.Add(btnEqual);
            Controls.Add(btnSum);
            Controls.Add(btnSub);
            Controls.Add(btnMul);
            Controls.Add(btn0);
            Controls.Add(btnNoghteh);
            Controls.Add(btn00);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtCalculator);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCalculator;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn00;
        private Button btnNoghteh;
        private Button btn0;
        private Button btnMul;
        private Button btnSub;
        private Button btnSum;
        private Button btnEqual;
        private Button btnDiv;
        private Button btnC;
        private TextBox txtResult;
        private Button btnBack;
    }
}
