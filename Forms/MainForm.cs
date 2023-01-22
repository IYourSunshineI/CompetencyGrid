using System;
using System.Windows.Forms;

namespace CompetencyGrid {
    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
        }

        private void vorlageErstellenToolStripMenuItem_Click(object sender, EventArgs e) {
            CreateTemplateForm temp = new CreateTemplateForm();
            temp.Show();
        }
    }
}
