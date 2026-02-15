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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            textBox1.Text = Form2.no.ToString();


            MySqlConnection baglan = new MySqlConnection();
            baglan.ConnectionString = "server=localhost;user=root;password='';database=yonetim";
            baglan.Open();

            MySqlCommand getir = new MySqlCommand();
            getir.CommandText = "select * from apartman where daireno=@1";
            getir.Connection = baglan;
            getir.Parameters.Add("@1", int.Parse(textBox1.Text));
            MySqlDataReader oku;
            oku = getir.ExecuteReader();
            if (oku.HasRows == true)
            {
                while (oku.Read())
                {
                    textBox2.Text = oku.GetString(0);
                    textBox3.Text = oku.GetString(1);
                    textBox4.Text = oku.GetString(2);
                    textBox5.Text = oku.GetString(3);
                    if (oku.GetString(4) == "evsahibi")
                    {
                        radioButton1.Checked = true;

                    }
                    else if (oku.GetString(4) == "kiraci")
                    {
                        radioButton2.Checked = true;
                    }
                }
            }

            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection();
            baglan.ConnectionString = "server=localhost;user=root;password='';database=yonetim";
            baglan.Open();

            MySqlCommand kaydet = new MySqlCommand();
            kaydet.CommandText = "insert into apartman values(@1,@2,@3,@4,@5,@6)";
            kaydet.Connection = baglan;
            kaydet.Parameters.Add("@1",int.Parse(textBox1.Text));
            kaydet.Parameters.Add("@2",textBox2.Text);
            kaydet.Parameters.Add("@3",textBox3.Text);
            kaydet.Parameters.Add("@4", textBox4.Text);
            kaydet.Parameters.Add("@5",textBox5.Text);
            if (radioButton1.Checked)
            {
                kaydet.Parameters.Add("@6",radioButton1.Text);
            }
            else if (radioButton2.Checked)
            {
                kaydet.Parameters.Add("@6", radioButton2.Text);
            }
            if (kaydet.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("İşlem başarılı..");
            }
            else
            {
                MessageBox.Show("İşlem başarısız..");
            }
            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection();
            baglan.ConnectionString = "server=localhost;user=root;password='';database=yonetim";
            baglan.Open();

            MySqlCommand sil = new MySqlCommand();
            sil.CommandText = "delete from apartman where daireno=@1";
            sil.Connection = baglan;
            sil.Parameters.Add("@1", int.Parse(textBox1.Text));
            if (sil.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("İşlem başarısız");
            }
            baglan.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection();
            baglan.ConnectionString = "server=localhost;user=root;password='';database=yonetim";
            baglan.Open();

            MySqlCommand guncelle = new MySqlCommand();
            guncelle.CommandText = "update apartman set tckimlik=@2,adsoyad=@3,ksayisi=@4,tel=@5,tur=@6 where daireno=@1";
            guncelle.Connection = baglan;
            guncelle.Parameters.Add("@1",int.Parse(textBox1.Text));
            guncelle.Parameters.Add("@2",textBox2.Text);
            guncelle.Parameters.Add("@3",textBox3.Text);
            guncelle.Parameters.Add("@4",textBox4.Text);
            guncelle.Parameters.Add("@5",textBox5.Text);
            if (radioButton1.Checked)
            {
                guncelle.Parameters.Add("@6",radioButton1.Text);
            }
            else if (radioButton2.Checked)
            {
                guncelle.Parameters.Add("@6", radioButton2.Text);
            }
            if (guncelle.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("İşlem Başarısız");
            }

            baglan.Close();
        }
    }
}
