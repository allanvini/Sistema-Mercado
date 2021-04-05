using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Mercado.Models
{
    public class Endereco
    {
        private string rua;
        private string bairro;
        private string cidade;
        private string estado;
        private string CEP;

        public Endereco(string rua, string bairro, string cidade, string estado, string cep)
        {
            this.Rua = rua;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.CEP1 = cep;
        }

        public string Rua { get => rua; set => rua = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string CEP1 { get => CEP; set => CEP = value; }
    }
}
