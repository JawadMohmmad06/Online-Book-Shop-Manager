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

    public partial class Form5 : Form
    {
        Form1 login;
        List<Panel> lp = new List<Panel>();
        public string ID;
        public Form5(string ID)
        {
            this.ID = ID;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            login = new Form1();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c = "Ordered";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select UserName,Adress,BookName,BookPrice,Quantity,TransactionId,TotalPrice,Adress,Status,CancelReason from [Order] where Status='" + c + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();

            con.Close();
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string c = "Canceled";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select UserName,Adress,BookName,BookPrice,Quantity,TransactionId,TotalPrice,Adress,Status,CancelReason from [Order] where Status='" + c + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            cmd.ExecuteNonQuery();

            con.Close();
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string o = "Ordered";
            string d = "Delivered";
            string c = "Canceled";
            string r = "Receved";

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select UserName,Adress,BookName,BookPrice,Quantity,TransactionId,TotalPrice,Adress,Status,CancelReason from [Order] where Status ='" + d + "' OR Status='" +c + "' OR Status='" + o + "' OR Status='" + r + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            cmd.ExecuteNonQuery();

            con.Close();
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            panel6.Visible = false;
            panel7.Visible = false;
        }
        string convo;
        void d()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select convo from Conva where NameID ='" + ID+ "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                convo = da["convo"].ToString();
                label2.Text = da["convo"].ToString();

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Conva where NameID ='" + ID+ "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                convo = da["convo"].ToString();
                label2.Text = da["convo"].ToString();

            }
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
            panel7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string o = "Ordered";
            string d = "Delivered";
            string c = "Canceled";
            string r = "Receved";

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select UserName,Adress,BookName,BookPrice,Quantity,TransactionId,TotalPrice,Adress,Status,CancelReason from [Order] where Status ='" + d + "' OR Status='" +c + "' OR Status='" + o + "' OR Status='" + r + "'and TransactionId = '" + textBox3.Text+ "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            
            string c = "Canceled";

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select UserName,Adress,BookName,BookPrice,Quantity,TransactionId,TotalPrice,Adress,Status,CancelReason from [Order] where Status='" + c + "'and TransactionId = '" + textBox6.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [Order] SET Status=@Status where TransactionId='" + t + "'", con);
            cmd.Parameters.AddWithValue("@Status", "Receved");
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Done");
        }
        public int t;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["TransactionId"].FormattedValue.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {

            string c = "Ordered";

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select UserName,Adress,BookName,BookPrice,Quantity,TransactionId,TotalPrice,Adress,Status,CancelReason from [Order] where Status='" + c + "'and TransactionId = '" + textBox1.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["TransactionId"].FormattedValue.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [Order] SET Status=@Status where TransactionId='" + t + "'", con);
            cmd.Parameters.AddWithValue("@Status", "Delivered");
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Done");
        }
        void find2()
        {
            int sq = 1;
            int nsq = 2;
            string pos= "Delivary Boy";
             SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Conva SET sq=@sq where sq ='" + sq+ "' and Position='" + pos + "'", con);

            cmd.Parameters.AddWithValue("@sq", nsq);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            find2();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Conva SET convo=@convo,sq=@sq where NameID ='" + ID + "'", con);
            convo = convo + "\n" + ID + " " + textBox4.Text;
            cmd.Parameters.AddWithValue("@convo", convo);
            cmd.Parameters.AddWithValue("@sq", 1);
            cmd.ExecuteNonQuery();

            con.Close();
            
            d();
            MessageBox.Show("Done");
        }
    }
}
