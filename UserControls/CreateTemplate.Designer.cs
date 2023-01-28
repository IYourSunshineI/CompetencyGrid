namespace CompetencyGrid.Forms {
    partial class CreateTemplate {
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
            this.labelPLZ = new System.Windows.Forms.Label();
            this.labelSKZ = new System.Windows.Forms.Label();
            this.labelOrt = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelKlasse = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.labelSchuljahr = new System.Windows.Forms.Label();
            this.tb_PLZ = new CueTextBox();
            this.tb_SKZ = new CueTextBox();
            this.tb_ort = new CueTextBox();
            this.tb_Adr = new CueTextBox();
            this.tb_semester = new CueTextBox();
            this.tb_schuljahr = new CueTextBox();
            this.tb_klasse = new CueTextBox();
            this.tb_fileName = new CueTextBox();
            this.SuspendLayout();
            // 
            // labelPLZ
            // 
            this.labelPLZ.AutoSize = true;
            this.labelPLZ.Location = new System.Drawing.Point(280, 114);
            this.labelPLZ.Name = "labelPLZ";
            this.labelPLZ.Size = new System.Drawing.Size(43, 23);
            this.labelPLZ.TabIndex = 39;
            this.labelPLZ.Text = "PLZ";
            // 
            // labelSKZ
            // 
            this.labelSKZ.AutoSize = true;
            this.labelSKZ.Location = new System.Drawing.Point(3, 114);
            this.labelSKZ.Name = "labelSKZ";
            this.labelSKZ.Size = new System.Drawing.Size(44, 23);
            this.labelSKZ.TabIndex = 37;
            this.labelSKZ.Text = "SKZ";
            // 
            // labelOrt
            // 
            this.labelOrt.AutoSize = true;
            this.labelOrt.Location = new System.Drawing.Point(280, 78);
            this.labelOrt.Name = "labelOrt";
            this.labelOrt.Size = new System.Drawing.Size(35, 23);
            this.labelOrt.TabIndex = 35;
            this.labelOrt.Text = "Ort";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(3, 150);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(79, 23);
            this.labelAdresse.TabIndex = 34;
            this.labelAdresse.Text = "Adresse";
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.Font = new System.Drawing.Font("Roboto-Light", 10F);
            this.btn_save.Location = new System.Drawing.Point(502, 331);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(79, 27);
            this.btn_save.TabIndex = 33;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 23);
            this.labelName.TabIndex = 24;
            this.labelName.Text = "Name";
            // 
            // labelKlasse
            // 
            this.labelKlasse.AutoSize = true;
            this.labelKlasse.Location = new System.Drawing.Point(3, 42);
            this.labelKlasse.Name = "labelKlasse";
            this.labelKlasse.Size = new System.Drawing.Size(66, 23);
            this.labelKlasse.TabIndex = 25;
            this.labelKlasse.Text = "Klasse";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Location = new System.Drawing.Point(3, 78);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(90, 23);
            this.labelSemester.TabIndex = 27;
            this.labelSemester.Text = "Semester";
            // 
            // labelSchuljahr
            // 
            this.labelSchuljahr.AutoSize = true;
            this.labelSchuljahr.Location = new System.Drawing.Point(280, 42);
            this.labelSchuljahr.Name = "labelSchuljahr";
            this.labelSchuljahr.Size = new System.Drawing.Size(85, 23);
            this.labelSchuljahr.TabIndex = 26;
            this.labelSchuljahr.Text = "Schuljahr";
            // 
            // tb_PLZ
            // 
            this.tb_PLZ.Cue = "";
            this.tb_PLZ.Location = new System.Drawing.Point(390, 111);
            this.tb_PLZ.Name = "tb_PLZ";
            this.tb_PLZ.Size = new System.Drawing.Size(191, 30);
            this.tb_PLZ.TabIndex = 7;
            this.tb_PLZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_SKZ
            // 
            this.tb_SKZ.Cue = "";
            this.tb_SKZ.Location = new System.Drawing.Point(109, 111);
            this.tb_SKZ.Name = "tb_SKZ";
            this.tb_SKZ.Size = new System.Drawing.Size(137, 30);
            this.tb_SKZ.TabIndex = 6;
            this.tb_SKZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_ort
            // 
            this.tb_ort.Cue = "";
            this.tb_ort.Location = new System.Drawing.Point(390, 75);
            this.tb_ort.Name = "tb_ort";
            this.tb_ort.Size = new System.Drawing.Size(191, 30);
            this.tb_ort.TabIndex = 5;
            this.tb_ort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_Adr
            // 
            this.tb_Adr.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Adr.Cue = "";
            this.tb_Adr.Location = new System.Drawing.Point(109, 147);
            this.tb_Adr.Name = "tb_Adr";
            this.tb_Adr.Size = new System.Drawing.Size(472, 30);
            this.tb_Adr.TabIndex = 8;
            this.tb_Adr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_semester
            // 
            this.tb_semester.Cue = "1 od. 2";
            this.tb_semester.Location = new System.Drawing.Point(109, 75);
            this.tb_semester.Name = "tb_semester";
            this.tb_semester.Size = new System.Drawing.Size(137, 30);
            this.tb_semester.TabIndex = 4;
            this.tb_semester.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_schuljahr
            // 
            this.tb_schuljahr.Cue = "z.b. 2022/23";
            this.tb_schuljahr.Location = new System.Drawing.Point(390, 39);
            this.tb_schuljahr.Name = "tb_schuljahr";
            this.tb_schuljahr.Size = new System.Drawing.Size(191, 30);
            this.tb_schuljahr.TabIndex = 3;
            this.tb_schuljahr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_klasse
            // 
            this.tb_klasse.Cue = "z.b. 1";
            this.tb_klasse.Location = new System.Drawing.Point(109, 39);
            this.tb_klasse.Name = "tb_klasse";
            this.tb_klasse.Size = new System.Drawing.Size(137, 30);
            this.tb_klasse.TabIndex = 2;
            this.tb_klasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_fileName
            // 
            this.tb_fileName.BackColor = System.Drawing.SystemColors.Window;
            this.tb_fileName.Cue = "z.b. Vorlage 1. Klasse";
            this.tb_fileName.Location = new System.Drawing.Point(109, 3);
            this.tb_fileName.Name = "tb_fileName";
            this.tb_fileName.Size = new System.Drawing.Size(472, 30);
            this.tb_fileName.TabIndex = 1;
            this.tb_fileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CreateTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_PLZ);
            this.Controls.Add(this.labelPLZ);
            this.Controls.Add(this.tb_SKZ);
            this.Controls.Add(this.labelSKZ);
            this.Controls.Add(this.tb_ort);
            this.Controls.Add(this.labelOrt);
            this.Controls.Add(this.tb_Adr);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_semester);
            this.Controls.Add(this.tb_schuljahr);
            this.Controls.Add(this.tb_klasse);
            this.Controls.Add(this.tb_fileName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelKlasse);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelSchuljahr);
            this.Font = new System.Drawing.Font("Roboto-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(584, 361);
            this.MinimumSize = new System.Drawing.Size(584, 361);
            this.Name = "CreateTemplate";
            this.Size = new System.Drawing.Size(584, 361);
            this.Load += new System.EventHandler(this.CreateTemplate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CueTextBox tb_PLZ;
        private System.Windows.Forms.Label labelPLZ;
        private CueTextBox tb_SKZ;
        private System.Windows.Forms.Label labelSKZ;
        private CueTextBox tb_ort;
        private System.Windows.Forms.Label labelOrt;
        private CueTextBox tb_Adr;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Button btn_save;
        private CueTextBox tb_semester;
        private CueTextBox tb_schuljahr;
        private CueTextBox tb_klasse;
        private CueTextBox tb_fileName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelKlasse;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label labelSchuljahr;
    }
}
