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
    public partial class returnbooks : Form
    {
        public returnbooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminmain ad = new adminmain();
            ad.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection con;
        private void returnbooks_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=TAYYAB\\SQLEXPRESS;Initial Catalog=Lab;User ID=sa;Password=1234");
            con.Open();
            SqlDataAdapter dtp = new SqlDataAdapter("select * from lmsret", con);
            DataTable dp = new DataTable();
            dtp.Fill(dp);

            dataGridView1.DataSource = dp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
