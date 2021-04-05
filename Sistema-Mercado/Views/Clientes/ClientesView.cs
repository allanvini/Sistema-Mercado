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

namespace Sistema_Mercado.Views.Clientes
{
    public partial class ClientesView : Form
    {
        private Connection.Connection connection;

        private int IDClienteSelecionado = 0;
        private string ClienteSelecionadoNome;
        private string ClienteSelecionadoCPF;
        private string ClienteSelecionadoDataNascimento;
        private string ClienteSelecionadoEmail;

        public ClientesView()
        {
            InitializeComponent();
            carregarDados();
        }

        private void carregarDados()
        {
            connection = new Connection.Connection();
            dtgv_clientes.DataSource = null;
            dtgv_clientes.Rows.Clear();
            dtgv_clientes.Refresh();

            string connectionString = connection.getConnectionString();

            string query = "SELECT * FROM clientes";

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
                    catch(Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }
        }

        private void btn_cadastraCliente_Click(object sender, EventArgs e)
        {
            CadastraCliente formCadastro = new CadastraCliente();
            formCadastro.ShowDialog();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            this.carregarDados();
        }

        private void dtgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dtgv_clientes.SelectedRows)
            {
                this.IDClienteSelecionado = Convert.ToInt32(row.Cells[0].Value);
                this.ClienteSelecionadoNome = Convert.ToString(row.Cells[1].Value);
                this.ClienteSelecionadoCPF = Convert.ToString(row.Cells[2].Value);
                this.ClienteSelecionadoDataNascimento = Convert.ToString(row.Cells[3].Value);
                this.ClienteSelecionadoEmail = Convert.ToString(row.Cells[4].Value);

                lbl_clienteSelecionado.Text = Convert.ToString(row.Cells[1].Value);
            }
        }

        private void btn_excluirCliente_Click(object sender, EventArgs e)
        {
            Models.Cliente clienteDeletado = new Models.Cliente();
            clienteDeletado.ClienteID = this.IDClienteSelecionado;
            clienteDeletado.deletaCliente();
            carregarDados();
        }

        private void btn_verDetalhes_Click(object sender, EventArgs e)
        {
            DetalhesCliente detalhesCLiente = new DetalhesCliente(this.IDClienteSelecionado, this.ClienteSelecionadoNome, this.ClienteSelecionadoCPF, this.ClienteSelecionadoDataNascimento, this.ClienteSelecionadoEmail);
            detalhesCLiente.ShowDialog();
        }
    }
}
