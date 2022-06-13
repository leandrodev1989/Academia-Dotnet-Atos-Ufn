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
            this.btnentrada = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.textBox_listaVeiculosEntrada = new System.Windows.Forms.TextBox();
            this.textBox_listaveiculosSaida = new System.Windows.Forms.TextBox();
            this.labelplaca = new System.Windows.Forms.Label();
            this.labeldatahora = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnlistarsaisa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsaida = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label_horasaida = new System.Windows.Forms.Label();
            this.tbhoraentrada = new System.Windows.Forms.TextBox();
            this.tbhorasaida = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbplacasaida = new System.Windows.Forms.TextBox();
            this.label_placasaida = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(280, -9);
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
            this.btnFechar.Location = new System.Drawing.Point(865, 64);
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
            this.panel1.Size = new System.Drawing.Size(928, 55);
            this.panel1.TabIndex = 3;
            // 
            // lbplaca
            // 
            this.lbplaca.AutoSize = true;
            this.lbplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbplaca.Location = new System.Drawing.Point(32, 70);
            this.lbplaca.Name = "lbplaca";
            this.lbplaca.Size = new System.Drawing.Size(212, 20);
            this.lbplaca.TabIndex = 4;
            this.lbplaca.Text = "Digite a Placa Do Veiculo";
            // 
            // tbplaca
            // 
            this.tbplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbplaca.Location = new System.Drawing.Point(247, 72);
            this.tbplaca.Multiline = true;
            this.tbplaca.Name = "tbplaca";
            this.tbplaca.Size = new System.Drawing.Size(120, 27);
            this.tbplaca.TabIndex = 0;
            // 
            // btnentrada
            // 
            this.btnentrada.BackColor = System.Drawing.Color.Navy;
            this.btnentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrada.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnentrada.Location = new System.Drawing.Point(247, 223);
            this.btnentrada.Name = "btnentrada";
            this.btnentrada.Size = new System.Drawing.Size(120, 40);
            this.btnentrada.TabIndex = 3;
            this.btnentrada.Text = "ENTRADA";
            this.btnentrada.UseVisualStyleBackColor = false;
            this.btnentrada.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Navy;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlimpar.Location = new System.Drawing.Point(417, 223);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(112, 40);
            this.btnlimpar.TabIndex = 9;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // textBox_listaVeiculosEntrada
            // 
            this.textBox_listaVeiculosEntrada.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_listaVeiculosEntrada.Enabled = false;
            this.textBox_listaVeiculosEntrada.Location = new System.Drawing.Point(27, 304);
            this.textBox_listaVeiculosEntrada.Multiline = true;
            this.textBox_listaVeiculosEntrada.Name = "textBox_listaVeiculosEntrada";
            this.textBox_listaVeiculosEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listaVeiculosEntrada.Size = new System.Drawing.Size(342, 249);
            this.textBox_listaVeiculosEntrada.TabIndex = 10;
            // 
            // textBox_listaveiculosSaida
            // 
            this.textBox_listaveiculosSaida.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_listaveiculosSaida.Enabled = false;
            this.textBox_listaveiculosSaida.Location = new System.Drawing.Point(417, 304);
            this.textBox_listaveiculosSaida.Multiline = true;
            this.textBox_listaveiculosSaida.Name = "textBox_listaveiculosSaida";
            this.textBox_listaveiculosSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listaveiculosSaida.Size = new System.Drawing.Size(501, 249);
            this.textBox_listaveiculosSaida.TabIndex = 11;
            // 
            // labelplaca
            // 
            this.labelplaca.AutoSize = true;
            this.labelplaca.BackColor = System.Drawing.Color.Navy;
            this.labelplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelplaca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelplaca.Location = new System.Drawing.Point(33, 285);
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
            this.labeldatahora.Location = new System.Drawing.Point(94, 285);
            this.labeldatahora.Name = "labeldatahora";
            this.labeldatahora.Size = new System.Drawing.Size(126, 16);
            this.labeldatahora.TabIndex = 13;
            this.labeldatahora.Text = "DATA-ENTRADA";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(36, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Listar Entrada";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonListarEntrada_Click);
            // 
            // btnlistarsaisa
            // 
            this.btnlistarsaisa.BackColor = System.Drawing.Color.Navy;
            this.btnlistarsaisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistarsaisa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlistarsaisa.Location = new System.Drawing.Point(754, 223);
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
            this.label2.Location = new System.Drawing.Point(418, 285);
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
            this.label3.Location = new System.Drawing.Point(791, 285);
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
            this.label4.Location = new System.Drawing.Point(583, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "HORA-SAIDA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Navy;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(479, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "DATA-SAIDA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Navy;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(689, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "TP-PERMAN\r\n";
            // 
            // btnsaida
            // 
            this.btnsaida.BackColor = System.Drawing.Color.Navy;
            this.btnsaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsaida.Location = new System.Drawing.Point(635, 223);
            this.btnsaida.Name = "btnsaida";
            this.btnsaida.Size = new System.Drawing.Size(112, 40);
            this.btnsaida.TabIndex = 21;
            this.btnsaida.Text = "SAIDA";
            this.btnsaida.UseVisualStyleBackColor = false;
            this.btnsaida.Click += new System.EventHandler(this.btnsaida_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Navy;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(226, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "HORA-ENTRADA";
            // 
            // label_horasaida
            // 
            this.label_horasaida.AutoSize = true;
            this.label_horasaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_horasaida.Location = new System.Drawing.Point(32, 114);
            this.label_horasaida.Name = "label_horasaida";
            this.label_horasaida.Size = new System.Drawing.Size(209, 20);
            this.label_horasaida.TabIndex = 24;
            this.label_horasaida.Text = "Digite a Hora de Entrada";
            // 
            // tbhoraentrada
            // 
            this.tbhoraentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbhoraentrada.Location = new System.Drawing.Point(247, 110);
            this.tbhoraentrada.Multiline = true;
            this.tbhoraentrada.Name = "tbhoraentrada";
            this.tbhoraentrada.Size = new System.Drawing.Size(120, 27);
            this.tbhoraentrada.TabIndex = 1;
            // 
            // tbhorasaida
            // 
            this.tbhorasaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbhorasaida.Location = new System.Drawing.Point(635, 107);
            this.tbhorasaida.Multiline = true;
            this.tbhorasaida.Name = "tbhorasaida";
            this.tbhorasaida.Size = new System.Drawing.Size(120, 27);
            this.tbhorasaida.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(417, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Digite a Hora de Saida";
            // 
            // tbplacasaida
            // 
            this.tbplacasaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbplacasaida.Location = new System.Drawing.Point(635, 70);
            this.tbplacasaida.Multiline = true;
            this.tbplacasaida.Name = "tbplacasaida";
            this.tbplacasaida.Size = new System.Drawing.Size(120, 27);
            this.tbplacasaida.TabIndex = 29;
            // 
            // label_placasaida
            // 
            this.label_placasaida.AutoSize = true;
            this.label_placasaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_placasaida.Location = new System.Drawing.Point(417, 72);
            this.label_placasaida.Name = "label_placasaida";
            this.label_placasaida.Size = new System.Drawing.Size(212, 20);
            this.label_placasaida.TabIndex = 28;
            this.label_placasaida.Text = "Digite a Placa Do Veiculo";
            // 
            // FrmCadastroVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(920, 565);
            this.Controls.Add(this.tbhorasaida);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbplacasaida);
            this.Controls.Add(this.label_placasaida);
            this.Controls.Add(this.tbhoraentrada);
            this.Controls.Add(this.label_horasaida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnsaida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlistarsaisa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labeldatahora);
            this.Controls.Add(this.labelplaca);
            this.Controls.Add(this.textBox_listaveiculosSaida);
            this.Controls.Add(this.textBox_listaVeiculosEntrada);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnentrada);
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
        private System.Windows.Forms.Button btnentrada;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.TextBox textBox_listaVeiculosEntrada;
        private System.Windows.Forms.TextBox textBox_listaveiculosSaida;
        private System.Windows.Forms.Label labelplaca;
        private System.Windows.Forms.Label labeldatahora;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnlistarsaisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsaida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_horasaida;
        private System.Windows.Forms.TextBox tbhoraentrada;
        private System.Windows.Forms.TextBox tbhorasaida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbplacasaida;
        private System.Windows.Forms.Label label_placasaida;
    }
}