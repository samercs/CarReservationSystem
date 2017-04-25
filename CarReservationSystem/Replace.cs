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
    public partial class Replace : Form
    {
        public Replace()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form1_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadData()
        {
            var db = new Database();
            db.AddParameter("@customerId", Program.FormData.Customer.Id);
            DataTable dt =
                db.ExecuteDataTable(
                    "select concat_ws('-', car.type, car.model, car.year) as car_name, car.Id from car inner join booking on car.id=booking.carId where booking.status=1 and booking.customerId=@customerId");

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "car_name";
            comboBox1.ValueMember = "Id";


            dt =
                db.ExecuteDataTable(
                    "select concat_ws('-', car.type, car.model, car.year) as car_name, car.Id from car ");

            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "car_name";
            comboBox2.ValueMember = "Id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var db = new Database();
            db.AddParameter("@customerId", Program.FormData.Customer.Id);
            db.AddParameter("@carId", comboBox1.SelectedValue);
            DataTable dt =
                db.ExecuteDataTable(
                    "select booking.Id from car inner join booking on car.id=booking.carId where booking.status=1 and booking.customerId=@customerId and booking.carId=@carId");
            if (dt.Rows.Count > 0)
            {
                db.AddParameter("@carId", comboBox2.SelectedValue);
                db.AddParameter("@bookingId", dt.Rows[0]["id"].ToString());
                db.ExecuteNonQuery("update booking set carId=@carId where booking.Id=@bookingId");
                MessageBox.Show("Car has been replaced successfully.", "Replace", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                var main = new MainOption();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("can't find this car.", "Replace", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}
