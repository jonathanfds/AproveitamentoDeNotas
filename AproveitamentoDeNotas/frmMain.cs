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
        private void CadDisciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroMateria frmCadMateria = new frmCadastroMateria();
            //frmCadMateria.MdiParent = this;
            frmCadMateria.StartPosition = FormStartPosition.CenterScreen;
            frmCadMateria.Show();
        }

        private void CadAproveitamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovoAproveitamento frmNovoAprov = new frmNovoAproveitamento();
            //frmNovoAprov.MdiParent = this;
            frmNovoAprov.StartPosition = FormStartPosition.CenterScreen;
            frmNovoAprov.Show();
        }

        private void aproveitamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarRequerimentos frmConsulta = new frmConsultarRequerimentos();
            //frmConsulta.MdiParent = this;
            frmConsulta.StartPosition = FormStartPosition.CenterScreen;
            frmConsulta.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string Usuario="Jonathan";
            this.tsslUser.Text = "Bem vindo " + Usuario;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.tsslData.Text = System.DateTime.Now.ToString();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void intituicaoCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastraInstCurso frmInstCurso = new frmCadastraInstCurso();
            frmInstCurso.StartPosition = FormStartPosition.CenterScreen;
            frmInstCurso.Show();
        }
    }
}
