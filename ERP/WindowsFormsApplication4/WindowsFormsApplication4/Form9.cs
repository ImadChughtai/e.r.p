using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace WindowsFormsApplication4
{
    public partial class Form9 : Form
    {
        Myconn conn = new Myconn();

        public Form9()
        {
            
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Clear();
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select deptname from Dept", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                comboBox1.Items.Add(dr["deptname"].ToString());
            }


            conn.oleDbConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int soid = 0;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("Select count(SOID) from SO", conn.oleDbConnection1);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                soid = Convert.ToInt32(dr1[0]);
                soid++;


            }
            textBox1.Text = "soid" + "-" + soid + "-" + System.DateTime.Today.Year;
            if (comboBox1.Text == "Consumer")
            {
                textBox1.Text = "CONS" + "-" + soid + "-" + System.DateTime.Today.Year;
            }

            if (comboBox1.Text == "Sales")
            {
                textBox1.Text = "Sal-00" + "-" + soid.ToString() + "-" + System.DateTime.Today.Year;
                
            }

            if (comboBox1.Text == "HR")
            {
                textBox1.Text = "HR-00" + "-" + soid.ToString() + "-" + System.DateTime.Today.Year;
                
            }

            if (comboBox1.Text == "IT")
            {
                textBox1.Text = "IT-00" + "-" + soid.ToString() + "-" + System.DateTime.Today.Year;
                
            }
            conn.oleDbConnection1.Close();

            int a = 0;
            conn.oleDbConnection1.Open();
            OleDbCommand cmmm = new OleDbCommand("select count(CID) from SO where CDept='" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader drr = cmmm.ExecuteReader();
            if (drr.Read())
            {
                a = Convert.ToInt32(drr[0]);
                a++;
            }

            conn.oleDbConnection1.Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into SO(SOID, SODate, Status, Approve, CDept, CName, CID, CContectPerson, CCPPH, TotalAmount)values(@SOID, @SODate, @Status, @Approve, @CDept, @CName, @CID, @CContectPerson, @CCPPH, @TotalAmount);", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@SOID", textBox1.Text);
            cmd.Parameters.AddWithValue("@SODate", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Status", textBox6.Text);
            cmd.Parameters.AddWithValue("@Approve", textBox7.Text);
            cmd.Parameters.AddWithValue("@CDept", textBox3.Text);
            cmd.Parameters.AddWithValue("@CName", textBox2.Text);
            cmd.Parameters.AddWithValue("@CID", textBox9.Text);
            cmd.Parameters.AddWithValue("@CContectPerson", textBox4.Text);
            cmd.Parameters.AddWithValue("@CCPPH", textBox5.Text);
            cmd.Parameters.AddWithValue("@TotalAmount", textBox8.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Your data has been inserted");
            conn.oleDbConnection1.Close();
        }
    }
}
