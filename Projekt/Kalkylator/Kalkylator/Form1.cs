using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Kalkylator
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string num1 = "";
        private string num2 = "";
        private string results = "";
        private string op = "";

        private string Addiation(string val1, string val2)
        {
            return (float.Parse(val1, CultureInfo.InvariantCulture.NumberFormat) + float.Parse(val2, CultureInfo.InvariantCulture.NumberFormat)).ToString();
        }
        private string Subtraction(string val1, string val2)
        {
            return (float.Parse(val1, CultureInfo.InvariantCulture.NumberFormat) - float.Parse(val2, CultureInfo.InvariantCulture.NumberFormat)).ToString();
        }
        private string Multipliaction(string val1, string val2)
        {
            return (float.Parse(val1, CultureInfo.InvariantCulture.NumberFormat) * float.Parse(val2, CultureInfo.InvariantCulture.NumberFormat)).ToString();
        }
        private string Divsion(string val1, string val2)
        {
            return (float.Parse(val1, CultureInfo.InvariantCulture.NumberFormat) / float.Parse(val2, CultureInfo.InvariantCulture.NumberFormat)).ToString();
        }

        private string squareRoot(string val1)
        {
            return Math.Sqrt(float.Parse(val1, CultureInfo.InvariantCulture.NumberFormat)).ToString();
        }

        private string reciprocal(string val1)
        {
            return (float.Parse("1", CultureInfo.InvariantCulture.NumberFormat) / float.Parse(val1, CultureInfo.InvariantCulture.NumberFormat)).ToString();
        }

        private void equalSymbol_Click(object sender, EventArgs e)
        {
            if(num1 == "" || op == "" || num2 == "") return;
            if (op == "/" && num2 == "0")
            {
                MessageBox.Show("Cannot divide by 0");
                return;
            }
            if (op == "+") results = Addiation(num1, num2);
            if (op == "-") results = Subtraction(num1, num2);
            if (op == "*") results = Multipliaction(num1, num2);
            if (op == "/") results = Divsion(num1, num2);

            num1 = results;
            op = "";
            num2 = "";
            result.Text = results;
        }
        private void plusSymbol_Click(object sender, EventArgs e)
        {
            if (num1 == "") return;
            if (op == "") op = "+";
                
            result.Text = num1 + " " + op + " " + num2;
        }
        private void minusSymbol_Click(object sender, EventArgs e)
        {
            if (num1 == "") return;
            if (op == "") op = "-";
            
            result.Text = num1 + " " + op + " " + num2;
        }
        private void multiSymbol_Click(object sender, EventArgs e)
        {
            if (num1 == "") return;
            if (op == "") op = "*";
          
            result.Text = num1 + " " + op + " " + num2;
        }
        private void divsionSymbol_Click(object sender, EventArgs e)
        {
            if (num1 == "") return;
            if (op == "") op = "/";
            
            result.Text = num1 + " " + op + " " + num2;
        }

        private void squareSymbol_Click(object sender, EventArgs e)
        {
            if (num1 == "" || num1=="-") return;
            result.Text = squareRoot(num1);
            num1 = squareRoot(num1);
            op = "";
            num2 = "";
        }
        private void reciprocalSymbol_Click(object sender, EventArgs e)
        {
            if (num1 == "" || num1 == "-") return;
            result.Text = reciprocal(num1);
            num1 = squareRoot(num1);
            op = "";
            num2 = "";
        }

        private void zeroSymbol_Click(object sender, EventArgs e)
        {
            if (op == "") num1 += "0";
            else num2 += "0";

            result.Text = num1 + " " + op + " " + num2;

        }

        private void oneSymbol_Click(object sender, EventArgs e)
        {
            if (op == "") num1 += "1";
            else num2 += "1";

            result.Text = num1 + " " + op + " " + num2;
        }

        private void twoSymbol_Click(object sender, EventArgs e)
        {
            if (op == "") num1 += "2";
            else num2 += "2";

            result.Text = num1 + " " + op + " " + num2;
        }

        private void threeSymbol_Click(object sender, EventArgs e)
        {
            if (op == "") num1 += "3";
            else num2 += "3";

            result.Text = num1 + " " + op + " " + num2;
        }

        private void fourSymbol_Click(object sender, EventArgs e)
        {
            if (op == "") num1 += "4";
            else num2 += "4";

            result.Text = num1 + " " + op + " " + num2;
        }

        private void fiveSymbol_Click(object sender, EventArgs e)
        {
            if (op == "") num1 += "5";
            else num2 += "5";

            result.Text = num1 + " " + op + " " + num2;
        }

        private void sixSymbol_Click(object sender, EventArgs e)
        {
            if (op == "") num1 += "6";
            else num2 += "6";

            result.Text = num1 + " " + op + " " + num2;
        }

        private void sevenSymbol_Click(object sender, EventArgs e)
        {
            if (op == "") num1 += "7";
            else num2 += "7";

            result.Text = num1 + " " + op + " " + num2;
        }

        private void eightSymbol_Click(object sender, EventArgs e)
        {
            if (op == "") num1 += "8";
            else num2 += "8";

            result.Text = num1 + " " + op + " " + num2;
        }

        private void nineSymbol_Click(object sender, EventArgs e)
        {
            if (op == "") num1 += "9";
            else num2 += "9";

            result.Text = num1 + " " + op + " " + num2;
        }


        private void ceSymbol_Click(object sender, EventArgs e)
        {
            if (num2 != "")
            {

                num2 = num2.Remove(num2.Length - 1);
                result.Text = num1 + " " + op + " " + num2;
                return;
            }

            if (op != "")
            {

                op = "";
                result.Text = num1 + " " + op + " " + num2;
                return;
            }

            if (num1 != "")
            {

                num1 = num1.Remove(num1.Length - 1);
                result.Text = num1 + " " + op + " " + num2;
                return;
            }

        }

        private void cSymbol_Click(object sender, EventArgs e)
        {
            num1 = "";
            num2 = "";
            op = "";
            results = "";
            result.Text = "";
        }

        private void decimalSymbol_Click(object sender, EventArgs e)
        {
            if (op == "") num1 += ".";
            else num2 += ".";

            result.Text = num1 + " " + op + " " + num2;
        }

        private void plusMinusSymbol_Click(object sender, EventArgs e)
        {
            if (num2 != "" || op != "")
            {

                if (num2.Contains("-")) num2 = num2.Replace("-", "");
                else num2 = "-" + num2;

                result.Text = num1 + " " + op + " " + num2;
                return;
            }

        
            if (num1.Contains("-")) num1 = num1.Replace("-", "");
            else num1 = "-" + num1;
            result.Text = num1 + " " + op + " " + num2;
            return;
            
        }
    }
}
