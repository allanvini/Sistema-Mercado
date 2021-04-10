using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Sistema_Mercado.Models;

namespace Sistema_Mercado.Controllers
{
    class ProdutoController
    {
        private MySqlConnection con;
        private Connection.Connection connection;

        public void cadastraProduto(Produto novoProduto)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            string dataVencimento = $"{novoProduto.DiaVencimento}-{novoProduto.MesVencimento}-{novoProduto.AnoVencimento}";

            string query = "CALL cadastra_produto (?nome, ?empresa, ?categoria, ?preco_compra, ?preco_venda, ?estoque, ?dataVencimento)";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?nome", novoProduto.Nome);
                command.Parameters.AddWithValue("?empresa", novoProduto.Empresa);
                command.Parameters.AddWithValue("?categoria", novoProduto.Categoria);
                command.Parameters.AddWithValue("?preco_compra", novoProduto.PrecoCompra);
                command.Parameters.AddWithValue("?preco_venda", novoProduto.PrecoVenda);
                command.Parameters.AddWithValue("?estoque", novoProduto.Estoque);
                command.Parameters.AddWithValue("?dataVencimento", dataVencimento);

                command.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
                MessageBox.Show("Produto cadastrado com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void atualizaProduto(Produto produto)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();
            con.ConnectionString = connection.getConnectionString();

            string dataVencimento = ""+produto.DiaVencimento + "-" + produto.MesVencimento + "-" + produto.AnoVencimento+"";

            string query = "CALL edita_produto(?produtoID, ?produtoNome, ?produtoEmpresa, ?produtoCategoria, ?produtoPrecoCompra, ?produtoPrecoVenda, ?produtoEstoque, ?produtoDataVencimento);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?produtoID", produto.Id);
                command.Parameters.AddWithValue("?produtoNome", produto.Nome);
                command.Parameters.AddWithValue("?produtoEmpresa", produto.Empresa);
                command.Parameters.AddWithValue("?produtoCategoria", produto.Categoria);
                command.Parameters.AddWithValue("?produtoPrecoCompra", produto.PrecoCompra);
                command.Parameters.AddWithValue("?produtoPrecoVenda", produto.PrecoVenda);
                command.Parameters.AddWithValue("?produtoEstoque", produto.Estoque);
                command.Parameters.AddWithValue("?produtoDataVencimento", dataVencimento);

                command.ExecuteNonQuery();

                MessageBox.Show("Produto atualizado com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
