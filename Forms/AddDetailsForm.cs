using CompetencyGrid.Classes;
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
    public partial class AddDetailsForm : Form {
        private Font SmallFont = new Font("Arial", 10);
        private Font NormalFont = new Font("Arial", 14);
        private Subject subject;
        private List<string> optSpec;
        int pY = 3;
        int cnt = 0;
        public AddDetailsForm(Subject subject) {
            InitializeComponent();
            this.Text = "bearbeitete Themen " + subject.getName();
            this.subject = subject;
            optSpec = subject.getOptionalSpecifications();
            if (optSpec != null) initPanel();
        }

        private void initPanel() {
            foreach (string s in optSpec) {
                addToPanel(s);
            }
        }

        private void rebuildPanel() {
            pY = 3;
            cnt = 0;
            panel.Controls.Clear();
            initPanel();
        }

        private void addToList(string theme) {
            subject.addOptionalSpecification(theme);
            addToPanel(theme);
            if(optSpec == null) {
                optSpec = subject.getOptionalSpecifications();
            }
        }

        private void addToPanel(string s) {
            TextBox t = new TextBox();
            t.Name = "tb_" + cnt;
            t.ReadOnly = true;
            t.Size = new Size(400, 30);
            t.Text = s;
            t.Font = NormalFont;
            t.Location = new Point(3, pY);
            panel.Controls.Add(t);

            Button b = new Button();
            b.Name = "btn_" + cnt;
            b.Size = new Size(88, 30);
            b.Text = "entfernen";
            b.Font = SmallFont;
            b.Location = new Point(409, pY);
            b.Click += btnClickHandler;
            panel.Controls.Add(b);
            panel.Show();
            pY += 36;
            cnt++;
        }

        private void btnClickHandler(object sender, EventArgs e) {
            Button b = sender as Button;
            string n = b.Name.Trim('b', 't', 'n', '_');
            foreach(TextBox tb in panel.Controls.OfType<TextBox>()) {
                if(tb.Name.Trim('t', 'b', '_').Equals(n)) {
                    optSpec.Remove(tb.Text);
                    panel.Controls.Remove(tb);
                    tb.Dispose();
                    break;
                }
            }
            panel.Controls.Remove(b);
            b.Dispose();
            rebuildPanel();
        }

        private void btn_add_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(tb_theme.Text)) return;

            addToList(tb_theme.Text);
            tb_theme.Text = string.Empty;
        }
    }
}
