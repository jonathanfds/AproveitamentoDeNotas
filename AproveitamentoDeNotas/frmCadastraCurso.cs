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
    public partial class frmCadastraCurso : Form
    {
        private List<tb_curso> _ListadeCursos;
        public frmCadastraCurso()
        {
            InitializeComponent();
        }

        private void btnSalvarCurso_Click(object sender, EventArgs e)
        {
            string lNomeCurso = this.txtNomeCurso.Text;
            tb_curso lCurso = new tb_curso() {  nome_curso = lNomeCurso };
            if (clsFuncoesBase.insertCurso(lCurso))
                MessageBox.Show("Curso cadastrado !");
            else
                MessageBox.Show("Erro ao cadastrar instituição !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            PreencheCursos();
        }
        private void PreencheCursos()
        {
            _ListadeCursos = clsFuncoesBase.getCursos();
            this.dataGridView1.Rows.Clear();
            foreach (tb_curso Curso in _ListadeCursos)
            {
                string[] linhaGrid = new string[] { Curso.id_curso.ToString(), Curso.nome_curso };
                this.dataGridView1.Rows.Add(linhaGrid);
            }
        }

        private void frmCadastraCurso_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            PreencheCursos();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)//Botão Excluir
            {
                if (MessageBox.Show("Deseja excluir o curso?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tb_curso lCurso = _ListadeCursos.Find(T => T.id_curso.ToString() == this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (clsFuncoesBase.deleteCurso(lCurso))
                    {
                        MessageBox.Show("Curso excluído !");
                        PreencheCursos();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao excluir o curso.");
                    }
                };
            }
                
        }

    }
}
