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
    public partial class frmCadastrarUsuario : Form
    {
        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }
        List<tb_funcao_usuario> _FuncoesUser;
        private void frmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            PreencheFuncoes();
        }
        private void PreencheFuncoes()
        {
            this.cmbFuncoes.Items.Clear();
            _FuncoesUser =clsFuncoesBase.getFuncaoUsuario();
            foreach (tb_funcao_usuario Funcao in _FuncoesUser)
            {
                this.cmbFuncoes.Items.Add(Funcao.funcao);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tb_usuarios Usuario = new tb_usuarios();
            Usuario.nome_user = txtUser.Text;
            Usuario.pass_user = txtSenha.Text;
            Usuario.tb_funcao_usuario = _FuncoesUser.Find(t => t.funcao.Equals(cmbFuncoes.SelectedText));
            if (clsFuncoesBase.insertUsuario(Usuario))
            {
                MessageBox.Show("Usuario cadastrado !");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar usuario !");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
