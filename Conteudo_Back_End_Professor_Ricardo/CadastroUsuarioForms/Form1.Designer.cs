namespace CadastroUsuarioForms
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.SystemColors.Info, System.Drawing.SystemColors.InactiveCaption, new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_idusuario = new System.Windows.Forms.TextBox();
            this.textBox_nomecompleto = new System.Windows.Forms.TextBox();
            this.btnconectar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.list_usuario = new System.Windows.Forms.ListView();
            this.IdUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeCompleto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Completo";
            // 
            // textBox_idusuario
            // 
            this.textBox_idusuario.Location = new System.Drawing.Point(104, 189);
            this.textBox_idusuario.Name = "textBox_idusuario";
            this.textBox_idusuario.Size = new System.Drawing.Size(138, 20);
            this.textBox_idusuario.TabIndex = 3;
            // 
            // textBox_nomecompleto
            // 
            this.textBox_nomecompleto.Location = new System.Drawing.Point(104, 237);
            this.textBox_nomecompleto.Name = "textBox_nomecompleto";
            this.textBox_nomecompleto.Size = new System.Drawing.Size(138, 20);
            this.textBox_nomecompleto.TabIndex = 4;
            // 
            // btnconectar
            // 
            this.btnconectar.Location = new System.Drawing.Point(376, 323);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(100, 59);
            this.btnconectar.TabIndex = 6;
            this.btnconectar.Text = "Conectar";
            this.btnconectar.UseVisualStyleBackColor = true;
            this.btnconectar.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(142, 323);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 59);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(15, 323);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(100, 59);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // list_usuario
            // 
            this.list_usuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdUsuario,
            this.NomeCompleto,
            this.Email});
            this.list_usuario.HideSelection = false;
            this.list_usuario.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.list_usuario.Location = new System.Drawing.Point(12, 12);
            this.list_usuario.Name = "list_usuario";
            this.list_usuario.Size = new System.Drawing.Size(464, 155);
            this.list_usuario.TabIndex = 9;
            this.list_usuario.UseCompatibleStateImageBehavior = false;
            this.list_usuario.View = System.Windows.Forms.View.Details;
            // 
            // IdUsuario
            // 
            this.IdUsuario.Text = "IdUsuario";
            // 
            // NomeCompleto
            // 
            this.NomeCompleto.Text = "nomecompleto";
            this.NomeCompleto.Width = 200;
            // 
            // Email
            // 
            this.Email.Text = "email";
            this.Email.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.list_usuario);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnconectar);
            this.Controls.Add(this.textBox_nomecompleto);
            this.Controls.Add(this.textBox_idusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_idusuario;
        private System.Windows.Forms.TextBox textBox_nomecompleto;
        private System.Windows.Forms.Button btnconectar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ListView list_usuario;
        private System.Windows.Forms.ColumnHeader IdUsuario;
        private System.Windows.Forms.ColumnHeader NomeCompleto;
        private System.Windows.Forms.ColumnHeader Email;
    }
}

