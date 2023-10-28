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
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
           
        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void picVoltarEstoque_Click(object sender, EventArgs e)
        {
            //Voltar para tela de Funcionario caso seja funcionario
            MenuFuncionario Funcionario = new MenuFuncionario();
            Funcionario.ShowDialog();

            //Voltar para tela de Administrador caso seja Administrador
            MenuAdministrador Administrador = new MenuAdministrador();
            Administrador.ShowDialog();

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

            txtNomeProduto.Text = string.Empty;
            txtDescricaoProd.Text = string.Empty;
            txtCategoriaEstoque.Text = string.Empty;
            txtQuantidadeEstoque.Text = string.Empty;
            txtProcurarProd.Text = string.Empty;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            PizzariaDB _context = new PizzariaDB();

            string txt_nome = txtNomeProduto.Text;
            string txt_descricao = txtDescricaoProd.Text;
            int txt_Quantidade =  int.Parse(txtQuantidadeEstoque.Text);
            string txt_Categoria = txtCategoriaEstoque.Text;

            Estoque estoque = new Estoque
            {
                NomeProduto = txt_nome,
                DescricaoProduto = txt_descricao,
                QuantidadeProduto = txt_Quantidade,
                CategoriaProduto = txt_Categoria
            };

            _context.Estoque.Add(estoque);
        }
    }
}
