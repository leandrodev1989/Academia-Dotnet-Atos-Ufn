namespace VendasProdutos
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPÇÕESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTRODECLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTRODEPRODUTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPÇÕESToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // oPÇÕESToolStripMenuItem
            // 
            resources.ApplyResources(this.oPÇÕESToolStripMenuItem, "oPÇÕESToolStripMenuItem");
            this.oPÇÕESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTRODECLIENTESToolStripMenuItem,
            this.cADASTRODEPRODUTOSToolStripMenuItem,
            this.vENDASToolStripMenuItem});
            this.oPÇÕESToolStripMenuItem.Name = "oPÇÕESToolStripMenuItem";
            // 
            // cADASTRODECLIENTESToolStripMenuItem
            // 
            resources.ApplyResources(this.cADASTRODECLIENTESToolStripMenuItem, "cADASTRODECLIENTESToolStripMenuItem");
            this.cADASTRODECLIENTESToolStripMenuItem.Name = "cADASTRODECLIENTESToolStripMenuItem";
            this.cADASTRODECLIENTESToolStripMenuItem.Click += new System.EventHandler(this.cADASTRODECLIENTESToolStripMenuItem_Click);
            // 
            // cADASTRODEPRODUTOSToolStripMenuItem
            // 
            resources.ApplyResources(this.cADASTRODEPRODUTOSToolStripMenuItem, "cADASTRODEPRODUTOSToolStripMenuItem");
            this.cADASTRODEPRODUTOSToolStripMenuItem.Name = "cADASTRODEPRODUTOSToolStripMenuItem";
            this.cADASTRODEPRODUTOSToolStripMenuItem.Click += new System.EventHandler(this.cADASTRODEPRODUTOSToolStripMenuItem_Click);
            // 
            // vENDASToolStripMenuItem
            // 
            resources.ApplyResources(this.vENDASToolStripMenuItem, "vENDASToolStripMenuItem");
            this.vENDASToolStripMenuItem.Name = "vENDASToolStripMenuItem";
            this.vENDASToolStripMenuItem.Click += new System.EventHandler(this.vENDASToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            resources.ApplyResources(this.sAIRToolStripMenuItem, "sAIRToolStripMenuItem");
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.UseWaitCursor = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPÇÕESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTRODECLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTRODEPRODUTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENDASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
    }
}

