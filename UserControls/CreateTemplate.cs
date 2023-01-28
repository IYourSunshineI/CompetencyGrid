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

        private void btn_save_Click(object sender, EventArgs e) {
            bool flag = false;
            foreach (CueTextBox tb in Controls.OfType<CueTextBox>()) {
                if (tb.Text == null || tb.Text == string.Empty) {
                    tb.BackColor = Color.Red;
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
            parent.switchForm(this);
        }

        private void CreateTemplate_Load(object sender, EventArgs e) {
            parent = ParentForm as CreateTemplateForm;
        }
    }
}
