using MySql.Data.MySqlClient;
using System.Data;

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
    }
}