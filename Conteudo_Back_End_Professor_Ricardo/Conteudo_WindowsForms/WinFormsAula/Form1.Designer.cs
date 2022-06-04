namespace WinFormsAula
{
    partial class FLimpar
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tbModeloCarro = new System.Windows.Forms.TextBox();
            this.labelModelodoCarro = new System.Windows.Forms.Label();
            this.labelFabricantedocarro = new System.Windows.Forms.Label();
            this.tbFabricante = new System.Windows.Forms.TextBox();
            this.lbOpcionais = new System.Windows.Forms.CheckedListBox();
            this.labelopcionais = new System.Windows.Forms.Label();
            this.cbPortas = new System.Windows.Forms.ComboBox();
            this.lbllPortas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(358, 376);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(185, 62);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(549, 376);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(185, 62);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tbModeloCarro
            // 
            this.tbModeloCarro.Location = new System.Drawing.Point(136, 16);
            this.tbModeloCarro.Name = "tbModeloCarro";
            this.tbModeloCarro.Size = new System.Drawing.Size(339, 20);
            this.tbModeloCarro.TabIndex = 2;
            this.tbModeloCarro.TextChanged += new System.EventHandler(this.textBoxModeloCarro_TextChanged);
            // 
            // labelModelodoCarro
            // 
            this.labelModelodoCarro.AutoSize = true;
            this.labelModelodoCarro.Location = new System.Drawing.Point(25, 19);
            this.labelModelodoCarro.Name = "labelModelodoCarro";
            this.labelModelodoCarro.Size = new System.Drawing.Size(85, 13);
            this.labelModelodoCarro.TabIndex = 3;
            this.labelModelodoCarro.Text = "Modelo do Carro";
            // 
            // labelFabricantedocarro
            // 
            this.labelFabricantedocarro.AutoSize = true;
            this.labelFabricantedocarro.Location = new System.Drawing.Point(25, 55);
            this.labelFabricantedocarro.Name = "labelFabricantedocarro";
            this.labelFabricantedocarro.Size = new System.Drawing.Size(99, 13);
            this.labelFabricantedocarro.TabIndex = 4;
            this.labelFabricantedocarro.Text = "Fabricante do carro";
            // 
            // tbFabricante
            // 
            this.tbFabricante.Location = new System.Drawing.Point(136, 55);
            this.tbFabricante.Name = "tbFabricante";
            this.tbFabricante.Size = new System.Drawing.Size(339, 20);
            this.tbFabricante.TabIndex = 5;
            // 
            // lbOpcionais
            // 
            this.lbOpcionais.FormattingEnabled = true;
            this.lbOpcionais.Items.AddRange(new object[] {
            "Ar Condicionado",
            "Direção hidráulica",
            "Freio ABS",
            "Air bag",
            "Vidros elétricos"});
            this.lbOpcionais.Location = new System.Drawing.Point(143, 107);
            this.lbOpcionais.Name = "lbOpcionais";
            this.lbOpcionais.Size = new System.Drawing.Size(332, 94);
            this.lbOpcionais.TabIndex = 6;
            // 
            // labelopcionais
            // 
            this.labelopcionais.AutoSize = true;
            this.labelopcionais.Location = new System.Drawing.Point(25, 107);
            this.labelopcionais.Name = "labelopcionais";
            this.labelopcionais.Size = new System.Drawing.Size(54, 13);
            this.labelopcionais.TabIndex = 7;
            this.labelopcionais.Text = "Opcionais";
            // 
            // cbPortas
            // 
            this.cbPortas.FormattingEnabled = true;
            this.cbPortas.Items.AddRange(new object[] {
            "2 Portas",
            "3 Portas",
            "4 Portas",
            "5 Portas"});
            this.cbPortas.Location = new System.Drawing.Point(139, 222);
            this.cbPortas.Name = "cbPortas";
            this.cbPortas.Size = new System.Drawing.Size(336, 21);
            this.cbPortas.TabIndex = 8;
            // 
            // lbllPortas
            // 
            this.lbllPortas.AutoSize = true;
            this.lbllPortas.Location = new System.Drawing.Point(24, 223);
            this.lbllPortas.Name = "lbllPortas";
            this.lbllPortas.Size = new System.Drawing.Size(56, 13);
            this.lbllPortas.TabIndex = 9;
            this.lbllPortas.Text = "Qtd portas";
            // 
            // FLimpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.lbllPortas);
            this.Controls.Add(this.cbPortas);
            this.Controls.Add(this.labelopcionais);
            this.Controls.Add(this.lbOpcionais);
            this.Controls.Add(this.tbFabricante);
            this.Controls.Add(this.labelFabricantedocarro);
            this.Controls.Add(this.labelModelodoCarro);
            this.Controls.Add(this.tbModeloCarro);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FLimpar";
            this.Text = "MeuApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox tbModeloCarro;
        private System.Windows.Forms.Label labelModelodoCarro;
        private System.Windows.Forms.Label labelFabricantedocarro;
        private System.Windows.Forms.TextBox tbFabricante;
        private System.Windows.Forms.CheckedListBox lbOpcionais;
        private System.Windows.Forms.Label labelopcionais;
        private System.Windows.Forms.ComboBox cbPortas;
        private System.Windows.Forms.Label lbllPortas;
    }
}

