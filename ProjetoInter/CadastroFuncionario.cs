using ProjetoInter.DB;
using ProjetoInter.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInter
{
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
            txtSenha.MaxLength = 10;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string nomeCadastro = txtNome.Text;

            PizzariaDB _context = new PizzariaDB();
            Usuario usuario = _context.Usuarios.FirstOrDefault(x => x.Nome == nomeCadastro);

            if (usuario != null)
            {
                //Remove usuario inserido
                _context.Usuarios.Remove(usuario);
                MessageBox.Show("Usuario removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                //Mensagem de Erro
                MessageBox.Show("Usuário não encontrado ou já excluido","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private async void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            PizzariaDB _context = new PizzariaDB();

            string txt_nome = txtNome.Text;
            string txt_usuario = txtUsuario.Text;
            string txt_senha = txtSenha.Text;
            string txt_confirm_senha = txtconfirmaSenha.Text;
            string txt_cargo = cmbAcesso.Text;

            if(txt_senha == txt_confirm_senha)
            {
                Usuario usuario = new Usuario
                {
                    Nome = txt_nome,
                    Login = txt_usuario,
                    Senha = txt_senha,
                    Cargo = txt_cargo
                };

                // comando para adicionar no banco de dados
                _context.Usuarios.AddAsync(usuario);

                // comando para salvar as alterações no banco de dados
                _context.SaveChangesAsync();
            } else
            {
                MessageBox.Show("Senhas diferentes", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void picVoltarCadastro_Click(object sender, EventArgs e)
        {
            frmMenuAdministrador Administrador = new frmMenuAdministrador();
            this.Dispose();
            Administrador.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string cargoSelecionado = cmbAcesso.SelectedItem?.ToString();
            string nomeCadastro = txtNome.Text;

            PizzariaDB _context = new PizzariaDB();
            Usuario usuario = _context.Usuarios.FirstOrDefault(x => x.Nome == nomeCadastro);

            if (usuario != null)
            {
                usuario.Cargo = cmbAcesso.Text;
                usuario.Senha = txtSenha.Text;

                _context.Update(usuario);

                _context.SaveChanges();

                //Exibe Mensagem de Sucesso
                MessageBox.Show("Alteração feita com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                //Caso não encontra o produto solicitado
                MessageBox.Show("Usuário não encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
