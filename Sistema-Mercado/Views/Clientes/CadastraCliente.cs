using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Mercado.Models;


namespace Sistema_Mercado.Views.Clientes
{
    public partial class CadastraCliente : Form
    {
        

        private Cliente novoCliente = new Cliente();

        public CadastraCliente()
        {
            InitializeComponent();
        }

        

        private void btn_addEndereco_Click(object sender, EventArgs e)
        {
            Endereco novoEndereco = new Endereco(txb_rua.Text, txb_bairro.Text, txb_cidade.Text, txb_estado.Text, txb_CEP.Text);

            this.novoCliente.adicionaEndereco(novoEndereco);

            txb_rua.Text = "";
            txb_bairro.Text = "";
            txb_cidade.Text = "";
            txb_estado.Text = "";
            txb_CEP.Text = "";

            
        }

        private void btn_cancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_finalizaCadastro_Click(object sender, EventArgs e)
        {
            this.novoCliente.Nome = txb_nome.Text;
            this.novoCliente.CPF1 = txb_CPF.Text;
            this.novoCliente.DiaDataNascimento = Convert.ToInt32(txb_dia.Text);
            this.novoCliente.MesDataNascimento = Convert.ToInt32(txb_mes.Text);
            this.novoCliente.AnoDataNascimento = Convert.ToInt32(txb_ano.Text);
            this.novoCliente.Email = txb_email.Text;

            this.novoCliente.finalizaCadastro();

            this.Close();
        }
    }
}
