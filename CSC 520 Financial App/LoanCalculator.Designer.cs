
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
            this.principalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorTextBox = new System.Windows.Forms.TextBox();
            this.loanTermTextBox = new System.Windows.Forms.TextBox();
            this.termIntervalComboBox = new System.Windows.Forms.ComboBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mpLabel = new System.Windows.Forms.Label();
            this.monthlyPaymentTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // principalTextBox
            // 
            this.principalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principalTextBox.Location = new System.Drawing.Point(120, 19);
            this.principalTextBox.Name = "principalTextBox";
            this.principalTextBox.Size = new System.Drawing.Size(131, 21);
            this.principalTextBox.TabIndex = 0;
            this.principalTextBox.Tag = "LoanAmount";
            this.principalTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.principalTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.principalTextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(5, 22);
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
            this.label2.Location = new System.Drawing.Point(5, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loan Term";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(175, 181);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(74, 53);
            this.resetButton.TabIndex = 19;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Interest Rate %";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestRateTextBox.Location = new System.Drawing.Point(120, 91);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(131, 21);
            this.interestRateTextBox.TabIndex = 20;
            this.interestRateTextBox.Tag = "LoanAmount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.errorTextBox);
            this.groupBox2.Controls.Add(this.resetButton);
            this.groupBox2.Controls.Add(this.loanTermTextBox);
            this.groupBox2.Controls.Add(this.termIntervalComboBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.calcButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.interestRateTextBox);
            this.groupBox2.Controls.Add(this.principalTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 241);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // errorTextBox
            // 
            this.errorTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.errorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTextBox.ForeColor = System.Drawing.Color.Firebrick;
            this.errorTextBox.Location = new System.Drawing.Point(9, 118);
            this.errorTextBox.Multiline = true;
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.Size = new System.Drawing.Size(242, 57);
            this.errorTextBox.TabIndex = 0;
            this.errorTextBox.Visible = false;
            // 
            // loanTermTextBox
            // 
            this.loanTermTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanTermTextBox.Location = new System.Drawing.Point(120, 55);
            this.loanTermTextBox.Name = "loanTermTextBox";
            this.loanTermTextBox.Size = new System.Drawing.Size(55, 21);
            this.loanTermTextBox.TabIndex = 23;
            this.loanTermTextBox.TextChanged += new System.EventHandler(this.loanTermTextBox_TextChanged);
            // 
            // termIntervalComboBox
            // 
            this.termIntervalComboBox.FormattingEnabled = true;
            this.termIntervalComboBox.Items.AddRange(new object[] {
            "Years",
            "Months"});
            this.termIntervalComboBox.Location = new System.Drawing.Point(177, 55);
            this.termIntervalComboBox.Name = "termIntervalComboBox";
            this.termIntervalComboBox.Size = new System.Drawing.Size(74, 21);
            this.termIntervalComboBox.TabIndex = 22;
            this.termIntervalComboBox.Text = "Years";
            this.termIntervalComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(6, 181);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(167, 53);
            this.calcButton.TabIndex = 25;
            this.calcButton.Text = "Caclulate";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mpLabel);
            this.groupBox3.Controls.Add(this.monthlyPaymentTextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 104);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // mpLabel
            // 
            this.mpLabel.AutoSize = true;
            this.mpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mpLabel.Location = new System.Drawing.Point(6, 44);
            this.mpLabel.Name = "mpLabel";
            this.mpLabel.Size = new System.Drawing.Size(134, 18);
            this.mpLabel.TabIndex = 22;
            this.mpLabel.Text = "Monthly Payment $";
            this.mpLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // monthlyPaymentTextBox
            // 
            this.monthlyPaymentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.monthlyPaymentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyPaymentTextBox.Location = new System.Drawing.Point(143, 40);
            this.monthlyPaymentTextBox.Name = "monthlyPaymentTextBox";
            this.monthlyPaymentTextBox.ReadOnly = true;
            this.monthlyPaymentTextBox.Size = new System.Drawing.Size(123, 22);
            this.monthlyPaymentTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Loan Payment Calculator";
            // 
            // LoanCalculator
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 397);
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
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label mpLabel;
        private System.Windows.Forms.TextBox monthlyPaymentTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox loanTermTextBox;
        private System.Windows.Forms.ComboBox termIntervalComboBox;
        private System.Windows.Forms.TextBox errorTextBox;
        private System.Windows.Forms.Button resetButton;
    }
}

