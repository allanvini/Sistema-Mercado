using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                //command.ExecuteNonQuery();
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
            }
        }

        private void cadastraProdutosPedido(Pedido novoPedido)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            string query = "CALL cadastra_produto_pedido(?pedido_ID, ?produto_ID, ?produto_QTD);";

            con.Open();
            MySqlCommand command = new MySqlCommand(query, con);

            for (int index = 0; index < novoPedido.Produtos.Length; index++)
            {
                if (novoPedido.Produtos[index] != null)
                {
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

            string query = "CALL cadastra_servico_pedido(?pedido_ID, ?servico_ID);";

            con.Open();
            MySqlCommand command = new MySqlCommand(query, con);

            for(int index = 0; index < novoPedido.Servicos.Length; index++)
            {
                if(novoPedido.Servicos[index] != null)
                {
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
            }
        }

    }
}
