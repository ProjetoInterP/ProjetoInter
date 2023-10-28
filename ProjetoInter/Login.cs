using ProjetoInter.DB;
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

            Usuario user = db.Usuarios.FirstOrDefault(x => x.Login == login);

            if (user != null)
            {
                if (user.Senha == senha)
                {
                    // redireciona para a pagina correta (home)
                }
                else
                {
                    // senha inválida
                }
            } else
            {
                // usuário não encontrado
            }
        }

        private void InputFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
