using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Sistema_Mercado.Controllers
{
    class FuncionarioController
    {
        private MySqlConnection con;
        private Connection.Connection connection;

        public Models.Funcionario loginFuncionario(string login, string password)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            Models.Funcionario funcionario = null;

            string query = "CALL loga_funcionario(?login, ?senha)";

            try
            {
                con.Open();

                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?login", login);
                command.Parameters.AddWithValue("?senha", password);

                command.ExecuteNonQuery();
                command.Dispose();

                MySqlDataReader MySqlDR = command.ExecuteReader();
                MySqlDR.Read();

                try
                {
                    funcionario = new Models.Funcionario(Convert.ToInt32(MySqlDR.GetString(0)), MySqlDR.GetString(1), MySqlDR.GetString(2));
                }
                catch
                {
                    MessageBox.Show("Login ou senha incorretos", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                con.Close();
            }

            return funcionario;
        }
    }
}
