using CompetencyGrid.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CompetencyGrid {
    public partial class CreateTemplateForm : Form {
        private Template template;
        private bool refactored = false;
        private string name;

        public CreateTemplateForm() {
            InitializeComponent();
            createTemplate.BringToFront();
        }

        public CreateTemplateForm(Template template) {
            InitializeComponent();
            this.template = template;
            name = template.getName();
            createTemplate.init(template);
            createSection.init(template);
            createSection.BringToFront();
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

        public void done() {
            ObjectManager.SaveObject<Template>(template, "Templates", template.getName() + ".xml");
            if (refactored) {
                File.Delete("Templates/" + name + ".xml");
            }
            Close();
        }

        public void refactor() {
            refactored = true;
        }
    }
}
