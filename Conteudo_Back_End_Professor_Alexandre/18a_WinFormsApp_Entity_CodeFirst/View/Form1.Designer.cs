namespace _18a_WinFormsApp_Entity_CodeFirst
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.panel_campos = new System.Windows.Forms.Panel();
            this.button_salvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nomePaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.dataGridViewPaciente = new System.Windows.Forms.DataGridView();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_campos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(106, 41);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(350, 23);
            this.textBox_email.TabIndex = 3;
            // 
            // panel_campos
            // 
            this.panel_campos.Controls.Add(this.button_salvar);
            this.panel_campos.Controls.Add(this.textBox_email);
            this.panel_campos.Controls.Add(this.label2);
            this.panel_campos.Controls.Add(this.textBox_nomePaciente);
            this.panel_campos.Controls.Add(this.label1);
            this.panel_campos.Enabled = false;
            this.panel_campos.Location = new System.Drawing.Point(27, 255);
            this.panel_campos.Name = "panel_campos";
            this.panel_campos.Size = new System.Drawing.Size(462, 100);
            this.panel_campos.TabIndex = 11;
            // 
            // button_salvar
            // 
            this.button_salvar.Location = new System.Drawing.Point(106, 70);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(75, 23);
            this.button_salvar.TabIndex = 4;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // textBox_nomePaciente
            // 
            this.textBox_nomePaciente.Location = new System.Drawing.Point(106, 11);
            this.textBox_nomePaciente.Name = "textBox_nomePaciente";
            this.textBox_nomePaciente.Size = new System.Drawing.Size(350, 23);
            this.textBox_nomePaciente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Paciente";
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.Location = new System.Drawing.Point(408, 207);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.button_pesquisar.TabIndex = 10;
            this.button_pesquisar.Text = "Pesquisar";
            this.button_pesquisar.UseVisualStyleBackColor = true;
            this.button_pesquisar.Click += new System.EventHandler(this.button_pesquisar_Click_1);
            // 
            // button_editar
            // 
            this.button_editar.Location = new System.Drawing.Point(296, 207);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(75, 23);
            this.button_editar.TabIndex = 9;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click_1);
            // 
            // button_deletar
            // 
            this.button_deletar.Location = new System.Drawing.Point(139, 207);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(75, 23);
            this.button_deletar.TabIndex = 8;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click_1);
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Location = new System.Drawing.Point(27, 207);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.button_cadastrar.TabIndex = 7;
            this.button_cadastrar.Text = "Cadastrar";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click_1);
            // 
            // dataGridViewPaciente
            // 
            this.dataGridViewPaciente.AutoGenerateColumns = false;
            this.dataGridViewPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPacienteDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.nomePacienteDataGridViewTextBoxColumn});
            this.dataGridViewPaciente.DataSource = this.pacienteBindingSource;
            this.dataGridViewPaciente.Location = new System.Drawing.Point(27, 27);
            this.dataGridViewPaciente.Name = "dataGridViewPaciente";
            this.dataGridViewPaciente.RowTemplate.Height = 25;
            this.dataGridViewPaciente.Size = new System.Drawing.Size(456, 150);
            this.dataGridViewPaciente.TabIndex = 12;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataSource = typeof(_18a_WinFormsApp_Entity_CodeFirst.Paciente);
            // 
            // idPacienteDataGridViewTextBoxColumn
            // 
            this.idPacienteDataGridViewTextBoxColumn.DataPropertyName = "IdPaciente";
            this.idPacienteDataGridViewTextBoxColumn.HeaderText = "IdPaciente";
            this.idPacienteDataGridViewTextBoxColumn.Name = "idPacienteDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 160;
            // 
            // nomePacienteDataGridViewTextBoxColumn
            // 
            this.nomePacienteDataGridViewTextBoxColumn.DataPropertyName = "NomePaciente";
            this.nomePacienteDataGridViewTextBoxColumn.HeaderText = "NomePaciente";
            this.nomePacienteDataGridViewTextBoxColumn.Name = "nomePacienteDataGridViewTextBoxColumn";
            this.nomePacienteDataGridViewTextBoxColumn.Width = 160;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 373);
            this.Controls.Add(this.dataGridViewPaciente);
            this.Controls.Add(this.panel_campos);
            this.Controls.Add(this.button_pesquisar);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.button_cadastrar);
            this.Name = "Form1";
            this.Text = "Gestão de Pacientes";
            this.panel_campos.ResumeLayout(false);
            this.panel_campos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private TextBox textBox_email;
        private Panel panel_campos;
        private Button button_salvar;
        private Label label2;
        private TextBox textBox_nomePaciente;
        private Label label1;
        private Button button_pesquisar;
        private Button button_editar;
        private Button button_deletar;
        private Button button_cadastrar;
        private DataGridView dataGridViewPaciente;
        private BindingSource pacienteBindingSource;
        private DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomePacienteDataGridViewTextBoxColumn;
    }
}