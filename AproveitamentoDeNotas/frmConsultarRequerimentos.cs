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
        frmMain _FormPrincipal;
        public frmConsultarRequerimentos(frmMain FormPrincipal)
        {
            InitializeComponent();
            _FormPrincipal = FormPrincipal;
        }

        private void frmConsultarRequerimentos_Load(object sender, EventArgs e)
        {
            string[] ArraytoGrid = new string[] { "1430481423035", "Jonathan Freire da Silva",
                "Análise e Desenvolvimento de Sistemas","Finalizada" };
            DataGridViewRow dr = new DataGridViewRow(); 
            foreach(string cellvalue in ArraytoGrid)
            {
                DataGridViewTextBoxCell currentcell= new DataGridViewTextBoxCell();
                currentcell.Value=cellvalue;
                dr.Cells.Add(currentcell);
            }            
            this.dataGridView1.Rows.Add(dr);
        }
        
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _FormPrincipal.AbrirFormNoPanel(ListaDeForms.Form_Comparar_Materias, 665, 684, 885, 735);
        }
    }
}
