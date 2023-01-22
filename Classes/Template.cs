using CompetencyGrid.Classes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CompetencyGrid {

    [DataContract]
    public class Template {
        [DataMember]
        private string name;

        [DataMember]
        private string header;

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

        public Template(string name, string header, string klasse, string schoolYear, string semester) {
            this.name = name;
            this.klasse = klasse;
            this.header = header;
            this.schoolYear = schoolYear;
            this.semester = semester;
            subjects = new List<Subject>();
        }

        public void addSubject(string name) {
            subjects.Add(new Subject(name));
        }

        public void removeSubject(string name) {
            foreach (Subject subject in subjects) {
                if (subject.getName().Equals(name)) {
                    subjects.Remove(subject);
                    return;
                }
            }
        }

        //returns false if given subject does not exists, true otherwise
        public bool addCompetence(string subject, string competence) {
            foreach (Subject s in subjects) {
                if (s.getName().Equals(subject)) {
                    s.addCompetence(competence);
                    return true;
                }
            }
            return false;
        }

        //returns false if given subject does not exists, true otherwise
        public bool addCompetence(string subject, string competence, int index) {
            foreach (Subject s in subjects) {
                if (s.getName().Equals(subject)) {
                    s.addCompetence(competence, index);
                    return true;
                }
            }
            return false;
        }

        //returns false if given subject does not exists, true otherwise
        public bool removeCompetence(string subject, string competence) {
            foreach (Subject s in subjects) {
                if (s.getName().Equals(subject)) {
                    s.removeCompetence(competence);
                    return true;
                }
            }
            return false;
        }

        public string getName() {
            return name;
        }

        public string getHeader() {
            return header + ", Schuljahr " + schoolYear;
        }

        public string getDescription() {
            if(description == null) {
                description = "Schriftliche Erläuterung/Kompetenzkatalog für Vorname Nachname\nSchüler/in der " +
                    klasse + ". Klasse im " + semester + ". Semester";
            }
            return description;
        }

        public string getKlasse() {
            return klasse;
        }

        public string getSchoolYear() {
            return schoolYear;
        }

        public string getSemester() {
            return semester;
        }

        public List<Subject> getSubjects() {
            return subjects;
        }



        public string toString() {
            string temp = name + "\n";
            foreach (Subject subject in subjects) {
                temp += "\t" + subject.toString() + "\n";
            }
            return temp;
        }
    }

    public static class Test {
        static void Main(string[] args) {
            Template temp = new Template("temp", "Volksschule Würflach, SKZ: 318.501, 2732 Würflach, Neunkirchner Str. 76",
                "1", "2022/23", "1");
            temp.addSubject("Religion");
            temp.addCompetence("Religion", "Du arbeitest mit Freude und Interesse.");
            temp.addCompetence("Religion", "Du kannst Geschichten oder Heiligenlegenden nacherzählen");
            temp.addSubject("Sachunterricht");
            temp.addCompetence("Sachunterricht", "Du kennst die Rechte und Pflichten in der Klassengemeinschaft und kannst sie" +
                "umsetzten");
            temp.addCompetence("Sachunterricht", "Du kannst Auswirkungen des eigenen Verhaltens auf " +
                "die Natur nennen und Fehlverhalten erkennen.");
            for(int i = 0; i < 20; i++) {
                temp.addSubject(i.ToString());
                temp.addCompetence(i.ToString(), (i + 10).ToString());
            }
            ObjectManager.SaveObject(temp, "Templates", "temp.xml");

            Printer.printToPDF("PDFs", temp);
            /*
            Template temp = ObjectManager.LoadObject<Template>("Templates", "temp.xml");
            Console.Write(temp.toString());
            temp.addCompetence("Religion", "amen");
            temp.removeSubject("amk");
            ObjectManager.SaveObject(temp, "Templates", "temp.xml");
            */
        }
    }
}
