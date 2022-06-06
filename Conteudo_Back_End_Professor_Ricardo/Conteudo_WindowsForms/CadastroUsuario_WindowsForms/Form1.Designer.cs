namespace CadastroUsuario
{
    partial class Form1
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
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbTipos = new System.Windows.Forms.ComboBox();
            this.lbTiposUsuario = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.MaskedTextBox();
            this.tbtelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbCpf = new System.Windows.Forms.MaskedTextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNome.Location = new System.Drawing.Point(9, 19);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(44, 16);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNome.Location = new System.Drawing.Point(12, 38);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(274, 20);
            this.tbNome.TabIndex = 0;
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.Location = new System.Drawing.Point(12, 67);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(27, 16);
            this.lbCpf.TabIndex = 2;
            this.lbCpf.Text = "Cpf";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.Location = new System.Drawing.Point(174, 67);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(61, 16);
            this.lbTelefone.TabIndex = 5;
            this.lbTelefone.Text = "Telefone";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(12, 126);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(54, 16);
            this.lbUsuario.TabIndex = 6;
            this.lbUsuario.Text = "Usuario";
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbUsuario.Location = new System.Drawing.Point(15, 145);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(128, 20);
            this.tbUsuario.TabIndex = 3;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(174, 126);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(46, 16);
            this.lbSenha.TabIndex = 8;
            this.lbSenha.Text = "Senha";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(15, 269);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(132, 47);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar Usuário";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(174, 185);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(94, 16);
            this.lbStatus.TabIndex = 13;
            this.lbStatus.Text = "Status Usuário";
            // 
            // cbTipos
            // 
            this.cbTipos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbTipos.FormattingEnabled = true;
            this.cbTipos.Items.AddRange(new object[] {
            "Administrador",
            "Usuário"});
            this.cbTipos.Location = new System.Drawing.Point(12, 204);
            this.cbTipos.Name = "cbTipos";
            this.cbTipos.Size = new System.Drawing.Size(131, 21);
            this.cbTipos.TabIndex = 5;
            // 
            // lbTiposUsuario
            // 
            this.lbTiposUsuario.AutoSize = true;
            this.lbTiposUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiposUsuario.Location = new System.Drawing.Point(9, 185);
            this.lbTiposUsuario.Name = "lbTiposUsuario";
            this.lbTiposUsuario.Size = new System.Drawing.Size(92, 16);
            this.lbTiposUsuario.TabIndex = 16;
            this.lbTiposUsuario.Text = "Tipos Usuário";
            // 
            // tbSenha
            // 
            this.tbSenha.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSenha.Location = new System.Drawing.Point(177, 145);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(109, 20);
            this.tbSenha.TabIndex = 4;
            // 
            // tbtelefone
            // 
            this.tbtelefone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbtelefone.Location = new System.Drawing.Point(177, 86);
            this.tbtelefone.Mask = "(00)00000-0000";
            this.tbtelefone.Name = "tbtelefone";
            this.tbtelefone.Size = new System.Drawing.Size(109, 20);
            this.tbtelefone.TabIndex = 2;
            // 
            // tbCpf
            // 
            this.tbCpf.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbCpf.Location = new System.Drawing.Point(12, 86);
            this.tbCpf.Mask = "000000000-00";
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(128, 20);
            this.tbCpf.TabIndex = 1;
            this.tbCpf.ValidatingType = typeof(int);
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbStatus.Location = new System.Drawing.Point(177, 204);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(109, 21);
            this.cbStatus.TabIndex = 6;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLimpar.Location = new System.Drawing.Point(176, 269);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(109, 46);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.btnLimpar;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.tbtelefone);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.lbTiposUsuario);
            this.Controls.Add(this.cbTipos);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbNome);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Cadastro Usuário";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cbTipos;
        private System.Windows.Forms.Label lbTiposUsuario;
        private System.Windows.Forms.MaskedTextBox tbSenha;
        private System.Windows.Forms.MaskedTextBox tbtelefone;
        private System.Windows.Forms.MaskedTextBox tbCpf;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnLimpar;
    }
}

