using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_Mercado.Views.Servicos
{
    public partial class ServicosView : Form
    {
        private Connection.Connection connection;
        private Models.Servico servico = new Models.Servico();
        public ServicosView()
        {
            InitializeComponent();
            carregarDados();
        }

        private void carregarDados()
        {
            // Colunas 3 =>>             ID, Descrição, Preço
            connection = new Connection.Connection();
            dtgv_servicos.DataSource = null;
            dtgv_servicos.Rows.Clear();
            dtgv_servicos.Refresh();

            string connectionString = connection.getConnectionString();

            string query = "SELECT * FROM servicos";

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
                            dtgv_servicos.Rows.Add
                            (
                                dataTable.Rows[index][0],
                                dataTable.Rows[index][1],
                                dataTable.Rows[index][2]
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

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void btn_verDetalhes_Click(object sender, EventArgs e)
        {
            DetalhesServico detalhesForm = new DetalhesServico(servico);
            detalhesForm.ShowDialog();
        }

        private void dtgv_servicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dtgv_servicos.SelectedRows)
            {
                lbl_servicoSelecionado.Text = Convert.ToString(row.Cells[1].Value);

                this.servico.Id = Convert.ToInt32(row.Cells[0].Value);
                this.servico.Descricao = Convert.ToString(row.Cells[1].Value);
                this.servico.Preco = (float)row.Cells[2].Value;
            }
        }

        private void btn_cadastraServico_Click(object sender, EventArgs e)
        {
            CadastraServico cadastroForm = new CadastraServico();
            cadastroForm.ShowDialog();
        }
    }
}
