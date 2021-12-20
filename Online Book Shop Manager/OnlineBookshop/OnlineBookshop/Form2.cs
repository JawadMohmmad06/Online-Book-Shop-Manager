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
    public partial class Form2 : Form
    {
        List<Panel> lp = new List<Panel>();
        Form1 login;
        public string name, pasword;
        public Form2(string name,string pasword)
        {
            InitializeComponent();
            this.name = name;
            this.pasword = pasword;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        string nam, phon, adress;
        void di()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select BName,Price FROM BookList", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView5.DataSource = dt;


            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Register where Name ='" + name + "' and Password='" + pasword + "'", con);
            SqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                textBox12.Text = da["Name"].ToString();
                textBox10.Text = da["Phon"].ToString();
                textBox11.Text = da["Adress"].ToString();
                nam = da["Name"].ToString();
                phon = da["Phon"].ToString();
                adress = da["Adress"].ToString();

            }
            con.Close();
            di();
            
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Register where Name ='" + name + "' and Password='" + pasword + "'", con);
            SqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                label1.Text = da["Name"].ToString();
                label2.Text = da["Adress"].ToString();
                label3.Text = da["Phon"].ToString();
                

            }

            panel4.Visible = true;
           
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel4.Visible = false;
          
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = true;
            panel8.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select BookName,BookPrice,Quantity,TransactionId,TotalPrice,Adress,Status from [Order] where UserName ='" + name + "' and Password='" + pasword + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            panel4.Visible = false;
            
            panel5.Visible = true;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            cmd.ExecuteNonQuery();

            con.Close();
        }
        string convo;
        void d()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select convo from Conva where NameID ='" + name + "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                convo = da["convo"].ToString();
                label4.Text = da["convo"].ToString();

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Conva where NameID ='" + name + "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                convo= da["convo"].ToString();
                label4.Text = da["convo"].ToString();
                
            }
            con.Close();
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select * FROM BookList ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            panel4.Visible = false;
            
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = true;
            panel9.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Register where Name ='" + name + "' and Password='" + pasword + "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            
            while (da.Read())
            {
                label49.Text = da["Name"].ToString();
                label50.Text = da["Password"].ToString();
                label51.Text = da["Dob"].ToString();
                label52.Text = da["Phon"].ToString();
                label53.Text = da["Email"].ToString();
                label54.Text=da["Adress"].ToString();
                textBox28.Text = da["Name"].ToString();
                textBox29.Text = da["Password"].ToString();
                dateTimePicker3.Text = da["Dob"].ToString();
                textBox30.Text = da["Phon"].ToString();
                textBox31.Text = da["Email"].ToString();
                textBox32.Text = da["Adress"].ToString();
            }
            con.Close();

            panel4.Visible = false;
            
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            login = new Form1();
            login.Show();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
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

        private void button18_Click(object sender, EventArgs e)
        {
            
            
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Select BName,Price FROM BookList Where BName ='" + textBox16.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView5.DataSource = dt;


                con.Close();
            
        }
        string sBname,orderbname;
        int price;
        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sBname = dataGridView5.Rows[e.RowIndex].Cells["BName"].FormattedValue.ToString();
            price = int.Parse(dataGridView5.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString());
            textBox15.Text = sBname;
            textBox14.Text = price.ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        int gPrice,quantity;
        string tran;

        private void button5_Click(object sender, EventArgs e)
        {
            string deb = "Delivered";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select BookName,TotalPrice,TransactionId,Status from [Order] where TransactionId ='" + textBox22.Text + "' and Status='" + deb + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            tran = textBox22.Text;
            cmd.ExecuteNonQuery();

            con.Close();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [Order] SET Status=@Status,CancelReason=@CancelReason", con);
            cmd.Parameters.AddWithValue("Status", "Canceled");
            cmd.Parameters.AddWithValue("CancelReason", textBox23.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Done");
            textBox22.Text = null;
            textBox23.Text = null;

        }
        void find2()
        {
            int sq = 1;
            int nsq = 2;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Conva SET sq=@sq where sq ='" + sq + "'", con);
    
            cmd.Parameters.AddWithValue("@sq", nsq);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string pos = "Customer";
            find2();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Conva SET convo=@convo,sq=@sq where NameID ='" + name + "' and Position='" + pos + "'", con);
            convo = convo + "\n" +name+": "+ textBox25.Text;
            cmd.Parameters.AddWithValue("@convo", convo);
            cmd.Parameters.AddWithValue("@sq", 1);
            cmd.ExecuteNonQuery();

            con.Close();
            d();
            MessageBox.Show("Done");
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select BookName,BookPrice,Quantity,TransactionId,TotalPrice,Adress,Status from [Order] where UserName ='" + name + "' and Password='" + pasword + "' and TransactionId='" + textBox24.Text+ "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;
                 cmd.ExecuteNonQuery();

            con.Close();
            }
            else if(radioButton1.Checked)
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select BookName,BookPrice,Quantity,TransactionId,TotalPrice,Adress,Status from [Order] where UserName ='" + name + "' and Password='" + pasword + "' and BookName='" + textBox24.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;
                cmd.ExecuteNonQuery();

                con.Close();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int tep;
            tep = price * int.Parse(comboBox3.Text);
            gPrice = tep + gPrice;
            textBox9.Text = gPrice.ToString();
            quantity = quantity + int.Parse(comboBox3.Text);
            orderbname = orderbname + "," + sBname;
            int n = dataGridView2.Rows.Add();
            dataGridView2.Rows[n].Cells[0].Value = textBox15.Text;
            dataGridView2.Rows[n].Cells[1].Value = comboBox3.Text;
            dataGridView2.Rows[n].Cells[2].Value = gPrice;

            textBox15.Text = null;
            textBox14.Text = null;
            comboBox3.Text = null;



        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Order](BookName,BookPrice,Quantity,TotalPrice,TransactionId,UserName,Phone,Adress,Status,Password) VALUES (@BookName,@BookPrice,@Quantity,@TotalPrice,@TransactionId,@UserName,@Phone,@Adress,@Status,@Password)", con);
            cmd.Parameters.AddWithValue("@BookName", orderbname);
            cmd.Parameters.AddWithValue("@BookPrice", price);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            Random r = new Random();

            cmd.Parameters.AddWithValue("@TransactionId", r.Next(0,10000));
            
            cmd.Parameters.AddWithValue("@TotalPrice", gPrice);
            cmd.Parameters.AddWithValue("@UserName", name);
            cmd.Parameters.AddWithValue("@Phone", phon);
            cmd.Parameters.AddWithValue("@Adress", adress);
            cmd.Parameters.AddWithValue("@Status", "Ordered");
            cmd.Parameters.AddWithValue("@Password", pasword);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Done");










        }

        private void button15_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Register SET Name=@Name,Email=@Email,Adress=@Adress,Phon=@Phon,Password=@Password,Dob=@Dob where Name ='" + name + "' and Password='" + pasword +  "'", con);
            cmd.Parameters.AddWithValue("@Name", textBox28.Text);
            cmd.Parameters.AddWithValue("@Email", textBox31.Text);
            cmd.Parameters.AddWithValue("@Adress", textBox32.Text);
            cmd.Parameters.AddWithValue("@Phon", textBox30.Text);
            cmd.Parameters.AddWithValue("@Password", textBox29.Text);
            cmd.Parameters.AddWithValue("@Dob", dateTimePicker3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
            
        }

        
    }
}
