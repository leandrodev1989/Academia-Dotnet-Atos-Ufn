namespace WindowsConectaBanco
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
            this.medidasglicemia = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonconectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxid_Gicemia = new System.Windows.Forms.TextBox();
            this.textboxvalor_Glicemia = new System.Windows.Forms.TextBox();
            this.textboxdata_Medicao = new System.Windows.Forms.TextBox();
            this.textboxid_Paciente = new System.Windows.Forms.TextBox();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.button_Remover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // medidasglicemia
            // 
            this.medidasglicemia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.medidasglicemia.HideSelection = false;
            this.medidasglicemia.Location = new System.Drawing.Point(12, 0);
            this.medidasglicemia.Name = "medidasglicemia";
            this.medidasglicemia.Size = new System.Drawing.Size(544, 257);
            this.medidasglicemia.TabIndex = 0;
            this.medidasglicemia.UseCompatibleStateImageBehavior = false;
            this.medidasglicemia.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "idMedidaGlicemia";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ValorGlicemia";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Datamedicao";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Paciente";
            this.columnHeader4.Width = 100;
            // 
            // buttonconectar
            // 
            this.buttonconectar.Location = new System.Drawing.Point(447, 377);
            this.buttonconectar.Name = "buttonconectar";
            this.buttonconectar.Size = new System.Drawing.Size(109, 50);
            this.buttonconectar.TabIndex = 1;
            this.buttonconectar.Text = "Conectar";
            this.buttonconectar.UseVisualStyleBackColor = true;
            this.buttonconectar.Click += new System.EventHandler(this.buttonconectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Glicemia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor Glicemia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Medição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Id Paciente";
            // 
            // textboxid_Gicemia
            // 
            this.textboxid_Gicemia.Location = new System.Drawing.Point(90, 263);
            this.textboxid_Gicemia.Name = "textboxid_Gicemia";
            this.textboxid_Gicemia.Size = new System.Drawing.Size(127, 20);
            this.textboxid_Gicemia.TabIndex = 6;
            // 
            // textboxvalor_Glicemia
            // 
            this.textboxvalor_Glicemia.Location = new System.Drawing.Point(90, 289);
            this.textboxvalor_Glicemia.Name = "textboxvalor_Glicemia";
            this.textboxvalor_Glicemia.Size = new System.Drawing.Size(127, 20);
            this.textboxvalor_Glicemia.TabIndex = 7;
            // 
            // textboxdata_Medicao
            // 
            this.textboxdata_Medicao.Location = new System.Drawing.Point(90, 315);
            this.textboxdata_Medicao.Name = "textboxdata_Medicao";
            this.textboxdata_Medicao.Size = new System.Drawing.Size(127, 20);
            this.textboxdata_Medicao.TabIndex = 8;
            // 
            // textboxid_Paciente
            // 
            this.textboxid_Paciente.Location = new System.Drawing.Point(90, 341);
            this.textboxid_Paciente.Name = "textboxid_Paciente";
            this.textboxid_Paciente.Size = new System.Drawing.Size(127, 20);
            this.textboxid_Paciente.TabIndex = 9;
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(131, 388);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(86, 39);
            this.buttonbuscar.TabIndex = 10;
            this.buttonbuscar.Text = "Adicionar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // button_Remover
            // 
            this.button_Remover.Location = new System.Drawing.Point(447, 292);
            this.button_Remover.Name = "button_Remover";
            this.button_Remover.Size = new System.Drawing.Size(109, 50);
            this.button_Remover.TabIndex = 11;
            this.button_Remover.Text = "Remover";
            this.button_Remover.UseVisualStyleBackColor = true;
            this.button_Remover.Click += new System.EventHandler(this.button_Remover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.button_Remover);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.textboxid_Paciente);
            this.Controls.Add(this.textboxdata_Medicao);
            this.Controls.Add(this.textboxvalor_Glicemia);
            this.Controls.Add(this.textboxid_Gicemia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonconectar);
            this.Controls.Add(this.medidasglicemia);
            this.Name = "Form1";
            this.Text = "Gestão de Glicemia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView medidasglicemia;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonconectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxid_Gicemia;
        private System.Windows.Forms.TextBox textboxvalor_Glicemia;
        private System.Windows.Forms.TextBox textboxdata_Medicao;
        private System.Windows.Forms.TextBox textboxid_Paciente;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.Button button_Remover;
    }
}

