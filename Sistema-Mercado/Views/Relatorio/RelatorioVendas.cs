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

namespace Sistema_Mercado.Views.Relatorio
{
    public partial class RelatorioVendas : Form
    {
        private Connection.Connection connection;

        double totalVendido = 0;
        int totalPedidos = 0;

        public RelatorioVendas()
        {
            InitializeComponent();
            obterTotalVendido();
            obterTotalPedidos();
            preencherCampos();
        }

        private void obterTotalVendido()
        {
            this.totalVendido = 0;

            connection = new Connection.Connection();
            string connectionString = connection.getConnectionString();

            string query = "CALL relatorio_vendas();";

            using(MySqlConnection con = new MySqlConnection(connectionString))
            {
                using(MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        for (int index = 0; index < dataTable.Rows.Count; index++)
                        {
                            this.totalVendido += Convert.ToDouble(dataTable.Rows[index][2]) * Convert.ToDouble(dataTable.Rows[index][3]);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }
        }

        private void obterTotalPedidos()
        {
            this.totalPedidos = 0;

            connection = new Connection.Connection();
            string connectionString = connection.getConnectionString();

            string query = "SELECT * FROM pedidos;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        this.totalPedidos = Convert.ToInt32(dataTable.Rows.Count);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }
        }

        private void preencherCampos()
        {
            lbl_totalVendido.Text = Convert.ToString(this.totalVendido);
            lbl_totalPedidos.Text = Convert.ToString(this.totalPedidos);
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            obterTotalVendido();
            obterTotalPedidos();
            preencherCampos();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
