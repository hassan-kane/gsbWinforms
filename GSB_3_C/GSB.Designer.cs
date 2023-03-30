
namespace GSB_3_C
{
    partial class GSB
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuGSB = new System.Windows.Forms.MenuStrip();
            this.gERERLESVISITEURSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vOIRSLESRAPPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGSB.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGSB
            // 
            this.menuGSB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gERERLESVISITEURSToolStripMenuItem,
            this.vOIRSLESRAPPORTSToolStripMenuItem});
            this.menuGSB.Location = new System.Drawing.Point(0, 0);
            this.menuGSB.Name = "menuGSB";
            this.menuGSB.Size = new System.Drawing.Size(800, 24);
            this.menuGSB.TabIndex = 0;
            this.menuGSB.Text = "menuStrip1";
            // 
            // gERERLESVISITEURSToolStripMenuItem
            // 
            this.gERERLESVISITEURSToolStripMenuItem.Name = "gERERLESVISITEURSToolStripMenuItem";
            this.gERERLESVISITEURSToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.gERERLESVISITEURSToolStripMenuItem.Text = "GERER LES VISITEURS";
            this.gERERLESVISITEURSToolStripMenuItem.Click += new System.EventHandler(this.gERERLESVISITEURSToolStripMenuItem_Click);
            // 
            // vOIRSLESRAPPORTSToolStripMenuItem
            // 
            this.vOIRSLESRAPPORTSToolStripMenuItem.Name = "vOIRSLESRAPPORTSToolStripMenuItem";
            this.vOIRSLESRAPPORTSToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.vOIRSLESRAPPORTSToolStripMenuItem.Text = "VOIRS LES RAPPORTS";
            this.vOIRSLESRAPPORTSToolStripMenuItem.Click += new System.EventHandler(this.vOIRSLESRAPPORTSToolStripMenuItem_Click);
            // 
            // GSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuGSB);
            this.MainMenuStrip = this.menuGSB;
            this.Name = "GSB";
            this.Text = "GSB";
            this.menuGSB.ResumeLayout(false);
            this.menuGSB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuGSB;
        private System.Windows.Forms.ToolStripMenuItem gERERLESVISITEURSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vOIRSLESRAPPORTSToolStripMenuItem;
    }
}

