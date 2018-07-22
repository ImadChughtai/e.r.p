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
    public partial class Form10 : Form
    {
        Myconn conn = new Myconn();
        public Form10()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

            int iid = 0;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd2 = new OleDbCommand("Select count(InvoiceID) from Invoice ", conn.oleDbConnection1);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read()) {
                iid = Convert.ToInt32(dr2[0]);
                iid++;
 
            }
            this.textBox1.Text = "InvoiceID" + "-" + iid + "-" + System.DateTime.Today.Year;
            conn.oleDbConnection1.Close();


            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select GRNID from GRN where status='Open'",conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                comboBox1.Items.Add(dr["GRNID"].ToString());
            }


            conn.oleDbConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from GRN where GRNID = '" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) {
                this.textBox3.Text = dr["Ddate"].ToString();
                this.textBox4.Text = dr["GRDate"].ToString();
                this.textBox5.Text = dr["POID"].ToString();
                this.textBox6.Text = dr["VName"].ToString();
            }
            conn.oleDbConnection1.Close();
            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("Select TotalAmount from PO where POID = '" + textBox5.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read()) {
                this.textBox2.Text = dr1["TotalAmount"].ToString();
 
            }
            conn.oleDbConnection1.Close();
        }
    }
}
