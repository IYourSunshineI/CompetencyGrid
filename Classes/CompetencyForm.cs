using iTextSharp.text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CompetencyGrid {

    [DataContract]
    public class CompetencyForm {
        [DataMember]
        private string vName;

        [DataMember]
        private string nName;

        [DataMember]
        private Template template;

        [DataMember]
        private List<int> score;

        public CompetencyForm(string vName, string nName, Template template) { 
            this.vName = vName;
            this.nName = nName;
            this.template = template;
            this.score = new List<int>();
        }




    }
}
