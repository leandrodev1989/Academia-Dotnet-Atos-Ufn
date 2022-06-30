namespace VendasProdutos
{
    partial class FormCadastroProduto
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNomeProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPrecoProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxEstoque = new System.Windows.Forms.TextBox();
            this.dgwprodutos = new System.Windows.Forms.DataGridView();
            this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelarproduto = new System.Windows.Forms.Button();
            this.btnCadastrarproduto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.itemVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendas_dbDataSet1 = new VendasProdutos.vendas_dbDataSet1();
            this.produtosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new VendasProdutos.vendas_dbDataSet1TableAdapters.produtosTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwprodutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "NOME";
            // 
            // tbxNomeProduto
            // 
            this.tbxNomeProduto.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxNomeProduto.Location = new System.Drawing.Point(135, 40);
            this.tbxNomeProduto.Name = "tbxNomeProduto";
            this.tbxNomeProduto.Size = new System.Drawing.Size(96, 20);
            this.tbxNomeProduto.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "PREÇO";
            // 
            // txbPrecoProduto
            // 
            this.txbPrecoProduto.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txbPrecoProduto.Location = new System.Drawing.Point(135, 66);
            this.txbPrecoProduto.Name = "txbPrecoProduto";
            this.txbPrecoProduto.Size = new System.Drawing.Size(96, 20);
            this.txbPrecoProduto.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "ESTOQUE";
            // 
            // tbxEstoque
            // 
            this.tbxEstoque.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxEstoque.Location = new System.Drawing.Point(135, 104);
            this.tbxEstoque.Name = "tbxEstoque";
            this.tbxEstoque.Size = new System.Drawing.Size(96, 20);
            this.tbxEstoque.TabIndex = 15;
            // 
            // dgwprodutos
            // 
            this.dgwprodutos.AutoGenerateColumns = false;
            this.dgwprodutos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwprodutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgwprodutos.DataSource = this.produtosBindingSource2;
            this.dgwprodutos.Location = new System.Drawing.Point(237, 40);
            this.dgwprodutos.MultiSelect = false;
            this.dgwprodutos.Name = "dgwprodutos";
            this.dgwprodutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwprodutos.Size = new System.Drawing.Size(544, 220);
            this.dgwprodutos.TabIndex = 16;
            // 
            // produtosBindingSource1
            // 
            this.produtosBindingSource1.DataMember = "produtos";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            // 
            // btnCancelarproduto
            // 
            this.btnCancelarproduto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelarproduto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarproduto.Location = new System.Drawing.Point(60, 160);
            this.btnCancelarproduto.Name = "btnCancelarproduto";
            this.btnCancelarproduto.Size = new System.Drawing.Size(80, 29);
            this.btnCancelarproduto.TabIndex = 17;
            this.btnCancelarproduto.Text = "Cancelar";
            this.btnCancelarproduto.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarproduto
            // 
            this.btnCadastrarproduto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastrarproduto.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCadastrarproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarproduto.Location = new System.Drawing.Point(146, 160);
            this.btnCadastrarproduto.Name = "btnCadastrarproduto";
            this.btnCadastrarproduto.Size = new System.Drawing.Size(85, 29);
            this.btnCadastrarproduto.TabIndex = 18;
            this.btnCadastrarproduto.Text = "Cadastrar";
            this.btnCadastrarproduto.UseVisualStyleBackColor = false;
            this.btnCadastrarproduto.Click += new System.EventHandler(this.btnCadastrarproduto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(312, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "LISTA DE PRODUTOS  CADASTRADOS";
            // 
            // itemVendaBindingSource
            // 
            this.itemVendaBindingSource.DataMember = "itemVenda";
            // 
            // vendas_dbDataSet1
            // 
            this.vendas_dbDataSet1.DataSetName = "vendas_dbDataSet1";
            this.vendas_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource2
            // 
            this.produtosBindingSource2.DataMember = "produtos";
            this.produtosBindingSource2.DataSource = this.vendas_dbDataSet1;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idProduto";
            this.dataGridViewTextBoxColumn1.HeaderText = "idProduto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodEAN";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodEAN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "nome";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "preco";
            this.dataGridViewTextBoxColumn4.HeaderText = "preco";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "estoque";
            this.dataGridViewTextBoxColumn5.HeaderText = "estoque";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(796, 331);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCadastrarproduto);
            this.Controls.Add(this.btnCancelarproduto);
            this.Controls.Add(this.dgwprodutos);
            this.Controls.Add(this.tbxEstoque);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbPrecoProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxNomeProduto);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Produto";
            this.Load += new System.EventHandler(this.FormCadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwprodutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNomeProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPrecoProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxEstoque;
        private System.Windows.Forms.DataGridView dgwprodutos;
    
        private System.Windows.Forms.BindingSource produtosBindingSource;
       
        private System.Windows.Forms.Button btnCancelarproduto;
        private System.Windows.Forms.Button btnCadastrarproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
     
        private System.Windows.Forms.BindingSource itemVendaBindingSource;
    
  
        private System.Windows.Forms.BindingSource produtosBindingSource1;
        private vendas_dbDataSet1 vendas_dbDataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource2;
        private vendas_dbDataSet1TableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}