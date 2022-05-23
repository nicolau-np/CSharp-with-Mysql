using MySql.Data.MySqlClient;
using System.Data;
using WinFormsApp1.controller;
using WinFormsApp1.model;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = AppSettings.connectionString();
            MySqlConnection mySqlConnection = new MySqlConnection(constring);   
            mySqlConnection.Open();
            if (mySqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexão Aberta com sucesso");
            }
            else { 
                MessageBox.Show("Erro na conexao");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User();
            UserController userController = new UserController();
            user.username = txtUsername.Text;
            user.password = txtPassword.Text;
            user.estado = txtEstado.Text;

            String usersms = userController.store();
            MessageBox.Show(usersms);

        }
    }
}