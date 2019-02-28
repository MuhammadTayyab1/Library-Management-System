using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liberary_management_system
{
    public partial class adminmain : Form
    {
        public adminmain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f6 = new Form1();
            f6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            returnbooks rb = new returnbooks();
            rb.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard db = new dashboard();
            db.Show();
        }
    }
}
