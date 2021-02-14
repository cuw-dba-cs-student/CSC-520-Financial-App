using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Globalization;

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

        /*
         * calcButton_Click: 
         *   Main program method that validates input and calculates monthly loan payments when the user
         *   clicks the "Calculate" button.
         */
        private void calcButton_Click(object sender, EventArgs e)
        {
            // input variables
            double principal, interestRate;
            string termInterval;
            int loanTerm;
            
            // Loan Payment Formula Variables
            double mthIntRate, mthlyPmt;            


            // Clear all output from the calculator form
            clearOutputText();

            // Get and validate the inputed principal amount 
            principal = getPrincipalAmount();
            
            // Exit this method if "-999.999" was returned.
            // "-999.999" is an error code that means the user inputed an invalid princiapl amount.
            if (principal == -999.999) { return; }

            // Exit this method if "-999.999" was returned.
            // "-999.999" is an error code that means the user inputed an invalid interest rate.
            interestRate = getInterestRate();
            if (interestRate == -999.999) { return; }            

            loanTerm = getLoanTerm();
            // Exit this method if "-999.999" was returned.
            // "-999.999" is an error code that means the user inputed an invalid term.
            if (loanTerm == -999) { return; }


            // calc monthly interst rate
            mthIntRate = (interestRate / 100) / 12;

            
            mthlyPmt = principal * ( ( mthIntRate * Math.Pow((1 + mthIntRate), loanTerm) ) / ( Math.Pow( (1 + mthIntRate), loanTerm) - 1 ) );
            
            // Round the monthly payment to two decimal places.
            mthlyPmt = Math.Round(mthlyPmt, 2);

            monthlyPaymentTextBox.Text = "$" + Convert.ToString(mthlyPmt);
            
        }

        /*
         * getPrincipalAmount: returns double
         *   Read and validate that the text entered into textbox "principalTextBox" 
         *   is a valid number between 0.00 and 100,000.00. If invalid input is encountered
         *   then set appropriate error text in textbox "principalErrorTextBox" and return
         *   an error code, otherwise parse and return a double from textbox "principalTextBox"   
         *   text.
         */
        public double getPrincipalAmount()
        {
            double principal;

            // Check if the user forgot to enter a loan amount.
            if (String.IsNullOrEmpty(principalTextBox.Text))
            {
                principalErrorTextBox.Text = "You must enter a Loan Amount";
                principalErrorTextBox.Visible = true;
                return -999.999;
            }
            // Houston we have input so let's go see if there's a problem...            
            else
            {
                // Use .Net Double.TryParse with the appropriate NumberStyles and CultureInfo to parse the text.
                // Return parsed double if valid otherwise set error text and return an error code. 
                // NumberStyles.Number and NumberStyles.AllowCurrencySymbol can parse strings like 1000.03, or 1,000.03 or $1000.03 or $1,000.03.
                if (Double.TryParse(principalTextBox.Text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, new CultureInfo("en-US"), out principal)) 
                {
                    if (principal < 0)
                    {
                        principalErrorTextBox.Text = "Loan amount must be greater than 0.";
                        principalErrorTextBox.Visible = true;
                        return -999.999;
                    }
                    else if (principal > 100000)
                    {
                        principalErrorTextBox.Text = "Loan amount must be less than 100,000.00";
                        principalErrorTextBox.Visible = true;
                        return -999.999;
                    }
                    else
                    {
                        return principal;
                    }                    
                }
                else
                {
                    principalErrorTextBox.Text = "Invalid loan amount.";
                    principalErrorTextBox.Visible = true;
                    return -999.999;
                }
            }
        }

        /*
        * getInterestRate: returns double
        *   Read and validate that values were entered into comboboxes "irWholeNumberComboBox"  
        *   and "irWholeNumberComboBox". These combo boxes are pre-setup with validated input.
        *   Only throw an error and return the error code if an input wasn't selected otherwise
        *   create an interest rate double from the input values.
        */
        public double getInterestRate()
        {            
            string ir; 

            // Check if the user forgot to enter an interest rate.
            if (String.IsNullOrEmpty(irWholeNumberComboBox.Text))
            {
                irErrorTextBox.Text = "You must enter/select an Interest Rate";
                irErrorTextBox.Visible = true;
                return -999.99;
            }
            else if (String.IsNullOrEmpty(irDecimalComboBox.Text))
            {
                irErrorTextBox.Text = "You must enter/select an Interest Rate";
                irErrorTextBox.Visible = true;
                return -999.999;
            }
            else
            {
                ir = Convert.ToString(irWholeNumberComboBox.SelectedItem) + '.' + Convert.ToString(irDecimalComboBox.SelectedItem);
                return Convert.ToDouble(ir);                 
            }
        }

        /*
        * getLoanTerm: returns int
        *   Read and validate that the text entered into textbox "loanTermTextBox" 
        *   is a valid period in the range of 0 to 1,200 months or 0 to 100 years
        *   If invalid then set appropriate error text in textbox "termErrorTextBox" and return
        *   an error code, otherwise parse and return an int from textbox "loanTermTextBox"   
        *   text.
        */
        public int getLoanTerm()
        {
            int loanTerm;
            string termInterval;

            if (String.IsNullOrEmpty(loanTermTextBox.Text))
            {                
                termErrorTextBox.Text = "You must enter a Loan Term";
                termErrorTextBox.Visible = true;
                return -999;
            }
            else
            {
                if (String.IsNullOrEmpty(Convert.ToString(termIntervalComboBox.SelectedItem)))
                {
                    termErrorTextBox.Text = "You must select a loan period of months or years.";
                    termErrorTextBox.Visible = true;
                    return -999;
                }
                else
                {
                    if (Int32.TryParse(loanTermTextBox.Text, NumberStyles.AllowThousands, new CultureInfo("en-US"), out loanTerm))
                    {
                        termInterval = Convert.ToString(termIntervalComboBox.SelectedItem);                        
                        //0 to 1,200 month and 0 to 100 years
                        if (termInterval == "Months")
                        {
                            if(loanTerm < 0)
                            {
                                termErrorTextBox.Text = "The loan term must be greater than 0 months.";
                                termErrorTextBox.Visible = true;
                                return -999;
                            }
                            else if (loanTerm > 1200)
                            {
                                termErrorTextBox.Text = "The loan term must be less than 1200 months.";
                                termErrorTextBox.Visible = true;
                                return -999;
                            }
                            return loanTerm;
                        }
                        else
                        {
                            if (loanTerm < 0)
                            {
                                termErrorTextBox.Text = "The loan term must be greater than 0 years.";
                                termErrorTextBox.Visible = true;
                                return -999;
                            }
                            else if (loanTerm > 1200)
                            {
                                termErrorTextBox.Text = "The loan term must be less than 100 years.";
                                termErrorTextBox.Visible = true;
                                return -999;
                            }
                            return loanTerm * 12;
                        }
                    }
                    else
                    {
                        termErrorTextBox.Text = "Invalid loan term.";
                        termErrorTextBox.Visible = true;
                        return -999;
                    }
                }
            }

        }

        public void clearOutputText()
        {
            principalErrorTextBox.Text = "";
            irErrorTextBox.Text = "";
            termErrorTextBox.Text = "";
            monthlyPaymentTextBox.Text = "";
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
        

        private void principalTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void loanTermTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void irWholeNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
