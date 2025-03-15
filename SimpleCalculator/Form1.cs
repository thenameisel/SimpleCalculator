using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {

        decimal calcValue = 0;
        decimal numOne = 0;
        decimal numTwo = 0;
        string operation = "";
        bool isDecimal = false;
        int decimalPlaces = 0;
        public Calculator()
        {
            InitializeComponent();
        }

        private void numberEntryClick(object sender, EventArgs e)
        {
            if (calcDisplay.Text.Length < 11)
            {
                Button b = (Button)sender;
                if (isDecimal)
                {
                    decimalPlaces++;
                    calcValue += decimal.Parse(b.Text) / (decimal)Math.Pow(10, decimalPlaces);
                    calcDisplay.Text = calcValue.ToString();
                    
                }
                else
                {
                    calcValue = (calcValue * 10) + decimal.Parse(b.Text);
                    calcDisplay.Text = calcValue.ToString();
                }
            }
        }
        private void periodEntryClick(object sender, EventArgs e)
        {
            if (calcDisplay.Text.Length < 12 && isDecimal!=true)
            {
                calcDisplay.Text += ".";
                isDecimal = true;
            }
        }
        private void backspaceClick(object sender, EventArgs e)
        {
            if (calcDisplay.Text.Length > 1)
            {
                if (calcDisplay.Text[calcDisplay.Text.Length - 1] == '.')
                {
                    isDecimal = false;
                    decimalPlaces = 0;
                }
                calcDisplay.Text = calcDisplay.Text.Remove(calcDisplay.Text.Length - 1);
                calcValue = decimal.Parse(calcDisplay.Text);
                decimalPlaces--;
                Console.WriteLine(calcValue);
            }
            else
            {
                calcDisplay.Text = "0";
                calcValue = 0;
            }
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (operation != "") { operation = b.Text; }
            else {
                operation = b.Text;
                numOne = calcValue;
                calcValue = 0;
                calcDisplay.Text = "0";
                decimalPlaces = 0;
                isDecimal = false;
                Console.WriteLine(operation);
                
            }
        }

        private void clearClick(object sender, EventArgs e)
        {
            calcValue = 0;
            numOne = 0;
            numTwo = 0;
            operation = "";
            isDecimal = false;
            decimalPlaces = 0;
            calcDisplay.Text = "0";
        }

        private void clearEntryClick(object sender, EventArgs e)
        {
            calcValue = 0;
            calcDisplay.Text = "0";
            isDecimal = false;
            decimalPlaces = 0;
        }

        private void negPosClick(object sender, EventArgs e) 
        { 
         if(calcValue != 0)
            {
                calcValue = calcValue * -1;
                calcDisplay.Text = calcValue.ToString();
            }
        }

        private void equalsClick(object sender, EventArgs e)
        {
            numTwo = calcValue;
            Console.WriteLine(numOne);
            Console.WriteLine(numTwo);

            if (operation == "/" && numTwo == 0)
            {
                calcDisplay.Text = "Err - Div by 0";
                
                return;
            }

            switch (operation)
            {
                case "+":
                    calcValue = numOne + numTwo;
                    break;
                case "-":
                    calcValue = numOne - numTwo;
                    break;
                case "X":
                    calcValue = numOne * numTwo;
                    break;
                case "/":
                    calcValue = numOne / numTwo;
                    break;
            }

            decimal.Round(calcValue, 4);
            string result = calcValue.ToString();
            if (result.Length > 12)
            {
                result = "Err - Too Lg";
            }

            calcDisplay.Text = result;
            numOne = 0;
            numTwo = 0;
            operation = "";
            isDecimal = false;
            decimalPlaces = 0;
        }

    }
}
