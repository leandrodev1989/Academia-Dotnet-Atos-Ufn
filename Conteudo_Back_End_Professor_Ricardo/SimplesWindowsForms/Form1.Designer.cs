namespace SimplesWindowsForms
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
            this.textBoxnome = new System.Windows.Forms.TextBox();
            this.textBoxbairro = new System.Windows.Forms.TextBox();
            this.textBoxidade = new System.Windows.Forms.TextBox();
            this.textBoxcidade = new System.Windows.Forms.TextBox();
            this.textBoxcpf = new System.Windows.Forms.TextBox();
            this.textBoxendereco = new System.Windows.Forms.TextBox();
            this.textBoxcep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxnome
            // 
            this.textBoxnome.Location = new System.Drawing.Point(81, 35);
            this.textBoxnome.Name = "textBoxnome";
            this.textBoxnome.Size = new System.Drawing.Size(231, 20);
            this.textBoxnome.TabIndex = 0;
            // 
            // textBoxbairro
            // 
            this.textBoxbairro.Location = new System.Drawing.Point(80, 185);
            this.textBoxbairro.Name = "textBoxbairro";
            this.textBoxbairro.Size = new System.Drawing.Size(232, 20);
            this.textBoxbairro.TabIndex = 4;
            // 
            // textBoxidade
            // 
            this.textBoxidade.Location = new System.Drawing.Point(81, 72);
            this.textBoxidade.Name = "textBoxidade";
            this.textBoxidade.Size = new System.Drawing.Size(231, 20);
            this.textBoxidade.TabIndex = 1;
            // 
            // textBoxcidade
            // 
            this.textBoxcidade.Location = new System.Drawing.Point(81, 266);
            this.textBoxcidade.Name = "textBoxcidade";
            this.textBoxcidade.Size = new System.Drawing.Size(231, 20);
            this.textBoxcidade.TabIndex = 6;
            // 
            // textBoxcpf
            // 
            this.textBoxcpf.Location = new System.Drawing.Point(81, 111);
            this.textBoxcpf.Name = "textBoxcpf";
            this.textBoxcpf.Size = new System.Drawing.Size(231, 20);
            this.textBoxcpf.TabIndex = 2;
            // 
            // textBoxendereco
            // 
            this.textBoxendereco.Location = new System.Drawing.Point(81, 148);
            this.textBoxendereco.Name = "textBoxendereco";
            this.textBoxendereco.Size = new System.Drawing.Size(231, 20);
            this.textBoxendereco.TabIndex = 3;
            // 
            // textBoxcep
            // 
            this.textBoxcep.Location = new System.Drawing.Point(81, 227);
            this.textBoxcep.Name = "textBoxcep";
            this.textBoxcep.Size = new System.Drawing.Size(231, 20);
            this.textBoxcep.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cpf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cep";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cidade";
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(208, 310);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(104, 39);
            this.btnsalvar.TabIndex = 7;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 364);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxcep);
            this.Controls.Add(this.textBoxendereco);
            this.Controls.Add(this.textBoxcpf);
            this.Controls.Add(this.textBoxcidade);
            this.Controls.Add(this.textBoxidade);
            this.Controls.Add(this.textBoxbairro);
            this.Controls.Add(this.textBoxnome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxnome;
        private System.Windows.Forms.TextBox textBoxbairro;
        private System.Windows.Forms.TextBox textBoxidade;
        private System.Windows.Forms.TextBox textBoxcidade;
        private System.Windows.Forms.TextBox textBoxcpf;
        private System.Windows.Forms.TextBox textBoxendereco;
        private System.Windows.Forms.TextBox textBoxcep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnsalvar;
    }
}

