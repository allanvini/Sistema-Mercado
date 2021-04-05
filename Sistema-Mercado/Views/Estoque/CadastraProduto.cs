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

namespace Sistema_Mercado.Views.Estoque
{
    public partial class CadastraProduto : Form
    {
        private Produto produto = new Produto();
        public CadastraProduto()
        {
            InitializeComponent();
        }

        private void preencherObjeto()
        {
            this.produto.Nome = txb_nome.Text;
            this.produto.Empresa = txb_empresa.Text;
            this.produto.Categoria = txb_categoria.Text;
            this.produto.PrecoCompra = float.Parse(txb_precoCompra.Text);
            this.produto.PrecoVenda = float.Parse(txb_precoVenda.Text);
            this.produto.Estoque = Convert.ToInt32(txb_estoque.Text);
            this.produto.AnoVencimento = Convert.ToInt32(txb_diaVencimento.Text);
            this.produto.MesVencimento = Convert.ToInt32(txb_mesVencimento.Text);
            this.produto.AnoVencimento = Convert.ToInt32(txb_anoVencimento.Text);
        }

        private void btn_finalizaCadastro_Click(object sender, EventArgs e)
        {
            this.preencherObjeto();

            this.produto.cadastraProduto();

            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
