using System.Windows.Forms;
using Sistema_Mercado.Controllers;

namespace Sistema_Mercado.Models
{
    public class Pedido
    {
        private int pedidoID;
        private int clienteID;
        private int vendedorID;
        private Produto[] produtos = new Produto[50];
        private Servico[] servicos = new Servico[50];
        private string forma_pagamento;

        private pedidoController controller = new pedidoController();

        public int ClienteID { get => clienteID; set => clienteID = value; }
        public int VendedorID { get => vendedorID; set => vendedorID = value; }
        public string Forma_pagamento { get => forma_pagamento; set => forma_pagamento = value; }
        public int PedidoID { get => pedidoID; set => pedidoID = value; }
        public Produto[] Produtos { get => produtos; set => produtos = value; }
        public Servico[] Servicos { get => servicos; set => servicos = value; }

        public void adicionaProduto(Produto novoProduto)
        {
            for(int index =0; index < Produtos.Length; index++)
            {
                if(Produtos[index] == null)
                {
                    Produtos[index] = novoProduto;
                    break;
                }
            }
            MessageBox.Show("Produto inserido com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void adicionaServico(Servico novoServico)
        {
            for(int index = 0; index < Servicos.Length; index++)
            {
                if(Servicos[index] == null)
                {
                    Servicos[index] = novoServico;
                    break;
                }
            }

            MessageBox.Show("Serviço inserido com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void finalizaPedido()
        {
            pedidoController controller = new pedidoController();
            controller.cadastraPedido(this);
        }

        public void excluirPedido()
        {
            pedidoController controller = new pedidoController();
            controller.excluirPedido(this.PedidoID);
        }

        public void quitarPedido()
        {
            pedidoController controller = new pedidoController();
            controller.quitaPedido(this.pedidoID);
        }
    }
}
