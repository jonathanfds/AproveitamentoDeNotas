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
    public partial class frmCadastroMateria : Form
    {
        public frmCadastroMateria()
        {
            InitializeComponent();
        }
        List<tb_curso> _ListadeCursos;
        List<tb_instituto> _ListaInsts;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tb_disciplina lDisciplina = new tb_disciplina();
            int lIdCurso = _ListadeCursos.Find(T => T.nome_curso.Equals(cmbCurso.SelectedItem)).id_curso;
            int lIdInstituto = _ListaInsts.Find(T => T.nome_instituto.Equals(cmbInstituicao.SelectedItem)).id_instituto;
            tb_instituto_curso lInstitutoCurso = clsFuncoesBase.getInstituoCurso(lIdCurso, lIdInstituto);
            lDisciplina.nome_disciplina = txtNomeMateria.Text;
            lDisciplina.ano_semestre = txtAnoSemestre.Text;
            lDisciplina.carga_horaria = Convert.ToInt32(txtCargaHoraria.Text);
            lDisciplina.descricao = txtDescricao.Text;
            lDisciplina.id_instituto_curso = lInstitutoCurso.id_inst_curso;
            if (clsFuncoesBase.insertDisciplina(lDisciplina))
            {
                MessageBox.Show("Disciplina cadastrada com sucesso !");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar disciplina !");
            }


        }
        private void LimparCampos()
        {
            this.cmbCurso.Items.Clear();
            this.cmbInstituicao.SelectedIndex = -1;
            this.txtAnoSemestre.Clear();
            this.txtCargaHoraria.Clear();
            this.txtDescricao.Clear();
            this.txtNomeMateria.Clear();
            _ListadeCursos = null;
        }

        private void frmCadastroMateria_Load(object sender, EventArgs e)
        {
            PreencheInstituicoes();
        }
        private void PreencheCursosInstituicao(int pIdInst)
        {
            Cursor.Current = Cursors.WaitCursor;
            _ListadeCursos = clsFuncoesBase.getCursosInstituicao(pIdInst);
            this.cmbCurso.Items.Clear();
            foreach (tb_curso Curso in _ListadeCursos)
            {
                this.cmbCurso.Items.Add(Curso.nome_curso);
            }
            Cursor.Current = Cursors.Default;
        }

        private void PreencheInstituicoes()
        {
            _ListaInsts = new List<tb_instituto>();
            _ListaInsts = clsFuncoesBase.getInstituicoes();
            this.cmbInstituicao.Items.Clear();
            foreach (tb_instituto Instituto in _ListaInsts)
            {
                this.cmbInstituicao.Items.Add(Instituto.nome_instituto);
            }
        }

        private void cmbInstituicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInstituicao.SelectedItem != null)
            {
                tb_instituto lInstituo = _ListaInsts.Find(T => T.nome_instituto.Equals(cmbInstituicao.SelectedItem));
                if(lInstituo != null)
                    PreencheCursosInstituicao(lInstituo.id_instituto);
            }
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (new frmCadastraInstCurso().ShowDialog() == DialogResult.OK)
            {
                PreencheInstituicoes();
            }
        }

        private void frmCadastroMateria_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
