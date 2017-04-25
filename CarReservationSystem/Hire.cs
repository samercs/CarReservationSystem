using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarReservationSystem;
using CarReservationSystem.Code;

namespace WindowsFormsApplication1
{
    public partial class Hire : Form
    {
        public float CarPrices { get; set; }
        public Hire()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var db = new Database();
            db.AddParameter("@carId", Program.FormData.BookCarId);
            var dt = db.ExecuteDataTable("select * from car where id=@carId");
            if (dt.Rows.Count > 0)
            {
                LblCarId.Text = $"{dt.Rows[0]["Type"]}-{dt.Rows[0]["model"]}-{dt.Rows[0]["year"]}";
                CarPrices = float.Parse(dt.Rows[0]["Prices"].ToString());
            }
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now.AddDays(2);
        }

        private void Form_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var days = dateTimePicker2.Value.Subtract(dateTimePicker1.Value).TotalDays;
            LblTotalPrices.Text = (CarPrices * days).ToString("00.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.FormData.StartDate = dateTimePicker1.Value;
            Program.FormData.EndDate = dateTimePicker2.Value;
            var payment = new Payment();
            payment.Show();
            this.Hide();
        }
    }
}
