using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AproveitamentoDeNotas
{
    public partial class formMotivoRecusa : Form
    {
        public formMotivoRecusa()
        {
            InitializeComponent();
        }

        private void rdbIncompCH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIncompCH.Checked)
            {
                rdbIncompCHeProg.Checked = !rdbIncompCH.Checked;
                rdbIncompProg.Checked = !rdbIncompCH.Checked;
            }
        }

        private void rdbIncompProg_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIncompProg.Checked)
            {
                rdbIncompCHeProg.Checked = !rdbIncompProg.Checked;
                rdbIncompCH.Checked = !rdbIncompProg.Checked;
            }
        }

        private void rdbIncompCHeProg_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIncompCHeProg.Checked)
            {
                rdbIncompProg.Checked = !rdbIncompCHeProg.Checked;
                rdbIncompCH.Checked = !rdbIncompCHeProg.Checked;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
