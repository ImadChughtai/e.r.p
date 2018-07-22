using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Myconn : Form
    {
        public Myconn()
        {
            InitializeComponent();
        }

        private void Myconn_Load(object sender, EventArgs e)
        {
            this.Text = "Administrator";
            this.button1.Text = "Insert/Search Vendor Details";
            this.button2.Text = "PO Product";
            this.button3.Text = "Create Purchase Order";
            this.button4.Text = "GRN";
            this.button5.Text = "Invoice";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 obj2 = new Form2();
            obj2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
        }
    }
}
