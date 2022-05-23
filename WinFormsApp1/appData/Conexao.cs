using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WinFormsApp1
{
    public class Conexao
    {

        MySqlConnection conn = new MySqlConnection();

        public Conexao()
        {
            conn.ConnectionString = "Server = localhost; Database = csharp; Uid = root; Pwd = ''";
        }

        public MySqlConnection conectar()
        {
            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public void desconectar()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
