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
            this.labelName = new System.Windows.Forms.Label();
            this.labelKlasse = new System.Windows.Forms.Label();
            this.labelSchuljahr = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.panel_create = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.tb_header = new CueTextBox();
            this.tb_semester = new CueTextBox();
            this.tb_schuljahr = new CueTextBox();
            this.tb_klasse = new CueTextBox();
            this.tb_fileName = new CueTextBox();
            this.panel_create.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelKlasse
            // 
            this.labelKlasse.AutoSize = true;
            this.labelKlasse.Location = new System.Drawing.Point(12, 51);
            this.labelKlasse.Name = "labelKlasse";
            this.labelKlasse.Size = new System.Drawing.Size(66, 23);
            this.labelKlasse.TabIndex = 2;
            this.labelKlasse.Text = "Klasse";
            // 
            // labelSchuljahr
            // 
            this.labelSchuljahr.AutoSize = true;
            this.labelSchuljahr.Location = new System.Drawing.Point(246, 51);
            this.labelSchuljahr.Name = "labelSchuljahr";
            this.labelSchuljahr.Size = new System.Drawing.Size(85, 23);
            this.labelSchuljahr.TabIndex = 5;
            this.labelSchuljahr.Text = "Schuljahr";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Location = new System.Drawing.Point(12, 87);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(90, 23);
            this.labelSemester.TabIndex = 8;
            this.labelSemester.Text = "Semester";
            // 
            // panel_create
            // 
            this.panel_create.Controls.Add(this.tb_header);
            this.panel_create.Controls.Add(this.labelHeader);
            this.panel_create.Controls.Add(this.btn_save);
            this.panel_create.Controls.Add(this.tb_semester);
            this.panel_create.Controls.Add(this.tb_schuljahr);
            this.panel_create.Controls.Add(this.tb_klasse);
            this.panel_create.Controls.Add(this.tb_fileName);
            this.panel_create.Controls.Add(this.labelName);
            this.panel_create.Controls.Add(this.labelKlasse);
            this.panel_create.Controls.Add(this.labelSemester);
            this.panel_create.Controls.Add(this.labelSchuljahr);
            this.panel_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_create.Location = new System.Drawing.Point(0, 0);
            this.panel_create.Name = "panel_create";
            this.panel_create.Size = new System.Drawing.Size(584, 361);
            this.panel_create.TabIndex = 11;
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_save.Location = new System.Drawing.Point(493, 322);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(79, 27);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(12, 123);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(70, 23);
            this.labelHeader.TabIndex = 16;
            this.labelHeader.Text = "Header";
            // 
            // tb_header
            // 
            this.tb_header.BackColor = System.Drawing.SystemColors.Window;
            this.tb_header.Cue = "Schule, SKZ, Adr.";
            this.tb_header.Location = new System.Drawing.Point(119, 120);
            this.tb_header.Name = "tb_header";
            this.tb_header.Size = new System.Drawing.Size(453, 30);
            this.tb_header.TabIndex = 15;
            this.tb_header.Text = "Volksschule Würflach, SKZ: 318.501, 2732 Würflach, Neunkirchner Str. 76";
            this.tb_header.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_semester
            // 
            this.tb_semester.Cue = "1 od. 2";
            this.tb_semester.Location = new System.Drawing.Point(119, 84);
            this.tb_semester.Name = "tb_semester";
            this.tb_semester.Size = new System.Drawing.Size(121, 30);
            this.tb_semester.TabIndex = 14;
            this.tb_semester.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_schuljahr
            // 
            this.tb_schuljahr.Cue = "z.b. 2022/23";
            this.tb_schuljahr.Location = new System.Drawing.Point(337, 51);
            this.tb_schuljahr.Name = "tb_schuljahr";
            this.tb_schuljahr.Size = new System.Drawing.Size(121, 30);
            this.tb_schuljahr.TabIndex = 13;
            this.tb_schuljahr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_klasse
            // 
            this.tb_klasse.Cue = "z.b. 1";
            this.tb_klasse.Location = new System.Drawing.Point(119, 48);
            this.tb_klasse.Name = "tb_klasse";
            this.tb_klasse.Size = new System.Drawing.Size(121, 30);
            this.tb_klasse.TabIndex = 12;
            this.tb_klasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_fileName
            // 
            this.tb_fileName.BackColor = System.Drawing.SystemColors.Window;
            this.tb_fileName.Cue = "z.b. Vorlage 1. Klasse";
            this.tb_fileName.Location = new System.Drawing.Point(119, 12);
            this.tb_fileName.Name = "tb_fileName";
            this.tb_fileName.Size = new System.Drawing.Size(453, 30);
            this.tb_fileName.TabIndex = 11;
            this.tb_fileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CreateTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel_create);
            this.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "CreateTemplateForm";
            this.Text = "Vorlage erstellen";
            this.panel_create.ResumeLayout(false);
            this.panel_create.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelKlasse;
        private System.Windows.Forms.Label labelSchuljahr;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Panel panel_create;
        private CueTextBox tb_semester;
        private CueTextBox tb_schuljahr;
        private CueTextBox tb_klasse;
        private CueTextBox tb_fileName;
        private System.Windows.Forms.Button btn_save;
        private CueTextBox tb_header;
        private System.Windows.Forms.Label labelHeader;
    }
}