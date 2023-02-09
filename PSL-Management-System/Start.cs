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

namespace PSL_Project
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            //Login form = new Login();
            this.Hide();
            //form.ShowDialog();

            Login login = new Login();
            login.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
