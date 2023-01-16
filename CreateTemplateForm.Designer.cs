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
            this.templateName = new System.Windows.Forms.Label();
            this.tempTextBox = new System.Windows.Forms.RichTextBox();
            this.btn_safe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // templateName
            // 
            this.templateName.AutoSize = true;
            this.templateName.Location = new System.Drawing.Point(12, 9);
            this.templateName.Name = "templateName";
            this.templateName.Size = new System.Drawing.Size(60, 23);
            this.templateName.TabIndex = 0;
            this.templateName.Text = "Name";
            // 
            // tempTextBox
            // 
            this.tempTextBox.Location = new System.Drawing.Point(12, 35);
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(477, 229);
            this.tempTextBox.TabIndex = 2;
            this.tempTextBox.Text = "";
            // 
            // btn_safe
            // 
            this.btn_safe.Font = new System.Drawing.Font("Roboto-Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_safe.Location = new System.Drawing.Point(411, 270);
            this.btn_safe.Name = "btn_safe";
            this.btn_safe.Size = new System.Drawing.Size(78, 23);
            this.btn_safe.TabIndex = 3;
            this.btn_safe.Text = "Speichern";
            this.btn_safe.UseVisualStyleBackColor = true;
            this.btn_safe.Click += new System.EventHandler(this.btn_safe_Click);
            // 
            // CreateTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 305);
            this.Controls.Add(this.btn_safe);
            this.Controls.Add(this.tempTextBox);
            this.Controls.Add(this.templateName);
            this.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "CreateTemplateForm";
            this.Text = "Vorlage erstellen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label templateName;
        private System.Windows.Forms.RichTextBox tempTextBox;
        private System.Windows.Forms.Button btn_safe;
    }
}