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
    public enum ListaDeForms
    {
        Form_Consultar_Materia,
        Form_Adicionar_Materia,
        Form_Comparar_Materias
    };
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

        }
    
        private void btnConsultar_Click(object sender, EventArgs e)
        {
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarRequerimentos frmConsulta = new frmConsultarRequerimentos();
            frmConsulta.MdiParent = this;
            frmConsulta.StartPosition = FormStartPosition.CenterScreen;
            frmConsulta.Show();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroMateria frmCadMateria = new frmCadastroMateria();
            frmCadMateria.MdiParent = this;
            frmCadMateria.StartPosition = FormStartPosition.CenterScreen;
            frmCadMateria.Show();
        }
    }
}
