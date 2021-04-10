using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Sistema_Mercado.Models;

namespace Sistema_Mercado.Controllers
{
    class clienteController
    {
        private MySqlConnection con;
        private Connection.Connection connection;
        private int newClientID;
        private Cliente novoCliente;

        public Cliente NovoCliente { get => novoCliente; set => novoCliente = value; }

        public void cadastraCliente()
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            string dataNascimento = $"{NovoCliente.DiaDataNascimento}-{NovoCliente.MesDataNascimento}-{NovoCliente.AnoDataNascimento}";
             
            string query = "CALL cadastra_cliente(?nome, ?CPF, ?dataNascimento, ?email);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?nome", NovoCliente.Nome);
                command.Parameters.AddWithValue("?CPF", NovoCliente.CPF1);
                command.Parameters.AddWithValue("?dataNascimento", dataNascimento);
                command.Parameters.AddWithValue("?email", NovoCliente.Email);

                command.Dispose();

                MySqlDataReader MySqlDR = command.ExecuteReader();
                MySqlDR.Read();

                this.newClientID = Convert.ToInt32(MySqlDR.GetString(0));

            }
            finally
            {
                con.Close();
                this.cadastraEnderecosCliente();

                MessageBox.Show("Cliente adidionado com sucesso!", "Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cadastraEnderecosCliente()
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            try
            {
                con.Open();

                for (int index = 0; index < this.novoCliente.Enderecos.Length; index++)
                {
                    if (this.novoCliente.Enderecos[index] != null)
                    {

                        string query = "CALL cadastra_endereco_cliente(?ID_cliente, ?Rua, ?Bairro, ?Cidade, ?Estado, ?CEP);";
                        MySqlCommand command = new MySqlCommand(query, con);

                        command.Parameters.AddWithValue("?ID_cliente", this.newClientID);
                        command.Parameters.AddWithValue("?Rua", this.novoCliente.Enderecos[index].Rua);
                        command.Parameters.AddWithValue("?Bairro", this.novoCliente.Enderecos[index].Bairro);
                        command.Parameters.AddWithValue("?Cidade", this.novoCliente.Enderecos[index].Cidade);
                        command.Parameters.AddWithValue("?Estado", this.novoCliente.Enderecos[index].Estado);
                        command.Parameters.AddWithValue("?CEP", this.novoCliente.Enderecos[index].CEP1);

                        command.ExecuteNonQuery();
                    }
                }
            }
            finally
            {
                con.Close();
            }

        }

        public void deletaCliente(int ClientID)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            string query = "CALL deleta_cliente(?ID_Cliente)";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?ID_Cliente", ClientID);

                command.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
                MessageBox.Show("Cliente excluido com sucesso!", "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
}
