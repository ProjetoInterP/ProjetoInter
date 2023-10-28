namespace ProjetoInter
{
    partial class MenuAdministrador
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
            this.lblMenuAdmin = new System.Windows.Forms.Label();
            this.btnCadastroAdmin = new System.Windows.Forms.Button();
            this.btnEstoqueAdmin = new System.Windows.Forms.Button();
            this.btnPedidosAdmin = new System.Windows.Forms.Button();
            this.btnLogoutAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuAdmin
            // 
            this.lblMenuAdmin.AutoSize = true;
            this.lblMenuAdmin.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuAdmin.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMenuAdmin.Location = new System.Drawing.Point(265, 47);
            this.lblMenuAdmin.Name = "lblMenuAdmin";
            this.lblMenuAdmin.Size = new System.Drawing.Size(270, 31);
            this.lblMenuAdmin.TabIndex = 0;
            this.lblMenuAdmin.Text = "Menu de Administrador";
            // 
            // btnCadastroAdmin
            // 
            this.btnCadastroAdmin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCadastroAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroAdmin.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroAdmin.Location = new System.Drawing.Point(151, 185);
            this.btnCadastroAdmin.Name = "btnCadastroAdmin";
            this.btnCadastroAdmin.Size = new System.Drawing.Size(129, 64);
            this.btnCadastroAdmin.TabIndex = 1;
            this.btnCadastroAdmin.Text = "CADASTRO";
            this.btnCadastroAdmin.UseVisualStyleBackColor = false;
            this.btnCadastroAdmin.Click += new System.EventHandler(this.btnCadastroAdmin_Click);
            // 
            // btnEstoqueAdmin
            // 
            this.btnEstoqueAdmin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEstoqueAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoqueAdmin.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueAdmin.Location = new System.Drawing.Point(537, 185);
            this.btnEstoqueAdmin.Name = "btnEstoqueAdmin";
            this.btnEstoqueAdmin.Size = new System.Drawing.Size(129, 64);
            this.btnEstoqueAdmin.TabIndex = 2;
            this.btnEstoqueAdmin.Text = "ESTOQUE";
            this.btnEstoqueAdmin.UseVisualStyleBackColor = false;
            this.btnEstoqueAdmin.Click += new System.EventHandler(this.btnEstoqueAdmin_Click);
            // 
            // btnPedidosAdmin
            // 
            this.btnPedidosAdmin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPedidosAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidosAdmin.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.btnPedidosAdmin.Location = new System.Drawing.Point(331, 185);
            this.btnPedidosAdmin.Name = "btnPedidosAdmin";
            this.btnPedidosAdmin.Size = new System.Drawing.Size(129, 64);
            this.btnPedidosAdmin.TabIndex = 3;
            this.btnPedidosAdmin.Text = "PEDIDOS";
            this.btnPedidosAdmin.UseVisualStyleBackColor = false;
            this.btnPedidosAdmin.Click += new System.EventHandler(this.btnPedidosAdmin_Click);
            // 
            // btnLogoutAdmin
            // 
            this.btnLogoutAdmin.BackColor = System.Drawing.Color.Red;
            this.btnLogoutAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutAdmin.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutAdmin.ForeColor = System.Drawing.Color.White;
            this.btnLogoutAdmin.Location = new System.Drawing.Point(331, 373);
            this.btnLogoutAdmin.Name = "btnLogoutAdmin";
            this.btnLogoutAdmin.Size = new System.Drawing.Size(129, 64);
            this.btnLogoutAdmin.TabIndex = 5;
            this.btnLogoutAdmin.Text = "LOGOUT";
            this.btnLogoutAdmin.UseVisualStyleBackColor = false;
            this.btnLogoutAdmin.Click += new System.EventHandler(this.btnLogoutAdmin_Click);
            // 
            // MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.btnLogoutAdmin);
            this.Controls.Add(this.btnPedidosAdmin);
            this.Controls.Add(this.btnEstoqueAdmin);
            this.Controls.Add(this.btnCadastroAdmin);
            this.Controls.Add(this.lblMenuAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAdministrador";
            this.Text = "Menu do Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuAdmin;
        private System.Windows.Forms.Button btnCadastroAdmin;
        private System.Windows.Forms.Button btnEstoqueAdmin;
        private System.Windows.Forms.Button btnPedidosAdmin;
        private System.Windows.Forms.Button btnLogoutAdmin;
    }
}