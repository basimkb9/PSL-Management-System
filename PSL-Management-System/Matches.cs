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
    public partial class Matches : Form
    {
        public Matches()
        {
            InitializeComponent();
        }

        public void displayData(String query)
        {
            string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string displayQuery = query;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = displayQuery;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.Equals(comboBox1.Text, "All Matches"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM MATCHES";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);

            }
            else if (String.Equals(comboBox1.Text, "Match 28"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM MATCH_28";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);
            }
            else if (String.Equals(comboBox1.Text, "Match 29"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM MATCH_29";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);
            }
            else if (String.Equals(comboBox1.Text, "Match 30"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM MATCH_30";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);
            }
            else if (String.Equals(comboBox1.Text, "Eliminator 1"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM Eliminator_1";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);
            }
            else if (String.Equals(comboBox1.Text, "Eliminator 2"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM Eliminator_2";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);
            }
            else if (String.Equals(comboBox1.Text, "Final"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM FINAL";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            this.Hide();
            form.ShowDialog();
        }
    }
}
