namespace ProjetoInter
{
    partial class MenuFuncionario
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
            this.lblMenuFuncionario = new System.Windows.Forms.Label();
            this.btnPedidoFuncionario = new System.Windows.Forms.Button();
            this.btnCardápioFuncionario = new System.Windows.Forms.Button();
            this.btnLogoutFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuFuncionario
            // 
            this.lblMenuFuncionario.AutoSize = true;
            this.lblMenuFuncionario.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuFuncionario.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMenuFuncionario.Location = new System.Drawing.Point(281, 55);
            this.lblMenuFuncionario.Name = "lblMenuFuncionario";
            this.lblMenuFuncionario.Size = new System.Drawing.Size(248, 31);
            this.lblMenuFuncionario.TabIndex = 0;
            this.lblMenuFuncionario.Text = "Menu de Funcionário ";
            // 
            // btnPedidoFuncionario
            // 
            this.btnPedidoFuncionario.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPedidoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidoFuncionario.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoFuncionario.Location = new System.Drawing.Point(129, 208);
            this.btnPedidoFuncionario.Name = "btnPedidoFuncionario";
            this.btnPedidoFuncionario.Size = new System.Drawing.Size(149, 82);
            this.btnPedidoFuncionario.TabIndex = 1;
            this.btnPedidoFuncionario.Text = "PEDIDO";
            this.btnPedidoFuncionario.UseVisualStyleBackColor = false;
            // 
            // btnCardápioFuncionario
            // 
            this.btnCardápioFuncionario.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCardápioFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCardápioFuncionario.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardápioFuncionario.Location = new System.Drawing.Point(522, 208);
            this.btnCardápioFuncionario.Name = "btnCardápioFuncionario";
            this.btnCardápioFuncionario.Size = new System.Drawing.Size(149, 82);
            this.btnCardápioFuncionario.TabIndex = 2;
            this.btnCardápioFuncionario.Text = "CARDÁPIO";
            this.btnCardápioFuncionario.UseVisualStyleBackColor = false;
            // 
            // btnLogoutFuncionario
            // 
            this.btnLogoutFuncionario.BackColor = System.Drawing.Color.Red;
            this.btnLogoutFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutFuncionario.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnLogoutFuncionario.Location = new System.Drawing.Point(323, 377);
            this.btnLogoutFuncionario.Name = "btnLogoutFuncionario";
            this.btnLogoutFuncionario.Size = new System.Drawing.Size(149, 82);
            this.btnLogoutFuncionario.TabIndex = 3;
            this.btnLogoutFuncionario.Text = "LOGOUT";
            this.btnLogoutFuncionario.UseVisualStyleBackColor = false;
            // 
            // MenuFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.btnLogoutFuncionario);
            this.Controls.Add(this.btnCardápioFuncionario);
            this.Controls.Add(this.btnPedidoFuncionario);
            this.Controls.Add(this.lblMenuFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuFuncionario";
            this.Text = "MenuFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuFuncionario;
        private System.Windows.Forms.Button btnPedidoFuncionario;
        private System.Windows.Forms.Button btnCardápioFuncionario;
        private System.Windows.Forms.Button btnLogoutFuncionario;
    }
}