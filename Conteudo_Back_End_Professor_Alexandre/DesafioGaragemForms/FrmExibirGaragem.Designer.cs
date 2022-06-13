namespace Garagemteste
{
    partial class FrmExibirGaragem
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
            this.btnFecharExibir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbentrada = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(203, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veiculos Cadastrado Entrada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFecharExibir
            // 
            this.btnFecharExibir.BackColor = System.Drawing.Color.Navy;
            this.btnFecharExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharExibir.ForeColor = System.Drawing.Color.Transparent;
            this.btnFecharExibir.Location = new System.Drawing.Point(643, 505);
            this.btnFecharExibir.Name = "btnFecharExibir";
            this.btnFecharExibir.Size = new System.Drawing.Size(147, 48);
            this.btnFecharExibir.TabIndex = 3;
            this.btnFecharExibir.Text = "Voltar Para O Menu";
            this.btnFecharExibir.UseVisualStyleBackColor = false;
            this.btnFecharExibir.Click += new System.EventHandler(this.btnFecharExibir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 85);
            this.panel1.TabIndex = 5;
            // 
            // tbentrada
            // 
            this.tbentrada.BackColor = System.Drawing.Color.LightGray;
            this.tbentrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbentrada.Enabled = false;
            this.tbentrada.Location = new System.Drawing.Point(199, 148);
            this.tbentrada.Multiline = true;
            this.tbentrada.Name = "tbentrada";
            this.tbentrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbentrada.Size = new System.Drawing.Size(403, 341);
            this.tbentrada.TabIndex = 6;
            this.tbentrada.TextChanged += new System.EventHandler(this.tbentrada_TextChanged);
            // 
            // FrmExibirGaragem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(862, 565);
            this.Controls.Add(this.tbentrada);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFecharExibir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmExibirGaragem";
            this.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.Text = "FrmExibirCadastro";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFecharExibir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbentrada;
    }
}