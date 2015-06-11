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

        private void frmConsultarRequerimentos_Load(object sender, EventArgs e)
        {
            PreencherGrid();
        }
        private void PreencherGrid()
        {
            _Aproveitamentos = clsFuncoesBase.getAproveitamentos();
            string Codigo, RA, Nome, Curso, Status;
            foreach (tb_aproveitamento AProv in _Aproveitamentos)
            {
                Codigo = AProv.id_aprov.ToString();
                RA = AProv.ra_aluno.ToString();
                Nome = AProv.nome_aluno;
                Curso = clsFuncoesBase.getCurso(AProv.id_curso_atual).nome_curso;
                Status = clsFuncoesBase.getSituacaoNome(AProv.tb_situacao_aprov);
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

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int IdAprov = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            tb_aproveitamento lAproveitamento = _Aproveitamentos.Find(t => t.id_aprov.Equals(IdAprov));
            frmComparar FormCompare = new frmComparar(lAproveitamento);
            FormCompare.Show();

        }
    }
}
