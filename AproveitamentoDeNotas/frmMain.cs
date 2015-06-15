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
            string Usuario = clsGlobal.UsuarioLogado.nome_user;
            this.tsslUser.Text = "Bem vindo " + Usuario;
            if (clsGlobal.UsuarioLogado.tb_funcao_usuario.funcao != FUNCOES_USUARIOS.Administrador.ToString())
            {
                consultarToolStripMenuItem.Enabled = false;
                usuárioToolStripMenuItem.Enabled = false;
            }
            else
            {
                consultarToolStripMenuItem.Enabled = true;
                usuárioToolStripMenuItem.Enabled = true;
            }
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
            frmCadastrarUsuario frmCaduser = new frmCadastrarUsuario();
            frmCaduser.StartPosition = FormStartPosition.CenterScreen;
            frmCaduser.Show();
        }

        private void intituicaoCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastraInstCurso frmInstCurso = new frmCadastraInstCurso();
            frmInstCurso.StartPosition = FormStartPosition.CenterScreen;
            frmInstCurso.Show();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastraCurso frmCurso = new frmCadastraCurso();
            frmCurso.StartPosition = FormStartPosition.CenterScreen;
            frmCurso.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            new frmLogin().Show();
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConfig(false).Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarRequerimentos frmConsulta = new frmConsultarRequerimentos();
            //frmConsulta.MdiParent = this;
            frmConsulta.StartPosition = FormStartPosition.CenterScreen;
            frmConsulta.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
