using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_Mercado.Views.Estoque
{
    public partial class EstoqueView : Form
    {
        private Connection.Connection connection;

        private Models.Produto produto = new Models.Produto();

        public EstoqueView()
        {
            InitializeComponent();
            carregarDados();
        }

        private void carregarDados()
        {
            connection = new Connection.Connection();
            dtgv_produtos.DataSource = null;
            dtgv_produtos.Rows.Clear();
            dtgv_produtos.Refresh();

            string connectionString = connection.getConnectionString();

            string query = "SELECT * FROM produtos;";

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
                    catch(Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }
        }

        private void dtgv_produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dtgv_produtos.SelectedRows)
            {
                lbl_produtoSelecionado.Text = Convert.ToString(row.Cells[1].Value);

                this.produto.Id = (int)row.Cells[0].Value;
                this.produto.Nome = (string)row.Cells[1].Value;
                this.produto.Empresa = (string)row.Cells[2].Value;
                this.produto.Categoria = (string)row.Cells[3].Value;
                this.produto.PrecoCompra = (float)row.Cells[4].Value;
                this.produto.PrecoVenda = (float)row.Cells[5].Value;
                this.produto.Estoque = (int)row.Cells[6].Value;

                string[] dataVencimento = Convert.ToString(row.Cells[7].Value).Split('-');

                this.produto.DiaVencimento = Convert.ToInt32(dataVencimento[0]);
                this.produto.MesVencimento = Convert.ToInt32(dataVencimento[1]);
                this.produto.AnoVencimento = Convert.ToInt32(dataVencimento[2]);
            }
        }

        private void btn_verDetalhes_Click(object sender, EventArgs e)
        {
            DetalhesProduto detalhesForm = new DetalhesProduto(this.produto);
            detalhesForm.ShowDialog();
        }

        private void btn_cadastraProduto_Click(object sender, EventArgs e)
        {
            CadastraProduto cadastroForm = new CadastraProduto();
            cadastroForm.ShowDialog();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            carregarDados();
        }
    }
}
