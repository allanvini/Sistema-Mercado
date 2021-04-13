using System;
using System.Data;
using System.Windows.Forms;
using Sistema_Mercado.Models;
using MySql.Data.MySqlClient;

namespace Sistema_Mercado.Views.Pedidos
{
    public partial class PedidosView : Form
    {
        private Funcionario funcionario;
        private Connection.Connection connection;
        private int PedidoID;

        public PedidosView(Funcionario funcionario)
        {
            InitializeComponent();
            this.funcionario = funcionario;
            carregarDados();
        }

        private void carregarDados()
        {
            connection = new Connection.Connection();
            dtgv_pedidos.DataSource = null;
            dtgv_pedidos.Rows.Clear();
            dtgv_pedidos.Refresh();

            string connectionString = connection.getConnectionString();

            string query = "CALL pedidos_feitos();";

            using(MySqlConnection con = new MySqlConnection(connectionString))
            {
                using(MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        for(int index = 0; index < dataTable.Rows.Count; index++)
                        {
                            dtgv_pedidos.Rows.Add
                            (
                                dataTable.Rows[index][0],
                                dataTable.Rows[index][1],
                                dataTable.Rows[index][2],
                                dataTable.Rows[index][3],
                                dataTable.Rows[index][4]
                            );
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }
        }
            

        private void dtgv_pedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dtgv_pedidos.SelectedRows)
            {
                lbl_pedidoID.Text = Convert.ToString(row.Cells[0].Value);
                this.PedidoID = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void btn_excluirPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.PedidoID = this.PedidoID;
            pedido.excluirPedido();
            carregarDados();
        }

        private void btn_adicionarPedido_Click(object sender, EventArgs e)
        {
            CadastraPedido cadastroPedidoForm = new CadastraPedido(this.funcionario);
            cadastroPedidoForm.ShowDialog();
        }

        private void btn_detalhesPedido_Click(object sender, EventArgs e)
        {
            DetalhesPedido detalhesForm = new DetalhesPedido(this.PedidoID);
            detalhesForm.ShowDialog();
        }
    }
}
