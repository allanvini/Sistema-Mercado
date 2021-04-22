using System;
using System.Data;
using System.Windows.Forms;
using Sistema_Mercado.Models;
using MySql.Data.MySqlClient;

namespace Sistema_Mercado.Views.Pedidos
{
    public partial class DetalhesPedido : Form
    {
        private double valorTotal = 0;
        private int PedidoID;
        private Connection.Connection connection;


        public DetalhesPedido(int pedidoID)
        {
            InitializeComponent();
            this.PedidoID = pedidoID;
            carregarDados();
            lbl_valorTotal.Text = Convert.ToString(this.valorTotal);
        }

        private void carregarDados()
        {
            this.valorTotal = 0;

            connection = new Connection.Connection();
            dtgv_pedido.DataSource = null;
            dtgv_pedido.Rows.Clear();
            dtgv_pedido.Refresh();

            string connectionString = connection.getConnectionString();

            string query = "CALL consulta_pedido(?PedidoID);";

            using(MySqlConnection con = new MySqlConnection(connectionString))
            {
                using(MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    MySqlCommand command = new MySqlCommand(query, con);
                    command.Parameters.Add("?PedidoID", (MySqlDbType)SqlDbType.Int);
                    command.Parameters["?PedidoID"].Value = this.PedidoID;

                    adapter.SelectCommand = command;
                    adapter.InsertCommand = command;

                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        for(int index = 0; index < dataTable.Rows.Count; index++)
                        {
                            dtgv_pedido.Rows.Add
                            (
                                dataTable.Rows[index][0],
                                dataTable.Rows[index][1],
                                dataTable.Rows[index][2],
                                dataTable.Rows[index][3],
                                dataTable.Rows[index][4],
                                dataTable.Rows[index][5],
                                dataTable.Rows[index][6],
                                dataTable.Rows[index][7]
                            );

                            this.valorTotal += Convert.ToDouble(dataTable.Rows[index][2]) * Convert.ToDouble(dataTable.Rows[index][3]);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }

            dtgv_servicos.DataSource = null;
            dtgv_servicos.Rows.Clear();
            dtgv_servicos.Refresh();

            query = "CALL consulta_pedido_servicos(?PedidoID);";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    MySqlCommand command = new MySqlCommand(query, con);
                    command.Parameters.Add("?PedidoID", (MySqlDbType)SqlDbType.Int);
                    command.Parameters["?PedidoID"].Value = this.PedidoID;

                    adapter.SelectCommand = command;
                    adapter.InsertCommand = command;

                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        for (int index = 0; index < dataTable.Rows.Count; index++)
                        {
                            dtgv_servicos.Rows.Add
                            (
                                dataTable.Rows[index][0],
                                dataTable.Rows[index][1],
                                dataTable.Rows[index][2],
                                dataTable.Rows[index][3],
                                dataTable.Rows[index][4],
                                dataTable.Rows[index][5],
                                dataTable.Rows[index][6]
                            );

                            this.valorTotal += Convert.ToDouble(dataTable.Rows[index][2]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }
        }

        private void btn_quitaPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.PedidoID = this.PedidoID;
            pedido.quitarPedido();
            carregarDados();
        }

        private void btn_excluidPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.PedidoID = this.PedidoID;
            pedido.excluirPedido();
            this.Close();
        }
    }
}
