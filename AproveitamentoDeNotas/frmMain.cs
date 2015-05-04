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
    public enum ListaDeForms
    {
        Form_Consultar_Materia,
        Form_Adicionar_Materia,
        Form_Comparar_Materias
    };
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarMateria_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(ListaDeForms.Form_Adicionar_Materia, 478, 383, 704, 434);
        }

        public void AbrirFormNoPanel(ListaDeForms FormParaAbrir, int WidthPanel, int HeightPanel, int WidthForm, int HeightForm)
        {
            pnlOpenForms.Controls.Clear();
            Form AbrirForm = null;

            if (FormParaAbrir == ListaDeForms.Form_Consultar_Materia)
            {
                AbrirForm = new frmConsultarRequerimentos(this);
            }
            else if (FormParaAbrir == ListaDeForms.Form_Adicionar_Materia)
            {
                AbrirForm = new frmCadastroMateria();
            }
            else if (FormParaAbrir == ListaDeForms.Form_Comparar_Materias)
            {
                AbrirForm = new frmComparar();
            }
            AbrirForm.TopLevel = false;
            AbrirForm.AutoScroll = true;
            AbrirForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pnlOpenForms.Size = new Size(WidthPanel, HeightPanel);
            this.Size = new Size(WidthForm, HeightForm);
            this.pnlOpenForms.Controls.Add(AbrirForm);
            AbrirForm.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(ListaDeForms.Form_Consultar_Materia, 824, 450, 1035, 465);
            //824; 456
        }
    }
}
