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
    public partial class NewSubject : Form {
        CreateTemplateForm caller;
        public NewSubject(CreateTemplateForm caller) {
            InitializeComponent();
            this.caller = caller;
        }

        private void btn_add_Click(object sender, EventArgs e) {
            if(tb_name.Text != null && tb_name.Text != string.Empty) {
                //caller.addSubject(new Subject(tb_name.Text));
                this.Close();
            }
        }
    }
}
