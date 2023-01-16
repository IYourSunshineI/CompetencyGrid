using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompetencyGrid {
    public partial class MainForm : Form {
        private static string templatePath;

        public MainForm() {
            InitializeComponent();
        }

        private void vorlageErstellenToolStripMenuItem_Click(object sender, EventArgs e) {
            CreateTemplateForm temp = new CreateTemplateForm();
            temp.Show();
        }

        public static void SetTemplatePath(string path) {
            templatePath= path;
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e) {
            SettingsForm temp = new SettingsForm();
            temp.Show();
        }
    }
}
