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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();
        }
        SqlConnection con;
        private void button1_Click(object sender, EventArgs e)
        {
            string p = textBox1.Text;
            string u = textBox2.Text;

            string pass = textBox3.Text;
            string pass1 = textBox4.Text;

            if (p=="" || u=="" || pass=="" || pass1=="")
            {
                label6.Text = "All fields are required";
            }
            else
            {
                if (pass == pass1)
                {
                    SqlCommand cnd = new SqlCommand("UPDATE loglms SET password='"+pass+"' WHERE username='" + u + "' and password='" + p + "'", con);
                    cnd.ExecuteNonQuery();
                }
                else
                {
                    label7.Text = "re type password not match";
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
