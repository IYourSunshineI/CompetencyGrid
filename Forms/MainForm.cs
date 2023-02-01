using System;
using System.Windows.Forms;

namespace CompetencyGrid {
    public partial class MainForm : Form {
        private Template[] templates;

        public MainForm() {
            InitializeComponent();
            this.GotFocus += new EventHandler(gotFocusHandler);
        }

        private void loadTemplates(ToolStripMenuItem menuItem, EventHandler eventHandler) {
            //loading templates and putting them into menuBar
            menuItem.DropDownItems.Clear();

            templates = ObjectManager.LoadObjects<Template>("Templates");
            if (templates == null) return;

            foreach (Template template in templates) {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.ImageKey = template.getName();
                item.Name = template.getName() + "ToolStripMenuItem";
                item.Text = template.getName();
                item.Click += new EventHandler(eventHandler);
                menuItem.DropDownItems.Add(item);
            }
        }

        private void vorlageErstellenToolStripMenuItem_Click(object sender, EventArgs e) {
            CreateTemplateForm temp = new CreateTemplateForm();
            temp.Show();
        }

        private void ChangeTemplateClickHandler(object sender, EventArgs e) {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            foreach (Template t in templates) {
                if (t.getName().Equals(menuItem.Text)) {
                    CreateTemplateForm temp = new CreateTemplateForm(t);
                    temp.Show();
                }
            }
        }

        private void EvaluateTemplateClickHandler(object sender, EventArgs e) {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            foreach(Template t in templates) {
                if (t.getName().Equals(menuItem.Text)) {
                    evaluateStudent.init(t);
                    return;
                }
            }
        }

        private void gotFocusHandler(object sender, EventArgs e) {
            loadTemplates(vorlageBearbeitenToolStripMenuItem, ChangeTemplateClickHandler);
            loadTemplates(bewertungBeginnenToolStripMenuItem, EvaluateTemplateClickHandler);
        }
    }
}
