using System.ComponentModel;

namespace WindowsFormsApplication3
{
    partial class Summary
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
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.Bank = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblExpire = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(286, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 44);
            this.button2.TabIndex = 16;
            this.button2.Text = "submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Car:";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCar.Location = new System.Drawing.Point(99, 21);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(0, 22);
            this.lblCar.TabIndex = 24;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStartDate.Location = new System.Drawing.Point(99, 55);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(0, 22);
            this.lblStartDate.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTo.Location = new System.Drawing.Point(99, 91);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(0, 22);
            this.lblTo.TabIndex = 28;
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.To.Location = new System.Drawing.Point(12, 91);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(31, 22);
            this.To.TabIndex = 27;
            this.To.Text = "To";
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBank.Location = new System.Drawing.Point(99, 129);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(0, 22);
            this.lblBank.TabIndex = 30;
            // 
            // Bank
            // 
            this.Bank.AutoSize = true;
            this.Bank.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bank.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bank.Location = new System.Drawing.Point(12, 129);
            this.Bank.Name = "Bank";
            this.Bank.Size = new System.Drawing.Size(54, 22);
            this.Bank.TabIndex = 29;
            this.Bank.Text = "Bank";
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCard.Location = new System.Drawing.Point(99, 168);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(0, 22);
            this.lblCard.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Card";
            // 
            // lblExpire
            // 
            this.lblExpire.AutoSize = true;
            this.lblExpire.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpire.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblExpire.Location = new System.Drawing.Point(99, 211);
            this.lblExpire.Name = "lblExpire";
            this.lblExpire.Size = new System.Drawing.Size(0, 22);
            this.lblExpire.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "Expire";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotal.Location = new System.Drawing.Point(99, 257);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 22);
            this.lblTotal.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Total";
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(449, 412);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblExpire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.Bank);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.To);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Name = "Summary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summary";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label Bank;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblExpire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
    }
}

