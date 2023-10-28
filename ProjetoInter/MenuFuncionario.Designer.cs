namespace ProjetoInter
{
    partial class frmMenuFuncionario
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
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.picEstoque = new System.Windows.Forms.PictureBox();
            this.picPedidos = new System.Windows.Forms.PictureBox();
            this.picLogout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblFuncionario.Location = new System.Drawing.Point(249, 100);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(103, 20);
            this.lblFuncionario.TabIndex = 25;
            this.lblFuncionario.Text = "Funcionário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProjetoInter.Properties.Resources.atendente;
            this.pictureBox1.Location = new System.Drawing.Point(252, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblEstoque.Location = new System.Drawing.Point(379, 255);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(76, 20);
            this.lblEstoque.TabIndex = 23;
            this.lblEstoque.Text = "Estoque";
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPedidos.Location = new System.Drawing.Point(146, 255);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(73, 20);
            this.lblPedidos.TabIndex = 22;
            this.lblPedidos.Text = "Pedidos";
            // 
            // picEstoque
            // 
            this.picEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEstoque.Image = global::ProjetoInter.Properties.Resources.despensa__1_;
            this.picEstoque.Location = new System.Drawing.Point(369, 167);
            this.picEstoque.Name = "picEstoque";
            this.picEstoque.Size = new System.Drawing.Size(100, 85);
            this.picEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEstoque.TabIndex = 21;
            this.picEstoque.TabStop = false;
            this.picEstoque.Click += new System.EventHandler(this.picEstoque_Click);
            // 
            // picPedidos
            // 
            this.picPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPedidos.Image = global::ProjetoInter.Properties.Resources.pedido;
            this.picPedidos.Location = new System.Drawing.Point(131, 167);
            this.picPedidos.Name = "picPedidos";
            this.picPedidos.Size = new System.Drawing.Size(100, 85);
            this.picPedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPedidos.TabIndex = 20;
            this.picPedidos.TabStop = false;
            this.picPedidos.Click += new System.EventHandler(this.picPedidos_Click);
            // 
            // picLogout
            // 
            this.picLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogout.Image = global::ProjetoInter.Properties.Resources.sair;
            this.picLogout.Location = new System.Drawing.Point(12, 368);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(100, 52);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogout.TabIndex = 19;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // frmMenuFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 432);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.picEstoque);
            this.Controls.Add(this.picPedidos);
            this.Controls.Add(this.picLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenuFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.PictureBox picEstoque;
        private System.Windows.Forms.PictureBox picPedidos;
        private System.Windows.Forms.PictureBox picLogout;
    }
}