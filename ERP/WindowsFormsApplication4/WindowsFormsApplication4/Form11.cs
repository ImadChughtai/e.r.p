using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class Form11 : Form
    {
        Myconn conn = new Myconn();
        public Form11()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            int c = 0;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select count(DCID) from DeliveryChalan", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]);
                c++;
            }
            textBox1.Text = "DC-0" + c.ToString();

            OleDbCommand cmm = new OleDbCommand("select SOID from SO where status='Open'", conn.oleDbConnection1);
            OleDbDataReader drr = cmm.ExecuteReader();
            while (drr.Read())
            {
                comboBox1.Items.Add(drr["SOID"]).ToString();
            }
            conn.oleDbConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from SO where SOID='" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader ddr = cmd.ExecuteReader();

            while (ddr.Read())
            {
                textBox6.Text = ddr["CID"].ToString();
                textBox7.Text = ddr["CName"].ToString();
                dateTimePicker1.Text = ddr["DDate"].ToString();
            }
            conn.oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Update DeliveryChalan set DCID=@DCID, CName=@CName,  DDate=@DDate where SOID=@SOID", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@DCID", textBox1.Text);
            cmd.Parameters.AddWithValue("@CName", textBox7.Text);
            cmd.Parameters.AddWithValue("@DDate", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@SOID", comboBox1.Text);


            cmd.ExecuteNonQuery();

            MessageBox.Show("Delivery Chalan has created");



            OleDbCommand cmm = new OleDbCommand("select * from DeliveryChalanProducts  ", conn.oleDbConnection1);
            OleDbDataReader dr = cmm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.oleDbConnection1.Close();
        }
    }
}
