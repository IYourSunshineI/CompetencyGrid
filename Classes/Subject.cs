using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CompetencyGrid.Classes {

    [DataContract]
    public class Subject {
        [DataMember]
        private string name;

        [DataMember]
        private List<Subject> subSections;

        [DataMember]
        private List<string> competencies;

        public Subject(string name) {
            this.name = name;
            competencies = new List<string>();
        }

        public Subject(string name, List<string> subSections) {
            this.name = name;
            this.subSections = new List<Subject>();
            foreach(string s in subSections) {
                this.subSections.Add(new Subject(s));
            }
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

        public List<string> getCompetencies() { 
            return competencies;
        }

        public List<Subject> getSubSections() {
            return subSections;
        }

        public string toString() {
            string temp = name + "\n";
            foreach (string competence in competencies) {
                temp += "\t\t" + competence + "\n";
            }
            return temp;
        }
    }
}
