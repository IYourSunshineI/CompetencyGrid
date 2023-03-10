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

namespace CompetencyGrid.Forms {
    public partial class CreateSection : UserControl {
        CreateTemplateForm parent;
        private Template template;
        private Dictionary<string, string> sub;
        private List<string> currentComp;
        private Subject currentSub;
        private int currentSelectedIndex;
        private int compIndex;
        private string indent = "     ";
        private string old;

        public CreateSection() {
            InitializeComponent();
            sub = new Dictionary<string, string>();
        }

        public void init(Template template) {
            this.template = template;
            List<Subject> subjects = template.getSubjects();
            foreach (Subject subject in subjects) {
                listBox_subjects.Items.Add(subject.getName());
                if (subject.hasSubSections()) {
                    List<Subject> sub = subject.getSubSections();
                    foreach (Subject subSection in sub) {
                        this.sub[subSection.getName()] = subject.getName();
                        listBox_subjects.Items.Add(indent + subSection.getName());
                    }
                }
            }
        }

        public void addSubject(Subject temp) {
            if (currentSub == null) {
                template.addSubject(temp);
                listBox_subjects.Items.Add(temp.getName());
            } else {
                int index = template.getSubjectIndex(currentSub);
                template.insertSubject(index + 1, temp);
                listBox_subjects.Items.Insert(currentSelectedIndex + currentSub.getSubCount() + 1, temp.getName());
            }
        }

        public void addSubSubject(Subject temp) {
            currentSub.addSubSection(temp);
            sub[temp.getName()] = currentSub.getName();
            listBox_subjects.Items.Insert(currentSelectedIndex + currentSub.getSubCount(), indent + temp.getName());
        }

        private void btn_back_Click(object sender, EventArgs e) {
            parent.switchForm(this);
        }

        private void btn_addSubject_Click(object sender, EventArgs e) {
            NewSubjectForm temp = new NewSubjectForm(this, false);
            temp.Show();
        }

        private void btn_addSubSection_Click(object sender, EventArgs e) {
            if (currentSub == null) return;

            if (sub.ContainsKey(currentSub.getName())) return;

            NewSubjectForm temp = new NewSubjectForm(this, true);
            temp.Show();
        }

        private void btn_deleteSubject_Click(object sender, EventArgs e) {
            if (currentSub == null) return;
            string parent;
            try {
                parent = sub[currentSub.getName()];
            } catch (KeyNotFoundException) {
                template.removeSubject(currentSub);
                List<string> keyList = new List<string>();
                foreach (KeyValuePair<string, string> keyValuePair in sub) {
                    if (keyValuePair.Value.Equals(currentSub.getName())) {
                        keyList.Add(keyValuePair.Key);
                    }
                }
                foreach (string key in keyList) {
                    sub.Remove(key);
                    listBox_subjects.Items.Remove(indent + key);
                }
                listBox_subjects.Items.Remove(currentSub.getName());
                return;
            }

            Subject s = template.getSubject(parent);
            s.removeSubSection(currentSub);
            listBox_subjects.Items.Remove(indent + currentSub.getName());

            Console.Write(template);
        }

        //go back in comps list
        private void btn_previous_Click(object sender, EventArgs e) {
            if (currentComp == null) return;

            if (compIndex == 0) return;

            if (compIndex > 0) {
                compIndex--;
                old = currentComp[compIndex];
                tb_competence.Text = old;
                label_competenceNumber.Text = (compIndex + 1).ToString()
                    + ". Kompetenz in " + currentSub.getName();
            }
        }

        //go to next on comps list
        private void next() {
            if (currentComp == null) return;

            if (compIndex < currentComp.Count - 1) {
                compIndex++;
                old = currentComp[compIndex];
                tb_competence.Text = old;
                label_competenceNumber.Text = (compIndex + 1).ToString()
                    + ". Kompetenz in " + currentSub.getName(); ;
                return;
            }
            if (compIndex == currentComp.Count - 1) {
                old = string.Empty;
                tb_competence.Text = old;
                compIndex++;
                label_competenceNumber.Text = (compIndex + 1).ToString()
                    + ". Kompetenz in " + currentSub.getName();
            }
        }
        private void btn_next_Click(object sender, EventArgs e) {
            next();
        }

        //adds the new comp to the list or updates the changed one
        private void btn_save_Click(object sender, EventArgs e) {
            if (currentComp == null) return;

            if (tb_competence.Text.Equals(old)) return;

            if (string.IsNullOrEmpty(old)) {
                currentSub.addCompetence(tb_competence.Text);
            } else {
                if (string.IsNullOrEmpty(tb_competence.Text)) {
                    currentComp.Remove(old);
                } else {
                    currentComp[compIndex] = tb_competence.Text;
                }
            }
            next();

            Console.Write(template);
        }

        //save the template as it is
        private void btn_done_Click(object sender, EventArgs e) {
            parent.done();
        }

        private void CreateSection_Load(object sender, EventArgs e) {
            parent = ParentForm as CreateTemplateForm;
            label_competenceNumber.Text = "-";
            tb_competence.ReadOnly = true;
        }

        private void CreateSection_Enter(object sender, EventArgs e) {
            if (template == null) {
                template = parent.getTemplate();
            }
        }

        private void listBox_subjects_SelectedIndexChanged(object sender, EventArgs e) {
            //reset/set currentComp to newly selected comps
            if (listBox_subjects.SelectedItem == null)
                return;

            string subject = listBox_subjects.SelectedItem.ToString();
            subject = subject.Trim();
            currentSub = template.getSubject(subject);
            currentComp = currentSub.getCompetencies();
            currentSelectedIndex = listBox_subjects.SelectedIndex;
            compIndex = 0;
            if (currentComp == null) {
                label_competenceNumber.Text = "-";
                tb_competence.Text = string.Empty;
                tb_competence.ReadOnly = true;
                return;
            } else {
                tb_competence.ReadOnly = false;
            }
            label_competenceNumber.Text = compIndex + 1 + ". Kompetenz in " + currentSub.getName();
            if (currentComp.Count() == 0) {
                old = string.Empty;
                tb_competence.Text = old;
            } else {
                old = currentComp[compIndex];
                tb_competence.Text = old;
            }
        }

        private void btn_preview_Click(object sender, EventArgs e) {
            Printer.printToPDF("PDFs", template);
            System.Diagnostics.Process.Start(Application.StartupPath + "/PDFs/" + template.getName() + ".pdf");
        }

        private void btn_addDetails_Click(object sender, EventArgs e) {
            if (currentSub == null) return;

            try {
                string sub = this.sub[currentSub.getName()];
                return;
            } catch (KeyNotFoundException) {
                AddDetailsForm temp = new AddDetailsForm(currentSub);
                temp.Show();
            }

        }
    }
}