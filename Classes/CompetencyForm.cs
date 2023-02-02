using CompetencyGrid.Classes;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CompetencyGrid {

    [DataContract]
    public class CompetencyForm : MyDocument {
        [DataMember]
        private string vName;
        [DataMember]
        private string nName;
        [DataMember]
        private string name;
        [DataMember]
        private Template template;
        [DataMember]
        private string SKZ;
        [DataMember]
        private string ort;
        [DataMember]
        private string plz;
        [DataMember]
        private string adr;
        [DataMember]
        private string description;
        [DataMember]
        private string klasse;
        [DataMember]
        private string schoolYear;
        [DataMember]
        private string semester;
        [DataMember]
        List<Subject> subjects;

        public CompetencyForm(Template template) {
            this.template = template;
            SKZ = template.getSKZ();
            ort = template.getOrt();
            plz = template.getPlz();
            adr = template.getAdr();
            klasse = template.getKlasse();
            schoolYear = template.getSchoolYear();
            semester = template.getSemester();
            subjects = ObjectManager.deepCopy<List<Subject>>(template.getSubjects());
        }

        public CompetencyForm(string vName, string nName, Template template) {
            this.vName = vName;
            this.nName = nName;
            name = vName + nName;
            this.template = template;
            SKZ = template.getSKZ();
            ort = template.getOrt();
            plz = template.getPlz();
            adr = template.getAdr();
            klasse = template.getKlasse();
            schoolYear = template.getSchoolYear();
            semester = template.getSemester();
            subjects = ObjectManager.deepCopy<List<Subject>>(template.getSubjects());
        }

        public void setName(string vName, string nName) {
            this.vName = vName;
            this.nName = nName;
            name = vName + nName;
        }

        public string getTemplateName() {
            return template.getName();
        }

        public string getDescription() {
            if (description == null) {
                description = "Schriftliche Erläuterung/Kompetenzkatalog für " + vName + " " + nName +
                    "\nSchüler/in der " + klasse + ". Klasse im " + semester + ". Semester";
            }
            return description;
        }

        public string getHeader() {
            return "Volksschule " + ort + ", SKZ: " + SKZ + ", " + plz + " " +
                ort + ", " + adr + ", Schuljahr " + schoolYear;
        }

        public string getName() {
            return name;
        }

        public string getNName() {
            return nName;
        }

        public string getOrt() {
            return ort;
        }

        public Subject getSubject(string name) {
            foreach (Subject s in subjects) {
                if (s.getName().Equals(name)) {
                    return s;
                }
                if (s.hasSubSections()) {
                    Subject temp = s.getSubSection(name);
                    if (temp != null)
                        return temp;
                }
            }
            return null;
        }

        public List<Subject> getSubjects() {
            return subjects;
        }

        public string getVName() {
            return vName;
        }

        public Template GetTemplate() {
            return template;
        }
    }
}
