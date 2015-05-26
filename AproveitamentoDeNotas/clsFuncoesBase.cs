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
        public static db_aproveitamentoEntities gEntityBase = new db_aproveitamentoEntities();

        public static tb_usuarios getUsuarios(string pUser, string pSenha)
        {
            try
            {
                tb_usuarios lUsuarios = null;
                gEntityBase.Database.Connection.ConnectionString = clsGlobal.ConnectionString;
                lUsuarios = gEntityBase.tb_usuarios.ToList().Find(T => T.nome_user == pUser && T.pass_user == pSenha);
                gEntityBase.Database.Connection.Close();
                return lUsuarios;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool insertUsuario(tb_usuarios pUsuario)
        {
            try
            {
                gEntityBase.Database.Connection.ConnectionString = clsGlobal.ConnectionString;
                gEntityBase.tb_usuarios.Add(pUsuario);
                int numRows = gEntityBase.SaveChanges();
                gEntityBase.Database.Connection.Close();
                if (numRows > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool deleteUsuario(tb_usuarios pUsuario)
        {
            try
            {
                gEntityBase.Database.Connection.ConnectionString = clsGlobal.ConnectionString;
                gEntityBase.tb_usuarios.Remove(pUsuario);
                int numRows = gEntityBase.SaveChanges();
                gEntityBase.Database.Connection.Close();
                if (numRows > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool updateUsuario(tb_usuarios pUsuario)
        {
            try
            {
                gEntityBase.Database.Connection.ConnectionString = clsGlobal.ConnectionString;
                tb_usuarios lUser = gEntityBase.tb_usuarios.ToList().Find(T => T.id_user == pUsuario.id_user);

                lUser.pass_user = pUsuario.pass_user;
                lUser.nome_user = pUsuario.nome_user;
                lUser.id_funcao_usuario = pUsuario.id_funcao_usuario;

                int numRows = gEntityBase.SaveChanges();
                gEntityBase.Database.Connection.Close();
                if (numRows > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion


    }

}
