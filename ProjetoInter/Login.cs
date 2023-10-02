using ProjetoInter.DB;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void InputLogin_TextChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

        }


        private void Logar(object sender, EventArgs e)
        {
            string login = InputLogin.Text;
            string senha = InputSenha.Text;

            // criando a instancia do banco de dados
            PizzariaDB db = new PizzariaDB();

            

        }
    }
}
