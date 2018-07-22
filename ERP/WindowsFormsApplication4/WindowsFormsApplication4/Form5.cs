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
    public partial class Form5 : Form
    {
        Myconn conn = new Myconn();
        public Form5()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select POID FROM PO where Status = 'Open' ",conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["POID"].ToString());

            }
            conn.oleDbConnection1.Close();
            int c = 0;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("Select count(GRNID) from GRN", conn.oleDbConnection1);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                c = Convert.ToInt32(dr1[0]);
                c++;
                    this.textBox1.Text= "GRN-0" + c.ToString();
            }
            conn.oleDbConnection1.Close();
            /*conn.oleDbConnection1.Open();
            OleDbCommand cmd2 = new OleDbCommand("Select POID from PO where Status='Open'", conn.oleDbConnection1);
            OleDbDataReader dr2 = cmd1.ExecuteReader();
            while (dr2.Read())*/
            
 
            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from PO where POID='" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["VID"].ToString();
                textBox3.Text = dr["VName"].ToString();
                dateTimePicker1.Text = dr["DDate"].ToString();
            }
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from POProducts", conn.oleDbConnection1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cmd.Parameters.AddWithValue();conn.oleDbConnection1.Open();
            

            /*OleDbCommand cmd = new OleDbCommand("Insert into GRN(GRNID,Status,GRDate) values(@GRNID,@Status,@GRDate)", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@GRNID", textBox3.Text);
            /*cmd.Parameters.AddWithValue("@BaseDocument", comboBox1.Text);*/
            /*cmd.Parameters.AddWithValue("@Status", "Open");
            cmd.Parameters.AddWithValue("@GRDate", System.DateTime.Today.Date.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("GRN Generate Completed ");

            cmd = new OleDbCommand("Select * from PO where POID = '" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                String vname = dr["VName"].ToString();
                String ddate = dr["DDate"].ToString();

                cmd = new OleDbCommand("Update GRN Set VName='" + dr["VName"].ToString() + "', DDAte = '" + dr["DDate"].ToString() + "' where GRNID = '" + textBox1.Text + "' ", conn.oleDbConnection1);
                cmd.ExecuteReader();
                MessageBox.Show("GRN table Complete");
                cmd = new OleDbCommand("Update PO set Status = 'Close' where POID ='" + comboBox1.Text + "'");
                MessageBox.Show("PO status Close");
            }
            conn.oleDbConnection1.Close();*/
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into grn (grnid,vname,poid,ddate,grdate,status) values (@grnid,@vname,@poid,@ddate,@grdate,@status)",conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@grnid",textBox1.Text);
            cmd.Parameters.AddWithValue("@vname",textBox2.Text);
          //  cmd.Parameters.AddWithValue("@vid",textBox3.Text);
            cmd.Parameters.AddWithValue("@poid",comboBox1.Text);
            cmd.Parameters.AddWithValue("@ddate",dateTimePicker1);
            cmd.Parameters.AddWithValue("@grdate",System.DateTime.Today);
            cmd.Parameters.AddWithValue("@status","Open");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data inserted");

            conn.oleDbConnection1.Close();
            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("update po set status=@status",conn.oleDbConnection1);
            cmd1.Parameters.AddWithValue("@status","Close");
            cmd1.ExecuteNonQuery();

            conn.oleDbConnection1.Close();
            this.Close();


        }
    }
}
