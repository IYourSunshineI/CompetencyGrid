using CompetencyGrid.Forms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CompetencyGrid {
    public partial class CreateTemplateForm : Form {
        private Template template;

        public CreateTemplateForm() {
            InitializeComponent();
            createTemplate.BringToFront();
        }

        public void switchForm(UserControl temp) {
            temp.SendToBack();
        }

        public void initTemplate(Template template) {
            this.template = template;
        }

        public Template getTemplate() {
            return template;
        }
    }
}
