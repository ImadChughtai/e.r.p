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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Administrator Login";
            this.label1.Text = "ID";
            this.label2.Text = "Password";
            this.label3.Text = "ADMINISTRATOR LOGIN";
            this.button1.Text = "LOG IN";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Admin" && this.textBox2.Text == "password")
            {
                Myconn f2 = new Myconn();
                f2.Show();
            }
        }

    }
}
