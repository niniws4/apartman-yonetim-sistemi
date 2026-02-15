using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static int no;
        private void button1_Click(object sender, EventArgs e)
        {
            no = 1;
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            no = 2;
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            no = 3;
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            no = 4;
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            no = 5;
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            no = 6;
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            no = 7;
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            no = 8;
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
