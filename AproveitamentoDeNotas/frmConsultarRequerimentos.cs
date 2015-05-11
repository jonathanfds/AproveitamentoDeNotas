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

        private void frmConsultarRequerimentos_Load(object sender, EventArgs e)
        {
            string[] ArraytoGrid = new string[] { "1430481423035", "Jonathan Freire da Silva",
                "Análise e Desenvolvimento de Sistemas","Finalizada" };             
            this.dataGridView1.Rows.Add(ArraytoGrid);
        }
        
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
