namespace CompetencyGrid {
    partial class CreateTemplateForm {
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
            this.createTemplate1 = new CompetencyGrid.Forms.CreateTemplate();
            this.createSection1 = new CompetencyGrid.Forms.CreateSection();
            this.SuspendLayout();
            // 
            // createTemplate1
            // 
            this.createTemplate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createTemplate1.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTemplate1.Location = new System.Drawing.Point(0, 0);
            this.createTemplate1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.createTemplate1.MaximumSize = new System.Drawing.Size(584, 361);
            this.createTemplate1.MinimumSize = new System.Drawing.Size(584, 361);
            this.createTemplate1.Name = "createTemplate1";
            this.createTemplate1.Size = new System.Drawing.Size(584, 361);
            this.createTemplate1.TabIndex = 2;
            this.createTemplate1.TabStop = false;
            // 
            // createSection1
            // 
            this.createSection1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createSection1.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSection1.Location = new System.Drawing.Point(0, 0);
            this.createSection1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.createSection1.MaximumSize = new System.Drawing.Size(584, 361);
            this.createSection1.MinimumSize = new System.Drawing.Size(584, 361);
            this.createSection1.Name = "createSection1";
            this.createSection1.Size = new System.Drawing.Size(584, 361);
            this.createSection1.TabIndex = 1;
            this.createSection1.TabStop = false;
            // 
            // CreateTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.createTemplate1);
            this.Controls.Add(this.createSection1);
            this.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "CreateTemplateForm";
            this.Text = "Vorlage erstellen";
            this.ResumeLayout(false);

        }

        #endregion
        private Forms.CreateSection createSection1;
        private Forms.CreateTemplate createTemplate1;
    }
}