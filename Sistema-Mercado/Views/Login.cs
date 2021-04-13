using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Mercado
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            Models.Funcionario funcionario;

            Controllers.FuncionarioController controller = new Controllers.FuncionarioController();

            funcionario = controller.loginFuncionario(txb_login.Text, txb_senha.Text);

            if(funcionario != null)
            {
                Views.Dashboard dashboard = new Views.Dashboard(funcionario);

                this.Hide();

                dashboard.ShowDialog();

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
