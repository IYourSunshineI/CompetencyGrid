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
        List<Subject> subjects;


        public Template(string name) {
            this.name = name;
            subjects = new List<Subject>();
        }

        public void addSubject(string name) {
            subjects.Add(new Subject(name));
        }

        public void removeSubject(string name) {
            foreach(Subject subject in subjects) {
                if(subject.getName().Equals(name)) {
                    subjects.Remove(subject);
                    return;
                }
            }
        }

        //returns false if given subject does not exists, true otherwise
        public bool addCompetence(string subject, string competence) {
            foreach(Subject s in subjects) {
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
            foreach(Subject s in subjects) {
                if (s.getName().Equals(subject)) {
                    s.removeCompetence(competence);
                    return true;
                }
            }
            return false;
        }

        public string toString() {
            string temp = name + "\n";
            foreach(Subject subject in subjects) {
                temp += "\t" + subject.toString() + "\n";
            }
            return temp;
        }

        public class Subject {
            public string name;
            public List<string> competencies;

            public Subject() { }

            public Subject(string name) {
                this.name = name;
                this.competencies = new List<string>();
            }

            public void addCompetence(string competence) {
                competencies.Add(competence);
            }

            public void addCompetence(string competence, int index) {
                competencies.Insert(index, competence);
            }

            public void removeCompetence(string competence) {
                competencies.Remove(competence);
            }

            public string getName() {
                return name;
            }

            public string toString() {
                string temp = name + "\n";
                foreach(string competence in competencies) {
                    temp += "\t\t" + competence + "\n";
                }
                return temp;
            }
        }
    }

    public static class Test {
        static void Main(string[] args) {
            /*Template temp = new Template("penis");
            temp.addSubject("amk");
            temp.addSubject("Religion");
            temp.addSubject("Sachunterricht");
            ObjectManager.SaveObject(temp, "temp.xml");
            temp = null;*/
            /*
            Template temp = ObjectManager.LoadObject<Template>("temp.xml");
            Console.Write(temp.toString());
            temp.addCompetence("Religion", "amen");
            ObjectManager.SaveObject(temp, "temp.xml");
            */
        }
    }
}
