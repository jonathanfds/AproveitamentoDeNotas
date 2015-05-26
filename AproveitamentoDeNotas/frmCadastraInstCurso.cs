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
        private void btnSalvarInst_Click(object sender, EventArgs e)
        {
            string lNomeInstituicao = this.txtNomeInstituicao.Text;
            tb_instituto lInstitucao = new tb_instituto() { nome_instituto = lNomeInstituicao };            
            if (clsFuncoesBase.insertInstituicao(lInstitucao))
                MessageBox.Show("Instituição cadastrada !");
            else
                MessageBox.Show("Erro ao cadastrar instituição !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void PreencheGrid()
        {

        }

        private void frmCadastraInstCurso_Load(object sender, EventArgs e)
        {
            List<tb_instituto> lListInstituto = new List<tb_instituto>();
            lListInstituto = clsFuncoesBase.getInstituicoes();
            this.dgvInstituicao.Rows.Clear();
            foreach (tb_instituto Instituto in lListInstituto)
            {
                string[] DadosToGrid = new string[]{ Instituto.id_instituto.ToString(), Instituto.nome_instituto };
                this.dgvInstituicao.Rows.Add(DadosToGrid);
            }
        }
        
    }
}
