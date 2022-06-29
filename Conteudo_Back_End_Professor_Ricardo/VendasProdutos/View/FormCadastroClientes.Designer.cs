namespace VendasProdutos
{
    partial class FormCadastroClientes
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.BTbtnCadastroCliente = new System.Windows.Forms.Button();
            this.btnCancelarcadastro = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
 
           
            this.tbxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbxCpf = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
           
            this.vendasdbDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
          
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            
            this.groupBox1.SuspendLayout();
           
            ((System.ComponentModel.ISupportInitialize)(this.vendasdbDataSet6BindingSource)).BeginInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "EMAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "NOME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "TELEFONE";
            // 
            // tbxNome
            // 
            this.tbxNome.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxNome.Location = new System.Drawing.Point(88, 160);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(190, 20);
            this.tbxNome.TabIndex = 4;
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxEmail.Location = new System.Drawing.Point(88, 111);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(190, 20);
            this.tbxEmail.TabIndex = 3;
            // 
            // BTbtnCadastroCliente
            // 
            this.BTbtnCadastroCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTbtnCadastroCliente.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTbtnCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTbtnCadastroCliente.Location = new System.Drawing.Point(184, 270);
            this.BTbtnCadastroCliente.Name = "BTbtnCadastroCliente";
            this.BTbtnCadastroCliente.Size = new System.Drawing.Size(94, 41);
            this.BTbtnCadastroCliente.TabIndex = 5;
            this.BTbtnCadastroCliente.Text = "CADASTRAR";
            this.BTbtnCadastroCliente.UseVisualStyleBackColor = false;
            this.BTbtnCadastroCliente.Click += new System.EventHandler(this.BTbtnCadastroCliente_Click);
            // 
            // btnCancelarcadastro
            // 
            this.btnCancelarcadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelarcadastro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarcadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarcadastro.Location = new System.Drawing.Point(88, 270);
            this.btnCancelarcadastro.Name = "btnCancelarcadastro";
            this.btnCancelarcadastro.Size = new System.Drawing.Size(83, 41);
            this.btnCancelarcadastro.TabIndex = 11;
            this.btnCancelarcadastro.Text = "CANCELAR";
            this.btnCancelarcadastro.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(424, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "LISTA DE CLIENTES CADASTRADOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(299, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 317);
            this.dataGridView1.TabIndex = 14;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
           
            // 
            // vendas_dbDataSet
            // 
           
            // 
            // clientesTableAdapter
            // 
           
            // 
            // tbxTelefone
            // 
            this.tbxTelefone.BackColor = System.Drawing.Color.White;
            this.tbxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTelefone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxTelefone.Location = new System.Drawing.Point(88, 30);
            this.tbxTelefone.Mask = "(00) 00000-0000";
            this.tbxTelefone.Name = "tbxTelefone";
            this.tbxTelefone.Size = new System.Drawing.Size(190, 20);
            this.tbxTelefone.TabIndex = 1;
            // 
            // tbxCpf
            // 
            this.tbxCpf.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxCpf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxCpf.Location = new System.Drawing.Point(88, 68);
            this.tbxCpf.Mask = "00000000-00";
            this.tbxCpf.Name = "tbxCpf";
            this.tbxCpf.Size = new System.Drawing.Size(190, 20);
            this.tbxCpf.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTbtnCadastroCliente);
            this.groupBox1.Controls.Add(this.tbxTelefone);
            this.groupBox1.Controls.Add(this.tbxCpf);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCancelarcadastro);
            this.groupBox1.Controls.Add(this.tbxNome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 322);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // vendas_dbDataSet6
            // 
           
            // 
            // vendasdbDataSet6BindingSource
            // 
            
            this.vendasdbDataSet6BindingSource.Position = 0;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // vendas_dbDataSet7
            // 
           
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "clientes";
           
            // 
            // clientesTableAdapter1
            // 
          
            // 
            // FormCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(850, 393);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Name = "FormCadastroClientes";
            this.Text = "Cadastro De Clientes";
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
           
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
          
            ((System.ComponentModel.ISupportInitialize)(this.vendasdbDataSet6BindingSource)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Button BTbtnCadastroCliente;
        private System.Windows.Forms.Button btnCancelarcadastro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        
        private System.Windows.Forms.BindingSource clientesBindingSource;
      
        private System.Windows.Forms.MaskedTextBox tbxTelefone;
        private System.Windows.Forms.MaskedTextBox tbxCpf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
      
        private System.Windows.Forms.BindingSource vendasdbDataSet6BindingSource;
       
        private System.Windows.Forms.BindingSource clientesBindingSource1;
       
    }
}