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
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            string cargoSelecionado = cmbFuncao.SelectedItem.ToString();



            //criando a instancia do banco de dados
            PizzariaDB db = new PizzariaDB();

            Usuario user = db.Usuarios.FirstOrDefault(x => x.Login == login);



            if (user != null)
            {
                if (user.Senha == senha)
                {
                    //redireciona para a pagina correta(home)
                }
                else
                {
                    MessageBox.Show("Senha Inválida", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }

            if (cargoSelecionado == "Administrador")
            {

                frmMenuAdministrador menuAdmin = new frmMenuAdministrador();
                this.Hide();
                menuAdmin.ShowDialog();
            }
            else if (cargoSelecionado == "Funcionário")
            {
                frmMenuFuncionario menuFunc = new frmMenuFuncionario();
                this.Hide();
                menuFunc.ShowDialog();

            }
            else
            {
                MessageBox.Show("Nenhum tipo de acesso selecionado,tente novamente", " "
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void picEncerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
