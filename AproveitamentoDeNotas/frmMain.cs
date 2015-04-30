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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarMateria_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            frmCadastroMateria formCadastro = new frmCadastroMateria();
            formCadastro.TopLevel = false;
            formCadastro.AutoScroll = true;
            formCadastro.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel1.Size = new Size(493, 401);
            this.panel1.Controls.Add(formCadastro);
            formCadastro.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            frmComparar formComparar = new frmComparar();
            formComparar.TopLevel = false;
            formComparar.AutoScroll = true;
            formComparar.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel1.Size = new Size(1100, 446);
            this.panel1.Controls.Add(formComparar);
            formComparar.Show();
        }
    }
}
