﻿using System;
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
        int _IdInstituicao = 1;
        int _IdInstituicaoOrigem = 1;
        int _IdCurso;
        int _IdCursoOrigem;
        int _IdDisciplinaAluno;
        int _IdDisciplinaOrigem;
        private void frmNovoAproveitamento_Load(object sender, EventArgs e)
        {
            PreencheCursosInstituicao(_IdInstituicao, cmbCursoAluno);
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
                PreencheDisciplinas(cmbDisciplinaAluno,_IdCurso,_IdInstituicao);
            }            
        }
        private void PreencheDisciplinas(ComboBox pCmbDisciplinas,int pIdCurso,int pIdInst)
        {
            int IdInstCurso = clsFuncoesBase.getInstituoCurso(pIdCurso, pIdInst).id_inst_curso;
            _ListaDisciplinas = clsFuncoesBase.getDisciplinas(IdInstCurso);
            pCmbDisciplinas.Items.Clear();
            foreach (tb_disciplina Disciplina in _ListaDisciplinas)
            {
                pCmbDisciplinas.Items.Add(Disciplina.nome_disciplina);
            }
        }

        private void cmbDisciplinaAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            _IdDisciplinaAluno = _ListaDisciplinas.Find(T => T.nome_disciplina.Equals(cmbDisciplinaAluno.SelectedItem)).id_disciplina;
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
        }

        private void cmbCursoOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            _IdCursoOrigem=_ListadeCursos.Find(t=>t.nome_curso.Equals(cmbCursoOrigem.SelectedItem)).id_curso;
            PreencheDisciplinas(cmbDisciplinaOrigem, _IdCursoOrigem, _IdInstituicaoOrigem);
        }

        private void cmbDisciplinaOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            _IdDisciplinaOrigem = _ListaDisciplinas.Find(t => t.nome_disciplina.Equals(cmbDisciplinaOrigem.SelectedItem)).id_disciplina;
            tb_disciplina Disciplina= _ListaDisciplinas.Find(t=>t.id_disciplina.Equals(_IdDisciplinaOrigem));
            this.txtAnoSemestre.Text = Disciplina.ano_semestre;
            this.txtCargaHoraria.Text = Disciplina.carga_horaria.ToString();
            this.txtDescricaoOrigem.Text = Disciplina.descricao;
        }
    }
}
