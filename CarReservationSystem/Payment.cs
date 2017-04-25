using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication3;
using CarReservationSystem;
using CarReservationSystem.Code;

namespace WindowsFormsApplication1
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var db = new Database();
            db.AddParameter("@carId", Program.FormData.BookCarId);
            var dt = db.ExecuteDataTable("select * from car where id=@carId");
            var days = Program.FormData.EndDate.Subtract(Program.FormData.StartDate).TotalDays;
            LblTotalPrices.Text = (float.Parse(dt.Rows[0]["prices"].ToString()) * days).ToString("00.00");


        }

        private void Form_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.FormData.Bank = comboBox1.Text;
            Program.FormData.CardNumber = $"{txtCardPrefix.Text}{txtCarNumber.Text}";
            Program.FormData.Pin = txtPin.Text;
            Program.FormData.Expire = new DateTime(int.Parse(ddlExpireYear.Text), int.Parse(ddlExpireDay.Text), 1);
            var summary = new Summary();
            summary.Show();
            this.Hide();
        }
    }
}
