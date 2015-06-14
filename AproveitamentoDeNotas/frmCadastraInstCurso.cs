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
    public partial class frmCadastraInstCurso : Form
    {
        public frmCadastraInstCurso()
        {
            InitializeComponent();
        }
        private int _IdInstituicao;
        private List<tb_curso> _ListadeCursos;
        private void btnSalvarInst_Click(object sender, EventArgs e)
        {
            string lNomeInstituicao = this.txtNomeInstituicao.Text;
            tb_instituto lInstitucao = new tb_instituto() { nome_instituto = lNomeInstituicao };            
            if (clsFuncoesBase.insertInstituicao(lInstitucao)){
                MessageBox.Show("Instituição cadastrada !");
                PreencheInstituicoes();
            }
            else
                MessageBox.Show("Erro ao cadastrar instituição !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void PreencheInstituicoes()
        {
            List<tb_instituto> lListInstituto = new List<tb_instituto>();
            lListInstituto = clsFuncoesBase.getInstituicoes();
            this.dgvInstituicao.Rows.Clear();
            foreach (tb_instituto Instituto in lListInstituto)
            {
                string[] LinhaGrid = new string[] { Instituto.id_instituto.ToString(), Instituto.nome_instituto };
                this.dgvInstituicao.Rows.Add(LinhaGrid);
            }
        }

        private void PreencheCursos()
        {
            _ListadeCursos = clsFuncoesBase.getCursos();
            this.lstCursoCadastrados.Items.Clear();
            foreach (tb_curso Curso in _ListadeCursos)
            {
                this.lstCursoCadastrados.Items.Add(Curso.nome_curso);
            }
        }

        private void frmCadastraInstCurso_Load(object sender, EventArgs e)
        {
            this.PreencheInstituicoes();
            this.PreencheCursos();
        }

        private void PreencheCursosInstituicao(int pIdInst)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<tb_curso> lCursos = clsFuncoesBase.getCursosInstituicao(pIdInst);
            this.lstCursosInst.Items.Clear();
            foreach (tb_curso Curso in lCursos)
            {
                this.lstCursosInst.Items.Add(Curso.nome_curso);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string lNomeCurso = lstCursoCadastrados.SelectedItem.ToString();
            tb_curso lCursoSelecionado = _ListadeCursos.Find(T => T.nome_curso.Equals(lNomeCurso));
            if (!lstCursosInst.Items.Contains(lNomeCurso))
            {
                if (clsFuncoesBase.insertCursoInstituicao(this._IdInstituicao, lCursoSelecionado.id_curso))
                {
                    MessageBox.Show("Curso adicionado a instituição !");
                    this.PreencheCursosInstituicao(_IdInstituicao);
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar curso a instituição !");
                }
            }
        }

        private void dgvInstituicao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //_IdInstituicao = Convert.ToInt32(this.dgvInstituicao.Rows[e.RowIndex].Cells[0].Value);
            //this.PreencheCursosInstituicao(_IdInstituicao);
        }

        private void dgvInstituicao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _IdInstituicao = Convert.ToInt32(this.dgvInstituicao.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex != 2)
                this.PreencheCursosInstituicao(_IdInstituicao);
            else
            { 
                //EXCLUIR
            }
        }

        private void lklNovoCurso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (new frmCadastraCurso().ShowDialog() == DialogResult.OK)
            {
                this.PreencheCursos();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastraInstCurso_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string lNomeCurso = lstCursosInst.SelectedItem.ToString();
            tb_curso lCursoSelecionado = _ListadeCursos.Find(T => T.nome_curso.Equals(lNomeCurso));

            if (clsFuncoesBase.deleteCursoInstituicao(this._IdInstituicao, lCursoSelecionado.id_curso))
            {
                MessageBox.Show("Curso removiado da instituição !");
                this.PreencheCursosInstituicao(_IdInstituicao);
            }
            else
            {
                MessageBox.Show("Erro ao remover curso da instituição !");
            }
        }        
    }
}
