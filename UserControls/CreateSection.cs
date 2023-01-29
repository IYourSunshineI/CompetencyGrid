﻿using CompetencyGrid.Classes;
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

        public CreateSection() {
            InitializeComponent();
            sub = new Dictionary<string, string>();
            currentComp = new List<string>();
        }

        public void addSubject(Subject temp) {
            template.addSubject(temp);
            listBox_subjects.Items.Add(temp.getName());
        }

        public void addSubSubject(Subject temp) {
            currentSub.addSubSection(temp);
            sub[temp.getName()] = currentSub.getName();
            listBox_subjects.Items.Insert(currentSelectedIndex + 1, indent + temp.getName());

            /*
            string currentSelected = listBox_subjects.SelectedItem.ToString();
            int index = listBox_subjects.Items.IndexOf(currentSelected);
            List<Subject> subjects = template.getSubjects();
            foreach (Subject s in subjects) {
                if (s.getName().Equals(currentSelected)) {
                    s.addSubSection(temp);
                    return;
                }
            }*/
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

            /*
            if (listBox_subjects.SelectedItem == null)
                return;

            string subSection = listBox_subjects.SelectedItem.ToString();
            subSection = subSection.Trim();
            if (!sub.ContainsKey(subSection)) {
                NewSubjectForm temp = new NewSubjectForm(this, true);
                temp.Show();
            }*/
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


        private void btn_previous_Click(object sender, EventArgs e) {
        }

        private void btn_next_Click(object sender, EventArgs e) {
            if (currentComp == null) return;

            if(compIndex < currentComp.Count - 1) {
                compIndex++;
                tb_competence.Text = currentComp[compIndex];
                label_competenceNumber.Text = (compIndex + 1).ToString() 
                    + ". Kompetenz im Themenbereich " + currentSub.getName(); ;
                return;
            }
            if(compIndex == currentComp.Count - 1) {
                tb_competence.Text = string.Empty;
                compIndex++;
                label_competenceNumber.Text = (compIndex + 1).ToString() 
                    + ". Kompetenz im Themenbereich " + currentSub.getName(); ;
                return;
            }


            string content = tb_competence.Text;
            if (content == null || content == string.Empty) return;

            currentSub.addCompetence(content);
            compIndex++;
            label_competenceNumber.Text = (compIndex + 1).ToString() 
                + ". Kompetenz im Themenbereich " + currentSub.getName();
            tb_competence.Text = string.Empty;
            Console.Write(template);
        }

        private void btn_save_Click(object sender, EventArgs e) {

        }

        private void CreateSection_Load(object sender, EventArgs e) {
            parent = ParentForm as CreateTemplateForm;
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
            if(currentComp == null) {
                label_competenceNumber.Text = "-";
                tb_competence.ReadOnly = true;
                return;
            } else {
                tb_competence.ReadOnly = false;
            }
            label_competenceNumber.Text = compIndex + 1 + ". Kompetenz im Themenbereich " + currentSub.getName();
            if(currentComp.Count() == 0) {
                tb_competence.Text = string.Empty;
            } else {
                tb_competence.Text = currentComp[compIndex];
            }
        }
    }
}

