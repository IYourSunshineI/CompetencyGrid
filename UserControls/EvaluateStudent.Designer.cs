namespace CompetencyGrid.UserControls {
    partial class EvaluateStudent {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluateStudent));
            this.panel_lowerPart = new System.Windows.Forms.Panel();
            this.panel_splitRight = new System.Windows.Forms.Panel();
            this.panel_comp = new System.Windows.Forms.Panel();
            this.label_comp = new System.Windows.Forms.Label();
            this.splitter = new System.Windows.Forms.Splitter();
            this.panel_splitLeft = new System.Windows.Forms.Panel();
            this.panel_Subjects = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Subjects = new System.Windows.Forms.Label();
            this.label_templateName = new System.Windows.Forms.Label();
            this.label_nameOfStudent = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tb_nName = new CueTextBox();
            this.tb_vName = new CueTextBox();
            this.panel_lowerPart.SuspendLayout();
            this.panel_splitRight.SuspendLayout();
            this.panel_splitLeft.SuspendLayout();
            this.panel_Subjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_lowerPart
            // 
            this.panel_lowerPart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_lowerPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_lowerPart.Controls.Add(this.panel_splitRight);
            this.panel_lowerPart.Controls.Add(this.splitter);
            this.panel_lowerPart.Controls.Add(this.panel_splitLeft);
            this.panel_lowerPart.Location = new System.Drawing.Point(0, 39);
            this.panel_lowerPart.Name = "panel_lowerPart";
            this.panel_lowerPart.Size = new System.Drawing.Size(817, 405);
            this.panel_lowerPart.TabIndex = 0;
            // 
            // panel_splitRight
            // 
            this.panel_splitRight.BackColor = System.Drawing.SystemColors.Control;
            this.panel_splitRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_splitRight.Controls.Add(this.panel_comp);
            this.panel_splitRight.Controls.Add(this.label_comp);
            this.panel_splitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_splitRight.Location = new System.Drawing.Point(271, 0);
            this.panel_splitRight.Name = "panel_splitRight";
            this.panel_splitRight.Size = new System.Drawing.Size(544, 403);
            this.panel_splitRight.TabIndex = 2;
            // 
            // panel_comp
            // 
            this.panel_comp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_comp.AutoScroll = true;
            this.panel_comp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_comp.Location = new System.Drawing.Point(0, 26);
            this.panel_comp.Name = "panel_comp";
            this.panel_comp.Size = new System.Drawing.Size(544, 377);
            this.panel_comp.TabIndex = 7;
            // 
            // label_comp
            // 
            this.label_comp.AutoSize = true;
            this.label_comp.Location = new System.Drawing.Point(2, 0);
            this.label_comp.Name = "label_comp";
            this.label_comp.Size = new System.Drawing.Size(126, 23);
            this.label_comp.TabIndex = 6;
            this.label_comp.Text = "Kompetenzen";
            // 
            // splitter
            // 
            this.splitter.Location = new System.Drawing.Point(268, 0);
            this.splitter.MinExtra = 200;
            this.splitter.MinSize = 200;
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(3, 403);
            this.splitter.TabIndex = 1;
            this.splitter.TabStop = false;
            // 
            // panel_splitLeft
            // 
            this.panel_splitLeft.BackColor = System.Drawing.SystemColors.Control;
            this.panel_splitLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_splitLeft.Controls.Add(this.panel_Subjects);
            this.panel_splitLeft.Controls.Add(this.label_Subjects);
            this.panel_splitLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_splitLeft.Location = new System.Drawing.Point(0, 0);
            this.panel_splitLeft.Name = "panel_splitLeft";
            this.panel_splitLeft.Size = new System.Drawing.Size(268, 403);
            this.panel_splitLeft.TabIndex = 0;
            // 
            // panel_Subjects
            // 
            this.panel_Subjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Subjects.AutoScroll = true;
            this.panel_Subjects.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_Subjects.Controls.Add(this.button4);
            this.panel_Subjects.Controls.Add(this.button3);
            this.panel_Subjects.Controls.Add(this.button2);
            this.panel_Subjects.Controls.Add(this.button1);
            this.panel_Subjects.Location = new System.Drawing.Point(-2, 26);
            this.panel_Subjects.Name = "panel_Subjects";
            this.panel_Subjects.Size = new System.Drawing.Size(269, 377);
            this.panel_Subjects.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(5, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "Schreiben";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(5, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Lesen";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(5, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Deutsch";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(5, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mathe";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // label_Subjects
            // 
            this.label_Subjects.AutoSize = true;
            this.label_Subjects.Location = new System.Drawing.Point(1, 0);
            this.label_Subjects.Name = "label_Subjects";
            this.label_Subjects.Size = new System.Drawing.Size(149, 23);
            this.label_Subjects.TabIndex = 5;
            this.label_Subjects.Text = "Themenbereiche";
            // 
            // label_templateName
            // 
            this.label_templateName.AutoSize = true;
            this.label_templateName.Location = new System.Drawing.Point(3, 6);
            this.label_templateName.Name = "label_templateName";
            this.label_templateName.Size = new System.Drawing.Size(15, 23);
            this.label_templateName.TabIndex = 1;
            this.label_templateName.Text = "-";
            // 
            // label_nameOfStudent
            // 
            this.label_nameOfStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_nameOfStudent.AutoSize = true;
            this.label_nameOfStudent.Location = new System.Drawing.Point(349, 6);
            this.label_nameOfStudent.Name = "label_nameOfStudent";
            this.label_nameOfStudent.Size = new System.Drawing.Size(93, 23);
            this.label_nameOfStudent.TabIndex = 2;
            this.label_nameOfStudent.Text = "Schüler/in";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.AutoSize = true;
            this.btn_save.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_save.Location = new System.Drawing.Point(735, 450);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(79, 27);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_preview.AutoSize = true;
            this.btn_preview.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_preview.Location = new System.Drawing.Point(650, 450);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(79, 27);
            this.btn_preview.TabIndex = 6;
            this.btn_preview.Text = "Vorschau";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_new
            // 
            this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_new.AutoSize = true;
            this.btn_new.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_new.Location = new System.Drawing.Point(3, 450);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(122, 27);
            this.btn_new.TabIndex = 7;
            this.btn_new.Text = "Nächster Schüler";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto-Light", 9F);
            this.label1.Location = new System.Drawing.Point(340, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "made by |YourSunshine|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Datei wurde erfolgreich gespeichert";
            this.notifyIcon.BalloonTipTitle = "Gespeichert";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Kompetenzraster";
            this.notifyIcon.Visible = true;
            // 
            // tb_nName
            // 
            this.tb_nName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_nName.Cue = "Nachname";
            this.tb_nName.Location = new System.Drawing.Point(634, 3);
            this.tb_nName.Name = "tb_nName";
            this.tb_nName.Size = new System.Drawing.Size(180, 30);
            this.tb_nName.TabIndex = 4;
            // 
            // tb_vName
            // 
            this.tb_vName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_vName.Cue = "Vorname";
            this.tb_vName.Location = new System.Drawing.Point(448, 3);
            this.tb_vName.Name = "tb_vName";
            this.tb_vName.Size = new System.Drawing.Size(180, 30);
            this.tb_vName.TabIndex = 3;
            // 
            // EvaluateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_nName);
            this.Controls.Add(this.tb_vName);
            this.Controls.Add(this.label_nameOfStudent);
            this.Controls.Add(this.label_templateName);
            this.Controls.Add(this.panel_lowerPart);
            this.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(817, 480);
            this.Name = "EvaluateStudent";
            this.Size = new System.Drawing.Size(817, 480);
            this.panel_lowerPart.ResumeLayout(false);
            this.panel_splitRight.ResumeLayout(false);
            this.panel_splitRight.PerformLayout();
            this.panel_splitLeft.ResumeLayout(false);
            this.panel_splitLeft.PerformLayout();
            this.panel_Subjects.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_lowerPart;
        private System.Windows.Forms.Label label_templateName;
        private System.Windows.Forms.Label label_nameOfStudent;
        private CueTextBox tb_vName;
        private CueTextBox tb_nName;
        private System.Windows.Forms.Panel panel_splitLeft;
        private System.Windows.Forms.Panel panel_splitRight;
        private System.Windows.Forms.Label label_comp;
        private System.Windows.Forms.Label label_Subjects;
        private System.Windows.Forms.Panel panel_Subjects;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Panel panel_comp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}
