namespace CompetencyGrid {
    partial class SettingsForm {
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
            this.labelTemplatePathStatic = new System.Windows.Forms.Label();
            this.textBoxTemplatePath = new System.Windows.Forms.TextBox();
            this.btn_SelectTemplatePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTemplatePathStatic
            // 
            this.labelTemplatePathStatic.AutoSize = true;
            this.labelTemplatePathStatic.Location = new System.Drawing.Point(12, 9);
            this.labelTemplatePathStatic.Name = "labelTemplatePathStatic";
            this.labelTemplatePathStatic.Size = new System.Drawing.Size(128, 23);
            this.labelTemplatePathStatic.TabIndex = 0;
            this.labelTemplatePathStatic.Text = "Vorlagen Pfad";
            // 
            // textBoxTemplatePath
            // 
            this.textBoxTemplatePath.Location = new System.Drawing.Point(146, 6);
            this.textBoxTemplatePath.Name = "textBoxTemplatePath";
            this.textBoxTemplatePath.ReadOnly = true;
            this.textBoxTemplatePath.Size = new System.Drawing.Size(498, 30);
            this.textBoxTemplatePath.TabIndex = 1;
            // 
            // btn_SelectTemplatePath
            // 
            this.btn_SelectTemplatePath.Font = new System.Drawing.Font("Roboto-Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectTemplatePath.Location = new System.Drawing.Point(650, 9);
            this.btn_SelectTemplatePath.Name = "btn_SelectTemplatePath";
            this.btn_SelectTemplatePath.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectTemplatePath.TabIndex = 2;
            this.btn_SelectTemplatePath.Text = "Ändern";
            this.btn_SelectTemplatePath.UseVisualStyleBackColor = true;
            this.btn_SelectTemplatePath.Click += new System.EventHandler(this.btn_SelectTemplatePath_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 431);
            this.Controls.Add(this.btn_SelectTemplatePath);
            this.Controls.Add(this.textBoxTemplatePath);
            this.Controls.Add(this.labelTemplatePathStatic);
            this.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SettingsForm";
            this.Text = "Einstellungen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTemplatePathStatic;
        private System.Windows.Forms.TextBox textBoxTemplatePath;
        private System.Windows.Forms.Button btn_SelectTemplatePath;
    }
}