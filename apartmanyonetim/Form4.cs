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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection();
            baglan.ConnectionString = "server=localhost;user=root;password='';database=yonetim";
            baglan.Open();
            MySqlCommand kaydet = new MySqlCommand();
            kaydet.CommandText = "insert into aidat values(@1,@2,@3,@4,@5)";
            kaydet.Connection = baglan;
            kaydet.Parameters.Add("@1", int.Parse(textBox1.Text));
            kaydet.Parameters.Add("@2", textBox2.Text);
            kaydet.Parameters.Add("@3", int.Parse(textBox3.Text));
            kaydet.Parameters.Add("@4", comboBox1.Text);
            kaydet.Parameters.Add("@5", int.Parse(comboBox2.Text));
            if (kaydet.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Kaydedildi");
            }
            else
            {
                MessageBox.Show("Hata");
            }

            baglan.Close();
        }
    }
}
