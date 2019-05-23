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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int op=0;
        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        SqlConnection con;
        int p1 = 0;
        int p2 = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Urdu for class 12");
            comboBox1.Items.Add("English for class 10");
            comboBox1.Items.Add("Math for class 12");
            comboBox1.Items.Add("Chemistry 9th version");
            comboBox1.Items.Add("Physics version 12");
            comboBox1.Items.Add("Programming with phyton");
            comboBox1.Items.Add("Javascript basics");
            comboBox1.Items.Add("C# 10th version");
            comboBox1.Items.Add("Data Base with Sql");
            comboBox1.Items.Add("Geography of world");
            comboBox1.Items.Add("Web development version 8th");
            comboBox1.Items.Add("Web assembly 2018");
            comboBox1.Items.Add("Linux commands");
        }
        string tname;
        string tcontact;
        string tcountry;
        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();

            Random r= new Random();
            

            string mname=textBox1.Text;
            string bname = Convert.ToString(comboBox1.SelectedItem);
            string contact=textBox2.Text;
            string country=textBox3.Text;
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            string time = DateTime.Now.ToString("HH:mm:ss");
            int pin=r.Next(1000,9999);

            if (mname == "" || bname == "" || contact == "" || country == "")
            {
                label5.Text = "Please fill complete info";
                
            }
            else
            {
                if (tname == mname && tcontact == contact && tcountry == country)
                {
                    label6.Text = "You already purchased a book\nTry with another contact number";
                    
                }
                else
                {
                    

                    
                    label6.Text = "";

                    if (bname=="Urdu for class 12")
                    {
                        op = 1;
                    }
                    else if (bname == "English for class 10")
                    {
                        op = 2;
                    }
                    else if (bname == "Math for class 12")
                    {
                        op = 3;
                    }
                    else if (bname == "Chemistry 9th version")
                    {
                        op = 4;
                    }
                    else if (bname == "Physics version 12")
                    {
                        op = 5;
                    }
                    else if (bname == "Programming with phyton")
                    {
                        op = 6;
                    }
                    else if (bname == "Javascript basics")
                    {
                        op = 7;
                    }
                    else if (bname == "C# 10th version")
                    {
                        op = 8;
                    }
                    else if (bname == "Data Base with Sql")
                    {
                        op = 9;
                    }
                    else if (bname == "Geography of world")
                    {
                        op = 10;
                    }
                    else if (bname == "Web development version 8th")
                    {
                        op = 11;
                    }
                    else if (bname == "Web assembly 2018")
                    {
                        op = 12;
                    }
                    else if (bname == "Linux commands")
                    {
                        op = 13;
                    }

                    


                    
                    con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
                    con.Open();
                    string query = "select * from book where id = " + op + "";
                    SqlCommand cqd = new SqlCommand(query, con);
                    SqlDataReader reader = cqd.ExecuteReader();
                    if (reader.Read())
                    {
                        
                        p1 = Convert.ToInt32(reader[3].ToString()); // 0
                        p2 = Convert.ToInt32(reader[4].ToString()); // 20 

                    }

                    

                   
                    con.Close();
                    reader.Close();

                    if (p2 > 0)
                    {

                        p2--;
                        p1++;

                        string a1 = Convert.ToString(p1);
                        string a2 = Convert.ToString(p2);


                        con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
                        con.Open();

                        SqlCommand cyd = new SqlCommand("UPDATE book SET issue='" + a1 + "',reamining='" + a2 + "' WHERE id=" + op + "", con);
                        cyd.ExecuteNonQuery();
                        con.Close();

                        con.Open();
                        
                        SqlCommand cmd = new SqlCommand("insert into lms(member_name,book_name,contact_number,country,date,time,pin,book_id)values('" + mname + "','" + bname + "','" + contact + "','" + country + "','" + date + "','" + time + "'," + pin + ","+op+")", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Please note this pin \n its require when you return , view and update the book info \n\nPin = " + pin);


                        tname = textBox1.Text;
                        tcontact = textBox2.Text;
                        tcountry = textBox3.Text;
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                    }
                    else
                    {
                        MessageBox.Show("there is no book available");
                    }
                }

            }
            string checkdate = DateTime.Now.ToString("MM");
            int cd=Convert.ToInt32(checkdate);

            string checkdin = DateTime.Now.ToString("dd");
            int ctq=Convert.ToInt32(checkdin);

            con.Open();
            SqlCommand ccmmd = new SqlCommand("insert into dms(getdate,pin,gettime)values(" + cd + "," + pin + ","+ctq+")", con);
            ccmmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("if you issue this book before 22 date of this month \n Please return this book before end of this month \n otherwise you will charge late fee");


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
