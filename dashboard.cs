using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Liberary_management_system
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminmain ad = new adminmain();
            ad.Show();
        }
        SqlConnection con;
        private void dashboard_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();
            string query1 = "select * from book where id=1";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                textBox1.Text = reader1[2].ToString();
                textBox26.Text = reader1[4].ToString();
                textBox39.Text = reader1[3].ToString();
            }
            con.Close();


            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();
            string query2 = "select * from book where id=2";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                textBox2.Text = reader2[2].ToString();
                textBox25.Text = reader2[4].ToString();
                textBox38.Text = reader2[3].ToString();
            }
            con.Close();


            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();
            string query3 = "select * from book where id=3";
            SqlCommand cmd3 = new SqlCommand(query3, con);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            if (reader3.Read())
            {
                textBox3.Text = reader3[2].ToString();
                textBox24.Text = reader3[4].ToString();
                textBox37.Text = reader3[3].ToString();
            }
            con.Close();


            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();
            string query4 = "select * from book where id=4";
            SqlCommand cmd4 = new SqlCommand(query4, con);
            SqlDataReader reader4 = cmd4.ExecuteReader();
            if (reader4.Read())
            {
                textBox4.Text = reader4[2].ToString();
                textBox23.Text = reader4[4].ToString();
                textBox36.Text = reader4[3].ToString();
            }
            con.Close();


            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();
            string query5 = "select * from book where id=5";
            SqlCommand cmd5 = new SqlCommand(query5, con);
            SqlDataReader reader5 = cmd5.ExecuteReader();
            if (reader5.Read())
            {
                textBox5.Text = reader5[2].ToString();
                textBox22.Text = reader5[4].ToString();
                textBox35.Text = reader5[3].ToString();
            }
            con.Close();


            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();
            string query6 = "select * from book where id=6";
            SqlCommand cmd6 = new SqlCommand(query6, con);
            SqlDataReader reader6 = cmd6.ExecuteReader();
            if (reader6.Read())
            {
                textBox6.Text = reader6[2].ToString();
                textBox21.Text = reader6[4].ToString();
                textBox34.Text = reader6[3].ToString();
            }
            con.Close();


            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();
            string query7 = "select * from book where id=7";
            SqlCommand cmd7 = new SqlCommand(query7, con);
            SqlDataReader reader7 = cmd7.ExecuteReader();
            if (reader7.Read())
            {
                textBox7.Text = reader7[2].ToString();
                textBox20.Text = reader7[4].ToString();
                textBox33.Text = reader7[3].ToString();
            }
            con.Close();


            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();
            string query8 = "select * from book where id=8";
            SqlCommand cmd8 = new SqlCommand(query8, con);
            SqlDataReader reader8 = cmd8.ExecuteReader();
            if (reader8.Read())
            {
                textBox8.Text = reader8[2].ToString();
                textBox19.Text = reader8[4].ToString();
                textBox32.Text = reader8[3].ToString();
            }
            con.Close();


            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();
            string query9 = "select * from book where id=9";
            SqlCommand cmd9 = new SqlCommand(query9, con);
            SqlDataReader reader9 = cmd9.ExecuteReader();
            if (reader9.Read())
            {
                textBox9.Text = reader9[2].ToString();
                textBox18.Text = reader9[4].ToString();
                textBox31.Text = reader9[3].ToString();
            }
            con.Close();


            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();
            string query10 = "select * from book where id=10";
            SqlCommand cmd10 = new SqlCommand(query10, con);
            SqlDataReader reader10 = cmd10.ExecuteReader();
            if (reader10.Read())
            {
                textBox10.Text = reader10[2].ToString();
                textBox17.Text = reader10[4].ToString();
                textBox30.Text = reader10[3].ToString();
            }
            con.Close();


            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();
            string query11 = "select * from book where id=11";
            SqlCommand cmd11 = new SqlCommand(query11, con);
            SqlDataReader reader11 = cmd11.ExecuteReader();
            if (reader11.Read())
            {
                textBox11.Text = reader11[2].ToString();
                textBox16.Text = reader11[4].ToString();
                textBox29.Text = reader11[3].ToString();
            }
            con.Close();


            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();
            string query12 = "select * from book where id=12";
            SqlCommand cmd12 = new SqlCommand(query12, con);
            SqlDataReader reader12 = cmd12.ExecuteReader();
            if (reader12.Read())
            {
                textBox12.Text = reader12[2].ToString();
                textBox15.Text = reader12[4].ToString();
                textBox28.Text = reader12[3].ToString();
            }
            con.Close();


            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();
            string query13 = "select * from book where id=13";
            SqlCommand cmd13 = new SqlCommand(query13, con);
            SqlDataReader reader13 = cmd13.ExecuteReader();
            if (reader13.Read())
            {
                textBox13.Text = reader13[2].ToString();
                textBox14.Text = reader13[4].ToString();
                textBox27.Text = reader13[3].ToString();
            }
            con.Close();


             textBox1.Enabled = false;
             textBox2.Enabled = false;
             textBox3.Enabled = false;
             textBox4.Enabled = false;
             textBox5.Enabled = false;
             textBox6.Enabled = false;
             textBox7.Enabled = false;
             textBox8.Enabled = false;
             textBox9.Enabled = false;
             textBox10.Enabled = false;
             textBox11.Enabled = false;
             textBox12.Enabled = false;
             textBox13.Enabled = false;
             textBox14.Enabled = false;
             textBox15.Enabled = false;
             textBox16.Enabled = false;
             textBox17.Enabled = false;
             textBox18.Enabled = false;
             textBox19.Enabled = false;
             textBox20.Enabled = false;
             textBox21.Enabled = false;
             textBox22.Enabled = false;
             textBox23.Enabled = false;
             textBox24.Enabled = false;
             textBox25.Enabled = false;
             textBox26.Enabled = false;
             textBox27.Enabled = false;
             textBox28.Enabled = false;
             textBox29.Enabled = false;
             textBox30.Enabled = false;
             textBox31.Enabled = false;
             textBox32.Enabled = false;
             textBox33.Enabled = false;
             textBox34.Enabled = false;
             textBox35.Enabled = false;
             textBox36.Enabled = false;
             textBox37.Enabled = false;
             textBox38.Enabled = false;
             textBox39.Enabled = false;
             
            

            


            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            book b = new book();
            b.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
