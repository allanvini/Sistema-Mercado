using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Mercado.Views.Servicos
{
    public partial class DetalhesServico : Form
    {
        private Models.Servico servico;
        public DetalhesServico(Models.Servico servico)
        {
            InitializeComponent();
            this.servico = servico;
            preencherDados();
        }

        private void preencherDados()
        {
            lbl_ID.Text = Convert.ToString(servico.Id);
            txb_descricao.Text = servico.Descricao;
            txb_preco.Text = Convert.ToString(servico.Preco);
        }

        private void atualizaObjeto()
        {
            this.servico.Descricao = txb_descricao.Text;
            this.servico.Preco = float.Parse(txb_preco.Text);
        }

        private void btn_salvaAlteracoes_Click(object sender, EventArgs e)
        {
            atualizaObjeto();
            servico.atualizaServico();
            this.Close();
        }
    }
}
