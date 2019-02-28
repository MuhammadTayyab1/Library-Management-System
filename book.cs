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
    public partial class book : Form
    {
        public book()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard ds = new dashboard();
            ds.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void book_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();

            SqlDataAdapter sdt = new SqlDataAdapter("select * from book", con);
            DataTable dt = new DataTable();
            sdt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
