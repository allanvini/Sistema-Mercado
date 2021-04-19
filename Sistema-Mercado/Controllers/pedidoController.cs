using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Sistema_Mercado.Models;

namespace Sistema_Mercado.Controllers
{
    class pedidoController
    {
        private MySqlConnection con;
        private Connection.Connection connection;

        public void cadastraPedido(Pedido novoPedido)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            string query = "CALL cadastra_pedido(?vendedorID, ?clienteID, ?formaPagamento);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?vendedorID", novoPedido.VendedorID);
                command.Parameters.AddWithValue("?clienteID", novoPedido.ClienteID);
                command.Parameters.AddWithValue("?formaPagamento", novoPedido.Forma_pagamento);

                command.Dispose();

                MySqlDataReader MySqlDR = command.ExecuteReader();
                MySqlDR.Read();

                novoPedido.PedidoID = Convert.ToInt32(MySqlDR.GetString(0));

                this.cadastraProdutosPedido(novoPedido);
                this.cadastraServicosPedido(novoPedido);
            }
            finally
            {
                con.Close();

                MessageBox.Show("Pedido registrado com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cadastraProdutosPedido(Pedido novoPedido)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            con.Open();

            for (int index = 0; index < novoPedido.Produtos.Length; index++)
            {
                if (novoPedido.Produtos[index] != null)
                {
                    string query = "CALL cadastra_produto_pedido(?pedido_ID, ?produto_ID, ?produto_QTD);";

                    MySqlCommand command = new MySqlCommand(query, con);

                    command.Parameters.AddWithValue("?pedido_ID", novoPedido.PedidoID);
                    command.Parameters.AddWithValue("?produto_ID", novoPedido.Produtos[index].Id);
                    command.Parameters.AddWithValue("?produto_QTD", novoPedido.Produtos[index].Quantidade);

                    command.ExecuteNonQuery();
                }
            }
            con.Close();
        }

        private void cadastraServicosPedido(Pedido novoPedido)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            con.Open();

            for (int index = 0; index < novoPedido.Servicos.Length; index++)
            {
                if(novoPedido.Servicos[index] != null)
                {
                    string query = "CALL cadastra_servico_pedido(?pedido_ID, ?servico_ID);";

                    MySqlCommand command = new MySqlCommand(query, con);

                    command.Parameters.AddWithValue("?pedido_ID", novoPedido.PedidoID);
                    command.Parameters.AddWithValue("?servico_ID", novoPedido.Servicos[index].Id);

                    command.ExecuteNonQuery();
                }
            }

            con.Close();
        }

        public void excluirPedido(int pedidoID)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            string query = "CALL excluir_pedido(?PedidoID);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?PedidoID", pedidoID);

                command.ExecuteNonQuery();
            }
            finally
            {
                con.Close();

                MessageBox.Show("Pedido removido com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void quitaPedido(int pedidoID)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            string query = "CALL quita_pedido(?PedidoID);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?PedidoID", pedidoID);

                command.ExecuteNonQuery();
            }
            finally
            {
                con.Close();

                MessageBox.Show("Pedido quitado.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
