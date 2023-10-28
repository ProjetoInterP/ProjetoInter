using ProjetoInter.Modelos;
using System;
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
    public partial class MenuFuncionario : Form
    {
        public MenuFuncionario()
        {
            InitializeComponent();
        }

        private void btnLogoutFuncionario_Click(object sender, EventArgs e)
        {
            //Volta para a tela de login
            frmLogin Login = new frmLogin();
            Login.ShowDialog();

        }

        private void btnPedidoFuncionario_Click(object sender, EventArgs e)
        {
            //Acesso a tela de Pedidos como Funcionario
            frmPedido PedidoFuncionario = new frmPedido();
            PedidoFuncionario.ShowDialog();
        }

        private void btnEstoqueFunc_Click(object sender, EventArgs e)
        {
            //Acesso a tela de Estoque como Funcionario
            frmEstoque EstoqueFuncionario = new frmEstoque();
            EstoqueFuncionario.ShowDialog();
        }
    }
}
