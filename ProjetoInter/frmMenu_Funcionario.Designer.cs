namespace ProjetoInter
{
    partial class frmMenu_Funcionario
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
            this.btnCardápioFunc = new System.Windows.Forms.Button();
            this.btnPedidosFunc = new System.Windows.Forms.Button();
            this.btnLogoutFunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFuncionario.Location = new System.Drawing.Point(293, 71);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(315, 33);
            this.lblFuncionario.TabIndex = 0;
            this.lblFuncionario.Text = "Menu de Funcionarios";
            // 
            // btnCardápioFunc
            // 
            this.btnCardápioFunc.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardápioFunc.Location = new System.Drawing.Point(157, 216);
            this.btnCardápioFunc.Name = "btnCardápioFunc";
            this.btnCardápioFunc.Size = new System.Drawing.Size(195, 97);
            this.btnCardápioFunc.TabIndex = 1;
            this.btnCardápioFunc.Text = "Cardápio";
            this.btnCardápioFunc.UseVisualStyleBackColor = true;
            this.btnCardápioFunc.Click += new System.EventHandler(this.btnCardápioFunc_Click);
            // 
            // btnPedidosFunc
            // 
            this.btnPedidosFunc.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidosFunc.Location = new System.Drawing.Point(542, 216);
            this.btnPedidosFunc.Name = "btnPedidosFunc";
            this.btnPedidosFunc.Size = new System.Drawing.Size(195, 97);
            this.btnPedidosFunc.TabIndex = 2;
            this.btnPedidosFunc.Text = "Pedidos";
            this.btnPedidosFunc.UseVisualStyleBackColor = true;
            this.btnPedidosFunc.Click += new System.EventHandler(this.btnPedidosFunc_Click);
            // 
            // btnLogoutFunc
            // 
            this.btnLogoutFunc.BackColor = System.Drawing.Color.Red;
            this.btnLogoutFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutFunc.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutFunc.ForeColor = System.Drawing.Color.White;
            this.btnLogoutFunc.Location = new System.Drawing.Point(345, 431);
            this.btnLogoutFunc.Name = "btnLogoutFunc";
            this.btnLogoutFunc.Size = new System.Drawing.Size(195, 97);
            this.btnLogoutFunc.TabIndex = 3;
            this.btnLogoutFunc.Text = "LOGOUT";
            this.btnLogoutFunc.UseVisualStyleBackColor = false;
            this.btnLogoutFunc.Click += new System.EventHandler(this.btnLogoutFunc_Click);
            // 
            // frmMenu_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(895, 674);
            this.Controls.Add(this.btnLogoutFunc);
            this.Controls.Add(this.btnPedidosFunc);
            this.Controls.Add(this.btnCardápioFunc);
            this.Controls.Add(this.lblFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu_Funcionario";
            this.Text = "Menu de Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Button btnCardápioFunc;
        private System.Windows.Forms.Button btnPedidosFunc;
        private System.Windows.Forms.Button btnLogoutFunc;
    }
}