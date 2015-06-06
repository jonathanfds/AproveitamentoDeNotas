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
        public static db_aproveitamento gEntityBase = new db_aproveitamento();

        public static tb_usuarios getUsuario(string pUser, string pSenha)
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
                return (numRows > 0);
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
                return (numRows > 0);
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
                return (numRows > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
       
        #endregion       

        public static List<tb_instituto> getInstituicoes()
        {
            try
            {
                List<tb_instituto> lInstituicoes = null;
                gEntityBase.Database.Connection.ConnectionString = clsGlobal.ConnectionString;
                lInstituicoes = gEntityBase.tb_instituto.ToList();
                gEntityBase.Database.Connection.Close();
                return lInstituicoes;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool insertInstituicao(tb_instituto pInstituto)
        {
            try
            {
                gEntityBase.Database.Connection.ConnectionString = clsGlobal.ConnectionString;
                gEntityBase.tb_instituto.Add(pInstituto);
                int numRows = gEntityBase.SaveChanges();
                gEntityBase.Database.Connection.Close();
                return (numRows > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static List<tb_curso> getCursos()
        {
            try
            {
                List<tb_curso> lCursos = null;
                gEntityBase.Database.Connection.ConnectionString = clsGlobal.ConnectionString;
                lCursos = gEntityBase.tb_curso.ToList();
                gEntityBase.Database.Connection.Close();
                return lCursos;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static tb_curso getCurso(int pId)
        {
            try
            {
                tb_curso lCurso = null;
                gEntityBase.Database.Connection.ConnectionString = clsGlobal.ConnectionString;
                lCurso = gEntityBase.tb_curso.ToList().Find(T => T.id_curso.Equals(pId));
                gEntityBase.Database.Connection.Close();
                return lCurso;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool insertCurso(tb_curso pCurso)
        {
            try
            {
                gEntityBase.Database.Connection.ConnectionString = clsGlobal.ConnectionString;
                gEntityBase.tb_curso.Add(pCurso);
                int numRows = gEntityBase.SaveChanges();
                gEntityBase.Database.Connection.Close();
                return (numRows > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool deleteCurso(tb_curso pCurso)
        {
            try
            {
                gEntityBase.Database.Connection.ConnectionString = clsGlobal.ConnectionString;
                gEntityBase.tb_curso.Remove(pCurso);
                int numRows = gEntityBase.SaveChanges();
                gEntityBase.Database.Connection.Close();
                return (numRows > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static List<tb_curso> getCursosInstituicao(int pIdInst)
        {
            try
            {
                List<tb_curso> lCursos = null;



                return lCursos;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }

}
