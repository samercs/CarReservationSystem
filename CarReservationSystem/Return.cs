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

namespace WindowsFormsApplication4
{
    public partial class ReturnForm : Form
    {
        public ReturnForm()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var db = new Database();
            db.AddParameter("@customerId", Program.FormData.Customer.Id);
            DataTable dt = db.ExecuteDataTable("select * from booking where status=1 and customerId=@customerId");
            if (dt.Rows.Count > 0)
            {
                textBox1.Text = dt.Rows[0]["CarId"].ToString();
            }
        }

        private void Form_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int carId;
            if (!int.TryParse(textBox1.Text, out carId))
            {
                MessageBox.Show($"Please check car id ({textBox1.Text}) is not valid car id.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var db = new Database();
            db.AddParameter("@carId", carId);
            DataTable dt = db.ExecuteDataTable("select * from booking where status=1 and carId=@carId");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show($"This car (Car Id:{carId}) is not booking.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            db.AddParameter("@carId", carId);
            db.ExecuteNonQuery("update booking set status = 0 where status=1 and carId=@carId");
            MessageBox.Show("Car has been returned successfully.", "Return", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            var main = new MainOption();
            main.Show();
            this.Hide();
        }
    }
}
