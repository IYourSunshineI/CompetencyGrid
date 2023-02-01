namespace CompetencyGrid.UserControls {
    partial class CompScore {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tb = new System.Windows.Forms.RichTextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.rB_3 = new System.Windows.Forms.RadioButton();
            this.rB_2 = new System.Windows.Forms.RadioButton();
            this.rB_1 = new System.Windows.Forms.RadioButton();
            this.rB_0 = new System.Windows.Forms.RadioButton();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb.Location = new System.Drawing.Point(3, 3);
            this.tb.Name = "tb";
            this.tb.ReadOnly = true;
            this.tb.Size = new System.Drawing.Size(332, 144);
            this.tb.TabIndex = 0;
            this.tb.Text = "";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.rB_3);
            this.panel.Controls.Add(this.rB_2);
            this.panel.Controls.Add(this.rB_1);
            this.panel.Controls.Add(this.rB_0);
            this.panel.Location = new System.Drawing.Point(341, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(192, 144);
            this.panel.TabIndex = 1;
            // 
            // rB_3
            // 
            this.rB_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rB_3.AutoSize = true;
            this.rB_3.Location = new System.Drawing.Point(146, 56);
            this.rB_3.Name = "rB_3";
            this.rB_3.Size = new System.Drawing.Size(39, 27);
            this.rB_3.TabIndex = 3;
            this.rB_3.TabStop = true;
            this.rB_3.Text = "3";
            this.rB_3.UseVisualStyleBackColor = true;
            // 
            // rB_2
            // 
            this.rB_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rB_2.AutoSize = true;
            this.rB_2.Location = new System.Drawing.Point(101, 56);
            this.rB_2.Name = "rB_2";
            this.rB_2.Size = new System.Drawing.Size(39, 27);
            this.rB_2.TabIndex = 2;
            this.rB_2.TabStop = true;
            this.rB_2.Text = "2";
            this.rB_2.UseVisualStyleBackColor = true;
            // 
            // rB_1
            // 
            this.rB_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rB_1.AutoSize = true;
            this.rB_1.Location = new System.Drawing.Point(56, 56);
            this.rB_1.Name = "rB_1";
            this.rB_1.Size = new System.Drawing.Size(39, 27);
            this.rB_1.TabIndex = 1;
            this.rB_1.TabStop = true;
            this.rB_1.Text = "1";
            this.rB_1.UseVisualStyleBackColor = true;
            // 
            // rB_0
            // 
            this.rB_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rB_0.AutoSize = true;
            this.rB_0.Location = new System.Drawing.Point(11, 56);
            this.rB_0.Name = "rB_0";
            this.rB_0.Size = new System.Drawing.Size(39, 27);
            this.rB_0.TabIndex = 0;
            this.rB_0.TabStop = true;
            this.rB_0.Text = "0";
            this.rB_0.UseVisualStyleBackColor = true;
            // 
            // CompScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tb);
            this.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "CompScore";
            this.Size = new System.Drawing.Size(536, 150);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox tb;
        public System.Windows.Forms.Panel panel;
        public System.Windows.Forms.RadioButton rB_3;
        public System.Windows.Forms.RadioButton rB_2;
        public System.Windows.Forms.RadioButton rB_1;
        public System.Windows.Forms.RadioButton rB_0;
    }
}
