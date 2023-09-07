namespace ProjetoInter
{
    partial class frmLogin
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
            this.InputLogin = new System.Windows.Forms.TextBox();
            this.InputSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Funcao = new System.Windows.Forms.ComboBox();
            this.btnValidaAcesso = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputLogin
            // 
            this.InputLogin.BackColor = System.Drawing.Color.AliceBlue;
            this.InputLogin.Location = new System.Drawing.Point(281, 141);
            this.InputLogin.Multiline = true;
            this.InputLogin.Name = "InputLogin";
            this.InputLogin.Size = new System.Drawing.Size(145, 20);
            this.InputLogin.TabIndex = 0;
            // 
            // InputSenha
            // 
            this.InputSenha.Location = new System.Drawing.Point(281, 196);
            this.InputSenha.Name = "InputSenha";
            this.InputSenha.Size = new System.Drawing.Size(145, 20);
            this.InputSenha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // Funcao
            // 
            this.Funcao.FormattingEnabled = true;
            this.Funcao.Items.AddRange(new object[] {
            "Admnistrador",
            "Funcionário"});
            this.Funcao.Location = new System.Drawing.Point(281, 236);
            this.Funcao.Name = "Funcao";
            this.Funcao.Size = new System.Drawing.Size(144, 21);
            this.Funcao.TabIndex = 5;
            this.Funcao.Text = "Selecione sua função";
            // 
            // btnValidaAcesso
            // 
            this.btnValidaAcesso.BackColor = System.Drawing.Color.DarkCyan;
            this.btnValidaAcesso.Location = new System.Drawing.Point(313, 281);
            this.btnValidaAcesso.Name = "btnValidaAcesso";
            this.btnValidaAcesso.Size = new System.Drawing.Size(75, 23);
            this.btnValidaAcesso.TabIndex = 6;
            this.btnValidaAcesso.Text = "Entrar";
            this.btnValidaAcesso.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(26, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Central de atendimento xxx-xxxx";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnValidaAcesso);
            this.Controls.Add(this.Funcao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputSenha);
            this.Controls.Add(this.InputLogin);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputLogin;
        private System.Windows.Forms.TextBox InputSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Funcao;
        private System.Windows.Forms.Button btnValidaAcesso;
        private System.Windows.Forms.Label label3;
    }
}