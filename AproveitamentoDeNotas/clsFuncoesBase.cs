using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AproveitamentoDeNotas
{
    class clsFuncoesBase
    {
        #region --Funcoes do Usuário
        public static TB_USUARIOS getUsuarios(string pUser, string pSenha)
        {
            TB_USUARIOS lUsuarios = null;
            SqlConnection lSqlconn = new SqlConnection();
            lSqlconn.ConnectionString = clsGlobal.ConnectionString;
            lSqlconn.Open();
            SqlCommand lSqlComm = lSqlconn.CreateCommand();
            lSqlComm.CommandText = "SELECT TOP 1 * FROM tb_usuarios Where nome_User = '" + pUser + "' and pass_user = '" + pSenha + "'";
            using (SqlDataReader dr = lSqlComm.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lUsuarios = new TB_USUARIOS();
                        lUsuarios.id_user = Convert.ToInt32(dr["id_user"].ToString());
                        lUsuarios.nome_user = dr["nome_user"].ToString();
                        lUsuarios.pass_user = dr["pass_user"].ToString();
                        lUsuarios.id_funcao_usuario = Convert.ToInt32(dr["id_funcao_usuario"].ToString());
                    }
                }
            }
            lSqlconn.Close();
            lSqlconn.Dispose();
            return lUsuarios;
        }
        public static bool InserirUsuário(TB_USUARIOS pUsuario)
        {
            bool lReturn = false;
            SqlConnection lSqlconn = new SqlConnection();
            lSqlconn.ConnectionString = clsGlobal.ConnectionString;
            lSqlconn.Open();
            SqlCommand lSqlComm = lSqlconn.CreateCommand();
            lSqlComm.CommandText = "INSERT INTO tb_usuarios VALUES('" + pUsuario.nome_user + "','" + pUsuario.pass_user + "'," + pUsuario.id_funcao_usuario + ")";
            if (lSqlComm.ExecuteNonQuery() > 0)
            {
                lReturn = true;
            }
            lSqlconn.Close();
            lSqlconn.Dispose();
            return lReturn;

        }
        public static bool AlterarUsuário(TB_USUARIOS pUsuario)
        {
            bool lReturn = false;
            SqlConnection lSqlconn = new SqlConnection();
            lSqlconn.ConnectionString = clsGlobal.ConnectionString;
            lSqlconn.Open();
            SqlCommand lSqlComm = lSqlconn.CreateCommand();
            lSqlComm.CommandText = "UPDATE tb_usuarios Set nome_User='" + pUsuario.nome_user + "',pass_User='" + pUsuario.pass_user + "',id_funcao_usuario=" + pUsuario.id_funcao_usuario + " where id_user=" + pUsuario.id_user + "";
            if (lSqlComm.ExecuteNonQuery() > 0)
            {
                lReturn = true;
            }
            lSqlconn.Close();
            lSqlconn.Dispose();
            return lReturn;

        }
        public static bool DeletarUsuário(TB_USUARIOS pUsuario)
        {
            bool lReturn = false;
            SqlConnection lSqlconn = new SqlConnection();
            lSqlconn.ConnectionString = clsGlobal.ConnectionString;
            lSqlconn.Open();
            SqlCommand lSqlComm = lSqlconn.CreateCommand();
            lSqlComm.CommandText = "DELETE FROM tb_usuarios where id_user=" + pUsuario.id_user + "";
            if (lSqlComm.ExecuteNonQuery() > 0)
                lReturn = true;
            lSqlconn.Close();
            lSqlconn.Dispose();
            return lReturn;

        }
        #endregion

        #region --Funcoes Instituto
        public static List<TB_INSTITUTO> getInstitutos()
        {
            List<TB_INSTITUTO> lTodosInstitutos = null;
            SqlConnection lSqlconn = new SqlConnection();
            lSqlconn.ConnectionString = clsGlobal.ConnectionString;
            lSqlconn.Open();
            SqlCommand lSqlComm = lSqlconn.CreateCommand();
            lSqlComm.CommandText = "SELECT * FROM tb_instituto";
            using (SqlDataReader dr = lSqlComm.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    lTodosInstitutos = new List<TB_INSTITUTO>();
                    while (dr.Read())
                    {
                        TB_INSTITUTO lInstituto = new TB_INSTITUTO();
                        lInstituto.id_instituto = Convert.ToInt32(dr["id_instituto"].ToString());
                        lInstituto.nome_instituto = dr["nome_instituto"].ToString();
                        lTodosInstitutos.Add(lInstituto);
                    }
                }
            }
            lSqlconn.Close();
            lSqlconn.Dispose();
            return lTodosInstitutos;
        }
        public bool InserirInstituto(string pNomeInstituto)
        {
            bool lReturn = false;
            SqlConnection lSqlconn = new SqlConnection();
            lSqlconn.ConnectionString = clsGlobal.ConnectionString;
            lSqlconn.Open();
            SqlCommand lSqlComm = lSqlconn.CreateCommand();
            lSqlComm.CommandText = "insert into tb_instituto values('" + pNomeInstituto + "')";
            if (lSqlComm.ExecuteNonQuery() > 0)            
                lReturn = true;
            lSqlconn.Close();
            lSqlconn.Dispose();
            return lReturn;
        }
        #endregion


    }

}
