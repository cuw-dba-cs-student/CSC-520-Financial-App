using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSC_520_Financial_App
{
    public partial class LoanCalculator : Form
    {
        public LoanCalculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // Form Inputs
            int principal, loanTerm;
            double interestRate;
            string termInterval;

            // Loan Payment Formula Variables
            double mir, tmp;
            int nlp;

            errorTextBox.Text = "";
            errorTextBox.Visible = false;

            // Validate Loan Amount Input
            if (String.IsNullOrEmpty(principalTextBox.Text))
            {
                errorTextBox.Text = "You must enter a Loan Amount";
                errorTextBox.Visible = true;
                return;
            }
            else
            {
                if (Int32.TryParse(principalTextBox.Text, out principal)) { }
                else
                {
                    errorTextBox.Text = "Loan Amount must be a whole number without any punctuation (e.g. $ , .)";
                    errorTextBox.Visible = true;
                    return;
                }
            }
            // Validate Loan Term Input
            if (String.IsNullOrEmpty(loanTermTextBox.Text))
            {
                errorTextBox.Text = "You must enter a Loan Term";
                errorTextBox.Visible = true;
                return;
            }
            else
            {
                if (Int32.TryParse(loanTermTextBox.Text, out loanTerm)) { }
                else
                {
                    errorTextBox.Text = "Loan Term must be a whole number";
                    errorTextBox.Visible = true;
                    return;
                }
            }
            // Validate Interest Rate Input
            if (String.IsNullOrEmpty(interestRateTextBox.Text))
            {
                errorTextBox.Text = "You must enter an Interest Rate";
                errorTextBox.Visible = true;
                return;
            }
            else
            {
                if (Double.TryParse(interestRateTextBox.Text, out interestRate))
                {
                    if (interestRate < 1)
                    {
                        errorTextBox.Text = "Interest Rate must be greater than 1%";
                        errorTextBox.Visible = true;
                        return;
                    }
                }
                else
                {
                    errorTextBox.Text = "Interest Rate must be a number (do not enter the percent '%' symbol)";
                    errorTextBox.Visible = true;
                    return;
                }
            }

            termInterval = Convert.ToString(termIntervalComboBox.SelectedItem);

            if (termInterval == "Months")
            {
                nlp = loanTerm;
            }
            else
            {
                nlp = loanTerm * 12;
            }


            mir = (interestRate / 100) / 12;
            //MessageBox.Show(Convert.ToString(nlp));
            //MessageBox.Show(Convert.ToString(mir));
            //MessageBox.Show(Convert.ToString(principal));
            //Math.Pow(value, power)
            tmp = principal * ((mir * Math.Pow((1 + mir), nlp)) / (Math.Pow((1 + mir), nlp) - 1));
            tmp = Math.Round(tmp, 2);

            monthlyPaymentTextBox.Text = "$" + Convert.ToString(tmp);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            errorTextBox.Text = "";
            errorTextBox.Visible = false;
            principalTextBox.Text = "";
            interestRateTextBox.Text = "";
            loanTermTextBox.Text = "";
            monthlyPaymentTextBox.Text = "";
            termIntervalComboBox.SelectedItem = termIntervalComboBox.Items[0];
        }

        private void principalTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void loanTermTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
