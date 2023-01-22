using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace CompetencyGrid {
    public partial class CreateTemplateForm : Form {
        string path = null;
        Font calibriDef = FontFactory.GetFont("Calibri Regular", 10);
        Font calibriBold = FontFactory.GetFont("Calibri Regular", BaseFont.CP1252, BaseFont.EMBEDDED, 12, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
        Font calibriHeader = FontFactory.GetFont("Calibri Regular", 11);
        Document doc;
        //List<Subject> subjects = new List<Subject>();

        public CreateTemplateForm() {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e) {
            //check inputs
            bool _break = false;
            var alltbs = panel_create.Controls.OfType<CueTextBox>();
            foreach (CueTextBox tb in alltbs) {
                if (tb.Text == null || tb.Text == string.Empty) {
                    tb.BackColor = Color.FromArgb(255, 128, 128);
                    _break = true;
                    continue;
                }
                tb.BackColor = Color.White;
            }
            if (_break)
                return;

            if (path == null) {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK) {
                    path = fbd.SelectedPath;
                } else {
                    Console.Error.WriteLine("Error occourd on path selection");
                    return;
                }
            }

            //create Document and write header
            doc = new Document();
            try {
                PdfWriter.GetInstance(doc, new FileStream(path + "/" + tb_fileName.Text + ".pdf", FileMode.Create));
                doc.Open();
                Paragraph paragraph = new Paragraph(tb_header.Text + ", Schuljahr " + tb_schuljahr.Text + "\n\n", calibriHeader);
                doc.Add(paragraph);
                paragraph = new Paragraph("Schriftliche Erläuterung/Kompetenzkatalog für Vorname Nachname\nSchüler/in der " + tb_klasse.Text +
                    ". Klasse im " + tb_semester.Text + ". Semester", calibriBold);
                doc.Add(paragraph);
            } catch (DocumentException dex) {
                throw (dex);
            } catch (IOException ioex) {
                throw (ioex);
            } finally {
                Console.WriteLine("done");
                doc.Close(); //!!
            }
            this.Text = tb_fileName.Text;
            panel_createSection.Visible = true;
        }

        //aborts the creation of the current template
        private void btn_abort_Click(object sender, EventArgs e) {
            doc.Close();
            File.Delete(path + "/" + tb_fileName.Text + ".pdf");
            Console.WriteLine("deleted");
            this.Close();
        }

        //adds a new subject to the current template
        /*public void addSubject(Subject subject) {
            subjects.Add(subject);
            listBox_subjects.Items.Add(subject.getName());
        }*/

        private void btn_addSubject_Click(object sender, EventArgs e) {
            NewSubject temp = new NewSubject(this);
            temp.Show();
        }

        /*private void btn_deleteSubject_Click(object sender, EventArgs e) {
            string toDelete = listBox_subjects.Text;
            foreach(Subject subject in subjects) {
                if(subject.getName().Equals(toDelete)) {
                    subjects.Remove(subject);
                    listBox_subjects.Items.Remove(toDelete);
                    return;
                }
            }
        }*/

        private void listBox_subjects_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
