using System.ComponentModel;

namespace WindowsFormsApplication1
{
    partial class Payment
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtCarNumber = new System.Windows.Forms.TextBox();
            this.ddlExpireYear = new System.Windows.Forms.ComboBox();
            this.ddlExpireDay = new System.Windows.Forms.ComboBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.LblTotalPrices = new System.Windows.Forms.Label();
            this.txtCardPrefix = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(31, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Total Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "PIN:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(198, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(31, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Expiration Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(31, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Card Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(31, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "Select your Bank:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(81, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 44);
            this.button2.TabIndex = 28;
            this.button2.Text = "submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "National Bank of Kuwait (K.S.C)",
            "Commercial Bank of Kuwait (K.S.C)",
            "Gulf Bank (K.S.C)",
            "Al Ahli Bank of Kuwait (K.S.C.P.)",
            "Al Ahli United Bank",
            "Burgan Bank (K.S.C)",
            "Kuwait International Bank (K.S.C)",
            "The Industrial Bank of Kuwait (K.S.C)",
            "Kuwait Finance House",
            "Boubyan Bank (K.S.C)",
            "Warba Bank"});
            this.comboBox1.Location = new System.Drawing.Point(221, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 25);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.Text = "Select your Bank:";
            // 
            // txtCarNumber
            // 
            this.txtCarNumber.Location = new System.Drawing.Point(300, 138);
            this.txtCarNumber.Name = "txtCarNumber";
            this.txtCarNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCarNumber.TabIndex = 29;
            // 
            // ddlExpireYear
            // 
            this.ddlExpireYear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlExpireYear.FormattingEnabled = true;
            this.ddlExpireYear.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.ddlExpireYear.Location = new System.Drawing.Point(300, 164);
            this.ddlExpireYear.Name = "ddlExpireYear";
            this.ddlExpireYear.Size = new System.Drawing.Size(100, 25);
            this.ddlExpireYear.TabIndex = 31;
            this.ddlExpireYear.Text = "2017";
            // 
            // ddlExpireDay
            // 
            this.ddlExpireDay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlExpireDay.FormattingEnabled = true;
            this.ddlExpireDay.Items.AddRange(new object[] {
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
            "12"});
            this.ddlExpireDay.Location = new System.Drawing.Point(221, 166);
            this.ddlExpireDay.Name = "ddlExpireDay";
            this.ddlExpireDay.Size = new System.Drawing.Size(73, 25);
            this.ddlExpireDay.TabIndex = 32;
            this.ddlExpireDay.Text = "4";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(221, 201);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(179, 20);
            this.txtPin.TabIndex = 34;
            // 
            // LblTotalPrices
            // 
            this.LblTotalPrices.AutoSize = true;
            this.LblTotalPrices.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPrices.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTotalPrices.Location = new System.Drawing.Point(217, 48);
            this.LblTotalPrices.Name = "LblTotalPrices";
            this.LblTotalPrices.Size = new System.Drawing.Size(0, 22);
            this.LblTotalPrices.TabIndex = 35;
            // 
            // txtCardPrefix
            // 
            this.txtCardPrefix.Location = new System.Drawing.Point(221, 137);
            this.txtCardPrefix.Name = "txtCardPrefix";
            this.txtCardPrefix.Size = new System.Drawing.Size(73, 20);
            this.txtCardPrefix.TabIndex = 36;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(449, 412);
            this.Controls.Add(this.txtCardPrefix);
            this.Controls.Add(this.LblTotalPrices);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.ddlExpireDay);
            this.Controls.Add(this.ddlExpireYear);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtCarNumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtCarNumber;
        private System.Windows.Forms.ComboBox ddlExpireYear;
        private System.Windows.Forms.ComboBox ddlExpireDay;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label LblTotalPrices;
        private System.Windows.Forms.TextBox txtCardPrefix;
    }
}

