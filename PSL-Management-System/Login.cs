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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string ad_username = "Tabish";
        string ad_password = "123";

        string us_username = "Zaeem";
        string us_password = "456";

        string us_username1 = "Basim";
        string us_password1 = "789";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.Equals(ad_username, textBox1.Text) && string.Equals(ad_password, textBox2.Text))
            {
                MessageBox.Show("Admin Login Succuss");
                Home form = new Home();
                this.Hide();
                form.ShowDialog();
            }
            else if (string.Equals(us_username, textBox1.Text) && string.Equals(us_password, textBox2.Text))
            {
                MessageBox.Show("User Login Succuss");
                Home form = new Home();
                this.Hide();
                form.ShowDialog();
            }
            else if (string.Equals(us_username1, textBox1.Text) && string.Equals(us_password1, textBox2.Text))
            {
                MessageBox.Show("User Login Succuss");
                Home form = new Home();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void Do_Checked()
        {
            button1.Enabled = checkBox1.Checked;
        }

    }
}
