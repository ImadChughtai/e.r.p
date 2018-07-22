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
    public partial class Form2 : Form
    {
        Myconn conn = new Myconn(); 
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label13;
    
        public Form2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(548, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(548, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(548, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "label13";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 56);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(80, 195);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(80, 254);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(323, 51);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(323, 109);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 21;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(323, 156);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 22;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(323, 202);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 23;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(323, 254);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 24;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(621, 51);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 25;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(621, 102);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 26;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(621, 153);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 56);
            this.button2.TabIndex = 28;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(363, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 47);
            this.button3.TabIndex = 29;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(489, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 47);
            this.button4.TabIndex = 30;
            this.button4.Text = "Submit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(615, 332);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 47);
            this.button5.TabIndex = 31;
            this.button5.Text = "Approve";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(741, 332);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 47);
            this.button6.TabIndex = 32;
            this.button6.Text = "Disapprove";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(894, 391);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "fdgdf";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;
            this.label7.Visible = false;
            this.label8.Visible = false;
            this.label9.Visible = false;
            this.label10.Visible = false;
            this.label11.Visible = false;
            this.label12.Visible = false;
            this.label13.Visible = false;

            this.textBox1.Visible = false;
            this.textBox2.Visible = false;
            this.textBox3.Visible = false;
            this.textBox4.Visible = false;
            this.textBox5.Visible = false;
            this.textBox6.Visible = false;
            this.textBox7.Visible = false;
            this.textBox8.Visible = false;
            this.textBox9.Visible = false;
            this.textBox10.Visible = false;
            this.textBox11.Visible = false;
            this.textBox12.Visible = false;
            this.textBox13.Visible = false;
            this.comboBox1.Visible = false;

            this.button3.Visible = false;
            this.button4.Visible = false;
            this.button5.Visible = false;
            this.button6.Visible = false;

            this.Text = "Vendor";
            this.label1.Text = "VID";
            this.label2.Text = "VName";
            this.label3.Text = "VCode";
            this.label4.Text = "VCity";
            this.label5.Text = "PH1";
            this.label6.Text = "PH2";
            this.label7.Text = "VAddress";
            this.label8.Text = "CPName";
            this.label9.Text = "CPPH";
            this.label10.Text = "VEmail";
            this.label11.Text = "VFax";
            this.label12.Text = "VGroup";
            this.label13.Text = "VStatus";


            this.button1.Text = "Insert";
            this.comboBox1.Visible = false;
            int vid = 0;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select count(VID) From vendor", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                vid = Convert.ToInt32(dr[0]);
                vid++;

            }
            conn.oleDbConnection1.Close();
            this.textBox1.Text = "vid 00" + "-" + vid + "-" + System.DateTime.Today.Year;


            conn.oleDbConnection1.Open();
            OleDbCommand cmm = new OleDbCommand("select vid from vendor", conn.oleDbConnection1);
            OleDbDataReader drr = cmm.ExecuteReader();
            while (drr.Read())
            {
                comboBox1.Items.Add(drr["vid"].ToString());
            }
            conn.oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            this.label2.Visible = true;
            this.label3.Visible = true;
            this.label4.Visible = true;
            this.label5.Visible = true;
            this.label6.Visible = true;
            this.label7.Visible = true;
            this.label8.Visible = true;
            this.label9.Visible = true;
            this.label10.Visible = true;
            this.label11.Visible = true;
            this.label12.Visible = true;
            this.label13.Visible = true;

            this.comboBox1.Visible = false;
            this.textBox1.Visible = true;

            this.textBox2.Visible = true;
            this.textBox3.Visible = true;
            this.textBox4.Visible = true;
            this.textBox5.Visible = true;
            this.textBox6.Visible = true;
            this.textBox7.Visible = true;
            this.textBox8.Visible = true;
            this.textBox9.Visible = true;
            this.textBox10.Visible = true;
            this.textBox11.Visible = true;
            this.textBox12.Visible = true;
            this.textBox13.Visible = true;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = true;
            this.button4.Visible = true;
            this.button5.Visible = true;
            this.button6.Visible = true;

            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            this.textBox8.Text = "";
            this.textBox9.Text = "";
            this.textBox10.Text = "";
            this.textBox11.Text = "";
            this.textBox12.Text = "";
            this.textBox13.Text = "";



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmm = new OleDbCommand("select * from vendor where vid='" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader drr = cmm.ExecuteReader();
            if (drr.Read())
            {
                textBox2.Text=drr["VName"].ToString();
                textBox3.Text = drr["VCode"].ToString();
                textBox4.Text = drr["VCity"].ToString();
                textBox5.Text = drr["PH1"].ToString();
                textBox6.Text = drr["PH2"].ToString();
                textBox7.Text = drr["VAddress"].ToString();
                textBox8.Text = drr["CPName"].ToString();
                textBox9.Text = drr["CPPH"].ToString();
                textBox10.Text = drr["VEmail"].ToString();
                textBox11.Text = drr["VFax"].ToString();
                textBox12.Text = drr["VGroup"].ToString();
                textBox13.Text = drr["VStatus"].ToString();

            }
            conn.oleDbConnection1.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            this.label2.Visible = true;
            this.label3.Visible = true;
            this.label4.Visible = true;
            this.label5.Visible = true;
            this.label6.Visible = true;
            this.label7.Visible = true;
            this.label8.Visible = true;
            this.label9.Visible = true;
            this.label10.Visible = true;
            this.label11.Visible = true;
            this.label12.Visible = true;
            this.label13.Visible = true;

            this.comboBox1.Visible = true;
            this.textBox2.Visible = true;
            this.textBox3.Visible = true;
            this.textBox4.Visible = true;
            this.textBox5.Visible = true;
            this.textBox6.Visible = true;
            this.textBox7.Visible = true;
            this.textBox8.Visible = true;
            this.textBox9.Visible = true;
            this.textBox10.Visible = true;
            this.textBox11.Visible = true;
            this.textBox12.Visible = true;
            this.textBox13.Visible = true;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button4.Visible = false;
            this.button5.Visible = false;
            this.button6.Visible = false;
            this.button3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            conn.oleDbConnection1.Open();

            OleDbCommand cmd = new OleDbCommand("Insert into vendor(VID,VName,VCode,VCity,PH1,PH2,VAddress,CPName,CPPH,VEmail,VFax,VGroup,VStatus) values(@VID,@VName,@VCode,@VCity,@PH1,@PH2,@VAddress,@CPName,@CPPH,@VEmail,@VFax,VGroup,@VStatus)", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@VID", textBox1.Text);
            cmd.Parameters.AddWithValue("@VName", textBox2.Text);
            cmd.Parameters.AddWithValue("@VCode", textBox3.Text);
            cmd.Parameters.AddWithValue("@VCity", textBox4.Text);
            cmd.Parameters.AddWithValue("@PH1", textBox5.Text);
            cmd.Parameters.AddWithValue("@PH2", textBox6.Text);
            cmd.Parameters.AddWithValue("@VAddress", textBox7.Text);
            cmd.Parameters.AddWithValue("@CPName", textBox8.Text);
            cmd.Parameters.AddWithValue("@CPPH", textBox9.Text);
            cmd.Parameters.AddWithValue("@VEmail", textBox10.Text);
            cmd.Parameters.AddWithValue("@VFax", textBox11.Text);

            cmd.Parameters.AddWithValue("@Vgroup", textBox12.Text);
            cmd.Parameters.AddWithValue("@VStatus", textBox13.Text);
            cmd.ExecuteNonQuery();
            conn.oleDbConnection1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;
            this.label7.Visible = false;
            this.label8.Visible = false;
            this.label9.Visible = false;
            this.label10.Visible = false;
            this.label11.Visible = false;
            this.label12.Visible = false;
            this.label13.Visible = false;

            this.textBox1.Visible = false;
            this.textBox2.Visible = false;
            this.textBox3.Visible = false;
            this.textBox4.Visible = false;
            this.textBox5.Visible = false;
            this.textBox6.Visible = false;
            this.textBox7.Visible = false;
            this.textBox8.Visible = false;
            this.textBox9.Visible = false;
            this.textBox10.Visible = false;
            this.textBox11.Visible = false;
            this.textBox12.Visible = false;
            this.textBox13.Visible = false;
            this.comboBox1.Visible = false;
            this.button1.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = false;
            this.button4.Visible = false;
            this.button5.Visible = false;
            this.button6.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox13.Text = "Approve";
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Update vendor set VStatus= 'Approve' where VID='" + comboBox1.Text + "'",conn.oleDbConnection1);
            cmd.ExecuteNonQuery();
            conn.oleDbConnection1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox13.Text = "Disapprove";
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Update vendor set VStatus= 'Disapprove' where VID='" + comboBox1.Text + "'",conn.oleDbConnection1);
            cmd.ExecuteNonQuery();
            conn.oleDbConnection1.Close();
        }
    }
}