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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vorlageErstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vorlageBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bewertungBeginnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bewertungBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluateStudent = new CompetencyGrid.UserControls.EvaluateStudent();
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
            this.bewertungBeginnenToolStripMenuItem,
            this.bewertungBearbeitenToolStripMenuItem});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // vorlageErstellenToolStripMenuItem
            // 
            this.vorlageErstellenToolStripMenuItem.Name = "vorlageErstellenToolStripMenuItem";
            this.vorlageErstellenToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.vorlageErstellenToolStripMenuItem.Text = "Vorlage erstellen";
            this.vorlageErstellenToolStripMenuItem.Click += new System.EventHandler(this.vorlageErstellenToolStripMenuItem_Click);
            // 
            // vorlageBearbeitenToolStripMenuItem
            // 
            this.vorlageBearbeitenToolStripMenuItem.Name = "vorlageBearbeitenToolStripMenuItem";
            this.vorlageBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.vorlageBearbeitenToolStripMenuItem.Text = "Vorlage bearbeiten";
            // 
            // bewertungBeginnenToolStripMenuItem
            // 
            this.bewertungBeginnenToolStripMenuItem.Name = "bewertungBeginnenToolStripMenuItem";
            this.bewertungBeginnenToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.bewertungBeginnenToolStripMenuItem.Text = "Bewertung beginnen";
            // 
            // bewertungBearbeitenToolStripMenuItem
            // 
            this.bewertungBearbeitenToolStripMenuItem.Name = "bewertungBearbeitenToolStripMenuItem";
            this.bewertungBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.bewertungBearbeitenToolStripMenuItem.Text = "Bewertung bearbeiten";
            // 
            // evaluateStudent
            // 
            this.evaluateStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.evaluateStudent.Enabled = false;
            this.evaluateStudent.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluateStudent.Location = new System.Drawing.Point(0, 24);
            this.evaluateStudent.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.evaluateStudent.MinimumSize = new System.Drawing.Size(817, 480);
            this.evaluateStudent.Name = "evaluateStudent";
            this.evaluateStudent.Size = new System.Drawing.Size(817, 480);
            this.evaluateStudent.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 504);
            this.Controls.Add(this.evaluateStudent);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(833, 543);
            this.Name = "MainForm";
            this.Text = "Kompetenz Raster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vorlageErstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vorlageBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bewertungBeginnenToolStripMenuItem;
        private UserControls.EvaluateStudent evaluateStudent;
        private System.Windows.Forms.ToolStripMenuItem bewertungBearbeitenToolStripMenuItem;
    }
}

