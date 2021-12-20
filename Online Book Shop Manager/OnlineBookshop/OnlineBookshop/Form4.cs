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
    public partial class Form4 : Form
    {
        List<Panel> lp = new List<Panel>();
        Form1 login;
        public string ID;
        public Form4(string ID)
        {
            this.ID = ID;
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
        }
        string nam, convo;
        void getinfo(string pos)
             
        {
            int sq = 1;
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Conva where sq ='" + sq + "'and Position = '" + pos +  "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                convo = da["convo"].ToString();
                
                nam= da["NameID"].ToString();
                

            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {


            int sq = 1;
            string pos = "Customer";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Conva where sq ='" + sq + "'and Position = '" + pos + "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                convo = da["convo"].ToString();

                nam = da["NameID"].ToString();


            }
            con.Close();
            label9.Text = convo;
            textBox7.Text = nam;

            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pos = "Bookshop Manager";
            int sq = 1;
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Conva where sq ='" + sq + "'and Position = '" + pos + "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                convo = da["convo"].ToString();

                nam = da["NameID"].ToString();


            }
            con.Close();
            label13.Text = convo;
            textBox3.Text = nam;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string pos = "Delivary Boy";
            int sq = 1;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Conva where sq ='" + sq + "'and Position = '" + pos + "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                convo = da["convo"].ToString();

                nam = da["NameID"].ToString();


            }
            con.Close();
            label11.Text = convo;
            textBox5.Text = nam;

            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            panel6.Visible = false;

        }
        void find2(string pos)
        {
            int sq = 1;
            int nsq = 2;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Conva SET sq=@sq where sq ='" + nsq + "'and Position = '" + pos + "'", con);

            cmd.Parameters.AddWithValue("@sq", sq);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            find2("Customer");
            string p = "Customer";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Conva SET convo=@convo,sq=@sq where NameID ='" + textBox7.Text + "'and Position = '" + p + "'", con);
            convo = convo + "\n" + "Center " + textBox4.Text;
            cmd.Parameters.AddWithValue("@convo", convo);
            cmd.Parameters.AddWithValue("@sq", 2);
            cmd.ExecuteNonQuery();

            con.Close();
            
            getinfo("Customer");
            label9.Text = convo;
            textBox7.Text = nam;
            textBox4.Text = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string p = "Delivary Boy";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Conva SET convo=@convo,sq=@sq where NameID ='" + textBox5.Text + "'and Position = '" + p + "'", con);
            convo = convo + "\n" + "Center " + textBox6.Text;
            cmd.Parameters.AddWithValue("@convo", convo);
            cmd.Parameters.AddWithValue("@sq", 2);
            cmd.ExecuteNonQuery();

            con.Close();
            find2("Delivary Boy");
            getinfo("Delivary Boy");
            label11.Text = convo;
            textBox5.Text = nam;
            textBox6.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string p = "Bookshop Manager";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Conva SET convo=@convo,sq=@sq where NameID ='" + textBox3.Text + "'and Position = '" + p + "'", con);
            convo = convo + "\n" + "Center " + textBox2.Text;
            cmd.Parameters.AddWithValue("@convo", convo);
            cmd.Parameters.AddWithValue("@sq", 2);
            cmd.ExecuteNonQuery();

            con.Close();
            find2("Bookshop Manager");
            getinfo("Bookshop Manager");
            label13.Text = convo;
            textBox3.Text = nam;
            textBox2.Text = null;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            login = new Form1();
            login.Show();
        }
    }
}
