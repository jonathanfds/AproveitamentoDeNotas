using System;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AproveitamentoDeNotas
{
    
    public class clsGlobal
    {
        public static Configuration ConfigurationMng = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
        public static tb_usuarios UsuarioLogado {get;set;}
        public static string ConnectionString = @"server=localhost\sqlexpress;database=db_aproveitamento;user=sa;pwd=123456";
        public static int ID_INSTITUICAO_PADRAO = 1;

        public static void SetConfigurations()
        {
            string Server = clsGlobal.ConfigurationMng.AppSettings.Settings["Server"].Value;
            string database = clsGlobal.ConfigurationMng.AppSettings.Settings["Database"].Value;
            string user = clsGlobal.ConfigurationMng.AppSettings.Settings["User"].Value;
            string password = clsGlobal.ConfigurationMng.AppSettings.Settings["Password"].Value;
            clsGlobal.ID_INSTITUICAO_PADRAO = Convert.ToInt32(clsGlobal.ConfigurationMng.AppSettings.Settings["InstitutoPadrao"].Value);
            clsGlobal.ConnectionString = "server=" + Server + ";database=" + database + ";user=" + user + ";pwd=" + password;
        }

    }
    public enum SITUACOES_APROVEITAMENTO 
    { 
        Pendente = 1,
        Aprovado = 2,
        Rejeitado = 3,
        Encaminhado = 4
    }
    public enum FUNCOES_USUARIOS
    {
        Administrador = 1,
        Funcionário = 2
    }
}
