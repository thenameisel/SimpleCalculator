using System;
using System.CodeDom.Compiler;
using System.Windows.Forms.VisualStyles;

namespace SimpleCalculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.calcDisplay = new System.Windows.Forms.TextBox();
            this.button_NegPos = new System.Windows.Forms.Button();
            this.button_Equal = new System.Windows.Forms.Button();
            this.button_Period = new System.Windows.Forms.Button();
            this.button_Zero = new System.Windows.Forms.Button();
            this.button_Two = new System.Windows.Forms.Button();
            this.button_Three = new System.Windows.Forms.Button();
            this.button_Plus = new System.Windows.Forms.Button();
            this.button_One = new System.Windows.Forms.Button();
            this.button_Five = new System.Windows.Forms.Button();
            this.button_Six = new System.Windows.Forms.Button();
            this.button_Minus = new System.Windows.Forms.Button();
            this.button_Four = new System.Windows.Forms.Button();
            this.button_Eight = new System.Windows.Forms.Button();
            this.button_Nine = new System.Windows.Forms.Button();
            this.button_Multiply = new System.Windows.Forms.Button();
            this.button_Seven = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Divide = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcDisplay
            // 
            this.calcDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcDisplay.Location = new System.Drawing.Point(12, 12);
            this.calcDisplay.Name = "calcDisplay";
            this.calcDisplay.Size = new System.Drawing.Size(304, 57);
            this.calcDisplay.TabIndex = 0;
            this.calcDisplay.Text = "0";
            this.calcDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_NegPos
            // 
            this.button_NegPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NegPos.Location = new System.Drawing.Point(15, 379);
            this.button_NegPos.Name = "button_NegPos";
            this.button_NegPos.Size = new System.Drawing.Size(70, 70);
            this.button_NegPos.TabIndex = 1;
            this.button_NegPos.Text = "+/-";
            this.button_NegPos.UseVisualStyleBackColor = true;
            this.button_NegPos.Click += new System.EventHandler(this.negPosClick);
            // 
            // button_Equal
            // 
            this.button_Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Equal.Location = new System.Drawing.Point(243, 379);
            this.button_Equal.Name = "button_Equal";
            this.button_Equal.Size = new System.Drawing.Size(70, 70);
            this.button_Equal.TabIndex = 2;
            this.button_Equal.Text = "=";
            this.button_Equal.UseVisualStyleBackColor = true;
            this.button_Equal.Click += new System.EventHandler(this.equalsClick);
            // 
            // button_Period
            // 
            this.button_Period.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Period.Location = new System.Drawing.Point(167, 379);
            this.button_Period.Name = "button_Period";
            this.button_Period.Size = new System.Drawing.Size(70, 70);
            this.button_Period.TabIndex = 3;
            this.button_Period.Text = ".";
            this.button_Period.UseVisualStyleBackColor = true;
            this.button_Period.Click += new System.EventHandler(this.periodEntryClick);
            // 
            // button_Zero
            // 
            this.button_Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Zero.Location = new System.Drawing.Point(91, 379);
            this.button_Zero.Name = "button_Zero";
            this.button_Zero.Size = new System.Drawing.Size(70, 70);
            this.button_Zero.TabIndex = 4;
            this.button_Zero.Text = "0";
            this.button_Zero.UseVisualStyleBackColor = true;
            this.button_Zero.Click += new System.EventHandler(this.numberEntryClick);
            // 
            // button_Two
            // 
            this.button_Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Two.Location = new System.Drawing.Point(91, 303);
            this.button_Two.Name = "button_Two";
            this.button_Two.Size = new System.Drawing.Size(70, 70);
            this.button_Two.TabIndex = 8;
            this.button_Two.Text = "2";
            this.button_Two.UseVisualStyleBackColor = true;
            this.button_Two.Click += new System.EventHandler(this.numberEntryClick);
            // 
            // button_Three
            // 
            this.button_Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Three.Location = new System.Drawing.Point(167, 303);
            this.button_Three.Name = "button_Three";
            this.button_Three.Size = new System.Drawing.Size(70, 70);
            this.button_Three.TabIndex = 7;
            this.button_Three.Text = "3";
            this.button_Three.UseVisualStyleBackColor = true;
            this.button_Three.Click += new System.EventHandler(this.numberEntryClick);
            // 
            // button_Plus
            // 
            this.button_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Plus.Location = new System.Drawing.Point(243, 303);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(70, 70);
            this.button_Plus.TabIndex = 6;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = true;
            this.button_Plus.Click += new System.EventHandler(this.operatorClick);
            // 
            // button_One
            // 
            this.button_One.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_One.Location = new System.Drawing.Point(15, 303);
            this.button_One.Name = "button_One";
            this.button_One.Size = new System.Drawing.Size(70, 70);
            this.button_One.TabIndex = 5;
            this.button_One.Text = "1";
            this.button_One.UseVisualStyleBackColor = true;
            this.button_One.Click += new System.EventHandler(this.numberEntryClick);
            // 
            // button_Five
            // 
            this.button_Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Five.Location = new System.Drawing.Point(91, 227);
            this.button_Five.Name = "button_Five";
            this.button_Five.Size = new System.Drawing.Size(70, 70);
            this.button_Five.TabIndex = 12;
            this.button_Five.Text = "5";
            this.button_Five.UseVisualStyleBackColor = true;
            this.button_Five.Click += new System.EventHandler(this.numberEntryClick);
            // 
            // button_Six
            // 
            this.button_Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Six.Location = new System.Drawing.Point(167, 227);
            this.button_Six.Name = "button_Six";
            this.button_Six.Size = new System.Drawing.Size(70, 70);
            this.button_Six.TabIndex = 11;
            this.button_Six.Text = "6";
            this.button_Six.UseVisualStyleBackColor = true;
            this.button_Six.Click += new System.EventHandler(this.numberEntryClick);
            // 
            // button_Minus
            // 
            this.button_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minus.Location = new System.Drawing.Point(243, 227);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(70, 70);
            this.button_Minus.TabIndex = 10;
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = true;
            this.button_Minus.Click += new System.EventHandler(this.operatorClick);
            // 
            // button_Four
            // 
            this.button_Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Four.Location = new System.Drawing.Point(15, 227);
            this.button_Four.Name = "button_Four";
            this.button_Four.Size = new System.Drawing.Size(70, 70);
            this.button_Four.TabIndex = 9;
            this.button_Four.Text = "4";
            this.button_Four.UseVisualStyleBackColor = true;
            this.button_Four.Click += new System.EventHandler(this.numberEntryClick);
            // 
            // button_Eight
            // 
            this.button_Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Eight.Location = new System.Drawing.Point(91, 151);
            this.button_Eight.Name = "button_Eight";
            this.button_Eight.Size = new System.Drawing.Size(70, 70);
            this.button_Eight.TabIndex = 16;
            this.button_Eight.Text = "8";
            this.button_Eight.UseVisualStyleBackColor = true;
            this.button_Eight.Click += new System.EventHandler(this.numberEntryClick);
            // 
            // button_Nine
            // 
            this.button_Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Nine.Location = new System.Drawing.Point(167, 151);
            this.button_Nine.Name = "button_Nine";
            this.button_Nine.Size = new System.Drawing.Size(70, 70);
            this.button_Nine.TabIndex = 15;
            this.button_Nine.Text = "9";
            this.button_Nine.UseVisualStyleBackColor = true;
            this.button_Nine.Click += new System.EventHandler(this.numberEntryClick);
            // 
            // button_Multiply
            // 
            this.button_Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Multiply.Location = new System.Drawing.Point(243, 151);
            this.button_Multiply.Name = "button_Multiply";
            this.button_Multiply.Size = new System.Drawing.Size(70, 70);
            this.button_Multiply.TabIndex = 14;
            this.button_Multiply.Text = "X";
            this.button_Multiply.UseVisualStyleBackColor = true;
            this.button_Multiply.Click += new System.EventHandler(this.operatorClick);
            // 
            // button_Seven
            // 
            this.button_Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Seven.Location = new System.Drawing.Point(15, 151);
            this.button_Seven.Name = "button_Seven";
            this.button_Seven.Size = new System.Drawing.Size(70, 70);
            this.button_Seven.TabIndex = 13;
            this.button_Seven.Text = "7";
            this.button_Seven.UseVisualStyleBackColor = true;
            this.button_Seven.Click += new System.EventHandler(this.numberEntryClick);
            // 
            // button_C
            // 
            this.button_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_C.Location = new System.Drawing.Point(91, 75);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(70, 70);
            this.button_C.TabIndex = 20;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.clearClick);
            // 
            // button_Back
            // 
            this.button_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Back.Location = new System.Drawing.Point(167, 75);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(70, 70);
            this.button_Back.TabIndex = 19;
            this.button_Back.Text = "⌫";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.backspaceClick);
            // 
            // button_Divide
            // 
            this.button_Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Divide.Location = new System.Drawing.Point(243, 75);
            this.button_Divide.Name = "button_Divide";
            this.button_Divide.Size = new System.Drawing.Size(70, 70);
            this.button_Divide.TabIndex = 18;
            this.button_Divide.Text = "/";
            this.button_Divide.UseVisualStyleBackColor = true;
            this.button_Divide.Click += new System.EventHandler(this.operatorClick);
            // 
            // button_CE
            // 
            this.button_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CE.Location = new System.Drawing.Point(15, 75);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(70, 70);
            this.button_CE.TabIndex = 17;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = true;
            this.button_CE.Click += new System.EventHandler(this.clearEntryClick);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 462);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Divide);
            this.Controls.Add(this.button_CE);
            this.Controls.Add(this.button_Eight);
            this.Controls.Add(this.button_Nine);
            this.Controls.Add(this.button_Multiply);
            this.Controls.Add(this.button_Seven);
            this.Controls.Add(this.button_Five);
            this.Controls.Add(this.button_Six);
            this.Controls.Add(this.button_Minus);
            this.Controls.Add(this.button_Four);
            this.Controls.Add(this.button_Two);
            this.Controls.Add(this.button_Three);
            this.Controls.Add(this.button_Plus);
            this.Controls.Add(this.button_One);
            this.Controls.Add(this.button_Zero);
            this.Controls.Add(this.button_Period);
            this.Controls.Add(this.button_Equal);
            this.Controls.Add(this.button_NegPos);
            this.Controls.Add(this.calcDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calcDisplay;
        private System.Windows.Forms.Button button_NegPos;
        private System.Windows.Forms.Button button_Equal;
        private System.Windows.Forms.Button button_Period;
        private System.Windows.Forms.Button button_Zero;
        private System.Windows.Forms.Button button_Two;
        private System.Windows.Forms.Button button_Three;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.Button button_One;
        private System.Windows.Forms.Button button_Five;
        private System.Windows.Forms.Button button_Six;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.Button button_Four;
        private System.Windows.Forms.Button button_Eight;
        private System.Windows.Forms.Button button_Nine;
        private System.Windows.Forms.Button button_Multiply;
        private System.Windows.Forms.Button button_Seven;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Divide;
        private System.Windows.Forms.Button button_CE;
    }
}

