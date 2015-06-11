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
            this.Close();
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {

        }

        private void lblDescricaoInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblDescricaoReq_text_Click(object sender, EventArgs e)
        {

        }

        private void btnReprovar_Click(object sender, EventArgs e)
        {
            formMotivoRecusa frmMotivo = new formMotivoRecusa();
            frmMotivo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           frmMotivoExame frmMotivo = new frmMotivoExame();
           frmMotivo.Show();
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


            }
        }
    }
}
