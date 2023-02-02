using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompetencyGrid.Forms {
    public partial class CreateTemplate : UserControl {
        private CreateTemplateForm parent;
        private Template template;
        public CreateTemplate() {
            InitializeComponent();
        }

        public void init(Template template) {
            this.template = template;
            tb_fileName.Text = template.getName();
            tb_klasse.Text = template.getKlasse();
            tb_schuljahr.Text = template.getSchoolYear();
            tb_semester.Text = template.getSemester();
            tb_ort.Text = template.getOrt();
            tb_SKZ.Text = template.getSKZ();
            tb_PLZ.Text = template.getPlz();
            tb_Adr.Text = template.getAdr();
        }

        private void btn_next_Click(object sender, EventArgs e) {
            bool flag = false;
            foreach (CueTextBox tb in Controls.OfType<CueTextBox>()) {
                if (tb.Text == null || tb.Text == string.Empty) {
                    tb.BackColor = Color.FromArgb(255, 192, 192);
                    flag = true;
                } else {
                    tb.BackColor = Color.White;
                }
            }
            if (flag)
                return;


            if (template == null) {
                //Creating Template
                template = new Template(tb_fileName.Text, tb_SKZ.Text, tb_ort.Text, tb_PLZ.Text,
                    tb_Adr.Text, tb_klasse.Text, tb_schuljahr.Text, tb_semester.Text);
                parent.initTemplate(template);
            } else {
                //refactor all attr. (inefficient but idcrn)
                template.refactor(tb_fileName.Text, tb_SKZ.Text, tb_ort.Text, tb_PLZ.Text,
                    tb_Adr.Text, tb_klasse.Text, tb_schuljahr.Text, tb_semester.Text);
            }
            parent.Text = template.getName();
            parent.switchForm(this);
        }

        private void CreateTemplate_Load(object sender, EventArgs e) {
            parent = ParentForm as CreateTemplateForm;
        }
    }
}
