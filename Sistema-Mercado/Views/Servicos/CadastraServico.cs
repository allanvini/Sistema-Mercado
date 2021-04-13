using System;
using System.Windows.Forms;
using Sistema_Mercado.Models;

namespace Sistema_Mercado.Views.Servicos
{
    public partial class CadastraServico : Form
    {
        private Servico servico = new Servico();
        public CadastraServico()
        {
            InitializeComponent();
        }

        private void preencherObjeto()
        {
            this.servico.Descricao = txb_descricao.Text;
            this.servico.Preco = float.Parse(txb_preco.Text);
        }
        
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_finalizaCadastro_Click(object sender, EventArgs e)
        {
            preencherObjeto();
            servico.cadastraNovoServico();
            this.Close();
        }
    }
}
