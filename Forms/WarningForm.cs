using CompetencyGrid.UserControls;
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
    public partial class WarningForm : Form {
        private EvaluateStudent parent;
        public WarningForm(EvaluateStudent parent) {
            InitializeComponent();
            this.parent = parent;
            parent.Enabled = false;
        }

        private void btn_continue_Click(object sender, EventArgs e) {
            parent.Enabled = true;
            parent.newStudent();
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e) {
            parent.Enabled = true;
            Close();
        }
    }
}
