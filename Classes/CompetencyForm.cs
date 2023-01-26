using CompetencyGrid.Classes;
using iTextSharp.text;
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

        public CompetencyForm(string vName, string nName, Template template) {
            this.vName = vName;
            this.nName = nName;
            name = vName + nName;
            SKZ = template.getSKZ();
            ort = template.getOrt();
            plz = template.getPlz();
            adr = template.getAdr();
            klasse = template.getKlasse();
            schoolYear = template.getSchoolYear();
            semester = template.getSemester();
            subjects = template.getSubjects();
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

        public List<Subject> getSubjects() {
            return subjects;
        }

        public string getVName() {
            return vName;
        }
    }
}
