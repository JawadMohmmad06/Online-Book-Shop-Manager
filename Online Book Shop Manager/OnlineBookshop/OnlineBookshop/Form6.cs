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
    public partial class Form6 : Form
    {
        Form1 login;
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login= new Form1();
            login.Show();

        }
        void convo(string n)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Conva(NameID,Position) VALUES (@NameID,@Position)", con);
            cmd.Parameters.AddWithValue("@NameID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Position", "Customer");
            cmd.ExecuteNonQuery();
            con.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V73H055;Initial Catalog=OnlineBookShop;Persist Security Info=True;User ID=sa;Password=028054803");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Register(Name,Email,Adress,Phon,Password,Dob,Gender) VALUES (@Name,@Email,@Adress,@Phon,@Password,@Dob,@Gender)", con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Email", textBox2.Text);
            cmd.Parameters.AddWithValue("@Adress", textBox3.Text);
            cmd.Parameters.AddWithValue("@Phon", textBox4.Text);
            cmd.Parameters.AddWithValue("@Password", textBox5.Text);
            cmd.Parameters.AddWithValue("@Dob", dateTimePicker1.Text);
            if (radioButton1.Checked)
            {
                cmd.Parameters.AddWithValue("@Gender", radioButton1.Text);
            }
            else if (radioButton2.Checked)
            {
                cmd.Parameters.AddWithValue("@Gender", radioButton2.Text);
            }
            cmd.ExecuteNonQuery();
            con.Close();
            convo(textBox1.Text);
            MessageBox.Show("Successfully registered");
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }
        
    }
}
