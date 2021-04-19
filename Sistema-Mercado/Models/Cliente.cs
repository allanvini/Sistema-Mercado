using System.Windows.Forms;
using Sistema_Mercado.Controllers;

namespace Sistema_Mercado.Models
{
    public class Cliente
    {
        private int clienteID;
        private string nome;
        private string CPF;
        private int diaDataNascimento;
        private int mesDataNascimento;
        private int anoDataNascimento;
        private string email;
        private Endereco[] enderecos = new Endereco[5];

        public int ClienteID { get => clienteID; set => clienteID = value; }
        public string Nome { get => nome; set => nome = value; }
        public string CPF1 { get => CPF; set => CPF = value; }
        public int DiaDataNascimento { get => diaDataNascimento; set => diaDataNascimento = value; }
        public int MesDataNascimento { get => mesDataNascimento; set => mesDataNascimento = value; }
        public int AnoDataNascimento { get => anoDataNascimento; set => anoDataNascimento = value; }
        public string Email { get => email; set => email = value; }
        public Endereco[] Enderecos { get => enderecos; set => enderecos = value; }
        

        public Cliente(string nome, string CPF, int diaDataNascimento, int mesDataNascimento, int anoDataNascimento, string email)
        {
            this.nome = nome;
            this.CPF = CPF;
            this.diaDataNascimento = diaDataNascimento;
            this.mesDataNascimento = mesDataNascimento;
            this.anoDataNascimento = anoDataNascimento;
            this.email = email;
        }

        public Cliente()
        {

        }

        public void adicionaEndereco(Endereco novoEndereco)
        {
            for(int index = 0; index < this.enderecos.Length; index++)
            {
                if(this.enderecos[index] == null)
                {
                    this.enderecos[index] = novoEndereco;
                    break;
                }
            }
            MessageBox.Show("Endereço adidionado com sucesso!", "Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void finalizaCadastro()
        {
            clienteController controller = new clienteController();

            controller.NovoCliente = this;
            controller.cadastraCliente();
        }

        public void deletaCliente()
        {
            clienteController controller = new clienteController();
            controller.deletaCliente(this.clienteID);
        }

    }
}
