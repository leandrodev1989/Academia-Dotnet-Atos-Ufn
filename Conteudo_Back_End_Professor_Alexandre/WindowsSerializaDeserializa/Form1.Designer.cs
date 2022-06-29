namespace WindowsSerializaDeserializa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btngravar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxnome = new System.Windows.Forms.TextBox();
            this.textBoxdatanascimento = new System.Windows.Forms.TextBox();
            this.textBoxcpf = new System.Windows.Forms.TextBox();
            this.tblista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cpf";
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(140, 151);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 3;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Serializar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxnome
            // 
            this.textBoxnome.Location = new System.Drawing.Point(176, 21);
            this.textBoxnome.Name = "textBoxnome";
            this.textBoxnome.Size = new System.Drawing.Size(206, 20);
            this.textBoxnome.TabIndex = 5;
            // 
            // textBoxdatanascimento
            // 
            this.textBoxdatanascimento.Location = new System.Drawing.Point(176, 63);
            this.textBoxdatanascimento.Name = "textBoxdatanascimento";
            this.textBoxdatanascimento.Size = new System.Drawing.Size(206, 20);
            this.textBoxdatanascimento.TabIndex = 6;
            // 
            // textBoxcpf
            // 
            this.textBoxcpf.Location = new System.Drawing.Point(176, 105);
            this.textBoxcpf.Name = "textBoxcpf";
            this.textBoxcpf.Size = new System.Drawing.Size(206, 20);
            this.textBoxcpf.TabIndex = 7;
            // 
            // tblista
            // 
            this.tblista.Location = new System.Drawing.Point(26, 278);
            this.tblista.Multiline = true;
            this.tblista.Name = "tblista";
            this.tblista.Size = new System.Drawing.Size(356, 181);
            this.tblista.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 485);
            this.Controls.Add(this.tblista);
            this.Controls.Add(this.textBoxcpf);
            this.Controls.Add(this.textBoxdatanascimento);
            this.Controls.Add(this.textBoxnome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxnome;
        private System.Windows.Forms.TextBox textBoxdatanascimento;
        private System.Windows.Forms.TextBox textBoxcpf;
        private System.Windows.Forms.TextBox tblista;
    }
}

