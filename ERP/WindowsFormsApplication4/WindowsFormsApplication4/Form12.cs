using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;


namespace WindowsFormsApplication4
{
    public partial class Form12 : Form
    {
        Myconn conn = new Myconn();
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            //this.textBox10.ReadOnly = true;
            int c = 0;

            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select count(InvoiceID) from Invoice ", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]);
                c++;
            }

            textBox10.Text = "0" + c.ToString();
            OleDbCommand cmdd = new OleDbCommand("Select DCID from DeliveryChalan where Status ='Open' ", conn.oleDbConnection1);
            OleDbDataReader drr = cmdd.ExecuteReader();

            while (drr.Read())
            {
                comboBox1.Items.Add(drr["DCID"]).ToString();
            }


            conn.oleDbConnection1.Close();




        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into Invoice(InvoiceID,CustomerID,CustomerName,DDate,CDate,AmountPayable,DCID) values(@InvoiceID,@CustomerID,@CustomerName,@DDate,@CDate,@AmountPayable,@DCID)", conn.oleDbConnection1);

            cmd.Parameters.AddWithValue("@InvoiceID", textBox10.Text);
            cmd.Parameters.AddWithValue("@CustomerID", textBox5.Text);
            cmd.Parameters.AddWithValue("@CustomerName", textBox6.Text);
            cmd.Parameters.AddWithValue("@DDate", textBox1.Text);
            cmd.Parameters.AddWithValue("@CDate", dateTimePicker2);
            cmd.Parameters.AddWithValue("@AmountPayable", textBox8.Text);
            cmd.Parameters.AddWithValue("@DCID", comboBox1.Text);

            cmd.ExecuteNonQuery();

            conn.oleDbConnection1.Close();
            MessageBox.Show("Pay the amount");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from DeliveryChalan where DCID = '" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                textBox1.Text = dr["DDate"].ToString();
                textBox7.Text = dr["SOID"].ToString();
                textBox6.Text = dr["CName"].ToString();

            }
            conn.oleDbConnection1.Close();

            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("Select * from SO where CName = @CName", conn.oleDbConnection1);
            cmd1.Parameters.AddWithValue("CName", textBox6.Text);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                textBox2.Text = dr1["TotalAmount"].ToString();
                textBox5.Text = dr1["CID"].ToString();

            }
            conn.oleDbConnection1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from DeliveryChalanProducts where DCID = '" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                textBox8.Text = dr["PModel"].ToString();
                textBox9.Text = dr["PQty"].ToString();
            }
            conn.oleDbConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox3.Text);
            int disc = Convert.ToInt32(textBox7.Text);
            int discount = (price * disc) / 100;
            int da = price - discount;
            textBox8.Text = da.ToString();
        }
    }
}