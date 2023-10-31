namespace ProjetoInter
{
    partial class frmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtProcurarProd = new System.Windows.Forms.TextBox();
            this.lblProcurarProdut = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.txtDescricaoProd = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtCategoriaEstoque = new System.Windows.Forms.TextBox();
            this.txtQuantidadeEstoque = new System.Windows.Forms.TextBox();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picLimpar = new System.Windows.Forms.PictureBox();
            this.picBuscarEstoque = new System.Windows.Forms.PictureBox();
            this.picVoltarEstoque = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltarEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(227, 326);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(97, 33);
            this.btnAlterar.TabIndex = 28;
            this.btnAlterar.Text = "Alterar ";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Red;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemover.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(328, 326);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(97, 33);
            this.btnRemover.TabIndex = 27;
            this.btnRemover.Text = "Remover ";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Green;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(117, 326);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(105, 33);
            this.btnAdicionar.TabIndex = 26;
            this.btnAdicionar.Text = "Adicionar ";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtProcurarProd
            // 
            this.txtProcurarProd.Location = new System.Drawing.Point(233, 186);
            this.txtProcurarProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtProcurarProd.Name = "txtProcurarProd";
            this.txtProcurarProd.Size = new System.Drawing.Size(164, 20);
            this.txtProcurarProd.TabIndex = 24;
            // 
            // lblProcurarProdut
            // 
            this.lblProcurarProdut.AutoSize = true;
            this.lblProcurarProdut.BackColor = System.Drawing.Color.Transparent;
            this.lblProcurarProdut.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcurarProdut.ForeColor = System.Drawing.Color.White;
            this.lblProcurarProdut.Location = new System.Drawing.Point(114, 185);
            this.lblProcurarProdut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProcurarProdut.Name = "lblProcurarProdut";
            this.lblProcurarProdut.Size = new System.Drawing.Size(152, 21);
            this.lblProcurarProdut.TabIndex = 23;
            this.lblProcurarProdut.Text = "Procurar Produto:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblQuantidade.Location = new System.Drawing.Point(258, 120);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(92, 19);
            this.lblQuantidade.TabIndex = 21;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.BackColor = System.Drawing.Color.Transparent;
            this.lblCat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.ForeColor = System.Drawing.Color.White;
            this.lblCat.Location = new System.Drawing.Point(114, 120);
            this.lblCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(85, 19);
            this.lblCat.TabIndex = 19;
            this.lblCat.Text = "Categoria:";
            // 
            // txtDescricaoProd
            // 
            this.txtDescricaoProd.Location = new System.Drawing.Point(116, 90);
            this.txtDescricaoProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricaoProd.Name = "txtDescricaoProd";
            this.txtDescricaoProd.Size = new System.Drawing.Size(310, 20);
            this.txtDescricaoProd.TabIndex = 18;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(114, 69);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(207, 23);
            this.lblDescricao.TabIndex = 17;
            this.lblDescricao.Text = "Descrição do Produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(117, 37);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(308, 20);
            this.txtNomeProduto.TabIndex = 16;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.ForeColor = System.Drawing.Color.White;
            this.lblNomeProduto.Location = new System.Drawing.Point(114, 16);
            this.lblNomeProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(170, 23);
            this.lblNomeProduto.TabIndex = 15;
            this.lblNomeProduto.Text = "Nome do Produto:";
            // 
            // txtCategoriaEstoque
            // 
            this.txtCategoriaEstoque.Location = new System.Drawing.Point(117, 140);
            this.txtCategoriaEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoriaEstoque.Name = "txtCategoriaEstoque";
            this.txtCategoriaEstoque.Size = new System.Drawing.Size(129, 20);
            this.txtCategoriaEstoque.TabIndex = 32;
            // 
            // txtQuantidadeEstoque
            // 
            this.txtQuantidadeEstoque.Location = new System.Drawing.Point(261, 140);
            this.txtQuantidadeEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque";
            this.txtQuantidadeEstoque.Size = new System.Drawing.Size(129, 20);
            this.txtQuantidadeEstoque.TabIndex = 33;
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(116, 208);
            this.dgvEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.RowHeadersWidth = 51;
            this.dgvEstoque.RowTemplate.Height = 24;
            this.dgvEstoque.Size = new System.Drawing.Size(308, 114);
            this.dgvEstoque.TabIndex = 36;
            this.dgvEstoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellClick);
            this.dgvEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellContentClick);
            this.dgvEstoque.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEstoque_CellFormatting_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoInter.Properties.Resources.mercado;
            this.pictureBox1.Location = new System.Drawing.Point(481, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // picLimpar
            // 
            this.picLimpar.Image = global::ProjetoInter.Properties.Resources.apagar;
            this.picLimpar.Location = new System.Drawing.Point(434, 175);
            this.picLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.picLimpar.Name = "picLimpar";
            this.picLimpar.Size = new System.Drawing.Size(38, 31);
            this.picLimpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLimpar.TabIndex = 38;
            this.picLimpar.TabStop = false;
            this.picLimpar.Click += new System.EventHandler(this.picLimpar_Click);
            // 
            // picBuscarEstoque
            // 
            this.picBuscarEstoque.Image = global::ProjetoInter.Properties.Resources.procurar__1_;
            this.picBuscarEstoque.Location = new System.Drawing.Point(401, 175);
            this.picBuscarEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.picBuscarEstoque.Name = "picBuscarEstoque";
            this.picBuscarEstoque.Size = new System.Drawing.Size(29, 31);
            this.picBuscarEstoque.TabIndex = 35;
            this.picBuscarEstoque.TabStop = false;
            // 
            // picVoltarEstoque
            // 
            this.picVoltarEstoque.BackColor = System.Drawing.Color.Transparent;
            this.picVoltarEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVoltarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("picVoltarEstoque.Image")));
            this.picVoltarEstoque.Location = new System.Drawing.Point(23, 22);
            this.picVoltarEstoque.Name = "picVoltarEstoque";
            this.picVoltarEstoque.Size = new System.Drawing.Size(38, 33);
            this.picVoltarEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVoltarEstoque.TabIndex = 31;
            this.picVoltarEstoque.TabStop = false;
            this.picVoltarEstoque.Click += new System.EventHandler(this.picVoltarEstoque_Click);
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(593, 427);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picLimpar);
            this.Controls.Add(this.dgvEstoque);
            this.Controls.Add(this.picBuscarEstoque);
            this.Controls.Add(this.txtQuantidadeEstoque);
            this.Controls.Add(this.txtCategoriaEstoque);
            this.Controls.Add(this.picVoltarEstoque);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtProcurarProd);
            this.Controls.Add(this.lblProcurarProdut);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.txtDescricaoProd);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltarEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtProcurarProd;
        private System.Windows.Forms.Label lblProcurarProdut;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.TextBox txtDescricaoProd;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.PictureBox picVoltarEstoque;
        private System.Windows.Forms.TextBox txtCategoriaEstoque;
        private System.Windows.Forms.TextBox txtQuantidadeEstoque;
        private System.Windows.Forms.PictureBox picBuscarEstoque;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.PictureBox picLimpar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}