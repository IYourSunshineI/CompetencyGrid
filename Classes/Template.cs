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
    public class Template : MyDocument{
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

        public Template(string name, string SKZ, string ort, string plz, string adr, string klasse, string schoolYear, string semester) {
            this.name = name;
            this.klasse = klasse;
            this.SKZ = SKZ; 
            this.ort = ort;
            this.plz = plz;
            this.adr = adr;
            this.schoolYear = schoolYear;
            this.semester = semester;
            subjects = new List<Subject>();
        }

        public void refactor(string name, string SKZ, string ort, string plz, string adr, string klasse, string schoolYear, string semester) {
            this.name = name;
            this.klasse = klasse;
            this.SKZ = SKZ;
            this.ort = ort;
            this.plz = plz;
            this.adr = adr;
            this.schoolYear = schoolYear;
            this.semester = semester;
        }

        public void addSubject(string name) {
            subjects.Add(new Subject(name));
        }

        public void addSubject(Subject sub) {
            subjects.Add(sub);
        }

        public void insertSubject(int index, Subject sub) {
            subjects.Insert(index, sub);
        }

        public int getSubjectIndex(Subject sub) {
            return subjects.IndexOf(sub);
        }

        public void removeSubject(string name) {
            foreach (Subject subject in subjects) {
                if (subject.getName().Equals(name)) {
                    subjects.Remove(subject);
                    return;
                }
            }
        }

        public void removeSubject(Subject sub) {
            subjects.Remove(sub);
        }

        public string getName() {
            return name;
        }

        public string getHeader() {
            return "Volksschule " + ort + ", SKZ: " + SKZ + ", " + plz + " " + ort + ", " + adr + ", Schuljahr " + schoolYear;
        }

        public string getOrt() {
            return ort;
        }

        public string getDescription() {
            if (description == null) {
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

        //find a given subject by name
        //also searches subSection of Subjects
        public Subject getSubject(string name) {
            foreach(Subject s in subjects) {
                if(s.getName().Equals(name)) {
                    return s;
                }
                if(s.hasSubSections()) {
                    Subject temp = s.getSubSection(name);
                    if (temp != null)
                        return temp;
                }
            }
            return null;
        }

        public string getVName() {
            return "Vorname";
        }

        public string getNName() {
            return "Nachname";
        }

        public string getSKZ() {
            return SKZ;
        }

        public string getPlz() {
            return plz;
        }

        public string getAdr() {
            return adr;
        }

        public override string ToString() {
            string temp = name + "\n";
            foreach (Subject subject in subjects) {
                temp += "\t" + subject.ToString() + "\n";
            }
            return temp;
        }
    }

    //Test class
    /*
    public static class Test {
        static void Main(string[] args) {
            Template temp = new Template("temp", "318.501", "Würflach", "2732", "Neunkirchner Str. 76", "1", "2022/23", "1");
            Subject sub;
            sub = new Subject("Religion");
            sub.addCompetence("Du arbeitest mit Freude und Interesse.");
            sub.addCompetence("Du kannst Geschichten oder Heiligenlegenden nacherzählen");
            sub.addCompetence("Du kannst die wichtigsten Feste im Kirchenjahr erkennen und mit biblischen Ereignissen verknüpfen.");
            sub.addCompetence("Du bemühst dich beim Gestalten deines Heftes.");
            temp.addSubject(sub);

            sub = new Subject("Sachunterricht");
            sub.addCompetence("Du kennst die Rechte und Pflichten in der Klassengemeinschaft und kannst sie umsetzen.");
            sub.addCompetence("Du hast Kenntnisse über biologische und ökologische Zusammenhänge.");
            sub.addCompetence("Du kannst Auswirkungen des eigenen Verhaltens auf die Natur nennen und Fehlverhalten erkennen.");
            sub.addCompetence("Du kannst dich in der näheren Umgebung orientieren.");
            sub.addCompetence("Du kannst Zeitabläufe innerhalb des Jahreskreises erfassen.");
            sub.addCompetence("Du kennst unterschiedliche Rollen des familiären Zusammenlebens.");
            sub.addOptionalSpecification(" ");
            sub.addOptionalSpecification(" ");
            sub.addOptionalSpecification(" ");
            sub.addOptionalSpecification(" ");
            temp.addSubject(sub);

            Subject d = new Subject("Deutsch, Lesen, Schreiben");
            sub = new Subject("Sprechen");
            sub.addCompetence("Du kannst verständlich und zusammenhängend erzählen.");
            sub.addCompetence("Du kannst dich an Gesprächsregeln halten und dich themenbezogen äußern.");
            sub.addCompetence("Du kannst zuhören.");
            d.addSubSection(sub);

            sub = new Subject("Lesen");
            sub.addCompetence("Du kannst die gelernten Buchstaben erkennen und die Laute zuordnen.");
            sub.addCompetence("Du kannst Buchstaben in Druckschrift benennen.");
            sub.addCompetence("Du kannst Großbuchstaben den entsprechenden Kleinbuchstaben zuordnen.");
            sub.addCompetence("Du kannst Silben lesen.");
            sub.addCompetence("Du kannst die gelernten Wörter lesen und verstehst den Sinn.");
            sub.addCompetence("Du kannst einfache Sätze lesen.");
            d.addSubSection(sub);

            sub = new Subject("Schreiben");
            sub.addCompetence("Du kannst die gelernten Buchstaben in Druckschrift formgerecht schreiben.");
            sub.addCompetence("Du schreibst in den Zeilen in der richtigen Größe.");
            sub.addCompetence("Du schreibst ordentlich und sauber.");
            d.addSubSection(sub);

            sub = new Subject("Verfassen von Texten");
            sub.addCompetence("Du kannst vorgegebene Sätze abschreiben.");
            sub.addCompetence("Du kannst eigene Sätze schreiben.");
            d.addSubSection(sub);

            sub = new Subject("Rechtschreiben");
            sub.addCompetence("Du kannst Silben auf Ansage richtig schreiben.");
            sub.addCompetence("Du kannst die bisher gelernten Lernwörter auf Ansage schreiben.");
            sub.addCompetence("Du kannst Satzanfänge und Namenwörter groß schreiben.");
            d.addSubSection(sub);

            sub = new Subject("Sprachbetrachtung");
            sub.addCompetence("Du kannst Namenwörtern den richtigen Begleiter zuordnen.");
            sub.addCompetence("Du kannst passende Reimwörter finden.");
            sub.addCompetence("Du kannst Namenwörter in die Mehrzahl setzen.");
            d.addSubSection(sub);
            temp.addSubject(d);

            sub = new Subject("Mathematik");
            sub.addCompetence("Du kannst die Ziffern von 0 bis 9 lesen.");
            sub.addCompetence("Du kannst Mengen im ZR bis 10 erkennen.");
            sub.addCompetence("Du kannst Zahlen im ZR bis 10 zerlegen.");
            sub.addCompetence("Du kannst die Bedeutung der Zeichen +, -, = erfassen.");
            sub.addCompetence("Du kannst im ZR bis 10 Additionen durchführen.");
            sub.addCompetence("Du kannst Zahlen im ZR bis 10 mit den Zeichen <, > vergleichen.");
            sub.addCompetence("Du kannst Raumlagebeziehungen herstellen.");
            sub.addCompetence("Du kannst die geometrischen Figuren Dreieck, Viereck und Kreis benennen.");
            sub.addCompetence("Du kannst geometrische Muster und Figuren nachlegen.");
            temp.addSubject(sub);

            sub = new Subject("Musikerziehung");
            sub.addCompetence("Du beteiligst dich aktiv am Unterricht.");
            sub.addCompetence("Du hast Freude am Singen und Tanzen.");
            sub.addCompetence("Du hast Freude am Musizieren mit Klangstäben.");
            sub.addCompetence("Du kannst einen vorgegebenen Rhythmus nachklatschen.");
            temp.addSubject(sub);

            sub = new Subject("Bildnerische Erziehung");
            sub.addCompetence("Du hast Freude am Malen, Zeichnen und Gestalten.");
            sub.addCompetence("Du kannst gut mit der Schere umgehen.");
            sub.addCompetence("Du arbeitest sorgfältig.");
            sub.addCompetence("Du führst Arbeiten gewissenhaft zu Ende.");
            temp.addSubject(sub);

            sub = new Subject("Technisches Werken, Textiles Werken");
            sub.addCompetence("Du arbeitest selbständig.");
            sub.addCompetence("Du arbeitest mit Freude und Fantasie.");
            sub.addCompetence("Du arbeitest sorgfältig.");
            temp.addSubject(sub);

            sub = new Subject("Bewegung und Sport");
            sub.addCompetence("Du beteiligst dich freudig und aktiv am Unterricht.");
            sub.addCompetence("Du kannst Übungen zur Bewegungs- und Haltungsschulung ausführen.");
            sub.addCompetence("Du kannst auf akustische und optische Signale reagieren.");
            sub.addCompetence("Du kannst dich an Spielregeln halten.");
            sub.addCompetence("Du kannst an Geräten kettern, schaukeln und schwingen.");
            sub.addCompetence("Du kannst Bälle werfen und fangen.");
            sub.addCompetence("Du sammelst Erfahrungen beim Eislaufen.");
            temp.addSubject(sub);

            sub = new Subject("Arbeits- und Sozialverhalten");
            sub.addCompetence("Du arbeitest mit Freude.");
            sub.addCompetence("Du kannst mit anderen zusammenarbeiten.");
            sub.addCompetence("Du entscheidest dich selbst für eine Arbeit.");
            sub.addCompetence("Du besitzt ein angemessenes Arbeitstempo.");
            sub.addCompetence("Du erledigst deine Hausübungen regelmäßig und gewissenhaft.");
            sub.addCompetence("Du arbeitest konzentriert und ausdauernd.");
            sub.addCompetence("Du bist höflich und zeigst dich anderen gegenüber hilfsbereit.");
            sub.addCompetence("Du kannst im Unterricht gut zuhören und das Gehörte umsetzen.");
            sub.addCompetence("Du gehst sorgsam mit eigenen und fremden Sachen um.");
            temp.addSubject(sub);


            CompetencyForm myform = new CompetencyForm("Sebastian", "KLAUS", temp);

            ObjectManager.SaveObject(temp, "Templates", "temp.xml");
            ObjectManager.SaveObject(myform, "Templates", "me.xml");
            Printer.printToPDF("PDFs", temp);
            Printer.printToPDF("PDFs", myform);
            
            Template temp = ObjectManager.LoadObject<Template>("Templates", "temp.xml");
            Printer.printToPDF("PDFs", temp);            
        }
    }*/
}