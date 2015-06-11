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
    public partial class frmNovoAproveitamento : Form
    {
        public frmNovoAproveitamento()
        {
            InitializeComponent();
        }
        List<tb_curso> _ListadeCursos;
        List<tb_disciplina> _ListaDisciplinas;
        List<tb_instituto> _lListaInsts;        
        int _IdInstituicaoOrigem ;
        int _IdCurso;
        int _IdCursoOrigem;
        int _IdDisciplinaAluno;
        int _IdDisciplinaOrigem;
        private void frmNovoAproveitamento_Load(object sender, EventArgs e)
        {
            PreencheCursosInstituicao(clsGlobal.ID_INSTITUICAO_PADRAO, cmbCursoAluno);
            PreencheInstituicoes();
        }
        private void PreencheCursosInstituicao(int pIdInst,ComboBox pCmbCursos)
        {
            Cursor.Current = Cursors.WaitCursor;
            _ListadeCursos = clsFuncoesBase.getCursosInstituicao(pIdInst);
            pCmbCursos.Items.Clear();
            foreach (tb_curso Curso in _ListadeCursos)
            {
                pCmbCursos.Items.Add(Curso.nome_curso);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCursoAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCursoAluno.SelectedItem != null)
            {
                _IdCurso = _ListadeCursos.Find(T => T.nome_curso.Equals(cmbCursoAluno.SelectedItem)).id_curso;
                PreencheDisciplinas(cmbDisciplinaAluno, _IdCurso, clsGlobal.ID_INSTITUICAO_PADRAO);
            }            
        }
        private void PreencheDisciplinas(ComboBox pCmbDisciplinas,int pIdCurso,int pIdInst)
        {

            int IdInstituicaoCurso = clsFuncoesBase.getInstituoCurso(pIdCurso, pIdInst).id_inst_curso;            
            _ListaDisciplinas = clsFuncoesBase.getDisciplinas(IdInstituicaoCurso);
            pCmbDisciplinas.Items.Clear();
            foreach (tb_disciplina Disciplina in _ListaDisciplinas)
            {
                pCmbDisciplinas.Items.Add(Disciplina.nome_disciplina);
            }
        }

        private void cmbDisciplinaAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            _IdDisciplinaAluno = _ListaDisciplinas.Find(T => T.nome_disciplina.Equals(cmbDisciplinaAluno.SelectedItem)).id_disciplina;
            cmbInstituicaoOrigem.Enabled = true;
            lklNovoInst.Enabled = true;
        }
        private void PreencheInstituicoes()
        {
            _lListaInsts = new List<tb_instituto>();
            _lListaInsts = clsFuncoesBase.getInstituicoes();
            this.cmbInstituicaoOrigem.Items.Clear();
            foreach (tb_instituto Instituto in _lListaInsts)
            {
                this.cmbInstituicaoOrigem.Items.Add(Instituto.nome_instituto);
            }
        }

        private void cmbInstituicaoOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            _IdInstituicaoOrigem = _lListaInsts.Find(t => t.nome_instituto.Equals(cmbInstituicaoOrigem.SelectedItem)).id_instituto;
            PreencheCursosInstituicao(_IdInstituicaoOrigem, cmbCursoOrigem);
            cmbCursoOrigem.Enabled = true;
            lklNovoCurso.Enabled = true;
        }

        private void cmbCursoOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            _IdCursoOrigem=_ListadeCursos.Find(t=>t.nome_curso.Equals(cmbCursoOrigem.SelectedItem)).id_curso;
            PreencheDisciplinas(cmbDisciplinaOrigem, _IdCursoOrigem, _IdInstituicaoOrigem);
            cmbDisciplinaOrigem.Enabled = true;
            lklNovoDisciplina.Enabled = true;
        }

        private void cmbDisciplinaOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            _IdDisciplinaOrigem = _ListaDisciplinas.Find(t => t.nome_disciplina.Equals(cmbDisciplinaOrigem.SelectedItem)).id_disciplina;
            tb_disciplina Disciplina= _ListaDisciplinas.Find(t=>t.id_disciplina.Equals(_IdDisciplinaOrigem));
            this.txtAnoSemestre.Text = Disciplina.ano_semestre;
            this.txtCargaHoraria.Text = Disciplina.carga_horaria.ToString();
            this.txtDescricaoOrigem.Text = Disciplina.descricao;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tb_aproveitamento lAproveitamento = new tb_aproveitamento();
            lAproveitamento.dt_aprov = System.DateTime.Now;
            lAproveitamento.nome_aluno = txtNomeAluno.Text;
            lAproveitamento.ra_aluno = txtRA.Text;
            lAproveitamento.id_curso_atual = _IdCurso;
            lAproveitamento.id_disciplina_atual = _IdDisciplinaAluno;
            lAproveitamento.cod_disciplina_origem = _IdDisciplinaOrigem;
            lAproveitamento.tb_situacao_aprov = clsFuncoesBase.getSituacoes().Find(t => t.nome_situacao_aprov.Equals("Aberto"));
            if (clsFuncoesBase.insertAproveitamento(lAproveitamento)) {
                MessageBox.Show("Aproveitamento cadastrado com sucesso !");
            }
            else 
            {
                MessageBox.Show("Erro ao cadastrar aproveitamento !");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (new frmCadastraInstCurso().ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PreencheInstituicoes();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (new frmCadastroMateria().ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _IdCursoOrigem = _ListadeCursos.Find(t => t.nome_curso.Equals(cmbCursoOrigem.SelectedItem)).id_curso;
                PreencheDisciplinas(cmbDisciplinaOrigem, _IdCursoOrigem, _IdInstituicaoOrigem);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (new frmCadastraCurso().ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _IdInstituicaoOrigem = _lListaInsts.Find(t => t.nome_instituto.Equals(cmbInstituicaoOrigem.SelectedItem)).id_instituto;
                PreencheCursosInstituicao(_IdInstituicaoOrigem, cmbCursoOrigem);
            }
        }
    }
}
