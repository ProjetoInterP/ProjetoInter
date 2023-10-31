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
using static ProjetoInter.frmLogin;

namespace ProjetoInter
{
    public partial class frmCadastroCliente : Form
    {
        private string cargoUsuário;
        private frmLogin frmLogin;
        public frmCadastroCliente()
        {
            InitializeComponent();
            string cargoUsuario = Global.FuncaoSelecionada;
            frmLogin = new frmLogin();
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            mskTelefone.Text = "";
            txtNomeCliente.Text = "";
            txtNome.Focus();
            
        }
        private void picLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            long cel = Convert.ToInt64(mskTelefone.Text);
            string celFormatado = String.Format(@"{(00)\0000-0000}", cel);
            mskTelefone.Text = celFormatado;
        }

        private void picVoltarCadastro_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin.VoltarAoFormAnterior();
        }

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            PizzariaDB _context = new PizzariaDB();

            string txt_nome = txtNome.Text;
            string txt_Endereco = txtEndereco.Text;
            string txt_Telefone = mskTelefone.Text;


            Cliente cliente = new Cliente
            {
                Name = txt_nome,
                Endereco = txt_Endereco,
                Telefone = txt_Telefone
            };

            _context.Clientes.Add(cliente);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nomeCompleto = txtNome.Text;

            PizzariaDB _context = new PizzariaDB();
            Cliente cliente = _context.Clientes.FirstOrDefault(x => x.Name == nomeCompleto);
            if (nomeCompleto != null)
            {
                cliente.Endereco = txtEndereco.Text;
                cliente.Telefone = mskTelefone.Text;

                _context.SaveChanges();

                MessageBox.Show("Alteração feita com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Usuário não encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string nomeCliente = txtNome.Text;

            PizzariaDB _context = new PizzariaDB();
            Cliente cliente = _context.Clientes.FirstOrDefault(x => x.Name == nomeCliente);

            if (cliente != null)
            {
                //Remove usuário 
                _context.Clientes.Remove(cliente);
                MessageBox.Show("Usuário removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //Caso usuário não exista
                MessageBox.Show("Usuário não encontrado ou não existe", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
