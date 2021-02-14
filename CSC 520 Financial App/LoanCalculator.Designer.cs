
namespace CSC_520_Financial_App
{
    partial class LoanCalculator
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
            this.components = new System.ComponentModel.Container();
            this.principalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.irErrorTextBox = new System.Windows.Forms.TextBox();
            this.termErrorTextBox = new System.Windows.Forms.TextBox();
            this.principalErrorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loanTermTextBox = new System.Windows.Forms.TextBox();
            this.termIntervalComboBox = new System.Windows.Forms.ComboBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mpLabel = new System.Windows.Forms.Label();
            this.monthlyPaymentTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loanAmountToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.irWholeNumberComboBox = new System.Windows.Forms.ComboBox();
            this.irDecimalComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // principalTextBox
            // 
            this.principalTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principalTextBox.Location = new System.Drawing.Point(121, 16);
            this.principalTextBox.Name = "principalTextBox";
            this.principalTextBox.Size = new System.Drawing.Size(113, 26);
            this.principalTextBox.TabIndex = 0;
            this.principalTextBox.Tag = "LoanAmount";
            this.loanAmountToolTip.SetToolTip(this.principalTextBox, "Enter a principle in the range of 0.00 to 100,000.00");
            this.principalTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.principalTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.principalTextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loan Amount $";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loan Term";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Interest Rate %";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.irDecimalComboBox);
            this.groupBox2.Controls.Add(this.irWholeNumberComboBox);
            this.groupBox2.Controls.Add(this.termErrorTextBox);
            this.groupBox2.Controls.Add(this.loanTermTextBox);
            this.groupBox2.Controls.Add(this.termIntervalComboBox);
            this.groupBox2.Controls.Add(this.calcButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.principalTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.irErrorTextBox);
            this.groupBox2.Controls.Add(this.principalErrorTextBox);
            this.groupBox2.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox2.Location = new System.Drawing.Point(12, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 301);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // irErrorTextBox
            // 
            this.irErrorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.irErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.irErrorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irErrorTextBox.ForeColor = System.Drawing.Color.Firebrick;
            this.irErrorTextBox.Location = new System.Drawing.Point(9, 124);
            this.irErrorTextBox.Multiline = true;
            this.irErrorTextBox.Name = "irErrorTextBox";
            this.irErrorTextBox.Size = new System.Drawing.Size(302, 40);
            this.irErrorTextBox.TabIndex = 28;
            this.irErrorTextBox.TabStop = false;
            this.irErrorTextBox.Visible = false;
            // 
            // termErrorTextBox
            // 
            this.termErrorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.termErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.termErrorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termErrorTextBox.ForeColor = System.Drawing.Color.Firebrick;
            this.termErrorTextBox.Location = new System.Drawing.Point(9, 200);
            this.termErrorTextBox.Multiline = true;
            this.termErrorTextBox.Name = "termErrorTextBox";
            this.termErrorTextBox.Size = new System.Drawing.Size(301, 36);
            this.termErrorTextBox.TabIndex = 27;
            this.termErrorTextBox.TabStop = false;
            this.termErrorTextBox.Visible = false;
            // 
            // principalErrorTextBox
            // 
            this.principalErrorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.principalErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.principalErrorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principalErrorTextBox.ForeColor = System.Drawing.Color.Firebrick;
            this.principalErrorTextBox.Location = new System.Drawing.Point(8, 46);
            this.principalErrorTextBox.Multiline = true;
            this.principalErrorTextBox.Name = "principalErrorTextBox";
            this.principalErrorTextBox.Size = new System.Drawing.Size(302, 36);
            this.principalErrorTextBox.TabIndex = 0;
            this.principalErrorTextBox.TabStop = false;
            this.principalErrorTextBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(171, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = ".";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // loanTermTextBox
            // 
            this.loanTermTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanTermTextBox.Location = new System.Drawing.Point(120, 170);
            this.loanTermTextBox.Name = "loanTermTextBox";
            this.loanTermTextBox.Size = new System.Drawing.Size(55, 21);
            this.loanTermTextBox.TabIndex = 3;
            this.loanTermTextBox.TextChanged += new System.EventHandler(this.loanTermTextBox_TextChanged);
            // 
            // termIntervalComboBox
            // 
            this.termIntervalComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.termIntervalComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.termIntervalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.termIntervalComboBox.FormattingEnabled = true;
            this.termIntervalComboBox.Items.AddRange(new object[] {
            "Years",
            "Months"});
            this.termIntervalComboBox.Location = new System.Drawing.Point(180, 170);
            this.termIntervalComboBox.Name = "termIntervalComboBox";
            this.termIntervalComboBox.Size = new System.Drawing.Size(63, 21);
            this.termIntervalComboBox.TabIndex = 4;
            this.termIntervalComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(8, 242);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(302, 53);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Caclulate";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mpLabel);
            this.groupBox3.Controls.Add(this.monthlyPaymentTextBox);
            this.groupBox3.Location = new System.Drawing.Point(334, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 301);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // mpLabel
            // 
            this.mpLabel.AutoSize = true;
            this.mpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mpLabel.Location = new System.Drawing.Point(6, 16);
            this.mpLabel.Name = "mpLabel";
            this.mpLabel.Size = new System.Drawing.Size(189, 25);
            this.mpLabel.TabIndex = 22;
            this.mpLabel.Text = "Monthly Payments";
            this.mpLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // monthlyPaymentTextBox
            // 
            this.monthlyPaymentTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.monthlyPaymentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.monthlyPaymentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyPaymentTextBox.Location = new System.Drawing.Point(72, 68);
            this.monthlyPaymentTextBox.Name = "monthlyPaymentTextBox";
            this.monthlyPaymentTextBox.ReadOnly = true;
            this.monthlyPaymentTextBox.Size = new System.Drawing.Size(123, 22);
            this.monthlyPaymentTextBox.TabIndex = 0;
            this.monthlyPaymentTextBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Monthly Loan Payment Calculator";
            // 
            // loanAmountToolTip
            // 
            this.loanAmountToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // irWholeNumberComboBox
            // 
            this.irWholeNumberComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.irWholeNumberComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.irWholeNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.irWholeNumberComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irWholeNumberComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.irWholeNumberComboBox.FormattingEnabled = true;
            this.irWholeNumberComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.irWholeNumberComboBox.Location = new System.Drawing.Point(121, 88);
            this.irWholeNumberComboBox.Name = "irWholeNumberComboBox";
            this.irWholeNumberComboBox.Size = new System.Drawing.Size(47, 26);
            this.irWholeNumberComboBox.TabIndex = 1;
            this.irWholeNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.irWholeNumberComboBox_SelectedIndexChanged);
            // 
            // irDecimalComboBox
            // 
            this.irDecimalComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.irDecimalComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.irDecimalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.irDecimalComboBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irDecimalComboBox.FormattingEnabled = true;
            this.irDecimalComboBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.irDecimalComboBox.Location = new System.Drawing.Point(196, 88);
            this.irDecimalComboBox.Name = "irDecimalComboBox";
            this.irDecimalComboBox.Size = new System.Drawing.Size(47, 26);
            this.irDecimalComboBox.TabIndex = 2;
            // 
            // LoanCalculator
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(612, 353);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "LoanCalculator";
            this.Text = "Monthly Loan Payment Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox principalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label mpLabel;
        private System.Windows.Forms.TextBox monthlyPaymentTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox loanTermTextBox;
        private System.Windows.Forms.ComboBox termIntervalComboBox;
        private System.Windows.Forms.TextBox principalErrorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox irErrorTextBox;
        private System.Windows.Forms.TextBox termErrorTextBox;
        private System.Windows.Forms.ToolTip loanAmountToolTip;
        private System.Windows.Forms.ComboBox irWholeNumberComboBox;
        private System.Windows.Forms.ComboBox irDecimalComboBox;
    }
}

