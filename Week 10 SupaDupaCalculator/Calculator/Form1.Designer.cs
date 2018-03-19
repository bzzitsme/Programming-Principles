﻿namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.TextBox();
            this.operationChanger = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.operationClearEntry = new System.Windows.Forms.Button();
            this.operationClear = new System.Windows.Forms.Button();
            this.operationPercent = new System.Windows.Forms.Button();
            this.operationInverse = new System.Windows.Forms.Button();
            this.operationEqual = new System.Windows.Forms.Button();
            this.operationSqrt = new System.Windows.Forms.Button();
            this.operationDivide = new System.Windows.Forms.Button();
            this.operationMultiply = new System.Windows.Forms.Button();
            this.operationSubstract = new System.Windows.Forms.Button();
            this.operationAdd = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(12, 12);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(260, 20);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // operationChanger
            // 
            this.operationChanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationChanger.Location = new System.Drawing.Point(215, 38);
            this.operationChanger.Name = "operationChanger";
            this.operationChanger.Size = new System.Drawing.Size(57, 41);
            this.operationChanger.TabIndex = 1;
            this.operationChanger.Text = "+/-";
            this.operationChanger.UseVisualStyleBackColor = true;
            this.operationChanger.Click += new System.EventHandler(this.operationEqualOthers_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(161, 38);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 41);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "⮾";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.operationClear_Click);
            // 
            // operationClearEntry
            // 
            this.operationClearEntry.Location = new System.Drawing.Point(106, 38);
            this.operationClearEntry.Name = "operationClearEntry";
            this.operationClearEntry.Size = new System.Drawing.Size(49, 41);
            this.operationClearEntry.TabIndex = 3;
            this.operationClearEntry.Text = "CE";
            this.operationClearEntry.UseVisualStyleBackColor = true;
            this.operationClearEntry.Click += new System.EventHandler(this.operationClear_Click);
            // 
            // operationClear
            // 
            this.operationClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationClear.Location = new System.Drawing.Point(52, 38);
            this.operationClear.Name = "operationClear";
            this.operationClear.Size = new System.Drawing.Size(48, 41);
            this.operationClear.TabIndex = 4;
            this.operationClear.Text = "C";
            this.operationClear.UseVisualStyleBackColor = true;
            this.operationClear.Click += new System.EventHandler(this.operationClear_Click);
            // 
            // operationPercent
            // 
            this.operationPercent.Location = new System.Drawing.Point(232, 138);
            this.operationPercent.Name = "operationPercent";
            this.operationPercent.Size = new System.Drawing.Size(40, 41);
            this.operationPercent.TabIndex = 5;
            this.operationPercent.Text = "%";
            this.operationPercent.UseVisualStyleBackColor = true;
            this.operationPercent.Click += new System.EventHandler(this.operationEqualOthers_Click);
            // 
            // operationInverse
            // 
            this.operationInverse.Location = new System.Drawing.Point(232, 185);
            this.operationInverse.Name = "operationInverse";
            this.operationInverse.Size = new System.Drawing.Size(40, 41);
            this.operationInverse.TabIndex = 6;
            this.operationInverse.Text = "1/x";
            this.operationInverse.UseVisualStyleBackColor = true;
            this.operationInverse.Click += new System.EventHandler(this.operationEqualOthers_Click);
            // 
            // operationEqual
            // 
            this.operationEqual.Location = new System.Drawing.Point(232, 232);
            this.operationEqual.Name = "operationEqual";
            this.operationEqual.Size = new System.Drawing.Size(40, 41);
            this.operationEqual.TabIndex = 7;
            this.operationEqual.Text = "=";
            this.operationEqual.UseVisualStyleBackColor = true;
            this.operationEqual.Click += new System.EventHandler(this.operationEqual_Click);
            // 
            // operationSqrt
            // 
            this.operationSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationSqrt.Location = new System.Drawing.Point(232, 91);
            this.operationSqrt.Name = "operationSqrt";
            this.operationSqrt.Size = new System.Drawing.Size(40, 41);
            this.operationSqrt.TabIndex = 8;
            this.operationSqrt.Text = "√";
            this.operationSqrt.UseVisualStyleBackColor = true;
            this.operationSqrt.Click += new System.EventHandler(this.operationEqualOthers_Click);
            // 
            // operationDivide
            // 
            this.operationDivide.Location = new System.Drawing.Point(186, 91);
            this.operationDivide.Name = "operationDivide";
            this.operationDivide.Size = new System.Drawing.Size(40, 41);
            this.operationDivide.TabIndex = 9;
            this.operationDivide.Text = "/";
            this.operationDivide.UseVisualStyleBackColor = true;
            this.operationDivide.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationMultiply
            // 
            this.operationMultiply.Location = new System.Drawing.Point(186, 138);
            this.operationMultiply.Name = "operationMultiply";
            this.operationMultiply.Size = new System.Drawing.Size(40, 41);
            this.operationMultiply.TabIndex = 10;
            this.operationMultiply.Text = "*";
            this.operationMultiply.UseVisualStyleBackColor = true;
            this.operationMultiply.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationSubstract
            // 
            this.operationSubstract.Location = new System.Drawing.Point(186, 185);
            this.operationSubstract.Name = "operationSubstract";
            this.operationSubstract.Size = new System.Drawing.Size(40, 41);
            this.operationSubstract.TabIndex = 11;
            this.operationSubstract.Text = "-";
            this.operationSubstract.UseVisualStyleBackColor = true;
            this.operationSubstract.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationAdd
            // 
            this.operationAdd.Location = new System.Drawing.Point(186, 232);
            this.operationAdd.Name = "operationAdd";
            this.operationAdd.Size = new System.Drawing.Size(40, 41);
            this.operationAdd.TabIndex = 12;
            this.operationAdd.Text = "+";
            this.operationAdd.UseVisualStyleBackColor = true;
            this.operationAdd.Click += new System.EventHandler(this.operation_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(140, 91);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 41);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(140, 138);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 41);
            this.btn6.TabIndex = 14;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(140, 185);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 41);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(140, 232);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(40, 41);
            this.button16.TabIndex = 16;
            this.button16.Text = ",";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.btn_click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(98, 91);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 41);
            this.btn8.TabIndex = 17;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(52, 91);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 41);
            this.btn7.TabIndex = 18;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(98, 138);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 41);
            this.btn5.TabIndex = 19;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(98, 185);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 41);
            this.btn2.TabIndex = 20;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_click);
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(52, 232);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(86, 41);
            this.btnPoint.TabIndex = 21;
            this.btnPoint.Text = "0";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btn_click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(52, 138);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 41);
            this.btn4.TabIndex = 22;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(52, 185);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 41);
            this.btn1.TabIndex = 23;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(284, 275);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.operationAdd);
            this.Controls.Add(this.operationSubstract);
            this.Controls.Add(this.operationMultiply);
            this.Controls.Add(this.operationDivide);
            this.Controls.Add(this.operationSqrt);
            this.Controls.Add(this.operationEqual);
            this.Controls.Add(this.operationInverse);
            this.Controls.Add(this.operationPercent);
            this.Controls.Add(this.operationClear);
            this.Controls.Add(this.operationClearEntry);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.operationChanger);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button operationChanger;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button operationClearEntry;
        private System.Windows.Forms.Button operationClear;
        private System.Windows.Forms.Button operationPercent;
        private System.Windows.Forms.Button operationInverse;
        private System.Windows.Forms.Button operationEqual;
        private System.Windows.Forms.Button operationSqrt;
        private System.Windows.Forms.Button operationDivide;
        private System.Windows.Forms.Button operationMultiply;
        private System.Windows.Forms.Button operationSubstract;
        private System.Windows.Forms.Button operationAdd;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
    }
}
