using CompetencyGrid.Classes;
using CompetencyGrid.Forms;
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
    public partial class NewSubjectForm : Form {
        CreateSection caller;
        bool sub;

        public NewSubjectForm(CreateSection caller, bool sub) {
            InitializeComponent();
            this.caller = caller;
            this.sub = sub;
        }

        private void btn_add_Click(object sender, EventArgs e) {
            if (tb_name.Text != null && tb_name.Text != string.Empty) {
                if (!sub)
                    caller.addSubject(new Subject(tb_name.Text));
                else
                    caller.addSubSubject(new Subject(tb_name.Text));

                this.Close();
            }
        }
    }
}
