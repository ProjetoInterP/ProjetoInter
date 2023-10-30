using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProjetoInter
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
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
    }
}
