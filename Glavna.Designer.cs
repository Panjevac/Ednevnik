namespace EDnevnik
{
    partial class Glavna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jedanBezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jedanSaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaBezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaSaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_user = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jedanBezToolStripMenuItem,
            this.jedanSaToolStripMenuItem,
            this.tabelaBezToolStripMenuItem,
            this.tabelaSaToolStripMenuItem,
            this.izvestajiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jedanBezToolStripMenuItem
            // 
            this.jedanBezToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobeToolStripMenuItem});
            this.jedanBezToolStripMenuItem.Name = "jedanBezToolStripMenuItem";
            this.jedanBezToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.jedanBezToolStripMenuItem.Text = "jedan bez";
            // 
            // jedanSaToolStripMenuItem
            // 
            this.jedanSaToolStripMenuItem.Name = "jedanSaToolStripMenuItem";
            this.jedanSaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.jedanSaToolStripMenuItem.Text = "jedan sa";
            // 
            // tabelaBezToolStripMenuItem
            // 
            this.tabelaBezToolStripMenuItem.Name = "tabelaBezToolStripMenuItem";
            this.tabelaBezToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.tabelaBezToolStripMenuItem.Text = "tabela bez";
            // 
            // tabelaSaToolStripMenuItem
            // 
            this.tabelaSaToolStripMenuItem.Name = "tabelaSaToolStripMenuItem";
            this.tabelaSaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tabelaSaToolStripMenuItem.Text = "tabela sa";
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.izvestajiToolStripMenuItem.Text = "izvestaji";
            // 
            // osobeToolStripMenuItem
            // 
            this.osobeToolStripMenuItem.Name = "osobeToolStripMenuItem";
            this.osobeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.osobeToolStripMenuItem.Text = "osobe";
            this.osobeToolStripMenuItem.Click += new System.EventHandler(this.osobeToolStripMenuItem_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(468, 10);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(35, 13);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "label1";
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna";
            this.Text = "Glavna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glavna_FormClosed);
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jedanBezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jedanSaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaBezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaSaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
        private System.Windows.Forms.Label lbl_user;
    }
}