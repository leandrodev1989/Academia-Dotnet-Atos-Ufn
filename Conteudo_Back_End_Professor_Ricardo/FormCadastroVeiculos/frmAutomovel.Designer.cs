namespace FormCadastroVeiculos
{
    partial class frmAutomovel
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
            this.tbmodelocarro = new System.Windows.Forms.TextBox();
            this.lbmodelocarro = new System.Windows.Forms.Label();
            this.lbfabricante = new System.Windows.Forms.Label();
            this.tbfabricante = new System.Windows.Forms.TextBox();
            this.lblOpcionais = new System.Windows.Forms.Label();
            this.cbportas = new System.Windows.Forms.ComboBox();
            this.lbOpcionais = new System.Windows.Forms.CheckedListBox();
            this.lbportas = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgAutomovel = new System.Windows.Forms.DataGridView();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ac = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.abs = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ve = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ab = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.portas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btncarregarlista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAutomovel)).BeginInit();
            this.SuspendLayout();
            // 
            // tbmodelocarro
            // 
            this.tbmodelocarro.Location = new System.Drawing.Point(103, 9);
            this.tbmodelocarro.Name = "tbmodelocarro";
            this.tbmodelocarro.Size = new System.Drawing.Size(121, 20);
            this.tbmodelocarro.TabIndex = 0;
            // 
            // lbmodelocarro
            // 
            this.lbmodelocarro.AutoSize = true;
            this.lbmodelocarro.Location = new System.Drawing.Point(12, 12);
            this.lbmodelocarro.Name = "lbmodelocarro";
            this.lbmodelocarro.Size = new System.Drawing.Size(85, 13);
            this.lbmodelocarro.TabIndex = 1;
            this.lbmodelocarro.Text = "Modelo do Carro";
            // 
            // lbfabricante
            // 
            this.lbfabricante.AutoSize = true;
            this.lbfabricante.Location = new System.Drawing.Point(12, 59);
            this.lbfabricante.Name = "lbfabricante";
            this.lbfabricante.Size = new System.Drawing.Size(85, 13);
            this.lbfabricante.TabIndex = 2;
            this.lbfabricante.Text = "Fabricante Carro";
            // 
            // tbfabricante
            // 
            this.tbfabricante.Location = new System.Drawing.Point(103, 56);
            this.tbfabricante.Name = "tbfabricante";
            this.tbfabricante.Size = new System.Drawing.Size(121, 20);
            this.tbfabricante.TabIndex = 3;
            // 
            // lblOpcionais
            // 
            this.lblOpcionais.AutoSize = true;
            this.lblOpcionais.Location = new System.Drawing.Point(12, 118);
            this.lblOpcionais.Name = "lblOpcionais";
            this.lblOpcionais.Size = new System.Drawing.Size(54, 13);
            this.lblOpcionais.TabIndex = 5;
            this.lblOpcionais.Text = "Opcionais";
            // 
            // cbportas
            // 
            this.cbportas.FormattingEnabled = true;
            this.cbportas.Items.AddRange(new object[] {
            "2 portas",
            "3 portas",
            "4 portas",
            "5 portas"});
            this.cbportas.Location = new System.Drawing.Point(104, 232);
            this.cbportas.Name = "cbportas";
            this.cbportas.Size = new System.Drawing.Size(120, 21);
            this.cbportas.TabIndex = 6;
            // 
            // lbOpcionais
            // 
            this.lbOpcionais.FormattingEnabled = true;
            this.lbOpcionais.Items.AddRange(new object[] {
            "Ar Condicionado",
            "Direção Hidraulica",
            "Freio Abs",
            "Air Bag",
            "Vidros Elétricos"});
            this.lbOpcionais.Location = new System.Drawing.Point(103, 118);
            this.lbOpcionais.Name = "lbOpcionais";
            this.lbOpcionais.Size = new System.Drawing.Size(120, 94);
            this.lbOpcionais.TabIndex = 7;
            // 
            // lbportas
            // 
            this.lbportas.AutoSize = true;
            this.lbportas.Location = new System.Drawing.Point(12, 232);
            this.lbportas.Name = "lbportas";
            this.lbportas.Size = new System.Drawing.Size(54, 13);
            this.lbportas.TabIndex = 8;
            this.lbportas.Text = "QtdPortas";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(10, 324);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 47);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(137, 324);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 47);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgAutomovel
            // 
            this.dgAutomovel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAutomovel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelo,
            this.fabricante,
            this.ac,
            this.dh,
            this.abs,
            this.ve,
            this.ab,
            this.portas});
            this.dgAutomovel.Location = new System.Drawing.Point(230, 12);
            this.dgAutomovel.Name = "dgAutomovel";
            this.dgAutomovel.Size = new System.Drawing.Size(737, 359);
            this.dgAutomovel.TabIndex = 11;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            // 
            // fabricante
            // 
            this.fabricante.HeaderText = "Fabricante";
            this.fabricante.Name = "fabricante";
            this.fabricante.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ac
            // 
            this.ac.HeaderText = "AC";
            this.ac.Name = "ac";
            this.ac.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ac.Width = 25;
            // 
            // dh
            // 
            this.dh.HeaderText = "DH";
            this.dh.Name = "dh";
            this.dh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // abs
            // 
            this.abs.HeaderText = "ABS";
            this.abs.Name = "abs";
            this.abs.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.abs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ve
            // 
            this.ve.HeaderText = "VE";
            this.ve.Name = "ve";
            this.ve.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ve.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ab
            // 
            this.ab.HeaderText = "AB";
            this.ab.Name = "ab";
            this.ab.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ab.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // portas
            // 
            this.portas.HeaderText = "PORTAS";
            this.portas.Name = "portas";
            this.portas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.portas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btncarregarlista
            // 
            this.btncarregarlista.Location = new System.Drawing.Point(34, 380);
            this.btncarregarlista.Name = "btncarregarlista";
            this.btncarregarlista.Size = new System.Drawing.Size(174, 40);
            this.btncarregarlista.TabIndex = 12;
            this.btncarregarlista.Text = "Carregar Lista";
            this.btncarregarlista.UseVisualStyleBackColor = true;
            this.btncarregarlista.Click += new System.EventHandler(this.btncarregarlista_Click);
            // 
            // frmAutomovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.btncarregarlista);
            this.Controls.Add(this.dgAutomovel);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbportas);
            this.Controls.Add(this.lbOpcionais);
            this.Controls.Add(this.cbportas);
            this.Controls.Add(this.lblOpcionais);
            this.Controls.Add(this.tbfabricante);
            this.Controls.Add(this.lbfabricante);
            this.Controls.Add(this.lbmodelocarro);
            this.Controls.Add(this.tbmodelocarro);
            this.Name = "frmAutomovel";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgAutomovel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbmodelocarro;
        private System.Windows.Forms.Label lbmodelocarro;
        private System.Windows.Forms.Label lbfabricante;
        private System.Windows.Forms.TextBox tbfabricante;
        private System.Windows.Forms.Label lblOpcionais;
        private System.Windows.Forms.ComboBox cbportas;
        private System.Windows.Forms.CheckedListBox lbOpcionais;
        private System.Windows.Forms.Label lbportas;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgAutomovel;
        private System.Windows.Forms.Button btncarregarlista;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricante;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ac;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn abs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ve;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ab;
        private System.Windows.Forms.DataGridViewCheckBoxColumn portas;
    }
}

