using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection();
            baglan.ConnectionString = "server=localhost;user=root;password='';database=yonetim";
            baglan.Open();
            if (radioButton1.Checked)
            {
                MySqlCommand listele = new MySqlCommand();
                listele.CommandText = "select * from apartman";
                listele.Connection = baglan;

                DataSet ds = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(listele);
                adp.Fill(ds, "apartman");
                dataGridView1.DataSource = ds.Tables["apartman"];

            }
            if (radioButton2.Checked)
            {
                MySqlCommand listele = new MySqlCommand();
                listele.CommandText = "select * from aidat";
                listele.Connection = baglan;

                DataSet ds = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(listele);
                adp.Fill(ds, "aidat");
                dataGridView1.DataSource = ds.Tables["aidat"];
            }
            if (radioButton3.Checked)
            {
                MySqlCommand listele = new MySqlCommand();
                listele.CommandText = "select * from gider";
                listele.Connection = baglan;

                DataSet ds = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(listele);
                adp.Fill(ds, "gider");
                dataGridView1.DataSource = ds.Tables["gider"];
            }
            baglan.Close();
        }
    }
}
