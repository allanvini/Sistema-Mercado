using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Mercado.Models
{
    public class Produto
    {
        private string nome;
        private string empresa;
        private string categoria;
        private float precoCompra;
        private float precoVenda;
        private int estoque;
        private int quantidade;
        private int id;

        private int anoVencimento;
        private int mesVencimento;
        private int diaVencimento;

        public string Nome { get => nome; set => nome = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public float PrecoCompra { get => precoCompra; set => precoCompra = value; }
        public float PrecoVenda { get => precoVenda; set => precoVenda = value; }
        public int Estoque { get => estoque; set => estoque = value; }
        public int AnoVencimento { get => anoVencimento; set => anoVencimento = value; }
        public int MesVencimento { get => mesVencimento; set => mesVencimento = value; }
        public int DiaVencimento { get => diaVencimento; set => diaVencimento = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public int Id { get => id; set => id = value; }

        public Produto(string nome, string empresa, string categoria, float precoCompra, float precoVenda, int estoque, int anoVencimento, int mesVencimento, int diaVencimento)
        {
            this.nome = nome;
            this.empresa = empresa;
            this.categoria = categoria;
            this.precoCompra = precoCompra;
            this.precoVenda = precoVenda;
            this.estoque = estoque;

            this.anoVencimento = anoVencimento;
            this.mesVencimento = mesVencimento;
            this.diaVencimento = diaVencimento;
        }

        public Produto()
        {

        }

        public void atualizaProduto()
        {
            Controllers.ProdutoController controller = new Controllers.ProdutoController();
            controller.atualizaProduto(this);
        }

        public void cadastraProduto()
        {
            Controllers.ProdutoController controller = new Controllers.ProdutoController();
            controller.cadastraProduto(this);
        }

    }
}
