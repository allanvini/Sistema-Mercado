using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Mercado.Models
{
    public class Servico
    {
        private string descricao;
        private float preco;
        private int id;

        public string Descricao { get => descricao; set => descricao = value; }
        public float Preco { get => preco; set => preco = value; }
        public int Id { get => id; set => id = value; }

        public Servico(string descricao, float preco)
        {
            this.descricao = descricao;
            this.preco = preco;
        }

        public Servico()
        {

        }

        public void cadastraNovoServico()
        {
            Controllers.ServicoController controller = new Controllers.ServicoController();

            controller.cadastraServico(this);
        }

        public void atualizaServico()
        {
            Controllers.ServicoController controller = new Controllers.ServicoController();
            controller.atualizaServico(this);
        }
    }
}
