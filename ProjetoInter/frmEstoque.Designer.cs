﻿namespace ProjetoInter
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
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.txtDescricaoProd = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.picVoltarEstoque = new System.Windows.Forms.PictureBox();
            this.txtCategoriaEstoque = new System.Windows.Forms.TextBox();
            this.txtQuantidadeEstoque = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltarEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(253, 326);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(97, 33);
            this.btnAlterar.TabIndex = 28;
            this.btnAlterar.Text = "Alterar +/-";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Red;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemover.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(354, 326);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(97, 33);
            this.btnRemover.TabIndex = 27;
            this.btnRemover.Text = "Remover -";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(143, 326);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(105, 33);
            this.btnAdicionar.TabIndex = 26;
            this.btnAdicionar.Text = "Adicionar +";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtProcurarProd
            // 
            this.txtProcurarProd.Location = new System.Drawing.Point(287, 188);
            this.txtProcurarProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.lblProcurarProdut.Location = new System.Drawing.Point(140, 185);
            this.lblProcurarProdut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProcurarProdut.Name = "lblProcurarProdut";
            this.lblProcurarProdut.Size = new System.Drawing.Size(124, 17);
            this.lblProcurarProdut.TabIndex = 23;
            this.lblProcurarProdut.Text = "Procurar Produto:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(284, 120);
            this.lblValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(81, 16);
            this.lblValor.TabIndex = 21;
            this.lblValor.Text = "Quantidade";
            this.lblValor.Click += new System.EventHandler(this.lblValor_Click);
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.BackColor = System.Drawing.Color.Transparent;
            this.lblCat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.ForeColor = System.Drawing.Color.White;
            this.lblCat.Location = new System.Drawing.Point(140, 120);
            this.lblCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(73, 16);
            this.lblCat.TabIndex = 19;
            this.lblCat.Text = "Categoria:";
            // 
            // txtDescricaoProd
            // 
            this.txtDescricaoProd.Location = new System.Drawing.Point(142, 90);
            this.txtDescricaoProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.lblDescricao.Location = new System.Drawing.Point(140, 69);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(165, 18);
            this.lblDescricao.TabIndex = 17;
            this.lblDescricao.Text = "Descrição do Produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(143, 37);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.lblNomeProduto.Location = new System.Drawing.Point(140, 16);
            this.lblNomeProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(135, 18);
            this.lblNomeProduto.TabIndex = 15;
            this.lblNomeProduto.Text = "Nome do Produto:";
            // 
            // dgvProduto
            // 
            this.dgvProduto.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(142, 221);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.RowHeadersWidth = 51;
            this.dgvProduto.Size = new System.Drawing.Size(308, 100);
            this.dgvProduto.TabIndex = 29;
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
            // txtCategoriaEstoque
            // 
            this.txtCategoriaEstoque.Location = new System.Drawing.Point(143, 140);
            this.txtCategoriaEstoque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCategoriaEstoque.Name = "txtCategoriaEstoque";
            this.txtCategoriaEstoque.Size = new System.Drawing.Size(129, 20);
            this.txtCategoriaEstoque.TabIndex = 32;
            // 
            // txtQuantidadeEstoque
            // 
            this.txtQuantidadeEstoque.Location = new System.Drawing.Point(287, 140);
            this.txtQuantidadeEstoque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque";
            this.txtQuantidadeEstoque.Size = new System.Drawing.Size(129, 20);
            this.txtQuantidadeEstoque.TabIndex = 33;
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(644, 427);
            this.Controls.Add(this.txtQuantidadeEstoque);
            this.Controls.Add(this.txtCategoriaEstoque);
            this.Controls.Add(this.picVoltarEstoque);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtProcurarProd);
            this.Controls.Add(this.lblProcurarProdut);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.txtDescricaoProd);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
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
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.TextBox txtDescricaoProd;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.PictureBox picVoltarEstoque;
        private System.Windows.Forms.TextBox txtCategoriaEstoque;
        private System.Windows.Forms.TextBox txtQuantidadeEstoque;
    }
}