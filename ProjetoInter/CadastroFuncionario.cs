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

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, btnAdicionar.Width, btnAdicionar.Height);
            btnAdicionar.Region = new Region(forma);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtSenha.Text = string.Empty;
            cmbAcesso.Text = string.Empty;
            txtPesquisa.Text = string.Empty;

        }

       

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void Fechar(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
