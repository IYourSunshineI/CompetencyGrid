namespace CompetencyGrid.Forms {
    partial class AddDetailsForm {
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
            this.btn_add = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.tb_theme = new CueTextBox();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.AutoSize = true;
            this.btn_add.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_add.Location = new System.Drawing.Point(479, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(88, 30);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "hinzufügen";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(12, 57);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(555, 273);
            this.panel.TabIndex = 2;
            // 
            // tb_theme
            // 
            this.tb_theme.Cue = null;
            this.tb_theme.Location = new System.Drawing.Point(12, 12);
            this.tb_theme.Name = "tb_theme";
            this.tb_theme.Size = new System.Drawing.Size(461, 30);
            this.tb_theme.TabIndex = 0;
            // 
            // AddDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 342);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_theme);
            this.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(595, 381);
            this.MinimumSize = new System.Drawing.Size(595, 381);
            this.Name = "AddDetailsForm";
            this.Text = "bearbeitete Themen für ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CueTextBox tb_theme;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel;
    }
}