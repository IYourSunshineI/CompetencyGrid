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

        public CreateSection() {
            InitializeComponent();
            sub = new Dictionary<string, string>();
        }

        public void addSubject(Subject temp) {
            template.addSubject(temp);
            listBox_subjects.Items.Add(temp.getName());

            Console.Write(template);
        }

        public void addSubSubject(Subject temp) {
            string currentSelected = listBox_subjects.SelectedItem.ToString();
            int index = listBox_subjects.Items.IndexOf(currentSelected);
            List<Subject> subjects = template.getSubjects();
            foreach (Subject s in subjects) {
                if (s.getName().Equals(currentSelected)) {
                    s.addSubSection(temp);
                    sub[temp.getName()] = s.getName();
                    listBox_subjects.Items.Insert(index + 1, "     " + temp.getName());
                    return;
                }
            }
        }


        private void btn_back_Click(object sender, EventArgs e) {
            parent.switchForm(this);
        }

        private void btn_addSubject_Click(object sender, EventArgs e) {
            NewSubjectForm temp = new NewSubjectForm(this, false);
            temp.Show();
        }

        private void btn_addSubSection_Click(object sender, EventArgs e) {
            if (listBox_subjects.SelectedItem != null) {
                NewSubjectForm temp = new NewSubjectForm(this, true);
                temp.Show();
            }
        }

        private void btn_deleteSubject_Click(object sender, EventArgs e) {
            if (listBox_subjects.SelectedItem != null) {
                string toDelete = listBox_subjects.SelectedItem.ToString();
                toDelete = toDelete.Trim();
                string parentS;
                try {
                    parentS = sub[toDelete];
                } catch (KeyNotFoundException) {
                    template.removeSubject(toDelete);
                    listBox_subjects.Items.Remove(toDelete);
                    return;
                }
                List<Subject> list = template.getSubjects();
                foreach (Subject s in list) {
                    if (s.getName().Equals(parentS)) {
                        s.removeSubSection(toDelete);
                        listBox_subjects.Items.Remove("     " + toDelete);
                        break;
                    }
                }
            }
        }

        private void btn_previous_Click(object sender, EventArgs e) {

        }

        private void btn_next_Click(object sender, EventArgs e) {

        }

        private void btn_done_Click(object sender, EventArgs e) {

        }

        private void CreateSection_Load(object sender, EventArgs e) {
            parent = ParentForm as CreateTemplateForm;
        }

        private void CreateSection_Enter(object sender, EventArgs e) {
            if (template == null) {
                template = parent.getTemplate();
            }
        }
    }
}
