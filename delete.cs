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
    
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }
        SqlConnection con;
        int p1 = 0;
        int p2 = 0;
        private void delete_Load(object sender, EventArgs e)
        {

          
            

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


            string name="";
            string bname="";
            string number="";
            string country="";
            string idate="";
            string rdate = DateTime.Now.ToString("MM/dd/yyyy");
            int pin = Convert.ToInt32(textBox1.Text);
            int op = 0;

             
            if (textBox1.Text == "")
            {
                label2.Text = "This field is required";
            }
            else
            {
                con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
                con.Open();
                string query = "select * from lms where pin = " + textBox1.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                     name = reader[1].ToString();
                     bname= reader[2].ToString();
                     number = reader[3].ToString();
                     country = reader[4].ToString();
                     idate = reader[5].ToString();
                     op = Convert.ToInt32(reader[8].ToString());

                     

                }
                else
                {
                    MessageBox.Show("Invalid pin");
                }
                con.Close();
                reader.Close();
                




                con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
                con.Open();
                string query1 = "select * from book where id = " + op + "";
                SqlCommand czd = new SqlCommand(query1, con);
                SqlDataReader read = czd.ExecuteReader();
                if (read.Read())
                {

                    p1 = Convert.ToInt32(read[3].ToString()); // 0
                    p2 = Convert.ToInt32(read[4].ToString()); // 20 
                    

                }
                con.Close();
                read.Close();

                if (p1 > 0)
                {

                    p2++;
                    p1--;

                    string a1 = Convert.ToString(p1);
                    string a2 = Convert.ToString(p2);


                    con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
                    con.Open();

                    SqlCommand cld = new SqlCommand("UPDATE book SET issue='" + a1 + "',reamining='" + a2 + "' WHERE id=" + op + "", con);
                    cld.ExecuteNonQuery();
                    con.Close();



                    con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
                    con.Open();

                    string myqurey = "insert into lmsret(name,book,contact,country,issue_date,return_date,pin)values('" + name + "','" + bname + "','" + number + "','" + country + "','" + idate + "','" + rdate + "'," + pin + ")";

                    SqlCommand cqd = new SqlCommand(myqurey, con);
                    cqd.ExecuteNonQuery();

                    con.Close();



                    label2.Text = "";
                    con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
                    con.Open();
                    SqlCommand cnd = new SqlCommand("delete from lms where pin=" + textBox1.Text + "", con);
                    cnd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Operation sucess");


                }
                else
                {
                    MessageBox.Show("You have not any issued book");
                }









            }
                string userdate = DateTime.Now.ToString("MM");
                int sd = Convert.ToInt32(userdate);

                con.Open();

                string olddate = "";
                int oldd = 0;

                string din = "";
                int diyint = 0;

                if (textBox1.Text != "")
                {
                    con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
                    con.Open();
                    string query = "select * from dms where pin = " + textBox1.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        olddate = reader[0].ToString();
                        din = reader[3].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Invalid pin");
                    }
                    oldd = Convert.ToInt32(olddate);
                    diyint = Convert.ToInt32(din);
                    con.Close();
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("This field is required");
                }

                string newdate = DateTime.Now.ToString("MM");
                int newd = Convert.ToInt32(newdate);


                if (diyint >= 22)
                {
                    newd--;
                }



                if (newd > oldd)
                {
                    MessageBox.Show("Now you will charge RS 500 as a fine of late book return\n Please send Rs 500 through easypaisa on this number \n 0345-3279744\n\n otherwise we will take strick action");
                }
                else
                {
                    MessageBox.Show("thanks for return at time");
                }

            }
            catch
            {
                MessageBox.Show("Please enter an numerical correct unique pin and try again");
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
            Application.Exit();
        }
    }
}
