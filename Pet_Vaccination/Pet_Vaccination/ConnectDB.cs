using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Pet_Vaccination
{
    class InfoDB
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=pet_vaccination";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Connecgtion! \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
        public static void saveUpdateDeleteData(string sql, string action)
        {
            string query = sql;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(action);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error!!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void dgvViewing(string sqlQuery, DataGridView dgv)
        {
            string sql = sqlQuery;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;

            con.Close();

        }
        public static bool GetAdminPassword(TextBox username, TextBox password)
        {
            bool checker = false;
            string sql = "SELECT COUNT(*) FROM account WHERE Username=@Username AND Password=@Password";

            using (MySqlConnection con = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.Add(new MySqlParameter("@Username", username.Text));
                cmd.Parameters.Add(new MySqlParameter("@Password", password.Text));

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    checker = true;
                    InfoStorage.infoSet.Username = username.Text;
                }
            }
            return checker;
        }
        public static void getMax()
        {
            string query = "SELECT MAX(`Customer ID`) as maxID from customer_info";
            MySqlConnection con = InfoDB.GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    if (((dataReader["maxID"]).ToString()) == "")
                    {
                        InfoStorage.infoSet.maxId = 1;
                    }
                    else
                    {
                        int idnum = int.Parse((dataReader["maxID"]).ToString());
                        InfoStorage.infoSet.maxId = idnum + 1;
                    }
                }
                dataReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}