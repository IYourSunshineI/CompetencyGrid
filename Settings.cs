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
    public partial class SettingsForm : Form {
        private string templatePath = Application.StartupPath;
        public SettingsForm() {
            InitializeComponent();
            MainForm.SetTemplatePath(templatePath);
            textBoxTemplatePath.Text = templatePath;
        }

        private void btn_SelectTemplatePath_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK) {
                MainForm.SetTemplatePath(fbd.SelectedPath);
                textBoxTemplatePath.Text = fbd.SelectedPath;
            }
        }
    }
}
