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
    public partial class Form4 : Form
    {

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button2;

        string[] st = new string[50];
        int[] qty = new int[50];
        int count = 0;
        int total = 0;
        Myconn conn = new Myconn();

    
        public Form4()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(249, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "POID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "PNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "BASE PRICE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "QUANTITY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "TOTAL AMOUNT";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(99, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 203);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(97, 245);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(365, 148);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 95);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(471, 148);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 95);
            this.textBox6.TabIndex = 14;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 46);
            this.button2.TabIndex = 15;
            this.button2.Text = "CREATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(851, 325);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "PO Product";
            this.label1.Text = "POID";
            this.label2.Text = "PID";
            this.label3.Text = "PName";
            this.label4.Text = "Base Price";
            this.label5.Text = "Quantiy";
            this.label6.Text = "Total Amount";

            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select poid from po", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["poid"].ToString());
            }
            conn.oleDbConnection1.Close();


            conn.oleDbConnection1.Open();
            OleDbCommand cmm = new OleDbCommand("select pid from products", conn.oleDbConnection1);
            OleDbDataReader drr = cmm.ExecuteReader();
            while (drr.Read())
            {
                comboBox2.Items.Add(drr["pid"].ToString());
            }
            conn.oleDbConnection1.Close();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;


            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select count(poid) from po where poid='" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]);
                c++;
            }

            if (comboBox1.Text == "Cons_01_2010")
            {
                textBox1.Text = "Cons-01-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "Cons_10_2010")
            {
                textBox1.Text = "Cons-10-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox1.Text == "Cons_02_2010")
            {
                textBox1.Text = "Cons-02-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox1.Text == "Cons_07_2010")
            {
                textBox1.Text = "Cons-07-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "Cons_08_2010")
            {
                textBox1.Text = "Cons-08-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "Cons_12_2010")
            {
                textBox1.Text = "Cons-12-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "HR_04_2010")
            {
                textBox1.Text = "HR-04-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "HR_05_2010")
            {
                textBox1.Text = "HR-05-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "HR_11_2010")
            {
                textBox1.Text = "HR-11-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "Sale_03_2010")
            {
                textBox1.Text = "Sal-03-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "Sale_06_2010")
            {
                textBox1.Text = "Sal-06-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }

            if (comboBox1.Text == "Sale_09_2010")
            {
                textBox1.Text = "Sal-09-00" + c.ToString() + "-" + System.DateTime.Today.Year;

            }
            conn.oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text += comboBox2.Text + Environment.NewLine;
            textBox6.Text += textBox3.Text + Environment.NewLine;
            st[count] = comboBox2.Text;
            qty[count] = Convert.ToInt32(textBox3.Text);
            count++;
            total += Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox3.Text);
            textBox5.Text = total.ToString();



            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();

            for (int i = 0; i < count; i++)
            {
                OleDbCommand cmd = new OleDbCommand("insert into poproducts(pid,pqty,poid) values(@pid,@pqty,@poid)", conn.oleDbConnection1);

                cmd.Parameters.AddWithValue("@pid", comboBox2.Text);
                cmd.Parameters.AddWithValue("@pqty", textBox3.Text);
                cmd.Parameters.AddWithValue("@pname", textBox2.Text);
               // cmd.Parameters.AddWithValue("@poid", textBox1.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Your PO Product Is Create");
            }
            conn.oleDbConnection1.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from products where pid='" + comboBox2.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["pname"].ToString();
                textBox4.Text = dr["baseprice"].ToString();
            }
            conn.oleDbConnection1.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
