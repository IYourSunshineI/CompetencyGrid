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
            this.panel_createSection = new System.Windows.Forms.Panel();
            this.btn_abort = new System.Windows.Forms.Button();
            this.btn_deleteSubject = new System.Windows.Forms.Button();
            this.btn_addSubject = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.listBox_subjects = new System.Windows.Forms.ListBox();
            this.label_competenceNumber = new System.Windows.Forms.Label();
            this.tb_competence = new System.Windows.Forms.TextBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_header = new CueTextBox();
            this.tb_semester = new CueTextBox();
            this.tb_schuljahr = new CueTextBox();
            this.tb_klasse = new CueTextBox();
            this.tb_fileName = new CueTextBox();
            this.panel_create.SuspendLayout();
            this.panel_createSection.SuspendLayout();
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
            this.panel_create.Controls.Add(this.panel_createSection);
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
            // panel_createSection
            // 
            this.panel_createSection.Controls.Add(this.btn_abort);
            this.panel_createSection.Controls.Add(this.btn_deleteSubject);
            this.panel_createSection.Controls.Add(this.btn_addSubject);
            this.panel_createSection.Controls.Add(this.btn_previous);
            this.panel_createSection.Controls.Add(this.btn_next);
            this.panel_createSection.Controls.Add(this.btn_done);
            this.panel_createSection.Controls.Add(this.listBox_subjects);
            this.panel_createSection.Controls.Add(this.label_competenceNumber);
            this.panel_createSection.Controls.Add(this.tb_competence);
            this.panel_createSection.Location = new System.Drawing.Point(0, 0);
            this.panel_createSection.Name = "panel_createSection";
            this.panel_createSection.Size = new System.Drawing.Size(584, 361);
            this.panel_createSection.TabIndex = 17;
            this.panel_createSection.Visible = false;
            // 
            // btn_abort
            // 
            this.btn_abort.AutoSize = true;
            this.btn_abort.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_abort.Location = new System.Drawing.Point(16, 322);
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.Size = new System.Drawing.Size(85, 27);
            this.btn_abort.TabIndex = 5;
            this.btn_abort.Text = "Abbrechen";
            this.btn_abort.UseVisualStyleBackColor = true;
            this.btn_abort.Click += new System.EventHandler(this.btn_abort_Click);
            // 
            // btn_deleteSubject
            // 
            this.btn_deleteSubject.AutoSize = true;
            this.btn_deleteSubject.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_deleteSubject.Location = new System.Drawing.Point(250, 45);
            this.btn_deleteSubject.Name = "btn_deleteSubject";
            this.btn_deleteSubject.Size = new System.Drawing.Size(164, 27);
            this.btn_deleteSubject.TabIndex = 3;
            this.btn_deleteSubject.Text = "Themenbereich löschen";
            this.btn_deleteSubject.UseVisualStyleBackColor = true;
            //this.btn_deleteSubject.Click += new System.EventHandler(this.btn_deleteSubject_Click);
            // 
            // btn_addSubject
            // 
            this.btn_addSubject.AutoSize = true;
            this.btn_addSubject.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_addSubject.Location = new System.Drawing.Point(250, 12);
            this.btn_addSubject.Name = "btn_addSubject";
            this.btn_addSubject.Size = new System.Drawing.Size(164, 27);
            this.btn_addSubject.TabIndex = 2;
            this.btn_addSubject.Text = "Neuer Themenbereich";
            this.btn_addSubject.UseVisualStyleBackColor = true;
            this.btn_addSubject.Click += new System.EventHandler(this.btn_addSubject_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.AutoSize = true;
            this.btn_previous.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_previous.Location = new System.Drawing.Point(305, 322);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(85, 27);
            this.btn_previous.TabIndex = 6;
            this.btn_previous.Text = "Vorherige";
            this.btn_previous.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.AutoSize = true;
            this.btn_next.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_next.Location = new System.Drawing.Point(396, 322);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(85, 27);
            this.btn_next.TabIndex = 7;
            this.btn_next.Text = "Nächste";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_done
            // 
            this.btn_done.AutoSize = true;
            this.btn_done.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_done.Location = new System.Drawing.Point(487, 322);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(85, 27);
            this.btn_done.TabIndex = 8;
            this.btn_done.Text = "Fertig";
            this.btn_done.UseVisualStyleBackColor = true;
            // 
            // listBox_subjects
            // 
            this.listBox_subjects.FormattingEnabled = true;
            this.listBox_subjects.ItemHeight = 23;
            this.listBox_subjects.Location = new System.Drawing.Point(19, 12);
            this.listBox_subjects.Name = "listBox_subjects";
            this.listBox_subjects.Size = new System.Drawing.Size(221, 96);
            this.listBox_subjects.TabIndex = 1;
            this.listBox_subjects.SelectedIndexChanged += new System.EventHandler(this.listBox_subjects_SelectedIndexChanged);
            // 
            // label_competenceNumber
            // 
            this.label_competenceNumber.AutoSize = true;
            this.label_competenceNumber.Location = new System.Drawing.Point(12, 123);
            this.label_competenceNumber.Name = "label_competenceNumber";
            this.label_competenceNumber.Size = new System.Drawing.Size(358, 23);
            this.label_competenceNumber.TabIndex = 1;
            this.label_competenceNumber.Text = "1. Kompetenz im Themenbereich Religion";
            // 
            // tb_competence
            // 
            this.tb_competence.Location = new System.Drawing.Point(16, 156);
            this.tb_competence.Multiline = true;
            this.tb_competence.Name = "tb_competence";
            this.tb_competence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_competence.Size = new System.Drawing.Size(556, 160);
            this.tb_competence.TabIndex = 4;
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
            this.panel_createSection.ResumeLayout(false);
            this.panel_createSection.PerformLayout();
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
        private System.Windows.Forms.Panel panel_createSection;
        private System.Windows.Forms.ListBox listBox_subjects;
        private System.Windows.Forms.Label label_competenceNumber;
        private System.Windows.Forms.TextBox tb_competence;
        private System.Windows.Forms.Button btn_deleteSubject;
        private System.Windows.Forms.Button btn_addSubject;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Button btn_abort;
    }
}