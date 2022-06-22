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
            this.btnentrada = new System.Windows.Forms.Button();
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
            this.tbplaca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_valorporhora = new System.Windows.Forms.TextBox();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.tb_numerovagas = new System.Windows.Forms.TextBox();
            this.tbvalor = new System.Windows.Forms.TextBox();
            this.tbvagas = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbHora = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbhorasaida = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.btnFechar.Location = new System.Drawing.Point(806, 517);
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
            this.panel1.Size = new System.Drawing.Size(872, 55);
            this.panel1.TabIndex = 3;
            // 
            // lbplaca
            // 
            this.lbplaca.AutoSize = true;
            this.lbplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbplaca.Location = new System.Drawing.Point(26, 174);
            this.lbplaca.Name = "lbplaca";
            this.lbplaca.Size = new System.Drawing.Size(185, 16);
            this.lbplaca.TabIndex = 4;
            this.lbplaca.Text = "Digite a Placa Do Veiculo";
            // 
            // btnentrada
            // 
            this.btnentrada.BackColor = System.Drawing.Color.Navy;
            this.btnentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrada.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnentrada.Location = new System.Drawing.Point(250, 223);
            this.btnentrada.Name = "btnentrada";
            this.btnentrada.Size = new System.Drawing.Size(120, 40);
            this.btnentrada.TabIndex = 3;
            this.btnentrada.Text = "ENTRADA";
            this.btnentrada.UseVisualStyleBackColor = false;
            this.btnentrada.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // textBox_listaVeiculosEntrada
            // 
            this.textBox_listaVeiculosEntrada.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_listaVeiculosEntrada.Enabled = false;
            this.textBox_listaVeiculosEntrada.Location = new System.Drawing.Point(28, 304);
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
            this.textBox_listaveiculosSaida.Location = new System.Drawing.Point(391, 304);
            this.textBox_listaveiculosSaida.Multiline = true;
            this.textBox_listaveiculosSaida.Name = "textBox_listaveiculosSaida";
            this.textBox_listaveiculosSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listaveiculosSaida.Size = new System.Drawing.Size(393, 249);
            this.textBox_listaveiculosSaida.TabIndex = 11;
            // 
            // labelplaca
            // 
            this.labelplaca.AutoSize = true;
            this.labelplaca.BackColor = System.Drawing.Color.Navy;
            this.labelplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelplaca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelplaca.Location = new System.Drawing.Point(34, 289);
            this.labelplaca.Name = "labelplaca";
            this.labelplaca.Size = new System.Drawing.Size(42, 12);
            this.labelplaca.TabIndex = 12;
            this.labelplaca.Text = "PLACA";
            // 
            // labeldatahora
            // 
            this.labeldatahora.AutoSize = true;
            this.labeldatahora.BackColor = System.Drawing.Color.Navy;
            this.labeldatahora.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldatahora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labeldatahora.Location = new System.Drawing.Point(119, 289);
            this.labeldatahora.Name = "labeldatahora";
            this.labeldatahora.Size = new System.Drawing.Size(92, 12);
            this.labeldatahora.TabIndex = 13;
            this.labeldatahora.Text = "DATA-ENTRADA";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(28, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "LISTAR ENTRADA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonListarEntrada_Click);
            // 
            // btnlistarsaisa
            // 
            this.btnlistarsaisa.BackColor = System.Drawing.Color.Navy;
            this.btnlistarsaisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistarsaisa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlistarsaisa.Location = new System.Drawing.Point(574, 223);
            this.btnlistarsaisa.Name = "btnlistarsaisa";
            this.btnlistarsaisa.Size = new System.Drawing.Size(121, 40);
            this.btnlistarsaisa.TabIndex = 15;
            this.btnlistarsaisa.Text = "LISTAR SAIDA";
            this.btnlistarsaisa.UseVisualStyleBackColor = false;
            this.btnlistarsaisa.Click += new System.EventHandler(this.btnlistarsaida_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(398, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "PLACA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(708, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "V.A PAGAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Navy;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(575, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "HR-ENTRADA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Navy;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(446, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "DT-SAIDA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Navy;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(659, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "TEMPO";
            // 
            // btnsaida
            // 
            this.btnsaida.BackColor = System.Drawing.Color.Navy;
            this.btnsaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsaida.Location = new System.Drawing.Point(736, 223);
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
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(248, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "HORA-ENTRADA";
            // 
            // tbplaca
            // 
            this.tbplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbplaca.Location = new System.Drawing.Point(217, 171);
            this.tbplaca.Multiline = true;
            this.tbplaca.Name = "tbplaca";
            this.tbplaca.Size = new System.Drawing.Size(121, 21);
            this.tbplaca.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(594, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "DATA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(733, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "HORA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 16);
            this.label12.TabIndex = 40;
            this.label12.Text = "Digite o Numero de Vagas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 16);
            this.label13.TabIndex = 42;
            this.label13.Text = "Digite o Valor Por Hora";
            // 
            // tb_valorporhora
            // 
            this.tb_valorporhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valorporhora.Location = new System.Drawing.Point(262, 100);
            this.tb_valorporhora.Multiline = true;
            this.tb_valorporhora.Name = "tb_valorporhora";
            this.tb_valorporhora.Size = new System.Drawing.Size(45, 21);
            this.tb_valorporhora.TabIndex = 43;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.Navy;
            this.btn_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Confirmar.Location = new System.Drawing.Point(335, 81);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(120, 40);
            this.btn_Confirmar.TabIndex = 46;
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // tb_numerovagas
            // 
            this.tb_numerovagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_numerovagas.Location = new System.Drawing.Point(262, 67);
            this.tb_numerovagas.Multiline = true;
            this.tb_numerovagas.Name = "tb_numerovagas";
            this.tb_numerovagas.Size = new System.Drawing.Size(45, 21);
            this.tb_numerovagas.TabIndex = 41;
            // 
            // tbvalor
            // 
            this.tbvalor.Enabled = false;
            this.tbvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbvalor.Location = new System.Drawing.Point(574, 99);
            this.tbvalor.Multiline = true;
            this.tbvalor.Name = "tbvalor";
            this.tbvalor.Size = new System.Drawing.Size(45, 21);
            this.tbvalor.TabIndex = 47;
            // 
            // tbvagas
            // 
            this.tbvagas.Enabled = false;
            this.tbvagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbvagas.Location = new System.Drawing.Point(574, 64);
            this.tbvagas.Multiline = true;
            this.tbvagas.Name = "tbvagas";
            this.tbvagas.Size = new System.Drawing.Size(45, 21);
            this.tbvagas.TabIndex = 48;
            // 
            // tbData
            // 
            this.tbData.Enabled = false;
            this.tbData.Location = new System.Drawing.Point(640, 170);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(86, 20);
            this.tbData.TabIndex = 49;
            // 
            // tbHora
            // 
            this.tbHora.Enabled = false;
            this.tbHora.Location = new System.Drawing.Point(785, 169);
            this.tbHora.Name = "tbHora";
            this.tbHora.Size = new System.Drawing.Size(63, 20);
            this.tbHora.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(344, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 16);
            this.label8.TabIndex = 51;
            this.label8.Text = "Digite a Hora Saida";
            // 
            // tbhorasaida
            // 
            this.tbhorasaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbhorasaida.Location = new System.Drawing.Point(504, 173);
            this.tbhorasaida.Multiline = true;
            this.tbhorasaida.Name = "tbhorasaida";
            this.tbhorasaida.Size = new System.Drawing.Size(72, 21);
            this.tbhorasaida.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Navy;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(510, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 12);
            this.label10.TabIndex = 53;
            this.label10.Text = "HR-SAIDA";
            // 
            // FrmCadastroVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(871, 565);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbhorasaida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbHora);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbvagas);
            this.Controls.Add(this.tbvalor);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.tb_valorporhora);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_numerovagas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.btnentrada);
            this.Controls.Add(this.tbplaca);
            this.Controls.Add(this.lbplaca);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmCadastroVeiculos";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbplaca;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnentrada;
        public System.Windows.Forms.TextBox tbplaca;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox tb_valorporhora;
        private System.Windows.Forms.Button btn_Confirmar;
        public System.Windows.Forms.TextBox tb_numerovagas;
        public System.Windows.Forms.TextBox tbvalor;
        public System.Windows.Forms.TextBox tbvagas;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbHora;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbhorasaida;
        private System.Windows.Forms.Label label10;
    }
}