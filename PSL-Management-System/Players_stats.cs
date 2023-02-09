using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSL_Project
{
    public partial class Players_stats : Form
    {
        public Players_stats()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void Players_stats_Load(object sender, EventArgs e)
        {
            displayData("SELECT * FROM BATTING_STATS");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            this.Hide();
            form.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (String.Equals(comboBox1.Text, "Over All PSL Batting Stats"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM BATTING_STATS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);

            }
            else if (String.Equals(comboBox1.Text, "Over All PSL Bowling Stats"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM BOWLING_STATS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);

            }
            else if (String.Equals(comboBox1.Text, "Karachi Kings Batting Stats"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM KARACHI_KINGS_BATTING_STATS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);

            }
            else if (String.Equals(comboBox1.Text, "Karachi Kings Bowling Stats"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM KARACHI_KINGS_BOWLING_STATS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);

            }
            else if (String.Equals(comboBox1.Text, "Lahore Qalandars Batting Stats"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM LAHORE_QALANDARS_BATTING_STATS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);
            }
            else if (String.Equals(comboBox1.Text, "Lahore Qalandars Bowling Stats"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM LAHORE_QALANDARS_BOWLING_STATS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);
            }
            else if (String.Equals(comboBox1.Text, "Islamabad United Batting Stats"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM ISLAMABAD_UNITED_BATTING_STATS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);
            }
            else if (String.Equals(comboBox1.Text, "Islamabad United Bowling Stats"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM ISLAMABAD_UNITED_BOWLING_STATS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);
            }
            else if (String.Equals(comboBox1.Text, "Quetta Gladiators Batting Stats"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM QUETTA_GLADIATORS_BATTING_STATS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);
            }
            else if (String.Equals(comboBox1.Text, "Quetta Gladiators Bowling Stats"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM QUETTA_GLADIATORS_BOWLING_STATS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);
            }
            else if (String.Equals(comboBox1.Text, "Peshawar Zalmi Batting Stats"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM PESHAWAR_ZALMI_BATTING_STATS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);
            }
            else if (String.Equals(comboBox1.Text, "Peshawar Zalmi Bowling Stats"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM PESHAWAR_ZALMI_BOWLING_STATS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);
            }
            else if (String.Equals(comboBox1.Text, "Multan Sultans Batting Stats"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM MULTAN_SULTANS_BATTING_STATS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);
            }
            else if (String.Equals(comboBox1.Text, "Multan Sultans Bowling Stats"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM MULTAN_SULTANS_BOWLING_STATS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);
            }
        }
    }
}
