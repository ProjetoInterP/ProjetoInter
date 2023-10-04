namespace ProjetoInter
{
    partial class frmMenu_Admin
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
            this.btnLogoutAdmin = new System.Windows.Forms.Button();
            this.btnPedidosAdmin = new System.Windows.Forms.Button();
            this.btnCardápioAdmin = new System.Windows.Forms.Button();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.btnCadastroAdmin = new System.Windows.Forms.Button();
            this.btnEstoqueAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogoutAdmin
            // 
            this.btnLogoutAdmin.BackColor = System.Drawing.Color.Red;
            this.btnLogoutAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutAdmin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutAdmin.ForeColor = System.Drawing.Color.White;
            this.btnLogoutAdmin.Location = new System.Drawing.Point(344, 469);
            this.btnLogoutAdmin.Name = "btnLogoutAdmin";
            this.btnLogoutAdmin.Size = new System.Drawing.Size(195, 97);
            this.btnLogoutAdmin.TabIndex = 7;
            this.btnLogoutAdmin.Text = "LOGOUT";
            this.btnLogoutAdmin.UseVisualStyleBackColor = false;
            // 
            // btnPedidosAdmin
            // 
            this.btnPedidosAdmin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidosAdmin.Location = new System.Drawing.Point(543, 200);
            this.btnPedidosAdmin.Name = "btnPedidosAdmin";
            this.btnPedidosAdmin.Size = new System.Drawing.Size(195, 97);
            this.btnPedidosAdmin.TabIndex = 6;
            this.btnPedidosAdmin.Text = "Pedidos";
            this.btnPedidosAdmin.UseVisualStyleBackColor = true;
            // 
            // btnCardápioAdmin
            // 
            this.btnCardápioAdmin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardápioAdmin.Location = new System.Drawing.Point(156, 200);
            this.btnCardápioAdmin.Name = "btnCardápioAdmin";
            this.btnCardápioAdmin.Size = new System.Drawing.Size(195, 97);
            this.btnCardápioAdmin.TabIndex = 5;
            this.btnCardápioAdmin.Text = "Cardápio";
            this.btnCardápioAdmin.UseVisualStyleBackColor = true;
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAdministrador.Location = new System.Drawing.Point(281, 118);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(330, 33);
            this.lblAdministrador.TabIndex = 4;
            this.lblAdministrador.Text = "Menu do Administrador";
            // 
            // btnCadastroAdmin
            // 
            this.btnCadastroAdmin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroAdmin.Location = new System.Drawing.Point(156, 341);
            this.btnCadastroAdmin.Name = "btnCadastroAdmin";
            this.btnCadastroAdmin.Size = new System.Drawing.Size(195, 97);
            this.btnCadastroAdmin.TabIndex = 8;
            this.btnCadastroAdmin.Text = "Cadastro";
            this.btnCadastroAdmin.UseVisualStyleBackColor = true;
            // 
            // btnEstoqueAdmin
            // 
            this.btnEstoqueAdmin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueAdmin.Location = new System.Drawing.Point(543, 341);
            this.btnEstoqueAdmin.Name = "btnEstoqueAdmin";
            this.btnEstoqueAdmin.Size = new System.Drawing.Size(195, 97);
            this.btnEstoqueAdmin.TabIndex = 9;
            this.btnEstoqueAdmin.Text = "Estoque";
            this.btnEstoqueAdmin.UseVisualStyleBackColor = true;
            // 
            // frmMenu_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(895, 674);
            this.Controls.Add(this.btnEstoqueAdmin);
            this.Controls.Add(this.btnCadastroAdmin);
            this.Controls.Add(this.btnLogoutAdmin);
            this.Controls.Add(this.btnPedidosAdmin);
            this.Controls.Add(this.btnCardápioAdmin);
            this.Controls.Add(this.lblAdministrador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu_Admin";
            this.Text = "Menu do Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogoutAdmin;
        private System.Windows.Forms.Button btnPedidosAdmin;
        private System.Windows.Forms.Button btnCardápioAdmin;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Button btnCadastroAdmin;
        private System.Windows.Forms.Button btnEstoqueAdmin;
    }
}