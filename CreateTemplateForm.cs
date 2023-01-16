using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompetencyGrid {
    public partial class CreateTemplateForm : Form {
        string filePath;

        public CreateTemplateForm() {
            InitializeComponent();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.DefaultExt = "txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                filePath = saveFileDialog.FileName;
                string temp = Path.GetFileNameWithoutExtension(filePath);
                templateName.Text = "Vorlage: " + temp;
            }
        }

        private void btn_safe_Click(object sender, EventArgs e) {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(filePath);
            writer.Write(tempTextBox.Text);
            writer.Close();
            writer.Dispose();
        }
    }
}
