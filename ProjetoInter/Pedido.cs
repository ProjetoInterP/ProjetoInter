using ProjetoInter.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        string pastaSelecionada = "";
        public frmPedido()
        {
            InitializeComponent();
            string cargoUsuario = Global.FuncaoSelecionada;
            frmLogin = new frmLogin();
            pastaSelecionada = Application.StartupPath + @"\";

            MessageBox.Show(pastaSelecionada);
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
            string nomeProdutoCoringa = txtPesquisaProd.Text;

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

                    // Exibe a Pizza de Frango com Catupiry
                    ImagemProdutosCoringa(nomeProdutoCoringa);
                }

            }
        

    

        }

        private void dgvClientePedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Certifique-se de que uma linha válida foi clicada
            {
                DataGridViewRow row = dgvClientePedido.Rows[e.RowIndex];

                // Preencha os campos de texto e combobox com os dados da célula clicada
                txtPesquisaNome.Text = row.Cells["Name"].Value.ToString();
                

                // Preencha outros campos de texto conforme necessário
            }
        }

        //Carrega informações do banco de dados
        private void frmPedido_Load(object sender, EventArgs e)
        {
            using (var db = new PizzariaDB())
            {
                //usa o dgvClientePedido
                var clientes = db.Clientes.ToList(); 
                dgvClientePedido.DataSource = clientes;


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

        //Função de Imagens de Pizza pela Database

        public void ImagemProdutos(string nomeProduto)
        {
            try
            {
                string imageFileName = Path.Combine(Application.StartupPath, "Images", "Icone-Pizza_" + nomeProduto + ".jpg");

                if (File.Exists(imageFileName))
                {
                    picImagem.Image = Image.FromFile(imageFileName);
                }
                else
                {
                    // Lidere com a situação em que a imagem não foi encontrada
                    MessageBox.Show($"Imagem não encontrada para {nomeProduto}");
                    picImagem.Image = null; // Defina a imagem como nula ou alguma imagem padrão
                }
            }
            catch (Exception ex)
            {
                // Lidere com exceções aqui, se necessário
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }



        //Função de Imagens Coringa
        public void ImagemProdutosCoringa(string nomeProdutoCoringa)
        {
            try
            {
                if (nomeProdutoCoringa == "Pizza Frango e Catupiry")
                {
                    picImagem.Image = Image.FromFile(Path.Combine(pastaSelecionada, @"Images\Icone-Pizza_FrangoCatupiry.jpg"));
                }
                else if (nomeProdutoCoringa == "Pizza Calabresa")
                {
                    picImagem.Image = Image.FromFile(Path.Combine(pastaSelecionada, @"Images\Icone-Pizza_Calabresa.jpg"));
                }
                else if (nomeProdutoCoringa == "Pizza Mussarela")
                {
                    picImagem.Image = Image.FromFile(Path.Combine(pastaSelecionada, @"Images\Icone-Pizza_Mussarela.jpg"));
                }
                else if (nomeProdutoCoringa == "Pizza Portuguesa")
                {
                    picImagem.Image = Image.FromFile(Path.Combine(pastaSelecionada, @"Images\Icone-Pizza_Portuguesa.jpg"));
                }
                else if (nomeProdutoCoringa == "Pizza Pepperoni")
                {
                    picImagem.Image = Image.FromFile(Path.Combine(pastaSelecionada, @"Images\Icone-Pizza_Pepperoni.png"));
                }
                // Possibilidade de inserir mais imagens de produtos ao longo do tempo
            }
            catch (FileNotFoundException ex)
            {
                // Lidere com exceção de arquivo não encontrado aqui (você pode mostrar uma imagem padrão ou mensagem de erro)
                MessageBox.Show($"Imagem não encontrada para {nomeProdutoCoringa}");
                picImagem.Image = null; // Define a imagem como nula ou alguma imagem padrão
            }
            
        }


        //Botão de envio de pedido (Sem tela de Status, apenas verificação local)

        private void btnEnviaProduto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPesquisaNome.Text) && !string.IsNullOrWhiteSpace(txtPesquisaProd.Text) && !string.IsNullOrWhiteSpace(cboTipoVenda.Text) && !string.IsNullOrWhiteSpace(txtDescricao.Text))
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
