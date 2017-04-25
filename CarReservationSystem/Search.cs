using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarReservationSystem.Code;

namespace WindowsFormsApplication5
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void form4_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadData()
        {
            var db = new Database();
            DataTable cars = db.ExecuteDataTable("select distinct type from car");
            foreach (DataRow carsRow in cars.Rows)
            {
                comboBox1.Items.Add(carsRow["type"].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var db = new Database();
            db.AddParameter("@type", comboBox1.Text);
            DataTable cars = db.ExecuteDataTable("select * from car where type=@type");
            foreach (DataRow carsRow in cars.Rows)
            {
                listView1.Items.Add($"{carsRow["model"]} {carsRow["year"]}", carsRow["id"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems[0].ImageKey);
        }
    }
}
