using System;
using System.Windows.Forms;

namespace CompetencyGrid {
    public partial class MainForm : Form {
        private Template[] templates;

        public MainForm() {
            InitializeComponent();
            this.GotFocus += new EventHandler(gotFocusHandler);
        }

        private void loadTemplates() {
            //loading templates and putting them into menuBar
            vorlageBearbeitenToolStripMenuItem.DropDownItems.Clear();

            templates = ObjectManager.LoadObjects<Template>("Templates");
            if (templates == null) return;

            foreach (Template template in templates) {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.ImageKey = template.getName();
                item.Name = template.getName() + "ToolStripMenuItem";
                item.Text = template.getName();
                item.Click += new EventHandler(MenuItemClickHandler);
                vorlageBearbeitenToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        private void vorlageErstellenToolStripMenuItem_Click(object sender, EventArgs e) {
            CreateTemplateForm temp = new CreateTemplateForm();
            temp.Show();
        }

        private void MenuItemClickHandler(object sender, EventArgs e) {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            foreach (Template t in templates) {
                if (t.getName().Equals(menuItem.Text)) {
                    CreateTemplateForm temp = new CreateTemplateForm(t);
                    temp.Show();
                }
            }
        }

        private void gotFocusHandler(object sender, EventArgs e) {
            loadTemplates();
        }
    }
}
