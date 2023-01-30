namespace CompetencyGrid.Forms {
    partial class CreateSection {
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_deleteSubject = new System.Windows.Forms.Button();
            this.btn_addSubject = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.listBox_subjects = new System.Windows.Forms.ListBox();
            this.label_competenceNumber = new System.Windows.Forms.Label();
            this.tb_competence = new System.Windows.Forms.TextBox();
            this.btn_addSubSection = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.AutoSize = true;
            this.btn_back.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_back.Location = new System.Drawing.Point(3, 331);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 27);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_deleteSubject
            // 
            this.btn_deleteSubject.AutoSize = true;
            this.btn_deleteSubject.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_deleteSubject.Location = new System.Drawing.Point(234, 69);
            this.btn_deleteSubject.Name = "btn_deleteSubject";
            this.btn_deleteSubject.Size = new System.Drawing.Size(180, 27);
            this.btn_deleteSubject.TabIndex = 3;
            this.btn_deleteSubject.Text = "Themenbereich löschen";
            this.btn_deleteSubject.UseVisualStyleBackColor = true;
            this.btn_deleteSubject.Click += new System.EventHandler(this.btn_deleteSubject_Click);
            // 
            // btn_addSubject
            // 
            this.btn_addSubject.AutoSize = true;
            this.btn_addSubject.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_addSubject.Location = new System.Drawing.Point(234, 3);
            this.btn_addSubject.Name = "btn_addSubject";
            this.btn_addSubject.Size = new System.Drawing.Size(180, 27);
            this.btn_addSubject.TabIndex = 1;
            this.btn_addSubject.Text = "Neuer Themenbereich";
            this.btn_addSubject.UseVisualStyleBackColor = true;
            this.btn_addSubject.Click += new System.EventHandler(this.btn_addSubject_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.AutoSize = true;
            this.btn_previous.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_previous.Location = new System.Drawing.Point(223, 331);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(85, 27);
            this.btn_previous.TabIndex = 6;
            this.btn_previous.Text = "Vorherige";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.AutoSize = true;
            this.btn_next.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_next.Location = new System.Drawing.Point(314, 331);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(85, 27);
            this.btn_next.TabIndex = 7;
            this.btn_next.Text = "Nächste";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_save.Location = new System.Drawing.Point(405, 331);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(85, 27);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // listBox_subjects
            // 
            this.listBox_subjects.FormattingEnabled = true;
            this.listBox_subjects.ItemHeight = 23;
            this.listBox_subjects.Location = new System.Drawing.Point(3, 3);
            this.listBox_subjects.Name = "listBox_subjects";
            this.listBox_subjects.Size = new System.Drawing.Size(221, 96);
            this.listBox_subjects.TabIndex = 9;
            this.listBox_subjects.SelectedIndexChanged += new System.EventHandler(this.listBox_subjects_SelectedIndexChanged);
            // 
            // label_competenceNumber
            // 
            this.label_competenceNumber.AutoSize = true;
            this.label_competenceNumber.Location = new System.Drawing.Point(-1, 121);
            this.label_competenceNumber.Name = "label_competenceNumber";
            this.label_competenceNumber.Size = new System.Drawing.Size(358, 23);
            this.label_competenceNumber.TabIndex = 10;
            this.label_competenceNumber.Text = "1. Kompetenz im Themenbereich Religion";
            // 
            // tb_competence
            // 
            this.tb_competence.Location = new System.Drawing.Point(3, 147);
            this.tb_competence.Multiline = true;
            this.tb_competence.Name = "tb_competence";
            this.tb_competence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_competence.Size = new System.Drawing.Size(578, 178);
            this.tb_competence.TabIndex = 4;
            // 
            // btn_addSubSection
            // 
            this.btn_addSubSection.AutoSize = true;
            this.btn_addSubSection.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_addSubSection.Location = new System.Drawing.Point(234, 36);
            this.btn_addSubSection.Name = "btn_addSubSection";
            this.btn_addSubSection.Size = new System.Drawing.Size(180, 27);
            this.btn_addSubSection.TabIndex = 2;
            this.btn_addSubSection.Text = "Unterkategorie hinzufügen";
            this.btn_addSubSection.UseVisualStyleBackColor = true;
            this.btn_addSubSection.Click += new System.EventHandler(this.btn_addSubSection_Click);
            // 
            // btn_done
            // 
            this.btn_done.AutoSize = true;
            this.btn_done.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_done.Location = new System.Drawing.Point(496, 331);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(85, 27);
            this.btn_done.TabIndex = 9;
            this.btn_done.Text = "Fertig";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // CreateSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.btn_addSubSection);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_deleteSubject);
            this.Controls.Add(this.btn_addSubject);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.listBox_subjects);
            this.Controls.Add(this.label_competenceNumber);
            this.Controls.Add(this.tb_competence);
            this.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(584, 361);
            this.MinimumSize = new System.Drawing.Size(584, 361);
            this.Name = "CreateSection";
            this.Size = new System.Drawing.Size(584, 361);
            this.Load += new System.EventHandler(this.CreateSection_Load);
            this.Enter += new System.EventHandler(this.CreateSection_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_deleteSubject;
        private System.Windows.Forms.Button btn_addSubject;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ListBox listBox_subjects;
        private System.Windows.Forms.Label label_competenceNumber;
        private System.Windows.Forms.TextBox tb_competence;
        private System.Windows.Forms.Button btn_addSubSection;
        private System.Windows.Forms.Button btn_done;
    }
}
