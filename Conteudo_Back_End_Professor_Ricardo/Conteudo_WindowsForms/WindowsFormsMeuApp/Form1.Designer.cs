namespace WindowsFormsMeuApp
{
    partial class FormCadastro
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
            this.BTok = new System.Windows.Forms.Button();
            this.BTCancelar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTok
            // 
            this.BTok.Location = new System.Drawing.Point(83, 312);
            this.BTok.Name = "BTok";
            this.BTok.Size = new System.Drawing.Size(152, 77);
            this.BTok.TabIndex = 10;
            this.BTok.Text = "Ok";
            this.BTok.UseVisualStyleBackColor = true;
            this.BTok.Click += new System.EventHandler(this.BTok_Click);
            // 
            // BTCancelar
            // 
            this.BTCancelar.Location = new System.Drawing.Point(345, 309);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(145, 80);
            this.BTCancelar.TabIndex = 12;
            this.BTCancelar.Text = "Cancelar";
            this.BTCancelar.UseVisualStyleBackColor = true;
            this.BTCancelar.Click += new System.EventHandler(this.BTCancelar_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(45, 23);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(83, 20);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(407, 20);
            this.tbNome.TabIndex = 0;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(45, 62);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(83, 59);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(407, 20);
            this.tbEmail.TabIndex = 1;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(28, 101);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(53, 13);
            this.labelEndereco.TabIndex = 6;
            this.labelEndereco.Text = "Endereço";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(83, 179);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(407, 20);
            this.tbEndereco.TabIndex = 4;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(43, 144);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(34, 13);
            this.labelBairro.TabIndex = 8;
            this.labelBairro.Text = "Bairro";
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(83, 215);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(407, 20);
            this.tbBairro.TabIndex = 5;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(37, 179);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(40, 13);
            this.labelCidade.TabIndex = 10;
            this.labelCidade.Text = "Cidade";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(83, 141);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(407, 20);
            this.tbCidade.TabIndex = 3;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(28, 222);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(49, 13);
            this.labelTelefone.TabIndex = 12;
            this.labelTelefone.Text = "Telefone";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(83, 98);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(407, 20);
            this.tbTelefone.TabIndex = 2;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.BTCancelar);
            this.Controls.Add(this.BTok);
            this.Name = "FormCadastro";
            this.Text = "AppCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTok;
        private System.Windows.Forms.Button BTCancelar;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox tbTelefone;
    }
}

