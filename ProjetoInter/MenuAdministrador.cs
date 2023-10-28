﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInter
{
    public partial class frmMenuAdministrador : Form
    {
        public frmMenuAdministrador()
        {
            InitializeComponent();
        }

        private void btnLogoutAdmin_Click(object sender, EventArgs e)
        {
            //Volta para tela de login
            frmLogin Login = new frmLogin();
            this.Hide();
            Login.ShowDialog();
            
        }

        private void btnCadastroAdmin_Click(object sender, EventArgs e)
        {
            //Acesso a tela de Cadastro como Administrador
            frmCadFuncionario CadFuncionario = new frmCadFuncionario();
            this.Hide();
            CadFuncionario.ShowDialog();
        }

        private void btnEstoqueAdmin_Click(object sender, EventArgs e)
        {
            //Acesso a tela de Estoque como Administrador
            frmEstoque EstoqueAdmin = new frmEstoque();
            this.Hide();
            EstoqueAdmin.ShowDialog();

        }

        private void btnPedidosAdmin_Click(object sender, EventArgs e)
        {
            //Acesso a tela de Pedidos como Administrador
            frmPedido PedidoAdmin = new frmPedido();
            this.Hide();
            PedidoAdmin.ShowDialog();
        }
    }
}
