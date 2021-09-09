using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace testeCRUDOOP.Classes
{
    class DB
    {
        public MySqlConnection con;

        public DB()
        {
            string host = "127.0.0.1";
            string db = "cpaction";
            string port = "3306";
            string user = "root";
            string pass = "";
            string constring = "datasource = " + host + "; database = " + 
                db + "; port = " + port + "; username = " + user + "; password = " + pass + "; SslMode=none";
            con = new MySqlConnection(constring);
        }
    }

    class CRUD : DB
    {
        public string id { set; get; }
        public string nome { set; get; }
        
        public string tipo { set; get; }

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        public void Create_data()
        {
            con.Open();
            using(MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO carteiras (NOME, TIPO) VALUES (@NOME, @TIPO)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@TIPO", MySqlDbType.VarChar).Value = tipo;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Update_data()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE carteiras SET NOME = @NOME, TIPO = @TIPO WHERE ID = @ID";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@TIPO", MySqlDbType.VarChar).Value = tipo;
                cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;


                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Delete_data()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM carteiras WHERE  ID= @ID";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;


                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Read_data()
        {
            dt.Clear();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                string query = "SELECT * FROM carteiras";

                MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);

                MDA.Fill(ds);
                dt = ds.Tables[0];
            }
        }
    }
}
