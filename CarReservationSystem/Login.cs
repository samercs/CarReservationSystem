using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication6;
using WindowsFormsApplication8;
using CarReservationSystem;
using CarReservationSystem.Code;

namespace WindowsFormsApplication9
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var db = new Database();
            db.AddParameter("@username", textBox1.Text);
            db.AddParameter("@password", textBox2.Text);
            DataTable loginInfo =
                db.ExecuteDataTable("select * from customer where username=@username and password=@password");

            if (loginInfo.Rows.Count <= 0)
            {
                MessageBox.Show("Error customer information.", "Error login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.FormData = new FormData
            {
                Customer = new Customer
                {
                    Id = int.Parse(loginInfo.Rows[0]["id"].ToString()),
                    Name = loginInfo.Rows[0]["name"].ToString(),
                    Age = int.Parse(loginInfo.Rows[0]["age"].ToString()),
                    UserName = loginInfo.Rows[0]["username"].ToString(),
                    Gender = loginInfo.Rows[0]["gender"].ToString()
                }
            };

            var mainOption = new MainOption();
            mainOption.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var signup = new Signup();
            signup.Show();
            this.Hide();
        }
    }
}
