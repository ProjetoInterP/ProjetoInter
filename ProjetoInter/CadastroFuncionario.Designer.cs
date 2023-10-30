namespace ProjetoInter
{
    partial class frmCadFuncionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFuncionario));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblAcesso = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cmbAcesso = new System.Windows.Forms.ComboBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblconfirmaSenha = new System.Windows.Forms.Label();
            this.picVoltarCadastro = new System.Windows.Forms.PictureBox();
            this.picProcurarFuncionario = new System.Windows.Forms.PictureBox();
            this.btnLimpaTexto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltarCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProcurarFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.lblNome.Location = new System.Drawing.Point(221, 78);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(90, 29);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.lblUsuario.Location = new System.Drawing.Point(221, 155);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(110, 29);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.lblSenha.Location = new System.Drawing.Point(447, 155);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(94, 29);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // lblAcesso
            // 
            this.lblAcesso.AutoSize = true;
            this.lblAcesso.BackColor = System.Drawing.Color.Transparent;
            this.lblAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAcesso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.lblAcesso.Location = new System.Drawing.Point(223, 316);
            this.lblAcesso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcesso.Name = "lblAcesso";
            this.lblAcesso.Size = new System.Drawing.Size(201, 29);
            this.lblAcesso.TabIndex = 3;
            this.lblAcesso.Text = "Tipo de acesso:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNome.Location = new System.Drawing.Point(227, 110);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(425, 26);
            this.txtNome.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtUsuario.Location = new System.Drawing.Point(227, 188);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(208, 26);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSenha.Location = new System.Drawing.Point(452, 188);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(201, 26);
            this.txtSenha.TabIndex = 6;
            // 
            // cmbAcesso
            // 
            this.cmbAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbAcesso.FormattingEnabled = true;
            this.cmbAcesso.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário"});
            this.cmbAcesso.Location = new System.Drawing.Point(227, 348);
            this.cmbAcesso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAcesso.Name = "cmbAcesso";
            this.cmbAcesso.Size = new System.Drawing.Size(427, 28);
            this.cmbAcesso.TabIndex = 7;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.lblPesquisar.Location = new System.Drawing.Point(225, 383);
            this.lblPesquisar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(137, 29);
            this.lblPesquisar.TabIndex = 8;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(11)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.btnEditar.Location = new System.Drawing.Point(360, 694);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(129, 41);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Red;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.btnRemover.Location = new System.Drawing.Point(512, 694);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(129, 41);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFuncionarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvFuncionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFuncionarios.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFuncionarios.EnableHeadersVisualStyles = false;
            this.dgvFuncionarios.Location = new System.Drawing.Point(213, 457);
            this.dgvFuncionarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFuncionarios.MultiSelect = false;
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.RowHeadersVisible = false;
            this.dgvFuncionarios.RowHeadersWidth = 51;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(441, 214);
            this.dgvFuncionarios.TabIndex = 15;
            this.dgvFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellClick);
            this.dgvFuncionarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvFuncionarios_CellFormatting);
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNomeFuncionario.Location = new System.Drawing.Point(227, 416);
            this.txtNomeFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(313, 26);
            this.txtNomeFuncionario.TabIndex = 16;
            this.txtNomeFuncionario.TextChanged += new System.EventHandler(this.txtNomeFuncionario_TextChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Green;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(5)))));
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.btnAdicionar.Location = new System.Drawing.Point(208, 694);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(129, 41);
            this.btnAdicionar.TabIndex = 18;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtConfirmarSenha.Location = new System.Drawing.Point(233, 266);
            this.txtConfirmarSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(420, 26);
            this.txtConfirmarSenha.TabIndex = 20;
            // 
            // lblconfirmaSenha
            // 
            this.lblconfirmaSenha.AutoSize = true;
            this.lblconfirmaSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblconfirmaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblconfirmaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.lblconfirmaSenha.Location = new System.Drawing.Point(225, 233);
            this.lblconfirmaSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblconfirmaSenha.Name = "lblconfirmaSenha";
            this.lblconfirmaSenha.Size = new System.Drawing.Size(211, 29);
            this.lblconfirmaSenha.TabIndex = 19;
            this.lblconfirmaSenha.Text = "Confirmar senha:";
            // 
            // picVoltarCadastro
            // 
            this.picVoltarCadastro.BackColor = System.Drawing.Color.Transparent;
            this.picVoltarCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVoltarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("picVoltarCadastro.Image")));
            this.picVoltarCadastro.Location = new System.Drawing.Point(45, 14);
            this.picVoltarCadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picVoltarCadastro.Name = "picVoltarCadastro";
            this.picVoltarCadastro.Size = new System.Drawing.Size(51, 41);
            this.picVoltarCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVoltarCadastro.TabIndex = 32;
            this.picVoltarCadastro.TabStop = false;
            this.picVoltarCadastro.Click += new System.EventHandler(this.picVoltarCadastro_Click);
            // 
            // picProcurarFuncionario
            // 
            this.picProcurarFuncionario.Image = global::ProjetoInter.Properties.Resources.procurar__1_;
            this.picProcurarFuncionario.Location = new System.Drawing.Point(555, 400);
            this.picProcurarFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picProcurarFuncionario.Name = "picProcurarFuncionario";
            this.picProcurarFuncionario.Size = new System.Drawing.Size(51, 50);
            this.picProcurarFuncionario.TabIndex = 33;
            this.picProcurarFuncionario.TabStop = false;
            this.picProcurarFuncionario.Click += new System.EventHandler(this.picProcurarFuncionario_Click);
            // 
            // btnLimpaTexto
            // 
            this.btnLimpaTexto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpaTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpaTexto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaTexto.ForeColor = System.Drawing.Color.White;
            this.btnLimpaTexto.Location = new System.Drawing.Point(579, 68);
            this.btnLimpaTexto.Name = "btnLimpaTexto";
            this.btnLimpaTexto.Size = new System.Drawing.Size(75, 35);
            this.btnLimpaTexto.TabIndex = 34;
            this.btnLimpaTexto.Text = "Limpar";
            this.btnLimpaTexto.UseVisualStyleBackColor = false;
            this.btnLimpaTexto.Click += new System.EventHandler(this.btnLimpaTexto_Click);
            // 
            // frmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 750);
            this.Controls.Add(this.btnLimpaTexto);
            this.Controls.Add(this.picProcurarFuncionario);
            this.Controls.Add(this.picVoltarCadastro);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.lblconfirmaSenha);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.cmbAcesso);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblAcesso);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCadFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Funcionario";
            this.Load += new System.EventHandler(this.frmCadFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltarCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProcurarFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblAcesso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ComboBox cmbAcesso;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label lblconfirmaSenha;
        private System.Windows.Forms.PictureBox picVoltarCadastro;
        private System.Windows.Forms.PictureBox picProcurarFuncionario;
        private System.Windows.Forms.Button btnLimpaTexto;
    }
}