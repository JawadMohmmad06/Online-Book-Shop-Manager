using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookshop
{
    public partial class Form3 : Form
    {
        List<Panel> lp = new List<Panel>();
        Form1 login;
        public string ID;
        public Form3(string ID)
        {
            this.ID = ID;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select * FROM BookList", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;


            con.Close();
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select * FROM BookList", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string c = "Canceled";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select UserName,Adress,BookName,BookPrice,Quantity,TransactionId,TotalPrice,Adress,Status,CancelReason from [Order] where Status ='" + c +"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            cmd.ExecuteNonQuery();

            con.Close();
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = true;
            panel8.Visible = false;
            panel9.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ID,Name,Position,Shift,Adress,Phone,JoinDate,Salary from ETable",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            cmd.ExecuteNonQuery();

            con.Close();
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }


        string convoo;
        void d()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select convo from Conva where NameID ='" + ID + "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                convoo = da["convo"].ToString();
                label26.Text = da["convo"].ToString();

            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Conva where NameID ='" + ID + "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                convoo = da["convo"].ToString();
                label26.Text = da["convo"].ToString();

            }
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            login = new Form1();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO BookList(BName,Language,Genre,Author,Publication,PDate,Quantity,Price) VALUES (@BName,@Language,@Genre,@Author,@Publication,@PDate,@Quantity,@Price)", con);
            cmd1.Parameters.AddWithValue("@BName", textBox1.Text);
            cmd1.Parameters.AddWithValue("@Language", textBox2.Text);
            cmd1.Parameters.AddWithValue("@Genre", comboBox1.Text);
            cmd1.Parameters.AddWithValue("@Author", textBox3.Text);
            cmd1.Parameters.AddWithValue("@Publication", textBox4.Text);
            cmd1.Parameters.AddWithValue("@PDate", dateTimePicker2.Text);
            cmd1.Parameters.AddWithValue("@Quantity", int.Parse(textBox6.Text));
            cmd1.Parameters.AddWithValue("@Price", int.Parse(textBox11.Text));
            cmd1.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("DOne");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            
            textBox6.Text = "";
            textBox11.Text = null;


        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (textBox27.Text == "")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Select * FROM BookList Where Genre ='" + comboBox5.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView4.DataSource = dt;


                con.Close();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Select * FROM BookList Where BName ='" + textBox27.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView4.DataSource = dt;


                con.Close();
            }

        }
        public string BName, PDate;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BName = dataGridView1.Rows[e.RowIndex].Cells["BName"].FormattedValue.ToString();
            PDate = dataGridView1.Rows[e.RowIndex].Cells["PDate"].FormattedValue.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("DELETE BookList where BName='" + BName + "'and PDate ='" + PDate + "'", con);

            cmd1.ExecuteNonQuery();

            con.Close();
            delete();
            textBox7.Text = null;
            MessageBox.Show("Done");
            
        }
        void delete()
        {
            if (textBox7.Text == "")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Select * FROM BookList Where Genre ='" + comboBox2.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                con.Close();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Select * FROM BookList Where BName ='" + textBox7.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                con.Close();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string c="Canceled";
            if (radioButton2.Checked)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select UserName,Adress,BookName,BookPrice,Quantity,TransactionId,TotalPrice,Adress,Status,CancelReason from [Order] where Status ='" + c +  "' and TransactionId='" + textBox10.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;
                cmd.ExecuteNonQuery();

                con.Close();
                textBox10.Text = null;
            }
            else if (radioButton1.Checked)
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select UserName,Adress,BookName,BookPrice,Quantity,TransactionId,TotalPrice,Adress,Status,CancelReason from [Order] where Status ='" + c +  "' and UserName='" + textBox10.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;
                cmd.ExecuteNonQuery();

                con.Close();
                textBox10.Text = null;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = true;
        }
        void convo()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Conva(NameID,Position) VALUES (@NameID,@Position)", con);
            cmd.Parameters.AddWithValue("@NameID", textBox14.Text);
            cmd.Parameters.AddWithValue("@Position", comboBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        private void button13_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO ETable(ID,Name,Password,Position,Shift,Adress,Phone,JoinDate,Salary) VALUES (@ID,@Name,@Password,@Position,@Shift,@Adress,@Phone,@JoinDate,@Salary)", con);
            cmd.Parameters.AddWithValue("@id", textBox14.Text);
            cmd.Parameters.AddWithValue("@Name", textBox18.Text);
            cmd.Parameters.AddWithValue("@Password", textBox12.Text);
            cmd.Parameters.AddWithValue("@Position", comboBox3.Text);
            if(radioButton3.Checked)
            {
                cmd.Parameters.AddWithValue("@Shift", radioButton3.Text);
            }
            else if(radioButton4.Checked)
            {
                cmd.Parameters.AddWithValue("@Shift", radioButton4.Text);
            }
            cmd.Parameters.AddWithValue("@Adress", textBox16.Text);
            cmd.Parameters.AddWithValue("@Phone", textBox15.Text);
            cmd.Parameters.AddWithValue("@JoinDate", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Salary", textBox13.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            convo();
            MessageBox.Show("Done");
            textBox14.Text = null;
            textBox18.Text = null;
            comboBox3.Text = null;
            textBox16.Text = null;
            textBox15.Text = null;
            textBox13.Text = null;
            textBox12.Text = null;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ID,Name,Position,Shift,Adress,Phone,JoinDate,Salary from ETable where ID='" + textBox17.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            cmd.ExecuteNonQuery();

            con.Close();
            textBox17.Text = null;
        }
        void find2()
        {
            int sq = 1;
            int nsq = 2;
            string pos = "Bookshop Manager";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Conva SET sq=@sq where sq ='" + sq + "' and Position='" + pos + "'", con);

            cmd.Parameters.AddWithValue("@sq", nsq);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            find2();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Conva SET convo=@convo,sq=@sq where NameID ='" + ID + "'", con);
            convoo = convoo + "\n" + ID + ": " + textBox8.Text;
            cmd.Parameters.AddWithValue("@convo", convoo);
            cmd.Parameters.AddWithValue("@sq", 1);
            cmd.ExecuteNonQuery();

            con.Close();
            
            d();
            textBox8.Text = null;
            MessageBox.Show("Done");
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (textBox7.Text == "")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Select * FROM BookList Where Genre ='" + comboBox2.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                cmd1.ExecuteNonQuery();

                con.Close();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Select * FROM BookList Where BName ='" + textBox7.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                cmd1.ExecuteNonQuery();

                con.Close();
            }

            
        }
    } }
