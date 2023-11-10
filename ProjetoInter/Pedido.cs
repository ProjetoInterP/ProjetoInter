using ProjetoInter.DB;
using ProjetoInter.Modelos;
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
        private Dictionary<string, string> imagensProdutos = new Dictionary<string, string>
        {
            { "Pizza Frango e Catupiry", "Icone-Pizza_FrangoCatupiry.jpg" },
            { "Pizza Calabresa", "Icone-Pizza_Calabresa.jpg" },
            { "Pizza Mussarela", "Icone-Pizza_Mussarela.jpg" },
            { "Pizza Portuguesa", "Icone-Pizza_Portuguesa.jpg" },
            { "Pizza Pepperoni", "Icone-Pizza_Pepperoni.png" }
        };

        public frmPedido()
        {
            InitializeComponent();
            string cargoUsuario = Global.FuncaoSelecionada;
            frmLogin = new frmLogin();
            pastaSelecionada = Application.StartupPath + @"\";
        }

        private void picVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin.VoltarAoFormAnterior();
        }
        List<string> pizzasCoringa = new List<string>
        {
            "Pizza Frango e Catupiry",
            "Pizza Calabresa",
            "Pizza Mussarela",
            "Pizza Portuguesa",
            "Pizza Pepperoni"

        };

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

        private void picPesquisaProd_Click(object sender, EventArgs e)
        {
            string nomeProduto = txtPesquisaProd.Text;

            if (pizzasCoringa.Contains(nomeProduto))
            {
                double valorPizza = ObterValorPizzaCoringaLocal(nomeProduto);
                lblTotal.Text = valorPizza.ToString("0.00");
            }
            else
            {
                using (var db = new PizzariaDB())
                {
                    var produtos = db.Estoque
                        .Where(u => u.NomeProduto.Contains(nomeProduto))
                        .ToList();

                    if (produtos.Any())
                    {
                        double valorProduto = produtos.First().Valor;
                        lblTotal.Text = valorProduto.ToString("0.00");
                    }
                    else
                    {
                        lblTotal.Text = "0.00";
                    }
                }
            }

            ExibirImagemProduto(nomeProduto);
        }

        private static double ObterValorPizzaCoringaLocal(string nomePizza)
        {
            Dictionary<string, double> valoresPizzasCoringa = new Dictionary<string, double>
            {
                { "Pizza Frango e Catupiry", 20.00 },
                { "Pizza Calabresa", 18.00 },
                { "Pizza Mussarela", 16.00 },
                { "Pizza Portuguesa", 22.00 },
                { "Pizza Pepperoni", 21.00 }
            };

            if (valoresPizzasCoringa.ContainsKey(nomePizza))
            {
                return valoresPizzasCoringa[nomePizza];
            }

            return 0;
        }

        private void dgvClientePedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientePedido.Rows[e.RowIndex];
                txtPesquisaNome.Text = row.Cells["Name"].Value.ToString();
            }
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            using (var db = new PizzariaDB())
            {
                var clientes = db.Clientes.ToList();
                dgvClientePedido.DataSource = clientes;
                var produtos = db.Estoque.ToList();
                dgvProdutosPedido.DataSource = produtos;
            }

            dgvClientePedido.MultiSelect = false;
            dgvClientePedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutosPedido.MultiSelect = false;
            dgvProdutosPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

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

        public void ExibirImagemProduto(string nomeProduto)
        {
            if (imagensProdutos.ContainsKey(nomeProduto))
            {
                string nomeArquivo = imagensProdutos[nomeProduto];
                string caminhoImagem = Path.Combine(pastaSelecionada, "Images", nomeArquivo);

                if (File.Exists(caminhoImagem))
                {
                    picImagem.Image = Image.FromFile(caminhoImagem);
                }
                else
                {
                    MessageBox.Show($"Imagem não encontrada para {nomeProduto}");
                    picImagem.Image = null;
                }
            }
        }

        private void dgvProdutosPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProdutosPedido.Rows[e.RowIndex];
                txtDescricao.Text = row.Cells["DescricaoProduto"].Value.ToString();

                double valorProduto = Convert.ToDouble(row.Cells["Valor"].Value);

                if (pizzasCoringa.Contains(row.Cells["NomeProduto"].Value.ToString()))
                {
                    double valorPizzaCoringa = ObterValorPizzaCoringa(row.Cells["NomeProduto"].Value.ToString());
                    valorProduto += valorPizzaCoringa;
                }

                lblTotal.Text = valorProduto.ToString("0.00");
            }
        }

        private double ObterValorPizzaCoringa(string nomePizza)
        {
            // Define os valores das pizzas coringa
            Dictionary<string, double> valoresPizzasCoringa = new Dictionary<string, double>
    {
        { "Pizza Frango e Catupiry", 20.00 },
        { "Pizza Calabresa", 18.00 },
        { "Pizza Mussarela", 16.00 },
        { "Pizza Portuguesa", 22.00 },
        { "Pizza Pepperoni", 21.00 }
    };

            // Verifica se o nome da pizza está no dicionário e retorna o valor correspondente
            if (valoresPizzasCoringa.ContainsKey(nomePizza))
            {
                return valoresPizzasCoringa[nomePizza];
            }

            // Se o nome da pizza não estiver no dicionário, retorna 0 como valor padrão
            return 0;
        }



        private void btnEnviaProduto_Click(object sender, EventArgs e)
        {
            if (dgvClientePedido.SelectedRows.Count > 0 && dgvProdutosPedido.SelectedRows.Count > 0 &&
                !string.IsNullOrWhiteSpace(cboTipoVenda.Text) && !string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                DataGridViewRow clienteRow = dgvClientePedido.SelectedRows[0];
                DataGridViewRow produtoRow = dgvProdutosPedido.SelectedRows[0];

                string nomeCliente = clienteRow.Cells["Name"].Value.ToString();
                string nomeProduto = produtoRow.Cells["NomeProduto"].Value.ToString();
                double valorProduto = Convert.ToDouble(produtoRow.Cells["Valor"].Value);

                using (var db = new PizzariaDB())
                {
                    Estoque estoque = db.Estoque.FirstOrDefault(u => u.NomeProduto == nomeProduto);
                    if (estoque != null && estoque.QuantidadeProduto > 0)
                    {
                        estoque.QuantidadeProduto -= 1;
                        db.SaveChanges();
                        MessageBox.Show($"Produto '{nomeProduto}' para '{nomeCliente}' enviado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Produto '{nomeProduto}' está fora de estoque!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltam informações, por favor, tente novamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
