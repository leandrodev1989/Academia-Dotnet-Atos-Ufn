namespace Garagemteste
{
    partial class FrmCadastroVeiculos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbplaca = new System.Windows.Forms.Label();
            this.tbplaca = new System.Windows.Forms.TextBox();
            this.lbopcional = new System.Windows.Forms.Label();
            this.cbopcional = new System.Windows.Forms.ComboBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.tbentrada = new System.Windows.Forms.TextBox();
            this.tbsaida = new System.Windows.Forms.TextBox();
            this.labelplaca = new System.Windows.Forms.Label();
            this.labeldatahora = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnlistarsaisa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(246, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro De Veiculos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Navy;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Transparent;
            this.btnFechar.Location = new System.Drawing.Point(796, 517);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(53, 36);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Voltar ";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 83);
            this.panel1.TabIndex = 3;
            // 
            // lbplaca
            // 
            this.lbplaca.AutoSize = true;
            this.lbplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbplaca.Location = new System.Drawing.Point(87, 134);
            this.lbplaca.Name = "lbplaca";
            this.lbplaca.Size = new System.Drawing.Size(212, 20);
            this.lbplaca.TabIndex = 4;
            this.lbplaca.Text = "Digite a Placa Do Veiculo";
            // 
            // tbplaca
            // 
            this.tbplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbplaca.Location = new System.Drawing.Point(322, 136);
            this.tbplaca.Multiline = true;
            this.tbplaca.Name = "tbplaca";
            this.tbplaca.Size = new System.Drawing.Size(164, 27);
            this.tbplaca.TabIndex = 5;
            // 
            // lbopcional
            // 
            this.lbopcional.AutoSize = true;
            this.lbopcional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbopcional.Location = new System.Drawing.Point(32, 100);
            this.lbopcional.Name = "lbopcional";
            this.lbopcional.Size = new System.Drawing.Size(276, 20);
            this.lbopcional.TabIndex = 6;
            this.lbopcional.Text = "Qual Operação Deseja Executar?";
            // 
            // cbopcional
            // 
            this.cbopcional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopcional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbopcional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbopcional.FormattingEnabled = true;
            this.cbopcional.Items.AddRange(new object[] {
            "ENTRADA",
            "SAIDA"});
            this.cbopcional.Location = new System.Drawing.Point(322, 99);
            this.cbopcional.Name = "cbopcional";
            this.cbopcional.Size = new System.Drawing.Size(164, 21);
            this.cbopcional.TabIndex = 7;
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.Navy;
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncadastrar.Location = new System.Drawing.Point(249, 191);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(112, 40);
            this.btncadastrar.TabIndex = 8;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Navy;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlimpar.Location = new System.Drawing.Point(374, 191);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(112, 40);
            this.btnlimpar.TabIndex = 9;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // tbentrada
            // 
            this.tbentrada.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbentrada.Enabled = false;
            this.tbentrada.Location = new System.Drawing.Point(27, 268);
            this.tbentrada.Multiline = true;
            this.tbentrada.Name = "tbentrada";
            this.tbentrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbentrada.Size = new System.Drawing.Size(252, 285);
            this.tbentrada.TabIndex = 10;
            // 
            // tbsaida
            // 
            this.tbsaida.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbsaida.Enabled = false;
            this.tbsaida.Location = new System.Drawing.Point(452, 268);
            this.tbsaida.Multiline = true;
            this.tbsaida.Name = "tbsaida";
            this.tbsaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbsaida.Size = new System.Drawing.Size(338, 285);
            this.tbsaida.TabIndex = 11;
            // 
            // labelplaca
            // 
            this.labelplaca.AutoSize = true;
            this.labelplaca.BackColor = System.Drawing.Color.Navy;
            this.labelplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelplaca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelplaca.Location = new System.Drawing.Point(33, 249);
            this.labelplaca.Name = "labelplaca";
            this.labelplaca.Size = new System.Drawing.Size(55, 16);
            this.labelplaca.TabIndex = 12;
            this.labelplaca.Text = "PLACA";
            // 
            // labeldatahora
            // 
            this.labeldatahora.AutoSize = true;
            this.labeldatahora.BackColor = System.Drawing.Color.Navy;
            this.labeldatahora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldatahora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labeldatahora.Location = new System.Drawing.Point(105, 249);
            this.labeldatahora.Name = "labeldatahora";
            this.labeldatahora.Size = new System.Drawing.Size(174, 16);
            this.labeldatahora.TabIndex = 13;
            this.labeldatahora.Text = "DATA-HORA-ENTRADA";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(27, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Listar Entrada";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlistarsaisa
            // 
            this.btnlistarsaisa.BackColor = System.Drawing.Color.Navy;
            this.btnlistarsaisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistarsaisa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlistarsaisa.Location = new System.Drawing.Point(607, 191);
            this.btnlistarsaisa.Name = "btnlistarsaisa";
            this.btnlistarsaisa.Size = new System.Drawing.Size(164, 40);
            this.btnlistarsaisa.TabIndex = 15;
            this.btnlistarsaisa.Text = "Listar Saida";
            this.btnlistarsaisa.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(458, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "PLACA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(644, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "VALOR A PAGAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Navy;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(532, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "QTD-HORAS";
            // 
            // FrmCadastroVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(860, 565);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlistarsaisa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labeldatahora);
            this.Controls.Add(this.labelplaca);
            this.Controls.Add(this.tbsaida);
            this.Controls.Add(this.tbentrada);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.cbopcional);
            this.Controls.Add(this.lbopcional);
            this.Controls.Add(this.tbplaca);
            this.Controls.Add(this.lbplaca);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmCadastroVeiculos";
            this.Text = "FrmCadastroVeiculos";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbplaca;
        private System.Windows.Forms.TextBox tbplaca;
        private System.Windows.Forms.Label lbopcional;
        private System.Windows.Forms.ComboBox cbopcional;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.TextBox tbentrada;
        private System.Windows.Forms.TextBox tbsaida;
        private System.Windows.Forms.Label labelplaca;
        private System.Windows.Forms.Label labeldatahora;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnlistarsaisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}