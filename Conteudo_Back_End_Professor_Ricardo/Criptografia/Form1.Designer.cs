namespace Criptografia
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
            this.txbfrase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncriptoassimetrico = new System.Windows.Forms.Button();
            this.lblcript = new System.Windows.Forms.Label();
            this.btndescriptoassimetrico = new System.Windows.Forms.Button();
            this.lbldescriptografar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncriptosimetrico = new System.Windows.Forms.Button();
            this.txbchave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btndescriptosimetrico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frase:";
            // 
            // txbfrase
            // 
            this.txbfrase.Location = new System.Drawing.Point(190, 42);
            this.txbfrase.Name = "txbfrase";
            this.txbfrase.Size = new System.Drawing.Size(225, 20);
            this.txbfrase.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Frase criptografada";
            // 
            // btncriptoassimetrico
            // 
            this.btncriptoassimetrico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncriptoassimetrico.Location = new System.Drawing.Point(302, 84);
            this.btncriptoassimetrico.Name = "btncriptoassimetrico";
            this.btncriptoassimetrico.Size = new System.Drawing.Size(131, 31);
            this.btncriptoassimetrico.TabIndex = 3;
            this.btncriptoassimetrico.Text = "Cripto Assimetrico";
            this.btncriptoassimetrico.UseVisualStyleBackColor = true;
            this.btncriptoassimetrico.Click += new System.EventHandler(this.btncriptografia_Click);
            // 
            // lblcript
            // 
            this.lblcript.AutoSize = true;
            this.lblcript.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcript.Location = new System.Drawing.Point(263, 181);
            this.lblcript.Name = "lblcript";
            this.lblcript.Size = new System.Drawing.Size(12, 16);
            this.lblcript.TabIndex = 4;
            this.lblcript.Text = "-";
            // 
            // btndescriptoassimetrico
            // 
            this.btndescriptoassimetrico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescriptoassimetrico.Location = new System.Drawing.Point(302, 245);
            this.btndescriptoassimetrico.Name = "btndescriptoassimetrico";
            this.btndescriptoassimetrico.Size = new System.Drawing.Size(159, 36);
            this.btndescriptoassimetrico.TabIndex = 5;
            this.btndescriptoassimetrico.Text = "Descripto Assimetrico";
            this.btndescriptoassimetrico.UseVisualStyleBackColor = true;
            this.btndescriptoassimetrico.Click += new System.EventHandler(this.btndescripto_Click);
            // 
            // lbldescriptografar
            // 
            this.lbldescriptografar.AutoSize = true;
            this.lbldescriptografar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescriptografar.Location = new System.Drawing.Point(263, 332);
            this.lbldescriptografar.Name = "lbldescriptografar";
            this.lbldescriptografar.Size = new System.Drawing.Size(12, 16);
            this.lbldescriptografar.TabIndex = 6;
            this.lbldescriptografar.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Frase  Descriptografada";
            // 
            // btncriptosimetrico
            // 
            this.btncriptosimetrico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncriptosimetrico.Location = new System.Drawing.Point(547, 84);
            this.btncriptosimetrico.Name = "btncriptosimetrico";
            this.btncriptosimetrico.Size = new System.Drawing.Size(131, 31);
            this.btncriptosimetrico.TabIndex = 8;
            this.btncriptosimetrico.Text = "Cripto Simetrico";
            this.btncriptosimetrico.UseVisualStyleBackColor = true;
            this.btncriptosimetrico.Click += new System.EventHandler(this.btncriptosimetrico_Click);
            // 
            // txbchave
            // 
            this.txbchave.Location = new System.Drawing.Point(547, 38);
            this.txbchave.Name = "txbchave";
            this.txbchave.Size = new System.Drawing.Size(131, 20);
            this.txbchave.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Chave";
            // 
            // btndescriptosimetrico
            // 
            this.btndescriptosimetrico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescriptosimetrico.Location = new System.Drawing.Point(519, 245);
            this.btndescriptosimetrico.Name = "btndescriptosimetrico";
            this.btndescriptosimetrico.Size = new System.Drawing.Size(159, 36);
            this.btndescriptosimetrico.TabIndex = 11;
            this.btndescriptosimetrico.Text = "Descripto Simetrico";
            this.btndescriptosimetrico.UseVisualStyleBackColor = true;
            this.btndescriptosimetrico.Click += new System.EventHandler(this.btndescriptosimetrico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 409);
            this.Controls.Add(this.btndescriptosimetrico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbchave);
            this.Controls.Add(this.btncriptosimetrico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbldescriptografar);
            this.Controls.Add(this.btndescriptoassimetrico);
            this.Controls.Add(this.lblcript);
            this.Controls.Add(this.btncriptoassimetrico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbfrase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbfrase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncriptoassimetrico;
        private System.Windows.Forms.Label lblcript;
        private System.Windows.Forms.Button btndescriptoassimetrico;
        private System.Windows.Forms.Label lbldescriptografar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncriptosimetrico;
        private System.Windows.Forms.TextBox txbchave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndescriptosimetrico;
    }
}

