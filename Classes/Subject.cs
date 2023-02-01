using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CompetencyGrid.Classes{

    [DataContract]
    public class Subject{
        [DataMember]
        private string name;

        [DataMember]
        private List<Subject> subSections;

        [DataMember]
        private List<string> competencies;

        [DataMember]
        private List<string> optionalSpecifications;

        [DataMember]
        private Dictionary<string, int> compScores;

        public Subject(string name) {
            this.name = name;
            competencies = new List<string>();
            compScores = new Dictionary<string, int>();
        }

        public void addSubSection(Subject sub) {
            if (subSections == null) {
                subSections = new List<Subject>();
                competencies = null;
            }
            subSections.Add(sub);
        }

        public void removeSubSection(string temp) {
            foreach (Subject subject in subSections) {
                if (subject.getName().Equals(temp)) {
                    subSections.Remove(subject);
                    return;
                }
            }
        }

        public void removeSubSection(Subject sub) {
            subSections.Remove(sub);
            if(subSections.Count == 0) {
                subSections = null;
                competencies = new List<string>();
            }
        }

        public void addOptionalSpecification(string spec) {
            if (optionalSpecifications == null)
                optionalSpecifications = new List<string>();
            optionalSpecifications.Add(spec);
        }

        public void addCompetence(string competence) {
            competencies.Add(competence);
            compScores[competence] = 3;
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

        public bool hasSubSections() {
            return subSections != null;
        }

        public Subject getSubSection(string name) {
            foreach (Subject s in subSections) {
                if (s.getName().Equals(name)) {
                    return s;
                }
            }
            return null;
        }

        public int getSubCount() {
            if (subSections == null) return 0;
            return subSections.Count;
        }

        public List<string> getOptionalSpecifications() {
            return optionalSpecifications;
        }

        public void changeCompScore(string comp, int score) {
            compScores[comp] = score;
        }

        public int getCompScore(string comp) {
            try {
                return compScores[comp];
            } catch (KeyNotFoundException) {
                return 3;
            }
        }

        public override string ToString() {
            string temp = name + "\n";
            if (subSections != null) {
                foreach (Subject s in subSections) {
                    temp += "\t\t" + s.ToString() + "\n";
                }
            } else {
                foreach (string competence in competencies) {
                    temp += "\t\t" + competence + "\n";
                }
            }
            return temp;
        }
    }
}
