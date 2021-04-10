using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Sistema_Mercado.Models;

namespace Sistema_Mercado.Controllers
{
    class ServicoController
    {
        private MySqlConnection con;
        private Connection.Connection connection;

        public void cadastraServico(Servico novoServico)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            string query = "CALL cadsatra_servicos(?descricao, ?preco);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?descricao", novoServico.Descricao);
                command.Parameters.AddWithValue("?preco", novoServico.Preco);

                command.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
                MessageBox.Show("Serviço cadastrado com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void atualizaServico(Servico servico)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            string query = "CALL atualiza_servicos(?ID, ?Descricao, ?Preco);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?ID", servico.Id);
                command.Parameters.AddWithValue("?Descricao", servico.Descricao);
                command.Parameters.AddWithValue("?Preco", servico.Preco);

                command.ExecuteNonQuery();

                MessageBox.Show("Serviço atualizado com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
