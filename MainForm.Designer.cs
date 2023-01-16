namespace CompetencyGrid {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vorlageErstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vorlageLadenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTemplatePanel = new System.Windows.Forms.Panel();
            this.vorlageBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(817, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vorlageErstellenToolStripMenuItem,
            this.vorlageBearbeitenToolStripMenuItem,
            this.vorlageLadenToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // vorlageErstellenToolStripMenuItem
            // 
            this.vorlageErstellenToolStripMenuItem.Name = "vorlageErstellenToolStripMenuItem";
            this.vorlageErstellenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vorlageErstellenToolStripMenuItem.Text = "Vorlage erstellen";
            this.vorlageErstellenToolStripMenuItem.Click += new System.EventHandler(this.vorlageErstellenToolStripMenuItem_Click);
            // 
            // vorlageLadenToolStripMenuItem
            // 
            this.vorlageLadenToolStripMenuItem.Name = "vorlageLadenToolStripMenuItem";
            this.vorlageLadenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vorlageLadenToolStripMenuItem.Text = "Vorlage laden";
            // 
            // createTemplatePanel
            // 
            this.createTemplatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createTemplatePanel.Location = new System.Drawing.Point(0, 24);
            this.createTemplatePanel.Name = "createTemplatePanel";
            this.createTemplatePanel.Size = new System.Drawing.Size(817, 480);
            this.createTemplatePanel.TabIndex = 1;
            // 
            // vorlageBearbeitenToolStripMenuItem
            // 
            this.vorlageBearbeitenToolStripMenuItem.Name = "vorlageBearbeitenToolStripMenuItem";
            this.vorlageBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vorlageBearbeitenToolStripMenuItem.Text = "Vorlage bearbeiten";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 504);
            this.Controls.Add(this.createTemplatePanel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Kompetenz Raster";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vorlageErstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vorlageLadenToolStripMenuItem;
        private System.Windows.Forms.Panel createTemplatePanel;
        private System.Windows.Forms.ToolStripMenuItem vorlageBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
    }
}

