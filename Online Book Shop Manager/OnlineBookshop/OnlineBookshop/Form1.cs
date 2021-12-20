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
    public partial class Form1 : Form
    {
        
        Form2 customer;
        Form3 bookShopM;
        Form4 ITM;
        Form5 delivaryBoy;
        Form6 resister;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Customer")
            {
                label2.Text = "User Name";
            }
            else
            {
                label2.Text = "ID";
            }
        }
        public string name, pasword;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            if (comboBox1.Text == "Customer")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Register where Name ='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
                SqlDataReader dr=cmd.ExecuteReader();
                int c = 0;
                while(dr.Read())
                {
                    c += 1;
                }
                if(c==1)
                {
                    name = textBox1.Text;
                    pasword = textBox2.Text;
                    this.Hide();
                    customer = new Form2(name,pasword);
                    customer.Show();

                }
                else
                {
                    MessageBox.Show("Worng User Name or Password");
                }
                
                con.Close();





                
            }
            else if (comboBox1.Text == "Bookshop Manager")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from ETable where ID ='" + textBox1.Text + "' and Password='" + textBox2.Text + "'and Position='" + comboBox1.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                int c = 0;
                while (dr.Read())
                {
                    c += 1;
                }
                if (c == 1)
                {
                    name = textBox1.Text;
                    pasword = textBox2.Text;

                    this.Hide();
                    bookShopM = new Form3(name);
                    bookShopM.Show();

                }
                else
                {
                    MessageBox.Show("Worng User Name or Password");
                }

            }
            else if (comboBox1.Text == "Communication Center")
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from ETable where ID ='" + textBox1.Text + "' and Password='" + textBox2.Text + "'and Position='" + comboBox1.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                int c = 0;
                while (dr.Read())
                {
                    c += 1;
                }
                if (c == 1)
                {
                    name = textBox1.Text;
                    pasword = textBox2.Text;
                    
                    this.Hide();
                    ITM = new Form4(name);
                    ITM.Show();

                }
                else
                {
                    MessageBox.Show("Worng User Name or Password");
                }

                con.Close();
                
            }
            else if (comboBox1.Text == "Delivary Boy")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from ETable where ID ='" + textBox1.Text + "' and Password='" + textBox2.Text + "'and Position='" + comboBox1.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                int c = 0;
                while (dr.Read())
                {
                    c += 1;
                }
                if (c == 1)
                {
                    name = textBox1.Text;
                    pasword = textBox2.Text;
                    this.Hide();
                    delivaryBoy = new Form5(name);
                    delivaryBoy.Show();

                }
                else
                {
                    MessageBox.Show("Worng User Name or Password");
                }

                con.Close();

                
            }
            else
            {
                MessageBox.Show("Worng Position");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("DELETE [Order] where BookName='" +textBox1.Text + "'", con);

            cmd1.ExecuteNonQuery();

            con.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Conva SET convo=@convo where NameID ='" + textBox1.Text +  "'", con);
            
            cmd.Parameters.AddWithValue("@convo", "");
            
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Conva SET convo=@convo where NameID ='" + textBox1.Text + "'", con);
            
            cmd.Parameters.AddWithValue("@convo", "");
            
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text== "Customer")
            {
                this.Hide();
                resister = new Form6();
                resister.Show();
            }
            else if(comboBox1.Text == "Bookshop Manager"|| comboBox1.Text == "Communication Center"|| comboBox1.Text == "Delivary Boy")
            {
                MessageBox.Show("Only Customer can registration here");
            }
            else
            {
                MessageBox.Show("Enter valid position");
            }
        }

    }
}
