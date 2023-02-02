using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompetencyGrid.UserControls {
    public partial class CompScore : UserControl {
        EvaluateStudent parent;
        public CompScore(EvaluateStudent parent) {
            InitializeComponent();
            this.parent = parent;
            foreach(RadioButton rb in panel.Controls.OfType<RadioButton>()) {
                rb.CheckedChanged += checkedRadioChangedHandler;
                rb.Click += parent.lastClickedHandler;
            }
        }

        private void checkedRadioChangedHandler(object sender, EventArgs e) {
            RadioButton rB = sender as RadioButton;
            parent.changeCompScore(tb.Text, int.Parse(rB.Text));
        }
    }
}
