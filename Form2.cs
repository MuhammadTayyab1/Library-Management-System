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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;

            SqlDataAdapter adp = new SqlDataAdapter("select * from loglms where username='" + user + "'and password='" + pass + "'", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Form4 f4 = new Form4();
                f4.Show();
            }
            else
            {
                label3.Text = "Incorrect username or password";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact us \n 0300-2507605 \n OR \n +1(202)9719510");
        }
    }
}
