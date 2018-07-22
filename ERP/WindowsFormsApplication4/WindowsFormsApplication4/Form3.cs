using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication4
{
    public partial class Form3 : Form
    {
        Myconn conn = new Myconn();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            this.Text = "Purchase Order";
            this.label1.Text = "Dept Id";
            this.label2.Text = "PO Id";
            this.label3.Text = "Vid";
            this.label4.Text = "Name";
            this.label5.Text = "Contact No";
            this.label6.Text = "Due Date";
            this.label7.Text = "PO Date";
            this.label8.Text = "Approve";
            this.label9.Text = "Total Amount";
            this.button1.Text = "Create PO";

            conn.oleDbConnection1.Open();
            OleDbCommand cmm = new OleDbCommand("select vdept from po",conn.oleDbConnection1);
            OleDbDataReader drr = cmm.ExecuteReader();
            while (drr.Read())
            {
                comboBox1.Items.Add(drr["vdept"].ToString());
            }
            conn.oleDbConnection1.Close();


            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select VID from  PO ", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.comboBox2.Items.Add(dr["VID"].ToString());
            }
            conn.oleDbConnection1.Close();
   


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select count(poid) from  po where vdept='" + comboBox1.Text + "'",conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                count = Convert.ToInt32(dr[0]);
                count++;
            }

            if (comboBox1.Text == "Consumer")
            {
                textBox1.Text += "Co-00" + count.ToString() + "-" + System.DateTime.Today.Year;
            }
            conn.oleDbConnection1.Close();
            


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from  PO where VID='" + comboBox2.Text + "'",conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            
           {
                this.textBox3.Text = dr["VContectPerson"].ToString();
                this.textBox4.Text = dr["VCPPH"].ToString();
                this.textBox5.Text = dr["DDate"].ToString();
                this.textBox6.Text = dr["PODate"].ToString();
                this.textBox7.Text = dr["Approve"].ToString();
                this.textBox8.Text = dr["TotalAmount"].ToString();
                conn.oleDbConnection1.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Purchase Order is created");
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
