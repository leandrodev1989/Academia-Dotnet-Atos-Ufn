namespace WindowsFormsCalculadora
{
    partial class ljCalculadora
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btdividir = new System.Windows.Forms.Button();
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.btsubtrair = new System.Windows.Forms.Button();
            this.btsomar = new System.Windows.Forms.Button();
            this.tbNr2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNr1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Controls.Add(this.btdividir);
            this.groupBox1.Controls.Add(this.btMultiplicar);
            this.groupBox1.Controls.Add(this.btsubtrair);
            this.groupBox1.Controls.Add(this.btsomar);
            this.groupBox1.Controls.Add(this.tbNr2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNr1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(17, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "Resultado";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(89, 179);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(15, 16);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "0";
            // 
            // btdividir
            // 
            this.btdividir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btdividir.Location = new System.Drawing.Point(283, 138);
            this.btdividir.Name = "btdividir";
            this.btdividir.Size = new System.Drawing.Size(70, 24);
            this.btdividir.TabIndex = 7;
            this.btdividir.Text = "Dividir";
            this.btdividir.UseVisualStyleBackColor = false;
            this.btdividir.Click += new System.EventHandler(this.btdividir_Click);
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btMultiplicar.Location = new System.Drawing.Point(194, 138);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(70, 24);
            this.btMultiplicar.TabIndex = 6;
            this.btMultiplicar.Text = "Multiplicar";
            this.btMultiplicar.UseVisualStyleBackColor = false;
            this.btMultiplicar.Click += new System.EventHandler(this.btMultiplicar_Click);
            // 
            // btsubtrair
            // 
            this.btsubtrair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btsubtrair.Location = new System.Drawing.Point(105, 138);
            this.btsubtrair.Name = "btsubtrair";
            this.btsubtrair.Size = new System.Drawing.Size(70, 24);
            this.btsubtrair.TabIndex = 5;
            this.btsubtrair.Text = "Subtrair";
            this.btsubtrair.UseVisualStyleBackColor = false;
            this.btsubtrair.Click += new System.EventHandler(this.btsubtrair_Click);
            // 
            // btsomar
            // 
            this.btsomar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btsomar.Location = new System.Drawing.Point(16, 138);
            this.btsomar.Name = "btsomar";
            this.btsomar.Size = new System.Drawing.Size(70, 24);
            this.btsomar.TabIndex = 3;
            this.btsomar.Text = "Somar";
            this.btsomar.UseVisualStyleBackColor = false;
            this.btsomar.Click += new System.EventHandler(this.btsomar_Click);
            // 
            // tbNr2
            // 
            this.tbNr2.BackColor = System.Drawing.SystemColors.Info;
            this.tbNr2.Location = new System.Drawing.Point(17, 94);
            this.tbNr2.Name = "tbNr2";
            this.tbNr2.Size = new System.Drawing.Size(97, 20);
            this.tbNr2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Segundo Número";
            // 
            // tbNr1
            // 
            this.tbNr1.BackColor = System.Drawing.SystemColors.Info;
            this.tbNr1.Location = new System.Drawing.Point(17, 43);
            this.tbNr1.Name = "tbNr1";
            this.tbNr1.Size = new System.Drawing.Size(97, 20);
            this.tbNr1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeiro Número";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 196);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // ljCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ljCalculadora";
            this.Text = "Calculadora Simples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNr1;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btdividir;
        private System.Windows.Forms.Button btMultiplicar;
        private System.Windows.Forms.Button btsubtrair;
        private System.Windows.Forms.Button btsomar;

        private System.Windows.Forms.TextBox tbNr2;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

