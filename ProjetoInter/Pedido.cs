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
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void picVoltar_Click(object sender, EventArgs e)
        {
            //Volta para tela de Menu do Funcionário
            frmMenuFuncionario pedidoFunc = new frmMenuFuncionario();
            this.Hide();
            pedidoFunc.Show();

            //Volta para tela de Menu do Administrador
            frmMenuAdministrador pedidoAdmin = new frmMenuAdministrador();
            this.Hide();
            pedidoAdmin.Show();
        }
    }
}
