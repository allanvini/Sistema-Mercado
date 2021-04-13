using System;
using System.Data;
using System.Windows.Forms;
using Sistema_Mercado.Models;
using MySql.Data.MySqlClient;

namespace Sistema_Mercado.Views.Pedidos
{

    public partial class CadastraPedido : Form
    {
        private Connection.Connection connection;
        private Pedido novoPedido = new Pedido();

        public CadastraPedido(Funcionario funcionario)
        {
            InitializeComponent();
            this.novoPedido.VendedorID = funcionario.ID1;
            carregarDadosClientes();
            carregarDadosProdutos();
            carregarDadosServicos();
        }

        private void carregarDadosClientes()
        {
            connection = new Connection.Connection();
            dtgv_clientes.DataSource = null;
            dtgv_clientes.Rows.Clear();
            dtgv_clientes.Refresh();

            string connectionString = connection.getConnectionString();

            string query = "SELECT * FROM clientes";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        for (int index = 0; index < dataTable.Rows.Count; index++)
                        {
                            dtgv_clientes.Rows.Add
                            (
                                dataTable.Rows[index][0],
                                dataTable.Rows[index][1],
                                dataTable.Rows[index][2],
                                dataTable.Rows[index][3],
                                dataTable.Rows[index][4]
                            );
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }
        }


        private void carregarDadosProdutos()
        {
            connection = new Connection.Connection();
            dtgv_produtos.DataSource = null;
            dtgv_produtos.Rows.Clear();
            dtgv_produtos.Refresh();

            string connectionString = connection.getConnectionString();

            string query = "SELECT * FROM produtos;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        for (int index = 0; index < dataTable.Rows.Count; index++)
                        {
                            dtgv_produtos.Rows.Add
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
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }
        }


        private void carregarDadosServicos()
        {
            connection = new Connection.Connection();
            dtgv_servicos.DataSource = null;
            dtgv_servicos.Rows.Clear();
            dtgv_servicos.Refresh();

            string connectionString = connection.getConnectionString();

            string query = "SELECT * FROM servicos";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
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
                                dataTable.Rows[index][2]
                            );
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }
        }

        private void btn_cancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_fechaPedido_Click(object sender, EventArgs e)
        {
            novoPedido.finalizaPedido();
            this.Close();
        }

        private void btn_selecionaCliente_Click(object sender, EventArgs e)
        {
            this.novoPedido.ClienteID = Convert.ToInt32(lbl_clienteID.Text);
        }

        private void btn_adicionaProduto_Click(object sender, EventArgs e)
        {
            Produto novoProduto = new Produto();
            novoProduto.Id = Convert.ToInt32(lbl_produtoID.Text);
            novoProduto.Quantidade = Convert.ToInt32(txb_quantidadeProduto.Text);

            this.novoPedido.adicionaProduto(novoProduto);

            txb_quantidadeProduto.Text = "_";
        }

        private void btn_adicionaServico_Click(object sender, EventArgs e)
        {
            Servico novoServico = new Servico();
            novoServico.Id = Convert.ToInt32(lbl_servicoID.Text);

            this.novoPedido.adicionaServico(novoServico);

            lbl_servicoID.Text = "_";
        }

        private void dtgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtgv_clientes.SelectedRows)
            {
                lbl_clienteID.Text = Convert.ToString(row.Cells[0].Value);
            }
        }

        private void dtgv_produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtgv_produtos.SelectedRows)
            {
                lbl_produtoID.Text = Convert.ToString(row.Cells[0].Value);
            }
        }

        private void dtgv_servicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtgv_servicos.SelectedRows)
            {
                lbl_servicoID.Text = Convert.ToString(row.Cells[0].Value);
            }
        }

        private void rdb_dinheiro_CheckedChanged(object sender, EventArgs e)
        {
            this.novoPedido.Forma_pagamento = "À Vista";
        }

        private void rdb_credito_CheckedChanged(object sender, EventArgs e)
        {
            this.novoPedido.Forma_pagamento = "Crédito";
        }
    }
}
