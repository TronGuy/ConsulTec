using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using ConsulTec.View;

namespace ProjectMurataConsul.DAO
{
    
    class conexoes
    {
        
        public void TestarConexao()
        {
            //FUNCIONANDO
            string parametros = "Server=localhost;Database=BD;Uid=root;Pwd= ;";
            MySqlConnection connection = new MySqlConnection(parametros);

            string Sql = "DESC USERS_LOGIN;";
            MySqlCommand comando = new MySqlCommand(Sql, connection);
            try

            {
                connection.Open();
                MySqlDataReader reader = comando.ExecuteReader();


                while (connection.State == System.Data.ConnectionState.Open)
                {

                    break;
                }
                connection.Close();
                connection.Dispose();
            }

            catch
            {
                var a = MessageBox.Show("A CONEXÃO COM O BANCO DE DADOS FALHOU", "ERRO DE CONEXÃO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

                if (a == DialogResult.Retry)
                {
                    TestarConexao();
                }
                else
                {

                    Application.Exit();
                }

                connection.Close();
                connection.Dispose();

            }
        }

        public void login(string login, string senha, Form formulario)
       
	 {
            //FUNCIONANDO
            
            NavigationFRM navigation = new NavigationFRM();
            string parametros = "Server=localhost;Database=BD;Uid=root;Pwd= ;";
            MySqlConnection connection = new MySqlConnection(parametros);

            string Sql = String.Format("SELECT * FROM users_login where login='{0}' and senha='{1}';", login, senha);
            MySqlCommand comando = new MySqlCommand(Sql, connection);
            
	    try
            
	      {

                connection.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())

                    {


                    }

                    formulario.Hide();
                    GC.Collect(0); //Garbage Collector

                    navigation.Show();
                    
                }
                else
                {
                    MessageBox.Show("Login ou senha estão errados","DADOS INCORRETOS",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch
            {

                TestarConexao();
              
            }

            connection.Close();
        }

      

  


            public void BtnBuscar(string buscar,ListBox listBoxCadastros)
        {
            
            TestarConexao();
            string parametros = "Server=localhost;Database=BD;Uid=root;Pwd= ;";
            MySqlConnection connection = new MySqlConnection(parametros);

            string Sql = "SELECT * FROM users_cadastro WHERE nome="+"'"+buscar+"'";
            MySqlCommand comando = new MySqlCommand(Sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    listBoxCadastros.Items.Add(reader.GetString("nome"));

                   

                }
                

                //listBoxCadastros.Items.Clear();

            }

            catch
            {

                MessageBox.Show("Não foi possível encontrar o cadastro. Por favor,tente com um cadastro diferente", "CADASTRO NÃO ENCONTRADO", default,MessageBoxIcon.Exclamation); ;

            }

            connection.Close();


        }

        public void CadastroAcessosLogin(string login,string senha,string categoria)
        {
            TestarConexao();
            string parametros = "Server=localhost;Database=BD;Uid=root;Pwd= ;";
            MySqlConnection connection = new MySqlConnection(parametros);

            string Sql = "INSERT INTO users_login VALUES("+"'"+login+"',"+"'"+senha+"'"+",'"+categoria+"')";
            MySqlCommand comando = new MySqlCommand(Sql, connection);
      
            try
            {
                connection.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                if (!reader.HasRows)
                {
                    while (reader.Read()){}

                    MessageBox.Show("O acesso foi cadastrado\nLogin:" + login + "\nSenha:" + senha, "CADASTRO EFETUADO COM SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Alguém ja possui este login. Tente novamente com um login diferente", "CADASTRO EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            
        }
    }
}