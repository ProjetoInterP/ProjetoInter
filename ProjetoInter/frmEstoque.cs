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
    public partial class frmEstoque : Form
    {
        
        private string cargoUsuário;
        private frmLogin frmLogin;
        public frmEstoque()
        {
            InitializeComponent();
            //serve para armazenar o que foi selecionado no form de login
            string cargoUsuario = Global.FuncaoSelecionada;
            frmLogin = new frmLogin();
            
        }



        private void picVoltarEstoque_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin.VoltarAoFormAnterior();
            

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string nomeProduto = txtNomeProduto.Text;

            PizzariaDB _context = new PizzariaDB();
            Estoque estoque = _context.Estoque.FirstOrDefault(x => x.NomeProduto == nomeProduto);

            if (estoque != null)
            {
                //Remove produto inserido
                _context.Estoque.Remove(estoque);
                MessageBox.Show("Produto removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //Caso produto não exista
                MessageBox.Show("Produto não encontrado ou não existe", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string nomeProduto = txtNomeProduto.Text;

            PizzariaDB _context = new PizzariaDB();
            Estoque estoque = _context.Estoque.FirstOrDefault(x => x.NomeProduto == nomeProduto);

            if (estoque != null)
            {
                estoque.DescricaoProduto = txtDescricaoProd.Text;
                estoque.QuantidadeProduto = int.Parse(txtQuantidadeEstoque.Text);
                estoque.CategoriaProduto = txtCategoriaEstoque.Text;

                _context.SaveChanges();

                //Exibe Mensagem de Sucesso
                MessageBox.Show("Alteração feita com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                //Caso não encontra o produto solicitado
                MessageBox.Show("Produto não encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            PizzariaDB _context = new PizzariaDB();

            string txt_nome = txtNomeProduto.Text;
            string txt_descricao = txtDescricaoProd.Text;
            int txt_Quantidade = int.Parse(txtQuantidadeEstoque.Text);
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



        private void dgvEstoque_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int columnIndex = dgvEstoque.Columns["Categoria"].Index;

            if (e.ColumnIndex == columnIndex && e.Value != null)
            {
                // Verifique o valor da célula e defina a cor com base no valor
                string valor = e.Value.ToString();
                if (valor == "Bebida")
                {
                    // Defina a cor de fundo para a célula com valor "Admin"
                    e.CellStyle.BackColor = Color.Blue; // Substitua pela cor que deseja
                    e.CellStyle.ForeColor = Color.White; // Defina a cor do texto para melhor legibilidade
                }
                else if (valor == "Pizza")
                {
                    // Defina a cor de fundo para a célula com valor "Funcionário"
                    e.CellStyle.BackColor = Color.DarkOrange; // Substitua pela cor que deseja
                    e.CellStyle.ForeColor = Color.White; // Defina a cor do texto para melhor legibilidade
                }
                
                // Você pode adicionar mais condições conforme necessário



            }
        }

        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Certificar de que há um usuário cadastrado
            {
                DataGridViewRow row = dgvEstoque.Rows[e.RowIndex];

                // DataGrid de Estoque
                txtNomeProduto.Text = row.Cells["Nome"].Value.ToString();
                txtDescricaoProd.Text = row.Cells["Descrição"].Value.ToString();
                txtCategoriaEstoque.Text = row.Cells["Categoria"].Value.ToString();
                txtQuantidadeEstoque.Text = row.Cells["Qtd"].Value.ToString();
                
               
            }
        }
        private void LimparCampos()
        {
            txtNomeProduto.Text = "";
            txtDescricaoProd.Text = "";
            txtCategoriaEstoque.Text = "";
            txtQuantidadeEstoque.Text = "";

            // Limpe outros campos de texto conforme necessário
        }

        private void picLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void picBuscarEstoque_Click(object sender, EventArgs e)
        {
            string nomeProduto = txtProcurarProd.Text;

            using (var db = new PizzariaDB())
            {
                var estoque = db.Estoque
                    .Where(u => u.NomeProduto.Contains(nomeProduto))
                    .ToList();

                dgvEstoque.DataSource = estoque;
            }
        }

        private void txtProcurarProd_TextChanged(object sender, EventArgs e)
        {
            string procurarProd = txtProcurarProd.Text;

            // Faça uma consulta no banco de dados para encontrar o funcionário com o nome fornecido
            using (var db = new PizzariaDB())
            {
                var estoque = db.Estoque.FirstOrDefault(u => u.NomeProduto.Contains(procurarProd));

                if (estoque != null)
                {
                    // Preencha os campos de texto e combobox com os dados do funcionário encontrado
                    txtNomeProduto.Text = estoque.NomeProduto;
                    txtQuantidadeEstoque.Text = estoque.QuantidadeProduto.ToString();
                    txtDescricaoProd.Text = estoque.DescricaoProduto;
                    txtCategoriaEstoque.Text = estoque.CategoriaProduto;



                }
                else
                {
                    // Se nenhum estoque for encontrado, limpe os campos de texto
                    LimparCampos();
                }
            }
        }
    }
}
