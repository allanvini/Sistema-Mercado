using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Mercado.Models
{
    public class Funcionario
    {
        private int ID;
        private string nome;
        private string cargo;

        public Funcionario(int ID, string nome, string cargo)
        {
            this.ID1 = ID;
            this.Nome = nome;
            this.Cargo = cargo;
        }

        public Funcionario()
        {

        }

        public int ID1 { get => ID; set => ID = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cargo { get => cargo; set => cargo = value; }
    }
}
