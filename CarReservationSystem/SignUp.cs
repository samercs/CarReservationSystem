using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication9;
using CarReservationSystem.Code;

namespace WindowsFormsApplication8
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void form2_Load(object sender, EventArgs e)
        {

        }

        private void form_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                var db = new Database();
                db.AddParameter("@name", textBox1.Text);
                db.AddParameter("@age", textBox2.Text);
                db.AddParameter("@username", textBox3.Text);
                db.AddParameter("@password", textBox4.Text);
                db.AddParameter("@gender", comboBox1.Text);
                db.ExecuteNonQuery("insert into customer(name,age,username,password,gender) values(@name,@age,@username,@password,@gender)");
                MessageBox.Show("Registration has been complete successfully.");
                var login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private bool ValidateData()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                ShowErrorMessage("Please enter your name");
                return false;
            }

            int age;
            if (!int.TryParse(textBox2.Text, out age))
            {
                ShowErrorMessage("Please check your age");
                return false;
            }
            if (age < 21)
            {
                ShowErrorMessage("Age must be 21 or above");
                return false;
            }
            if (textBox3.Text.Length < 5)
            {
                ShowErrorMessage("username must be 5 charachter or more");
                return false;
            }
            if (textBox4.Text.Length < 5)
            {
                ShowErrorMessage("password must be 5 charachter or more");
                return false;
            }
            if (!textBox4.Text.Equals(textBox5.Text))
            {
                ShowErrorMessage("password & password confirmation does not match");
                return false;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                ShowErrorMessage("please select your gender");
                return false;
            }
            return true;
        }

        private void ShowErrorMessage(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
