using System;
using System.Windows.Forms;
using Sistema_Mercado.Models;

namespace Sistema_Mercado.Views.Estoque
{
    public partial class DetalhesProduto : Form
    {
        private Produto produto;

        public DetalhesProduto(Produto produto)
        {
            InitializeComponent();
            this.produto = produto;
            preencheCampos();
        }

        public void preencheCampos()
        {
            lbl_ID.Text = Convert.ToString(this.produto.Id);
            txb_nome.Text = this.produto.Nome;
            txb_empresa.Text = this.produto.Empresa;
            txb_categoria.Text = this.produto.Categoria;
            txb_precoCompra.Text = Convert.ToString(this.produto.PrecoCompra);
            txb_precoVenda.Text = Convert.ToString(this.produto.PrecoVenda);
            txb_estoque.Text = Convert.ToString(this.produto.Estoque);

            txb_diaVencimento.Text = Convert.ToString(this.produto.DiaVencimento);
            txb_mesVencimento.Text = Convert.ToString(this.produto.MesVencimento);
            txb_anoVencimento.Text = Convert.ToString(this.produto.AnoVencimento);
        }

        private void atualizaObjeto()
        {
            this.produto.Nome = txb_nome.Text;
            this.produto.Empresa = txb_empresa.Text;
            this.produto.Categoria = txb_categoria.Text;
            this.produto.PrecoCompra = float.Parse(txb_precoCompra.Text);
            this.produto.PrecoVenda = float.Parse(txb_precoVenda.Text);
            this.produto.Estoque = Convert.ToInt32(txb_estoque.Text);
            this.produto.DiaVencimento = Convert.ToInt32(txb_diaVencimento.Text);
            this.produto.MesVencimento = Convert.ToInt32(txb_mesVencimento.Text);
            this.produto.AnoVencimento = Convert.ToInt32(txb_anoVencimento.Text);
        }

        private void btn_salvaAlteracoes_Click(object sender, EventArgs e)
        {
            this.atualizaObjeto();

            this.produto.atualizaProduto();

            this.Close();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
