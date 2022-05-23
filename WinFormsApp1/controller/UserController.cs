using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using WinFormsApp1.model;

namespace WinFormsApp1.controller
{
    public class UserController
    {
       Conexao conn = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        User user = new User();

        public string mensagem = "";
        
        public string store()
        {
            cmd.CommandText = "insert into utilizadores (username, password, estado) values " +
                "(@username, @password, @estado)";
            cmd.Parameters.AddWithValue("@username", user.username);
            cmd.Parameters.AddWithValue("@password", user.password);
            cmd.Parameters.AddWithValue("@estado", user.estado);
            try
            {
                cmd.Connection = conn.conectar();
                cmd.ExecuteNonQuery();
                conn.desconectar();
                this.mensagem = "Cadastro Feito com sucesso";
            }catch(MySqlException ex)
            {
                this.mensagem = ex+ " Erro ao conectar com o banco de dados";
            }
            return mensagem;
        }

    }
}
