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
    public partial class frmComparar : Form
    {
        tb_aproveitamento _Aproveitamento;
        public frmComparar(tb_aproveitamento pAprov)
        {
            InitializeComponent();
            this._Aproveitamento = pAprov;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            AtualizarAproveitamento(SITUACOES_APROVEITAMENTO.Aprovado);
        }
        private void AtualizarAproveitamento(SITUACOES_APROVEITAMENTO pSituacao)
        {
            tb_situacao_aprov Situacao = clsFuncoesBase.getSituacoes().Find(t => t.nome_situacao_aprov.Equals(pSituacao.ToString()));
            _Aproveitamento.tb_situacao_aprov = Situacao;
            if( clsFuncoesBase.updateAproveitamento(_Aproveitamento))
            {
                MessageBox.Show("O Aproveitamento de estudo foi finalizado !");
            }
            else
            {
                MessageBox.Show("Erro ao finalizar aproveitamento, tente novamente.");
            }
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void lblDescricaoInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblDescricaoReq_text_Click(object sender, EventArgs e)
        {

        }

        private void btnReprovar_Click(object sender, EventArgs e)
        {
            AtualizarAproveitamento(SITUACOES_APROVEITAMENTO.Rejeitado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           AtualizarAproveitamento(SITUACOES_APROVEITAMENTO.Encaminhado);
        }

        private void frmComparar_Load(object sender, EventArgs e)
        {
            Preencher();
        }
        private void Preencher()
        {
            if (_Aproveitamento != null)
            {
                tb_disciplina lDisciplina = clsFuncoesBase.getDisciplina(_Aproveitamento.id_disciplina_atual);
                tb_disciplina lDisciplinaOrigem = clsFuncoesBase.getDisciplina(_Aproveitamento.cod_disciplina_origem);

                string[] Curso_Disciplina_Nomes = clsFuncoesBase.getNomeInstituoCurso(_Aproveitamento.id_curso_atual, clsGlobal.ID_INSTITUICAO_PADRAO);
                this.lblNomeMateriaReq.Text = lDisciplina.nome_disciplina;
                this.lblCursoReq.Text = Curso_Disciplina_Nomes[0];
                this.lblInstituicaoReq.Text = Curso_Disciplina_Nomes[1];
                this.lblCargaHorariaReq.Text = lDisciplina.carga_horaria.ToString();
                this.lblAnoSemReq.Text = lDisciplina.ano_semestre.ToString();
                this.lblDescricaoReq.Text = lDisciplina.descricao;

                string[] Curso_Disciplina_Nomes_Origem = clsFuncoesBase.getNomeInstituoCurso(lDisciplinaOrigem.id_instituto_curso);
                this.lblNomeMateriaInfo.Text = lDisciplinaOrigem.nome_disciplina;
                this.lblCursoInfo.Text = Curso_Disciplina_Nomes_Origem[0];
                this.lblInstituicaoInfo.Text = Curso_Disciplina_Nomes_Origem[1];
                this.lblCargaHorariaInfo.Text = lDisciplinaOrigem.carga_horaria.ToString();
                this.lblAnoSemInfo.Text = lDisciplinaOrigem.ano_semestre.ToString();
                this.lblDescricaoInfo.Text = lDisciplinaOrigem.descricao;

                if (clsFuncoesBase.getSituacaoNome(_Aproveitamento.tb_situacao_aprov).
                    Equals(SITUACOES_APROVEITAMENTO.Aprovado.ToString()))
                {
                    this.btnAprovar.Enabled = false;
                }
                else if (clsFuncoesBase.getSituacaoNome(_Aproveitamento.tb_situacao_aprov).
                    Equals(SITUACOES_APROVEITAMENTO.Rejeitado.ToString()))
                {
                    this.btnReprovar.Enabled = false;
                }
                else if (clsFuncoesBase.getSituacaoNome(_Aproveitamento.tb_situacao_aprov).
                    Equals(SITUACOES_APROVEITAMENTO.Encaminhado.ToString()))
                {
                    this.btnEncaminhar.Enabled = false;
                }
            }            
        }
    }
}
