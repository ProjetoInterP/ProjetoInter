﻿using ProjetoInter.DB;
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

            if (pizzasCoringa.Contains(nomeProduto))
            {
                // Define o valor da pizza coringa usando o método específico da classe frmPedido
                double valorPizza = frmPedido.ObterValorPizzaCoringaLocal(nomeProduto);
                lblTotal.Text = valorPizza.ToString("0.00");
            }
            else
            {
                // Se não for uma pizza coringa, realiza a pesquisa no banco de dados
                using (var db = new PizzariaDB())
                {
                    var produtos = db.Estoque
                        .Where(u => u.NomeProduto.Contains(nomeProduto))
                        .ToList();

                    if (produtos.Any())
                    {
                        // Supondo que você queira pegar o valor do primeiro produto retornado da consulta
                        double valorProduto = produtos.First().Valor;
                        lblTotal.Text = valorProduto.ToString("0.00");
                    }
                    else
                    {
                        // Se nenhum produto for encontrado, você pode definir o lblTotal como 0 ou exibir uma mensagem de erro
                        lblTotal.Text = "0.00";
                        // Ou exibir uma mensagem de erro
                        // MessageBox.Show("Produto não encontrado no banco de dados.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private static double ObterValorPizzaCoringaLocal(string nomePizza)
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

        // Este método é chamado quando o formulário é carregado
        private void frmPedido_Load(object sender, EventArgs e)
        {
            // Usando um bloco 'using' para garantir que o contexto do banco de dados seja liberado após o uso
            using (var db = new PizzariaDB())
            {
                // Obtém todos os clientes do banco de dados e os vincula ao controle DataGridView dgvClientePedido
                var clientes = db.Clientes.ToList();
                dgvClientePedido.DataSource = clientes;

                // Obtém todos os produtos do banco de dados e os vincula ao controle DataGridView dgvProdutosPedido
                var produtos = db.Estoque.ToList();
                dgvProdutosPedido.DataSource = produtos;
            }

            // Configurações para o controle DataGridView dgvClientePedido:
            // - Impede a seleção múltipla de linhas
            // - Permite a seleção de linhas inteiras
            dgvClientePedido.MultiSelect = false;
            dgvClientePedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Configurações para o controle DataGridView dgvProdutosPedido:
            // - Impede a seleção múltipla de linhas
            // - Permite a seleção de linhas inteiras
            dgvProdutosPedido.MultiSelect = false;
            dgvProdutosPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            if (dgvClientePedido.SelectedRows.Count > 0 && dgvProdutosPedido.SelectedRows.Count > 0 &&
                !string.IsNullOrWhiteSpace(cboTipoVenda.Text) && !string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                DataGridViewRow clienteRow = dgvClientePedido.SelectedRows[0];
                DataGridViewRow produtoRow = dgvProdutosPedido.SelectedRows[0];

                string nomeCliente = clienteRow.Cells["Name"].Value.ToString();
                string nomeProduto = produtoRow.Cells["NomeProduto"].Value.ToString();
                double valorProduto = Convert.ToDouble(produtoRow.Cells["Valor"].Value);
                int quantidadeProduto = Convert.ToInt32(produtoRow.Cells["QuantidadeProduto"].Value);

                // Verificar se há quantidade suficiente em estoque
                if (quantidadeProduto > 0)
                {
                    // Atualizar a quantidade no banco de dados (subtrair 1 do estoque)
                    using (var db = new PizzariaDB())
                    {
                        Estoque estoque = db.Estoque.FirstOrDefault(u => u.NomeProduto == nomeProduto);
                        if (estoque != null)
                        {
                            estoque.QuantidadeProduto -= 1; // Subtrair 1 do estoque
                            db.SaveChanges();
                        }
                    }

                    // Exibir a mensagem de sucesso
                    MessageBox.Show($"Produto '{nomeProduto}' para '{nomeCliente}' enviado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Se não houver quantidade suficiente em estoque, exibir uma mensagem de erro
                    MessageBox.Show($"Produto '{nomeProduto}' está fora de estoque!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Se alguma informação estiver faltando, exibir uma mensagem de erro
                MessageBox.Show("Faltam informações, por favor, tente novamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProdutosPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProdutosPedido.Rows[e.RowIndex];
                txtDescricao.Text = row.Cells["DescricaoProduto"].Value.ToString();

                double valorProduto = Convert.ToDouble(row.Cells["Valor"].Value);

                // Se o produto selecionado for uma pizza coringa, somar ao valor do produto
                if (pizzasCoringa.Contains(row.Cells["NomeProduto"].Value.ToString()))
                {
                    double valorPizzaCoringa = ObterValorPizzaCoringa(row.Cells["NomeProduto"].Value.ToString());
                    valorProduto += valorPizzaCoringa;
                }

                // Atribuir o valor total ao lblTotal
                lblTotal.Text = valorProduto.ToString("0.00");
            }
        }
    }
}
