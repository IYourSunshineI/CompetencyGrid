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
            this.createSection = new CompetencyGrid.Forms.CreateSection();
            this.createTemplate = new CompetencyGrid.Forms.CreateTemplate();
            this.SuspendLayout();
            // 
            // createSection
            // 
            this.createSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createSection.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSection.Location = new System.Drawing.Point(0, 0);
            this.createSection.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.createSection.MaximumSize = new System.Drawing.Size(584, 361);
            this.createSection.MinimumSize = new System.Drawing.Size(584, 361);
            this.createSection.Name = "createSection";
            this.createSection.Size = new System.Drawing.Size(584, 361);
            this.createSection.TabIndex = 1;
            this.createSection.TabStop = false;
            // 
            // createTemplate
            // 
            this.createTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createTemplate.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTemplate.Location = new System.Drawing.Point(0, 0);
            this.createTemplate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.createTemplate.MaximumSize = new System.Drawing.Size(584, 361);
            this.createTemplate.MinimumSize = new System.Drawing.Size(584, 361);
            this.createTemplate.Name = "createTemplate";
            this.createTemplate.Size = new System.Drawing.Size(584, 361);
            this.createTemplate.TabIndex = 2;
            this.createTemplate.TabStop = false;
            // 
            // CreateTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.createSection);
            this.Controls.Add(this.createTemplate);
            this.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "CreateTemplateForm";
            this.Text = "Vorlage erstellen";
            this.ResumeLayout(false);

        }

        #endregion
        private Forms.CreateSection createSection;
        private Forms.CreateTemplate createTemplate;
    }
}