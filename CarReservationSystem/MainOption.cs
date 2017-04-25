using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication4;
using WindowsFormsApplication5;

namespace WindowsFormsApplication6
{
    public partial class MainOption : Form
    {
        public MainOption()
        {
            InitializeComponent();
        }

        private void form3_Load(object sender, EventArgs e)
        {

        }

        private void Form_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var search = new Search();
                search.Show();
                this.Hide();
            }

            if (radioButton2.Checked)
            {
                var returnFrm = new ReturnForm();
                returnFrm.Show();
                this.Hide();
            }
        }
    }
}
