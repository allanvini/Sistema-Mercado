﻿using Sistema_Mercado.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Mercado.Views.Clientes;
using Sistema_Mercado.Views.Estoque;
using Sistema_Mercado.Views.Pedidos;
using Sistema_Mercado.Views.Servicos;

namespace Sistema_Mercado.Views
{
    public partial class Dashboard : Form
    {
        private Funcionario funcionarioLogado;
        public Dashboard(Funcionario funcionario)
        {
            InitializeComponent();
            this.funcionarioLogado = funcionario;
            preencheCabecalhos();
        }

        private void preencheCabecalhos()
        {
            lbl_username.Text = funcionarioLogado.Nome;
            lbl_userPosition.Text = funcionarioLogado.Cargo;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btn_verPedidos_Click(object sender, EventArgs e)
        {
            PedidosView pedidosView = new PedidosView(funcionarioLogado);
            pedidosView.ShowDialog();
        }

        private void btn_verServicos_Click(object sender, EventArgs e)
        {
            ServicosView servicosView = new ServicosView();
            servicosView.ShowDialog();
        }

        private void btn_verEstoque_Click(object sender, EventArgs e)
        {
            EstoqueView estoqueView = new EstoqueView();
            estoqueView.ShowDialog();
        }

        private void btn_verClientes_Click(object sender, EventArgs e)
        {
            ClientesView clienteView = new ClientesView();
            clienteView.ShowDialog();
        }
    }
}