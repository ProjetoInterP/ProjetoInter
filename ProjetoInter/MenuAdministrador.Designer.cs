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
            this.lblPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPedidos.Location = new System.Drawing.Point(410, 251);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(73, 20);
            this.lblPedidos.TabIndex = 23;
            this.lblPedidos.Text = "Pedidos";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblEstoque.Location = new System.Drawing.Point(277, 251);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(76, 20);
            this.lblEstoque.TabIndex = 22;
            this.lblEstoque.Text = "Estoque";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCadastro.Location = new System.Drawing.Point(85, 251);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(82, 20);
            this.lblCadastro.TabIndex = 21;
            this.lblCadastro.Text = "Cadastro";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblAdmin.Location = new System.Drawing.Point(243, 100);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(120, 20);
            this.lblAdmin.TabIndex = 20;
            this.lblAdmin.Text = "Administrador";
            // 
            // picAdmin
            // 
            this.picAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAdmin.Image = global::ProjetoInter.Properties.Resources.Funcionario;
            this.picAdmin.Location = new System.Drawing.Point(253, 12);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(100, 85);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdmin.TabIndex = 19;
            this.picAdmin.TabStop = false;
            // 
            // picLogout
            // 
            this.picLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogout.Image = global::ProjetoInter.Properties.Resources.sair;
            this.picLogout.Location = new System.Drawing.Point(12, 354);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(71, 52);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogout.TabIndex = 18;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // picPedidos
            // 
            this.picPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPedidos.Image = global::ProjetoInter.Properties.Resources.pedido;
            this.picPedidos.Location = new System.Drawing.Point(403, 163);
            this.picPedidos.Name = "picPedidos";
            this.picPedidos.Size = new System.Drawing.Size(100, 85);
            this.picPedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPedidos.TabIndex = 17;
            this.picPedidos.TabStop = false;
            this.picPedidos.Click += new System.EventHandler(this.picPedidos_Click);
            // 
            // picEstoque
            // 
            this.picEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEstoque.Image = global::ProjetoInter.Properties.Resources.despensa__1_;
            this.picEstoque.Location = new System.Drawing.Point(263, 163);
            this.picEstoque.Name = "picEstoque";
            this.picEstoque.Size = new System.Drawing.Size(100, 85);
            this.picEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEstoque.TabIndex = 16;
            this.picEstoque.TabStop = false;
            this.picEstoque.Click += new System.EventHandler(this.picEstoque_Click);
            // 
            // picCadastro
            // 
            this.picCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCadastro.Image = global::ProjetoInter.Properties.Resources.cadastro;
            this.picCadastro.Location = new System.Drawing.Point(78, 163);
            this.picCadastro.Name = "picCadastro";
            this.picCadastro.Size = new System.Drawing.Size(100, 85);
            this.picCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCadastro.TabIndex = 15;
            this.picCadastro.TabStop = false;
            this.picCadastro.Click += new System.EventHandler(this.picCadastro_Click);
            // 
            // frmMenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 432);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.picAdmin);
            this.Controls.Add(this.picLogout);
            this.Controls.Add(this.picPedidos);
            this.Controls.Add(this.picEstoque);
            this.Controls.Add(this.picCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}