namespace ProjetoInter
{
    partial class frmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.pnlPedidos = new System.Windows.Forms.Panel();
            this.picProximo = new System.Windows.Forms.PictureBox();
            this.picVoltar = new System.Windows.Forms.PictureBox();
            this.panelContainerProdutos = new System.Windows.Forms.Panel();
            this.picPesquisaProd = new System.Windows.Forms.PictureBox();
            this.txtPesquisaProd = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cboTipoVenda = new System.Windows.Forms.ComboBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dblProdutos = new System.Windows.Forms.DataGridView();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.panelContainerClientes = new System.Windows.Forms.Panel();
            this.picPesquisaClientes = new System.Windows.Forms.PictureBox();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.dblClientes = new System.Windows.Forms.DataGridView();
            this.panelProdutos = new System.Windows.Forms.Panel();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.pnlPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            this.panelContainerProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPesquisaProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.panelContainerClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPesquisaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblClientes)).BeginInit();
            this.panelProdutos.SuspendLayout();
            this.panelClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPedidos
            // 
            this.pnlPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPedidos.Controls.Add(this.picProximo);
            this.pnlPedidos.Controls.Add(this.picVoltar);
            this.pnlPedidos.Controls.Add(this.panelContainerProdutos);
            this.pnlPedidos.Controls.Add(this.panelContainerClientes);
            this.pnlPedidos.Controls.Add(this.panelProdutos);
            this.pnlPedidos.Controls.Add(this.panelClientes);
            this.pnlPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPedidos.Location = new System.Drawing.Point(0, 0);
            this.pnlPedidos.Name = "pnlPedidos";
            this.pnlPedidos.Size = new System.Drawing.Size(799, 669);
            this.pnlPedidos.TabIndex = 0;
            // 
            // picProximo
            // 
            this.picProximo.BackColor = System.Drawing.Color.Transparent;
            this.picProximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProximo.Image = ((System.Drawing.Image)(resources.GetObject("picProximo.Image")));
            this.picProximo.Location = new System.Drawing.Point(746, 624);
            this.picProximo.Name = "picProximo";
            this.picProximo.Size = new System.Drawing.Size(38, 33);
            this.picProximo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProximo.TabIndex = 5;
            this.picProximo.TabStop = false;
            // 
            // picVoltar
            // 
            this.picVoltar.BackColor = System.Drawing.Color.Transparent;
            this.picVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVoltar.Image = ((System.Drawing.Image)(resources.GetObject("picVoltar.Image")));
            this.picVoltar.Location = new System.Drawing.Point(7, 624);
            this.picVoltar.Name = "picVoltar";
            this.picVoltar.Size = new System.Drawing.Size(38, 33);
            this.picVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVoltar.TabIndex = 4;
            this.picVoltar.TabStop = false;
            // 
            // panelContainerProdutos
            // 
            this.panelContainerProdutos.BackColor = System.Drawing.Color.Transparent;
            this.panelContainerProdutos.Controls.Add(this.picPesquisaProd);
            this.panelContainerProdutos.Controls.Add(this.txtPesquisaProd);
            this.panelContainerProdutos.Controls.Add(this.txtDescricao);
            this.panelContainerProdutos.Controls.Add(this.cboTipoVenda);
            this.panelContainerProdutos.Controls.Add(this.lblValor);
            this.panelContainerProdutos.Controls.Add(this.lblTotal);
            this.panelContainerProdutos.Controls.Add(this.dblProdutos);
            this.panelContainerProdutos.Controls.Add(this.picImagem);
            this.panelContainerProdutos.Location = new System.Drawing.Point(7, 338);
            this.panelContainerProdutos.Name = "panelContainerProdutos";
            this.panelContainerProdutos.Size = new System.Drawing.Size(786, 272);
            this.panelContainerProdutos.TabIndex = 3;
            // 
            // picPesquisaProd
            // 
            this.picPesquisaProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPesquisaProd.Image = ((System.Drawing.Image)(resources.GetObject("picPesquisaProd.Image")));
            this.picPesquisaProd.Location = new System.Drawing.Point(670, 0);
            this.picPesquisaProd.Name = "picPesquisaProd";
            this.picPesquisaProd.Size = new System.Drawing.Size(38, 33);
            this.picPesquisaProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPesquisaProd.TabIndex = 17;
            this.picPesquisaProd.TabStop = false;
            // 
            // txtPesquisaProd
            // 
            this.txtPesquisaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPesquisaProd.Location = new System.Drawing.Point(278, 10);
            this.txtPesquisaProd.Name = "txtPesquisaProd";
            this.txtPesquisaProd.Size = new System.Drawing.Size(387, 26);
            this.txtPesquisaProd.TabIndex = 16;
            this.txtPesquisaProd.Text = "Pesquisar por Produto";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(6, 197);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(240, 63);
            this.txtDescricao.TabIndex = 15;
            this.txtDescricao.Text = "Inserir descrição";
            // 
            // cboTipoVenda
            // 
            this.cboTipoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboTipoVenda.FormattingEnabled = true;
            this.cboTipoVenda.Items.AddRange(new object[] {
            "Entrega",
            "Retirada"});
            this.cboTipoVenda.Location = new System.Drawing.Point(6, 158);
            this.cboTipoVenda.MaximumSize = new System.Drawing.Size(240, 0);
            this.cboTipoVenda.MinimumSize = new System.Drawing.Size(240, 0);
            this.cboTipoVenda.Name = "cboTipoVenda";
            this.cboTipoVenda.Size = new System.Drawing.Size(240, 28);
            this.cboTipoVenda.TabIndex = 14;
            this.cboTipoVenda.Text = "Tipo de venda:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblValor.ForeColor = System.Drawing.SystemColors.Window;
            this.lblValor.Location = new System.Drawing.Point(255, 215);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(169, 25);
            this.lblValor.TabIndex = 13;
            this.lblValor.Text = "VALOR TOTAL: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTotal.Location = new System.Drawing.Point(430, 215);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 24);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dblProdutos
            // 
            this.dblProdutos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dblProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dblProdutos.Location = new System.Drawing.Point(277, 42);
            this.dblProdutos.Name = "dblProdutos";
            this.dblProdutos.Size = new System.Drawing.Size(500, 138);
            this.dblProdutos.TabIndex = 1;
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(6, 9);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(240, 128);
            this.picImagem.TabIndex = 0;
            this.picImagem.TabStop = false;
            // 
            // panelContainerClientes
            // 
            this.panelContainerClientes.BackColor = System.Drawing.Color.Transparent;
            this.panelContainerClientes.Controls.Add(this.picPesquisaClientes);
            this.panelContainerClientes.Controls.Add(this.txtPesquisaNome);
            this.panelContainerClientes.Controls.Add(this.dblClientes);
            this.panelContainerClientes.Location = new System.Drawing.Point(7, 79);
            this.panelContainerClientes.Name = "panelContainerClientes";
            this.panelContainerClientes.Size = new System.Drawing.Size(786, 195);
            this.panelContainerClientes.TabIndex = 2;
            // 
            // picPesquisaClientes
            // 
            this.picPesquisaClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPesquisaClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPesquisaClientes.Image = ((System.Drawing.Image)(resources.GetObject("picPesquisaClientes.Image")));
            this.picPesquisaClientes.Location = new System.Drawing.Point(375, 15);
            this.picPesquisaClientes.Name = "picPesquisaClientes";
            this.picPesquisaClientes.Size = new System.Drawing.Size(38, 33);
            this.picPesquisaClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPesquisaClientes.TabIndex = 2;
            this.picPesquisaClientes.TabStop = false;
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPesquisaNome.Location = new System.Drawing.Point(14, 24);
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(355, 26);
            this.txtPesquisaNome.TabIndex = 1;
            this.txtPesquisaNome.Text = "Pesquisar por nome";
            // 
            // dblClientes
            // 
            this.dblClientes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dblClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dblClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dblClientes.Location = new System.Drawing.Point(14, 53);
            this.dblClientes.Name = "dblClientes";
            this.dblClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dblClientes.Size = new System.Drawing.Size(763, 135);
            this.dblClientes.TabIndex = 0;
            // 
            // panelProdutos
            // 
            this.panelProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.panelProdutos.Controls.Add(this.lblProdutos);
            this.panelProdutos.Location = new System.Drawing.Point(0, 289);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(793, 43);
            this.panelProdutos.TabIndex = 1;
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblProdutos.ForeColor = System.Drawing.SystemColors.Window;
            this.lblProdutos.Location = new System.Drawing.Point(342, 9);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(123, 24);
            this.lblProdutos.TabIndex = 1;
            this.lblProdutos.Text = "PRODUTOS";
            // 
            // panelClientes
            // 
            this.panelClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.panelClientes.Controls.Add(this.lblClientes);
            this.panelClientes.Location = new System.Drawing.Point(3, 30);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(793, 43);
            this.panelClientes.TabIndex = 0;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.SystemColors.Window;
            this.lblClientes.Location = new System.Drawing.Point(342, 9);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(109, 24);
            this.lblClientes.TabIndex = 0;
            this.lblClientes.Text = "CLIENTES";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 669);
            this.Controls.Add(this.pnlPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.pnlPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            this.panelContainerProdutos.ResumeLayout(false);
            this.panelContainerProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPesquisaProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.panelContainerClientes.ResumeLayout(false);
            this.panelContainerClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPesquisaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblClientes)).EndInit();
            this.panelProdutos.ResumeLayout(false);
            this.panelProdutos.PerformLayout();
            this.panelClientes.ResumeLayout(false);
            this.panelClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPedidos;
        private System.Windows.Forms.Panel panelContainerClientes;
        private System.Windows.Forms.Panel panelProdutos;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.DataGridView dblClientes;
        private System.Windows.Forms.PictureBox picPesquisaClientes;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Panel panelContainerProdutos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dblProdutos;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cboTipoVenda;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.PictureBox picPesquisaProd;
        private System.Windows.Forms.TextBox txtPesquisaProd;
        private System.Windows.Forms.PictureBox picProximo;
        private System.Windows.Forms.PictureBox picVoltar;
    }
}