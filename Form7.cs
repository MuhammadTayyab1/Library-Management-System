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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection con;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                label2.Text = "Please enter unique pin";
            }
            else
            {

                try
                {
                    label2.Text = "";
                    con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
                    con.Open();
                    SqlDataAdapter adp = new SqlDataAdapter("select * from lms where pin=" + textBox1.Text + "", con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                
                
                if (dt.Rows.Count > 0)
                {
                    con.Close();
                    label2.Text = "";
                    label3.Text = "";
                    con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
                    con.Open();
                    SqlDataAdapter dtp = new SqlDataAdapter("select * from lms where pin=" + textBox1.Text + "", con);
                    DataTable dp = new DataTable();
                    dtp.Fill(dp);
                    dataGridView1.DataSource = dp;
                }
                else
                {
                    label3.Text = "Incorrect unique pin";
                }

                }
                catch
                {
                    MessageBox.Show("only allow to enter 4 digits numerical unique pin");
                }


                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f1 = new Form4();
            f1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
