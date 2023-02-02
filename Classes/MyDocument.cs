using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetencyGrid.Classes {
    public interface MyDocument {
        string getVName();
        string getNName();
        string getName();
        string getHeader();
        string getDescription();
        List<Subject> getSubjects();
        Subject getSubject(string name);
        string getOrt();
    }
}
