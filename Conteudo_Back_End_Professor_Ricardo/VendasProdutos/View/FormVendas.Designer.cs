namespace VendasProdutos
{
    partial class FormVendas
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
            this.lbvalortotal = new System.Windows.Forms.Label();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbClienteCadastrado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProdutoCadastrado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbQuantidade = new System.Windows.Forms.ComboBox();
            this.cbvalorunitario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnrealizavenda = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbvalortotal = new System.Windows.Forms.TextBox();
            this.listViewCarrinho = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendas_dbDataSet2 = new VendasProdutos.vendas_dbDataSet2();
            this.vendasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendasTableAdapter = new VendasProdutos.vendas_dbDataSet2TableAdapters.vendasTableAdapter();
            this.idVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_dbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbvalortotal
            // 
            this.lbvalortotal.AutoSize = true;
            this.lbvalortotal.Location = new System.Drawing.Point(173, 352);
            this.lbvalortotal.Name = "lbvalortotal";
            this.lbvalortotal.Size = new System.Drawing.Size(0, 13);
            this.lbvalortotal.TabIndex = 36;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            // 
            // cbClienteCadastrado
            // 
            this.cbClienteCadastrado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbClienteCadastrado.FormattingEnabled = true;
            this.cbClienteCadastrado.Location = new System.Drawing.Point(151, 15);
            this.cbClienteCadastrado.Name = "cbClienteCadastrado";
            this.cbClienteCadastrado.Size = new System.Drawing.Size(104, 21);
            this.cbClienteCadastrado.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "NOME DO CLIENTE";
            // 
            // cbProdutoCadastrado
            // 
            this.cbProdutoCadastrado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbProdutoCadastrado.FormattingEnabled = true;
            this.cbProdutoCadastrado.Location = new System.Drawing.Point(351, 12);
            this.cbProdutoCadastrado.Name = "cbProdutoCadastrado";
            this.cbProdutoCadastrado.Size = new System.Drawing.Size(100, 21);
            this.cbProdutoCadastrado.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "PRODUTO";
            // 
            // cbQuantidade
            // 
            this.cbQuantidade.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbQuantidade.FormattingEnabled = true;
            this.cbQuantidade.Location = new System.Drawing.Point(567, 14);
            this.cbQuantidade.Name = "cbQuantidade";
            this.cbQuantidade.Size = new System.Drawing.Size(82, 21);
            this.cbQuantidade.TabIndex = 42;
            // 
            // cbvalorunitario
            // 
            this.cbvalorunitario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbvalorunitario.FormattingEnabled = true;
            this.cbvalorunitario.Location = new System.Drawing.Point(792, 14);
            this.cbvalorunitario.Name = "cbvalorunitario";
            this.cbvalorunitario.Size = new System.Drawing.Size(82, 21);
            this.cbvalorunitario.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "QUANTIDADE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(667, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "VALOR UNITÁRIO";
            // 
            // btnrealizavenda
            // 
            this.btnrealizavenda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnrealizavenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrealizavenda.Location = new System.Drawing.Point(96, 152);
            this.btnrealizavenda.Name = "btnrealizavenda";
            this.btnrealizavenda.Size = new System.Drawing.Size(180, 32);
            this.btnrealizavenda.TabIndex = 46;
            this.btnrealizavenda.Text = "ADICIONA AO CARRINHO";
            this.btnrealizavenda.UseVisualStyleBackColor = false;
            this.btnrealizavenda.Click += new System.EventHandler(this.btnrealizavenda_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "VALOR TOTAL";
            // 
            // tbvalortotal
            // 
            this.tbvalortotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbvalortotal.Location = new System.Drawing.Point(113, 119);
            this.tbvalortotal.Multiline = true;
            this.tbvalortotal.Name = "tbvalortotal";
            this.tbvalortotal.Size = new System.Drawing.Size(119, 26);
            this.tbvalortotal.TabIndex = 49;
            // 
            // listViewCarrinho
            // 
            this.listViewCarrinho.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewCarrinho.HideSelection = false;
            this.listViewCarrinho.Location = new System.Drawing.Point(15, 190);
            this.listViewCarrinho.Name = "listViewCarrinho";
            this.listViewCarrinho.Size = new System.Drawing.Size(268, 199);
            this.listViewCarrinho.TabIndex = 50;
            this.listViewCarrinho.UseCompatibleStateImageBehavior = false;
            this.listViewCarrinho.View = System.Windows.Forms.View.List;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(408, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 32);
            this.button1.TabIndex = 51;
            this.button1.Text = "CONFIRMA VENDA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVendaDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vendasBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(330, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 199);
            this.dataGridView1.TabIndex = 52;
            // 
            // produtosBindingSource1
            // 
            this.produtosBindingSource1.DataMember = "produtos";
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "vendas";
            // 
            // vendas_dbDataSet2
            // 
            this.vendas_dbDataSet2.DataSetName = "vendas_dbDataSet2";
            this.vendas_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendasBindingSource1
            // 
            this.vendasBindingSource1.DataMember = "vendas";
            this.vendasBindingSource1.DataSource = this.vendas_dbDataSet2;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // idVendaDataGridViewTextBoxColumn
            // 
            this.idVendaDataGridViewTextBoxColumn.DataPropertyName = "idVenda";
            this.idVendaDataGridViewTextBoxColumn.HeaderText = "idVenda";
            this.idVendaDataGridViewTextBoxColumn.Name = "idVendaDataGridViewTextBoxColumn";
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(878, 401);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewCarrinho);
            this.Controls.Add(this.tbvalortotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnrealizavenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbvalorunitario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProdutoCadastrado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClienteCadastrado);
            this.Controls.Add(this.lbvalortotal);
            this.Name = "FormVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_dbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbvalortotal;
       
        private System.Windows.Forms.BindingSource produtosBindingSource;
        
        private System.Windows.Forms.ComboBox cbClienteCadastrado;
        private System.Windows.Forms.Label label1;
        
       
       
        private System.Windows.Forms.ComboBox cbProdutoCadastrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbQuantidade;
        private System.Windows.Forms.ComboBox cbvalorunitario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnrealizavenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbvalortotal;
        private System.Windows.Forms.ListView listViewCarrinho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.BindingSource vendasBindingSource;
      
        
        private System.Windows.Forms.BindingSource produtosBindingSource1;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private vendas_dbDataSet2 vendas_dbDataSet2;
        private System.Windows.Forms.BindingSource vendasBindingSource1;
        private vendas_dbDataSet2TableAdapters.vendasTableAdapter vendasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
    }
}