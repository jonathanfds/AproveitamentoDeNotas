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
    public partial class frmConsultarRequerimentos : Form
    {
        public frmConsultarRequerimentos()
        {
            InitializeComponent();
            
        }
        List<tb_aproveitamento> _Aproveitamentos;
        List<tb_curso> _ListCursos;
        List<tb_situacao_aprov> _ListSituacao;

        private void frmConsultarRequerimentos_Load(object sender, EventArgs e)
        {
            _Aproveitamentos = clsFuncoesBase.getAproveitamentos();
            PreencheSituacoes();
            PreencherGrid(_Aproveitamentos);
        }
        private void PreencherGrid(List<tb_aproveitamento> pAproveitamento)
        {            
            string Codigo, RA, Nome, Curso, Status;
            dataGridView1.Rows.Clear();
            foreach (tb_aproveitamento AProv in pAproveitamento)
            {
                Codigo = AProv.id_aprov.ToString();
                RA = AProv.ra_aluno.ToString();
                Nome = AProv.nome_aluno;
                tb_curso tbCurso = clsFuncoesBase.getCurso(AProv.id_curso_atual);
                tb_situacao_aprov tbSituacao = AProv.tb_situacao_aprov;
                Curso = tbCurso.nome_curso;
                Status = clsFuncoesBase.getSituacaoNome(tbSituacao);
                string[] ArraytoGrid = new string[] { Codigo, RA, Nome, Curso, Status };
                this.dataGridView1.Rows.Add(ArraytoGrid);
            }
        }

        private void PreencheSituacoes()
        {
            this.cmbSituacao.Items.Clear();
            foreach (tb_situacao_aprov SitAprov in clsFuncoesBase.getSituacoes())
            {
                this.cmbSituacao.Items.Add(SitAprov.nome_situacao_aprov);
            }
        }
        
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
            string nome = txtNome.Text;
            string ra = txtRA.Text;
            string situacao=string.Empty;
            int codigo = -1;
            if(!string.IsNullOrEmpty(txtCod.Text))
                codigo = Convert.ToInt32(txtCod.Text);

            if (codigo > 0)
            {
                PreencherGrid(_Aproveitamentos.Where(t => t.id_aprov.Equals(codigo)).ToList());
                return;
            }

            if (cmbSituacao.SelectedItem != null)
            {
                situacao = cmbSituacao.SelectedItem.ToString();
            }

            if (!string.IsNullOrEmpty(nome))
            {
                PreencherGrid(_Aproveitamentos.Where(t=>t.nome_aluno.Contains(nome)).ToList());
                return;
            }
            else if (!string.IsNullOrEmpty(ra))
            {
                PreencherGrid(_Aproveitamentos.Where(t => t.ra_aluno.Equals(ra)).ToList());
                return;
            }
            else if (!string.IsNullOrEmpty(situacao))
            {

                PreencherGrid(_Aproveitamentos.Where(t => t.tb_situacao_aprov.Equals(clsFuncoesBase.getSituacoes()
                    .Find(t2 => t2.nome_situacao_aprov.Equals(situacao)))).ToList());
                return;
            }
            else
            {
                _Aproveitamentos = clsFuncoesBase.getAproveitamentos();
                PreencheSituacoes();
                PreencherGrid(_Aproveitamentos);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int IdAprov = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            tb_aproveitamento lAproveitamento = _Aproveitamentos.Find(t => t.id_aprov.Equals(IdAprov));
            frmComparar FormCompare = new frmComparar(lAproveitamento);
            if (FormCompare.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                _Aproveitamentos = clsFuncoesBase.getAproveitamentos();
                PreencheSituacoes();
                PreencherGrid(_Aproveitamentos);
            }
        }
    }
}
