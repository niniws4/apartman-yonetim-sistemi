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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection();
            baglan.ConnectionString = "server=localhost;user=root;password='';database=yonetim";
            baglan.Open();

            MySqlCommand kaydet = new MySqlCommand();
            kaydet.CommandText = "insert into gider values(@1,@2,@3)";
            kaydet.Connection = baglan;
            kaydet.Parameters.Add("@1", textBox1.Text);
            kaydet.Parameters.Add("@2", textBox2.Text);
            kaydet.Parameters.Add("@3", Convert.ToDateTime(dateTimePicker1.Text));

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
