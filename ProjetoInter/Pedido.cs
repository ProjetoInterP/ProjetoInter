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
using static ProjetoInter.frmLogin;

namespace ProjetoInter
{
    public partial class frmPedido : Form
    {
        private string cargoUsuário;
        private frmLogin frmLogin;
        public frmPedido()
        {
            InitializeComponent();
            string cargoUsuario = Global.FuncaoSelecionada;
            frmLogin = new frmLogin();
        }

        private void picVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin.VoltarAoFormAnterior();
        }

        private void txtPesquisaProd_TextChanged(object sender, EventArgs e)
        {



        }

        //Pesquisas de Produtos e Clientes
        private void picPesquisaClientes_Click(object sender, EventArgs e)
        {
            string nomeCliente = txtPesquisaNome.Text;

            using (var db = new PizzariaDB())
            {
                var funcionarios = db.Clientes
                    .Where(u => u.Name.Contains(nomeCliente))
                    .ToList();

                dgvClientePedido.DataSource = funcionarios;
            }

        }
        List<string> pizzasCoringa = new List<string>
        {
            "Pizza Frango e Catupiry",
            "Pizza Calabresa",
            "Pizza Mussarela",
            "Pizza Portuguesa",
            "Pizza Pepperoni"

        };


        private void picPesquisaProd_Click(object sender, EventArgs e)
        {

            string nomeProduto = txtPesquisaProd.Text;

            using (var db = new PizzariaDB())
            {
                var produtos = db.Estoque
                    .Where(u => u.NomeProduto.Contains(nomeProduto))
                    .ToList();

                if (produtos.Any())
                {
                    dgvProdutosPedido.DataSource = produtos;
                    picImagem.Image = null;
                }
                else
                {
                    dgvProdutosPedido.DataSource = null;

                    // Exibe uma pizza coringa aleatória
                    Random random = new Random();
                    int indicePizzaCoringa = random.Next(pizzasCoringa.Count);
                    string pizzaCoringa = pizzasCoringa[indicePizzaCoringa];
                    picImagem.Image = Image.FromFile(@".../.../Debug/${ImagemProdutosCoringa}.jpg");
                }

            }
        

    

        }

