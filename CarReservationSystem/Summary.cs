using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication6;
using CarReservationSystem;
using CarReservationSystem.Code;

namespace WindowsFormsApplication3
{
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var db = new Database();
            db.AddParameter("@carId", Program.FormData.BookCarId);
            var dt = db.ExecuteDataTable("select * from car where id=@carId");
            var days = Program.FormData.EndDate.Subtract(Program.FormData.StartDate).TotalDays;
            lblTotal.Text = (float.Parse(dt.Rows[0]["prices"].ToString()) * days).ToString("00.00");
            lblTo.Text = Program.FormData.EndDate.ToString("dddd, dd/MM/yyyy");
            lblStartDate.Text = Program.FormData.StartDate.ToString("dddd, dd/MM/yyyy");
            lblBank.Text = Program.FormData.Bank;
            lblCar.Text = $"{dt.Rows[0]["type"]}-{dt.Rows[0]["model"]}-{dt.Rows[0]["year"]}";
            lblCard.Text = Program.FormData.CardNumber;
            lblExpire.Text = Program.FormData.Expire.ToString("MM yyyy");
        }

        private void Form_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var db = new Database();
            db.AddParameter("@carId", Program.FormData.BookCarId);
            db.AddParameter("@CustomerId", Program.FormData.Customer.Id);
            db.AddParameter("@startDate", Program.FormData.StartDate);
            db.AddParameter("@EndDate", Program.FormData.EndDate);
            var bookingId = db.ExecuteNonQuery_id(
                "insert into booking(carId,CustomerId,startDate,EndDate) values(@carId,@CustomerId,@startDate,@EndDate)");

            db.AddParameter("@CustomerID", Program.FormData.Customer.Id);
            db.AddParameter("@BokkingId", bookingId);
            db.AddParameter("@Total", lblTotal.Text);
            db.AddParameter("@AddDate", DateTime.Now);
            db.AddParameter("@CardNumber", Program.FormData.CardNumber);
            db.AddParameter("@Bank", Program.FormData.Bank);
            db.AddParameter("@Expire", Program.FormData.Expire);
            db.AddParameter("@Pin", Program.FormData.Pin);
            db.ExecuteNonQuery(
                "insert into payment(CustomerID,BookingId,Total,AddDate,CardNumber,Bank,Expire,Pin) values(@CustomerID,@BokkingId,@Total,@AddDate,@CardNumber,@Bank,@Expire,@Pin)");

            MessageBox.Show("Booking has been complete. thank you.", "Booking", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            var main = new MainOption();
            main.Show();
            this.Hide();


        }
    }
}
