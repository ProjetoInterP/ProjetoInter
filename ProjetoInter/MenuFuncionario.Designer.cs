﻿namespace ProjetoInter
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
            this.btnLogoutFuncionario = new System.Windows.Forms.Button();
            this.btnEstoqueFunc = new System.Windows.Forms.Button();
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
            this.btnPedidoFuncionario.Location = new System.Drawing.Point(147, 196);
            this.btnPedidoFuncionario.Name = "btnPedidoFuncionario";
            this.btnPedidoFuncionario.Size = new System.Drawing.Size(149, 82);
            this.btnPedidoFuncionario.TabIndex = 1;
            this.btnPedidoFuncionario.Text = "PEDIDO";
            this.btnPedidoFuncionario.UseVisualStyleBackColor = false;
            this.btnPedidoFuncionario.Click += new System.EventHandler(this.btnPedidoFuncionario_Click);
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
            this.btnLogoutFuncionario.Click += new System.EventHandler(this.btnLogoutFuncionario_Click);
            // 
            // btnEstoqueFunc
            // 
            this.btnEstoqueFunc.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEstoqueFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoqueFunc.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueFunc.Location = new System.Drawing.Point(511, 196);
            this.btnEstoqueFunc.Name = "btnEstoqueFunc";
            this.btnEstoqueFunc.Size = new System.Drawing.Size(149, 82);
            this.btnEstoqueFunc.TabIndex = 4;
            this.btnEstoqueFunc.Text = "ESTOQUE";
            this.btnEstoqueFunc.UseVisualStyleBackColor = false;
            this.btnEstoqueFunc.Click += new System.EventHandler(this.btnEstoqueFunc_Click);
            // 
            // MenuFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.btnEstoqueFunc);
            this.Controls.Add(this.btnLogoutFuncionario);
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
        private System.Windows.Forms.Button btnLogoutFuncionario;
        private System.Windows.Forms.Button btnEstoqueFunc;
    }
}