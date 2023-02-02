using CompetencyGrid.Classes;
using CompetencyGrid.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompetencyGrid.UserControls {
    public partial class EvaluateStudent : UserControl {
        private List<Subject> subjects;
        private Subject activeSubject;
        private CompetencyForm form;
        private Template template;
        private bool saved = false;
        public EvaluateStudent() {
            InitializeComponent();
            this.Enabled = false;
            panel_splitRight.Enabled = false;
            btn_save.Click += lastClickedHandler;
        }

        public void init(Template template) {
            this.template = template;
            form = new CompetencyForm(template);
            this.Enabled = true;
            label_templateName.Text = form.getTemplateName();
            this.subjects = form.getSubjects();
            panel_comp.Controls.Clear();
            initSubjects();
        }

        public void init(CompetencyForm form) {
            this.template = form.GetTemplate();
            this.form = form;
            this.Enabled = true;
            label_templateName.Text = form.getTemplateName();
            this.subjects = form.getSubjects();
            tb_vName.Text = form.getVName();
            tb_nName.Text = form.getNName();
            panel_comp.Controls.Clear();
            initSubjects();
        }

        private void initSubjects() {
            panel_Subjects.Controls.Clear();

            int pY = 3;
            foreach (Subject subject in subjects) {
                Button b = new Button();
                b.Name = "btn_" + subject.getName();
                b.Location = new Point(5, pY);
                b.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                b.Size = new Size(260, 33);
                b.Text = subject.getName();
                b.AutoEllipsis = true;
                b.TextAlign = ContentAlignment.MiddleLeft;
                b.BackColor = Color.FromArgb(255, 192, 192);
                b.Click += subjectClickHandler;
                panel_Subjects.Controls.Add(b);
                pY += 39;

                if (subject.hasSubSections()) {
                    b.Enabled = false;
                    b.BackColor = Color.White;
                    List<Subject> subSubjects = subject.getSubSections();
                    foreach (Subject subSubject in subSubjects) {
                        Button subb = new Button();
                        subb.Name = "btn_" + subSubject.getName();
                        subb.Location = new Point(5, pY);
                        subb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                        subb.Size = new Size(260, 33);
                        subb.Text = subSubject.getName();
                        subb.AutoEllipsis = true;
                        subb.TextAlign = ContentAlignment.MiddleRight;
                        subb.BackColor = Color.FromArgb(255, 192, 192);
                        subb.Click += subjectClickHandler;
                        panel_Subjects.Controls.Add(subb);
                        pY += 39;
                    }
                }
            }
        }

        private void initComp(Subject subject) {
            panel_splitRight.Enabled = true;
            panel_comp.Controls.Clear();
            label_comp.Text = "Kompetenzen in " + subject.getName();

            List<string> comps = subject.getCompetencies();
            int pY = 10;
            foreach (string comp in comps) {
                CompScore eval = new CompScore(this);
                eval.Name = "eval_" + comp;
                eval.Location = new Point(6, pY);
                eval.Size = new Size(panel_comp.Width - 12, 150);
                eval.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                eval.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                eval.tb.Text = comp;
                panel_comp.Controls.Add(eval);

                int score = subject.getCompScore(comp);
                foreach (RadioButton rb in eval.panel.Controls.OfType<RadioButton>()) {
                    if (rb.Text.Equals(score.ToString())) {
                        rb.Checked = true;
                    }
                }
                pY += 160;
            }
        }

        public void changeCompScore(string comp, int value) {
            activeSubject.changeCompScore(comp, value);
        }

        private void subjectClickHandler(object sender, EventArgs e) {
            Button b = sender as Button;
            b.BackColor = Color.FromArgb(192, 255, 192);
            string name = b.Text;
            activeSubject = form.getSubject(name);
            initComp(activeSubject);
        }

        private void btn_save_Click(object sender, EventArgs e) {
            bool flag = false;
            if (string.IsNullOrEmpty(tb_vName.Text)) {
                tb_vName.BackColor = Color.FromArgb(255, 192, 192);
                flag = true;
            } else
                tb_vName.BackColor = Color.White;
            if (string.IsNullOrEmpty(tb_nName.Text)) {
                tb_nName.BackColor = Color.FromArgb(255, 192, 192);
                flag = true;
            } else
                tb_nName.BackColor = Color.White;
            if (flag) return;

            form.setName(tb_vName.Text, tb_nName.Text);
            ObjectManager.SaveObject<CompetencyForm>(form, "Students", form.getName() + ".xml");
            Printer.printToPDF("PDFs/Students", form);
            notifyIcon.BalloonTipText = form.getName() + ".pdf wurde erfolgreich gespeichert";
            notifyIcon.ShowBalloonTip(1000);
        }

        private void btn_preview_Click(object sender, EventArgs e) {
            bool flag = false;
            if (string.IsNullOrEmpty(tb_vName.Text)) {
                tb_vName.BackColor = Color.FromArgb(255, 192, 192);
                flag = true;
            } else
                tb_vName.BackColor = Color.White;
            if (string.IsNullOrEmpty(tb_nName.Text)) {
                tb_nName.BackColor = Color.FromArgb(255, 192, 192);
                flag = true;
            } else
                tb_nName.BackColor = Color.White;
            if (flag) return;

            form.setName(tb_vName.Text, tb_nName.Text);
            Printer.printToPDF("PDFs/Students", form);
            System.Diagnostics.Process.Start(Application.StartupPath + "/PDFs/Students/" + form.getName() + ".pdf");
        }

        private void btn_new_Click(object sender, EventArgs e) {
            if (!saved) {
                WarningForm w = new WarningForm(this);
                w.Show();
            } else {
                newStudent();
            }
        }

        public void newStudent() {
            panel_comp.Controls.Clear();
            tb_nName.Text = string.Empty;
            tb_vName.Text = string.Empty;
            init(template);
        }

        public void lastClickedHandler(object sender, EventArgs e) {
            if (sender.GetType() == typeof(Button)) {
                Button b = sender as Button;
                if (b.Text.Equals("Speichern"))
                    saved = true;
                else
                    saved = false;
            }
            if (sender.GetType() == typeof(RadioButton)) {
                saved = false;
            }
        }
    }
}
