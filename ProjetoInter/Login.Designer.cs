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
            this.components = new System.ComponentModel.Container();
            this.InputLogin = new System.Windows.Forms.TextBox();
            this.InputSenha = new System.Windows.Forms.TextBox();
            this.Funcao = new System.Windows.Forms.ComboBox();
            this.btnValidaAcesso = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputLogin
            // 
            this.InputLogin.BackColor = System.Drawing.Color.White;
            this.InputLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.InputLogin.Location = new System.Drawing.Point(284, 171);
            this.InputLogin.Multiline = true;
            this.InputLogin.Name = "InputLogin";
            this.InputLogin.Size = new System.Drawing.Size(174, 20);
            this.InputLogin.TabIndex = 0;
            this.InputLogin.TextChanged += new System.EventHandler(this.InputLogin_TextChanged);
            // 
            // InputSenha
            // 
            this.InputSenha.BackColor = System.Drawing.SystemColors.Window;
            this.InputSenha.Location = new System.Drawing.Point(284, 246);
            this.InputSenha.Name = "InputSenha";
            this.InputSenha.Size = new System.Drawing.Size(171, 20);
            this.InputSenha.TabIndex = 2;
            this.InputSenha.TextChanged += new System.EventHandler(this.InputSenha_TextChanged);
            // 
            // Funcao
            // 
            this.Funcao.BackColor = System.Drawing.Color.Azure;
            this.Funcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Funcao.FormattingEnabled = true;
            this.Funcao.Items.AddRange(new object[] {
            "Admnistrador",
            "Funcionário"});
            this.Funcao.Location = new System.Drawing.Point(284, 287);
            this.Funcao.Name = "Funcao";
            this.Funcao.Size = new System.Drawing.Size(171, 21);
            this.Funcao.TabIndex = 5;
            this.Funcao.Text = "Selecione sua função";
            // 
            // btnValidaAcesso
            // 
            this.btnValidaAcesso.BackColor = System.Drawing.Color.SeaGreen;
            this.btnValidaAcesso.Location = new System.Drawing.Point(330, 339);
            this.btnValidaAcesso.Name = "btnValidaAcesso";
            this.btnValidaAcesso.Size = new System.Drawing.Size(75, 23);
            this.btnValidaAcesso.TabIndex = 6;
            this.btnValidaAcesso.Text = "Entrar";
            this.btnValidaAcesso.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(12, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Central de atendimento xxx-xxxx";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(304, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sing in to Bella Napoli ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(283, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username or email address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(284, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(710, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnValidaAcesso);
            this.Controls.Add(this.Funcao);
            this.Controls.Add(this.InputSenha);
            this.Controls.Add(this.InputLogin);
            this.Name = "frmLogin";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputLogin;
        private System.Windows.Forms.TextBox InputSenha;
        private System.Windows.Forms.ComboBox Funcao;
        private System.Windows.Forms.Button btnValidaAcesso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}