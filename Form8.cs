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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                label5.Text = "All fields are required";
            }
            else
            {
                label5.Text = "";
                con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
                con.Open();

                SqlCommand cnd = new SqlCommand("UPDATE lms SET member_name='" + textBox1.Text + "',contact_number='" + textBox2.Text + "',country='" + textBox3.Text + "' WHERE pin=" + textBox4.Text + "", con);
                cnd.ExecuteNonQuery();
                MessageBox.Show("Operation Sucess");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f1 = new Form4();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            { 
            if (textBox4.Text != "")
            {
                label6.Text = "";
                con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
                con.Open();
                string query = "select * from lms where pin = " + textBox4.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = reader[1].ToString();
                    textBox2.Text = reader[3].ToString();
                    textBox3.Text = reader[4].ToString();

                }
                else
                {
                    MessageBox.Show("Invalid pin");
                }

                con.Close();
                reader.Close();
            }
            else
            {
                label6.Text = "This field is required";
            }
            }
            catch
            {
                MessageBox.Show("only allow enter 4 digits numerical unique pin");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