        private void dgvClientePedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Certifique-se de que uma linha válida foi clicada
            {
                DataGridViewRow row = dgvClientePedido.Rows[e.RowIndex];

                // Preencha os campos de texto e combobox com os dados da célula clicada
                txtPesquisaNome.Text = row.Cells["Nome"].Value.ToString();
                

                // Preencha outros campos de texto conforme necessário
            }
        }

        //Carrega informações do banco de dados
        private void frmPedido_Load(object sender, EventArgs e)
        {
            using (var db = new PizzariaDB())
            {
                var clientes = db.Clientes.ToList(); 

                dgvClientePedido.DataSource = clientes;
            }

            using (var db = new PizzariaDB())
            {
                var produtos = db.Estoque.ToList();

                dgvProdutosPedido.DataSource = produtos;
            }
        }

        //PlaceHolders das txtPesquisaNome, txtPesquisaProd e txtDescricao

        private void txtPesquisaNome_Enter(object sender, EventArgs e)
        {
            if (txtPesquisaNome.Text == "Pesquisar por nome")
            {
                txtPesquisaNome.Text = "";
                txtPesquisaNome.ForeColor = Color.Black;

            }

        }

        private void txtPesquisaNome_Leave(object sender, EventArgs e)
        {

            if (txtPesquisaNome.Text == "")
            {
                txtPesquisaNome.Text = "Pesquisar por nome";
                txtPesquisaNome.ForeColor = Color.LightGray;

            }

        }

        private void txtPesquisaProd_Enter(object sender, EventArgs e)
        {
            if (txtPesquisaProd.Text == "Pesquisar por Produto")
            {
                txtPesquisaProd.Text = "";
                txtPesquisaProd.ForeColor = Color.Black;

            }

        }

        private void txtPesquisaProd_Leave(object sender, EventArgs e)
        {
            if (txtPesquisaProd.Text == "")
            {
                txtPesquisaProd.Text = "Pesquisar por Produto";
                txtPesquisaProd.ForeColor = Color.LightGray;

            }

        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "Inserir descrição")
            {
                txtDescricao.Text = "";
                txtDescricao.ForeColor = Color.Black;

            }

        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                txtDescricao.Text = "Inserir descrição";
                txtDescricao.ForeColor = Color.LightGray;

            }

        }

        public void ImagemProdutos()
        {
            string nomeProduto = dgvProdutosPedido.CurrentRow.Cells["NomeProduto"].Value.ToString();

            if (nomeProduto == "Pizza Frango e Catupiry")
            {
                picImagem.Image = Image.FromFile(@"C:../../Debug/Icone-Pizza_FrangoCatupiry.jpg");

            }
            else if (nomeProduto == "Pizza Calabresa")
            {
                picImagem.Image = Image.FromFile(@"C:../../Debug/Icone-Pizza_Calabresa.jpg");
            }
            else if (nomeProduto == "Pizza Mussarela")
            {
                picImagem.Image = Image.FromFile(@"C:../../Debug/Icone-Pizza_Mussarela.jpg");

            }
            else if (nomeProduto == "Pizza Portuguesa")
            {
                picImagem.Image = Image.FromFile(@"C:../../Debug/icone-Pizza_Portuguesa.jpg");
            }
            else if (nomeProduto == "Pizza Pepperoni")
            {
                picImagem.Image = Image.FromFile(@"C:../../Debug/icone-Pizza_Pepperoni.png");
            }

            //Possibilidade de inserir mais imagens de produtos ao longo do tempo
            

        }

        public void ImagemProdutosCoringa()
        {
            string nomeProdutoCoringa = txtPesquisaProd.Text ;

            if (nomeProdutoCoringa == "Pizza Frango e Catupiry")
            {
                picImagem.Image = Image.FromFile(@"C:../../Debug/Icone-Pizza_FrangoCatupiry.jpg");

            }
            else if (nomeProdutoCoringa == "Pizza Calabresa")
            {
                picImagem.Image = Image.FromFile(@"C:../../Debug/Icone-Pizza_Calabresa.jpg");
            }
            else if (nomeProdutoCoringa == "Pizza Mussarela")
            {
                picImagem.Image = Image.FromFile(@"C:../../Debug/Icone-Pizza_Mussarela.jpg");

            }
            else if (nomeProdutoCoringa == "Pizza Portuguesa")
            {
                picImagem.Image = Image.FromFile(@"C:../../Debug/icone-Pizza_Portuguesa.jpg");
            }
            else if (nomeProdutoCoringa == "Pizza Pepperoni")
            {
                picImagem.Image = Image.FromFile(@"C:../../Debug/icone-Pizza_Pepperoni.png");
            }
            else
            {
                PizzariaDB _context = new PizzariaDB();
                string nomeProduto = dgvProdutosPedido.CurrentRow.Cells["NomeProduto"].Value.ToString();

                if (nomeProduto == "Pizza Frango e Catupiry")
                {
                    picImagem.Image = Image.FromFile(@"C:../../Debug/Icone-Pizza_FrangoCatupiry.jpg");

                }
                else if (nomeProduto == "Pizza Calabresa")
                {
                    picImagem.Image = Image.FromFile(@"C:../../Debug/Icone-Pizza_Calabresa.jpg");
                }
                else if (nomeProduto == "Pizza Mussarela")
                {
                    picImagem.Image = Image.FromFile(@"C:../../Debug/Icone-Pizza_Mussarela.jpg");

                }
                else if (nomeProduto == "Pizza Portuguesa")
                {
                    picImagem.Image = Image.FromFile(@"C:../../Debug/icone-Pizza_Portuguesa.jpg");
                }
                else if (nomeProduto == "Pizza Pepperoni")
                {
                    picImagem.Image = Image.FromFile(@"C:../../Debug/icone-Pizza_Pepperoni.png");
                }



            }

            //Possibilidade de inserir mais imagens de produtos ao longo do tempo


        }

        //Botão de envio de pedido (Sem tela de Status, apenas verificação local)

        private void btnEnviaProduto_Click(object sender, EventArgs e)
        {
            if (txtPesquisaNome.Text != ""  && txtPesquisaProd.Text!= "" && cboTipoVenda.Text != "")
            {
                MessageBox.Show("Pedido Cadastrado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Faltam informações, por favor tente novamente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

       


    }
}
