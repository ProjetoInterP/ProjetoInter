namespace ProjetoInter
{
    partial class frmMenuAdministrador
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
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.picPedidos = new System.Windows.Forms.PictureBox();
            this.picEstoque = new System.Windows.Forms.PictureBox();
            this.picCadastro = new System.Windows.Forms.PictureBox();
            this.bgPicPedidosFunc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSairMenuAdmin = new System.Windows.Forms.Label();
            this.lblOpçãoMenuAdmin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.BackColor = System.Drawing.Color.DimGray;
            this.lblPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPedidos.Location = new System.Drawing.Point(587, 349);
            this.lblPedidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(90, 25);
            this.lblPedidos.TabIndex = 23;
            this.lblPedidos.Text = "Pedidos";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.BackColor = System.Drawing.Color.DimGray;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblEstoque.Location = new System.Drawing.Point(356, 349);
            this.lblEstoque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(91, 25);
            this.lblEstoque.TabIndex = 22;
            this.lblEstoque.Text = "Estoque";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.Color.DimGray;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCadastro.Location = new System.Drawing.Point(125, 349);
            this.lblCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(100, 25);
            this.lblCadastro.TabIndex = 21;
            this.lblCadastro.Text = "Cadastro";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Wheat;
            this.lblAdmin.Location = new System.Drawing.Point(346, 94);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(191, 25);
            this.lblAdmin.TabIndex = 20;
            this.lblAdmin.Text = "ADMINISTRADOR";
            // 
            // picAdmin
            // 
            this.picAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAdmin.Image = global::ProjetoInter.Properties.Resources.Funcionario;
            this.picAdmin.Location = new System.Drawing.Point(226, 52);
            this.picAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(112, 94);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdmin.TabIndex = 19;
            this.picAdmin.TabStop = false;
            // 
            // picLogout
            // 
            this.picLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogout.Image = global::ProjetoInter.Properties.Resources.sair;
            this.picLogout.Location = new System.Drawing.Point(16, 438);
            this.picLogout.Margin = new System.Windows.Forms.Padding(4);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(75, 64);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogout.TabIndex = 18;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // picPedidos
            // 
            this.picPedidos.BackColor = System.Drawing.Color.DimGray;
            this.picPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPedidos.Image = global::ProjetoInter.Properties.Resources.pedido;
            this.picPedidos.Location = new System.Drawing.Point(569, 241);
            this.picPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.picPedidos.Name = "picPedidos";
            this.picPedidos.Size = new System.Drawing.Size(133, 105);
            this.picPedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPedidos.TabIndex = 17;
            this.picPedidos.TabStop = false;
            this.picPedidos.Click += new System.EventHandler(this.picPedidos_Click);
            // 
            // picEstoque
            // 
            this.picEstoque.BackColor = System.Drawing.Color.DimGray;
            this.picEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEstoque.Image = global::ProjetoInter.Properties.Resources.despensa__1_;
            this.picEstoque.Location = new System.Drawing.Point(338, 241);
            this.picEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.picEstoque.Name = "picEstoque";
            this.picEstoque.Size = new System.Drawing.Size(133, 105);
            this.picEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEstoque.TabIndex = 16;
            this.picEstoque.TabStop = false;
            this.picEstoque.Click += new System.EventHandler(this.picEstoque_Click);
            // 
            // picCadastro
            // 
            this.picCadastro.BackColor = System.Drawing.Color.DimGray;
            this.picCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCadastro.Image = global::ProjetoInter.Properties.Resources.cadastro;
            this.picCadastro.Location = new System.Drawing.Point(109, 241);
            this.picCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.picCadastro.Name = "picCadastro";
            this.picCadastro.Size = new System.Drawing.Size(133, 105);
            this.picCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCadastro.TabIndex = 15;
            this.picCadastro.TabStop = false;
            this.picCadastro.Click += new System.EventHandler(this.picCadastro_Click);
            // 
            // bgPicPedidosFunc
            // 
            this.bgPicPedidosFunc.BackColor = System.Drawing.Color.DimGray;
            this.bgPicPedidosFunc.Location = new System.Drawing.Point(73, 210);
            this.bgPicPedidosFunc.Name = "bgPicPedidosFunc";
            this.bgPicPedidosFunc.Size = new System.Drawing.Size(204, 175);
            this.bgPicPedidosFunc.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(304, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 175);
            this.label1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(532, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 175);
            this.label2.TabIndex = 29;
            // 
            // lblSairMenuAdmin
            // 
            this.lblSairMenuAdmin.AutoSize = true;
            this.lblSairMenuAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSairMenuAdmin.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSairMenuAdmin.Location = new System.Drawing.Point(99, 457);
            this.lblSairMenuAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSairMenuAdmin.Name = "lblSairMenuAdmin";
            this.lblSairMenuAdmin.Size = new System.Drawing.Size(69, 32);
            this.lblSairMenuAdmin.TabIndex = 30;
            this.lblSairMenuAdmin.Text = "Sair";
            // 
            // lblOpçãoMenuAdmin
            // 
            this.lblOpçãoMenuAdmin.AutoSize = true;
            this.lblOpçãoMenuAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpçãoMenuAdmin.ForeColor = System.Drawing.Color.DarkGray;
            this.lblOpçãoMenuAdmin.Location = new System.Drawing.Point(302, 170);
            this.lblOpçãoMenuAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpçãoMenuAdmin.Name = "lblOpçãoMenuAdmin";
            this.lblOpçãoMenuAdmin.Size = new System.Drawing.Size(201, 25);
            this.lblOpçãoMenuAdmin.TabIndex = 31;
            this.lblOpçãoMenuAdmin.Text = "Escolha uma opção";
            // 
            // frmMenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.lblOpçãoMenuAdmin);
            this.Controls.Add(this.lblSairMenuAdmin);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.picAdmin);
            this.Controls.Add(this.picLogout);
            this.Controls.Add(this.picPedidos);
            this.Controls.Add(this.picEstoque);
            this.Controls.Add(this.picCadastro);
            this.Controls.Add(this.bgPicPedidosFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMenuAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu do Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.PictureBox picPedidos;
        private System.Windows.Forms.PictureBox picEstoque;
        private System.Windows.Forms.PictureBox picCadastro;
        private System.Windows.Forms.Label bgPicPedidosFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSairMenuAdmin;
        private System.Windows.Forms.Label lblOpçãoMenuAdmin;
    }
}