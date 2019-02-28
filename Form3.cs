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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string country = textBox2.Text;
            string email = textBox3.Text;
            string pass1 = textBox4.Text;
            string pass2 = textBox5.Text;

            if (name=="" || country=="" || email=="" || pass1=="" || pass2=="")
            {
                label6.Text = "Please fill complete infomation";
            }
            else
            {
                label6.Text = "";
                if(pass1==pass2)
                {
                    if (checkBox1.Checked == true)
                    {
                        SqlCommand cmd = new SqlCommand("insert into loglms(username,password,country,email)values('" + name + "','" + pass1 + "','" + country + "','" + email + "')", con);
                        cmd.ExecuteNonQuery();

                        label7.Text = "";
                        this.Hide();
                        Form4 f4 = new Form4();
                        f4.Show();
                    }
                    else
                    {
                        label14.Text = "First Accept our Terms and conditions";
                    }
                }
                else
                {
                    label7.Text = "incorrect re type password";
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();
            checkBox1.Checked = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int save = r.Next(100000, 999999);
            textBox4.Text = Convert.ToString(save);
            textBox5.Text = Convert.ToString(save);
            label13.Text = "Your auto generated password is   " + save;

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
