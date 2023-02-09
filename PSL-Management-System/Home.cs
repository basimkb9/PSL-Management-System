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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(String.Equals(comboBox1.Text, "Karachi Kings"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM KARACHI_KINGS_PLAYERS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);

            }
            else if (String.Equals(comboBox1.Text, "Lahore Qalandars"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM LAHORE_QALANDARS_PLAYERS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);

            }
            else if (String.Equals(comboBox1.Text, "Islamabad United"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM ISLAMABAD_UNITED_PLAYERS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);

            }
            else if (String.Equals(comboBox1.Text, "Quetta Gladiators"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM QUETTA_GLADIATORS_PLAYERS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);

            }
            else if (String.Equals(comboBox1.Text, "Peshawar Zalmi"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM PESHAWAR_ZALMI_PLAYERS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);

            }
            else if (String.Equals(comboBox1.Text, "Multan Sultan"))
            {
                string conString = "Data Source=DESKTOP-1ID9T28\\TABISHSQL;Initial Catalog=PSL;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string displayQuery = "SELECT * FROM MULTAN_SULTANS_PLAYERS";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = displayQuery;
                cmd.ExecuteNonQuery();

                displayData(displayQuery);

            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            displayData("SELECT * FROM TEAMS");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Players_stats form = new Players_stats();
            this.Hide();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Matches form = new Matches();
            this.Hide();
            form.ShowDialog();
        }
    }
}
