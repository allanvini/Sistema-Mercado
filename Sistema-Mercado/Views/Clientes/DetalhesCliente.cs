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
    public partial class DetalhesCliente : Form
    {
        private int ClienteID;
        private string nome;
        private string CPF;
        private string dataNascimento;
        private string email;
        private Connection.Connection connection;
        public DetalhesCliente(int ID, string nome, string CPF, string dataNascimento, string email)
        {
            InitializeComponent();
            this.ClienteID = ID;
            this.nome = nome;
            this.CPF = CPF;
            this.dataNascimento = dataNascimento;
            this.email = email;

            carregarDados();
            preencherCampos();
        }

        private void preencherCampos()
        {
            txb_CPF.Text = this.CPF;
            txb_dt_nascimento.Text = this.dataNascimento;
            txb_nome.Text = this.nome;
            txb_email.Text = this.email;
        }

        private void carregarDados()
        {
            connection = new Connection.Connection();
            dtgv_enderecos.DataSource = null;
            dtgv_enderecos.Rows.Clear();
            dtgv_enderecos.Refresh();

            string connectionString = connection.getConnectionString();

            string query = "SELECT * FROM enderecos WHERE fk_cliente_ID = ?Client_ID";

            using(MySqlConnection con = new MySqlConnection(connectionString))
            {
                using(MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    MySqlCommand command = new MySqlCommand(query, con);
                    command.Parameters.Add("?Client_ID", (MySqlDbType)SqlDbType.Int);
                    command.Parameters["?Client_ID"].Value = ClienteID;

                    adapter.SelectCommand = command;
                    adapter.InsertCommand = command;

                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        for(int index = 0; index < dataTable.Rows.Count; index++)
                        {
                            dtgv_enderecos.Rows.Add
                            (
                                dataTable.Rows[index][0],
                                dataTable.Rows[index][1],
                                dataTable.Rows[index][2],
                                dataTable.Rows[index][3],
                                dataTable.Rows[index][4],
                                dataTable.Rows[index][5]
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
    }
}
