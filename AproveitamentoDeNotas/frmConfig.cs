using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AproveitamentoDeNotas
{
    public partial class frmConfig : Form
    {
        bool _isFromLogin = false;
        public frmConfig(bool isFromLogin)
        {
            InitializeComponent();
            this._isFromLogin = isFromLogin;
        }
        List<tb_instituto>_ListaInsts;

        private void frmConfig_Load(object sender, EventArgs e)
        {
            PreencheValores();
        }
        private void PreencheValores()
        {
            try
            {
                _ListaInsts = new List<tb_instituto>();
                if (!_isFromLogin)
                {
                    _ListaInsts = clsFuncoesBase.getInstituicoes();
                    if (_ListaInsts != null && _ListaInsts.Count>0)
                    {
                        this.cmbInstituicao.Items.Clear();
                        foreach (tb_instituto Instituto in _ListaInsts)
                        {
                            this.cmbInstituicao.Items.Add(Instituto.nome_instituto);
                        }
                        this.cmbInstituicao.SelectedItem = clsFuncoesBase.getInstituicao(clsGlobal.ID_INSTITUICAO_PADRAO).nome_instituto;
                    }
                    else
                    {
                        cmbInstituicao.Enabled = false;
                    }
                }
                else
                {
                    cmbInstituicao.Enabled = false;
                }
                this.txtServer.Text = clsGlobal.ConfigurationMng.AppSettings.Settings["Server"].Value;
                this.txtBase.Text = clsGlobal.ConfigurationMng.AppSettings.Settings["Database"].Value;
                this.txtUsuário.Text = clsGlobal.ConfigurationMng.AppSettings.Settings["User"].Value;
                this.txtSenha.Text = clsGlobal.ConfigurationMng.AppSettings.Settings["Password"].Value;
                
            }
            catch (Exception ex)
            { 
            
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool SaveConfig()
        {
            try
            {
                clsGlobal.ConfigurationMng.AppSettings.Settings.Remove("Server");
                clsGlobal.ConfigurationMng.AppSettings.Settings.Remove("Database");
                clsGlobal.ConfigurationMng.AppSettings.Settings.Remove("User");
                clsGlobal.ConfigurationMng.AppSettings.Settings.Remove("Password");

                if (cmbInstituicao.Enabled)
                    clsGlobal.ConfigurationMng.AppSettings.Settings.Remove("InstitutoPadrao");


                clsGlobal.ConfigurationMng.AppSettings.Settings.Add("Server", this.txtServer.Text);
                clsGlobal.ConfigurationMng.AppSettings.Settings.Add("Database", this.txtBase.Text);
                clsGlobal.ConfigurationMng.AppSettings.Settings.Add("User", this.txtUsuário.Text);
                clsGlobal.ConfigurationMng.AppSettings.Settings.Add("Password", this.txtSenha.Text);

                if (cmbInstituicao.Enabled)
                    clsGlobal.ConfigurationMng.AppSettings.Settings.Add("InstitutoPadrao", _ListaInsts.Find(t => t.nome_instituto == cmbInstituicao.SelectedItem).id_instituto.ToString());

                clsGlobal.ConfigurationMng.Save(ConfigurationSaveMode.Minimal);
                clsGlobal.SetConfigurations();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SaveConfig())
            {
                MessageBox.Show("Configurações salvas com sucesso !");
            }
            else
            {
                MessageBox.Show("Erro ao salvar configurações, tente novamente !");
            }
        }
    }
}
