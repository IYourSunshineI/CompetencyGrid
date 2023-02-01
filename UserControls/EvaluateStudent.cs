using CompetencyGrid.Classes;
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
        private Template template;
        private List<Subject> subjects;
        private Subject activeSubject;
        public EvaluateStudent() {
            InitializeComponent();
            this.Enabled = false;
            panel_splitRight.Enabled = false;
        }

        public void init(Template template) {
            this.template = template;
            this.subjects = template.getSubjects();
            this.Enabled = true;
            label_templateName.Text = template.getName();
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
                    List<Subject> subSubjects = subject.getSubSections();
                    foreach (Subject subSubject in subSubjects) {
                        Button subb = new Button();
                        subb.Name = "btn_" + subSubject.getName();
                        subb.Location = new Point(5, pY);
                        subb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                        subb.Size = new Size(260, 33);
                        subb.Text = subSubject.getName();
                        subb.AutoEllipsis = true;
                        subb.TextAlign = ContentAlignment.MiddleCenter;
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
            string name = b.Text;
            activeSubject = template.getSubject(name);
            initComp(activeSubject);
        }
    }
}
