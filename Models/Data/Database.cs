using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace KoronaTakipV2.Models.Data
{
    
    public class Database
    {
        public static string _serverName = ".\\MSSQLSERVER2019";
        public static string _databaseName = "mavzerba_KoronaTakip";
        public static string _dbUser = "mavzerba_mavzerbay";
        public static string _dbUserPassword = "1q2w3e4r5tmav75";

        public Database()
        {
            string connection = 
                        "Data Source=" + _serverName +
                        ";Initial Catalog=" + _databaseName +
                        ";User ID=" + _dbUser +
                        ";Password=" + _dbUserPassword;
            con = new SqlConnection(connection);
        }

        SqlConnection con;


        public bool Komut(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                con.Close();
                throw new Exception(ex.Message, ex);
            }
        }
        public DataTable TableDataTable(string sql)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                con.Close();
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
