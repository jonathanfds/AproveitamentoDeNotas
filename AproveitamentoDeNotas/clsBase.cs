using System;                       
using System.Collections.Generic;   
using System.Text;                  
using System.Data;                  
using System.Data.Common;           
using System.Data.SqlClient;        
                                    
namespace AproveitamentoDeNotas
{
    public class TB_APROVEITAMENTO 
    {
        private int _id_aprov;
        
        public int id_aprov
        {
            get{ return _id_aprov;}
            set{ _id_aprov = value;}
        }
        private DateTime _dt_aprov;
        
        public DateTime dt_aprov
        {
            get{ return _dt_aprov;}
            set{ _dt_aprov = value;}
        }
        private string _ra_aluno;
        
        public string ra_aluno
        {
            get{ return _ra_aluno;}
            set{ _ra_aluno = value;}
        }
        private string _nome_aluno;
        
        public string nome_aluno
        {
            get{ return _nome_aluno;}
            set{ _nome_aluno = value;}
        }
        private int _id_curso_atual;
        
        public int id_curso_atual
        {
            get{ return _id_curso_atual;}
            set{ _id_curso_atual = value;}
        }
        private int _id_disciplina_atual;
        
        public int id_disciplina_atual
        {
            get{ return _id_disciplina_atual;}
            set{ _id_disciplina_atual = value;}
        }
        private int _cod_disciplina_origem;
        
        public int cod_disciplina_origem
        {
            get{ return _cod_disciplina_origem;}
            set{ _cod_disciplina_origem = value;}
        }
        private string _id_situacao_aprov;
        
        public string id_situacao_aprov
        {
            get{ return _id_situacao_aprov;}
            set{ _id_situacao_aprov = value;}
        }
        private int _id_usuario;
        
        public int id_usuario
        {
            get{ return _id_usuario;}
            set{ _id_usuario = value;}
        }
    }
    public class TB_CURSO 
    {
        private int _id_curso;
        
        public int id_curso
        {
            get{ return _id_curso;}
            set{ _id_curso = value;}
        }
        private string _nome_curso;
        
        public string nome_curso
        {
            get{ return _nome_curso;}
            set{ _nome_curso = value;}
        }
        private int _id_instituto;
        
        public int id_instituto
        {
            get{ return _id_instituto;}
            set{ _id_instituto = value;}
        }
    }
    public class TB_DISCIPLINA 
    {
        private int _id_disciplina;
        
        public int id_disciplina
        {
            get{ return _id_disciplina;}
            set{ _id_disciplina = value;}
        }
        private string _nome_disciplina;
        
        public string nome_disciplina
        {
            get{ return _nome_disciplina;}
            set{ _nome_disciplina = value;}
        }
        private int _carga_horaria;
        
        public int carga_horaria
        {
            get{ return _carga_horaria;}
            set{ _carga_horaria = value;}
        }
        private string _ano_semestre;
        
        public string ano_semestre
        {
            get{ return _ano_semestre;}
            set{ _ano_semestre = value;}
        }
        private string _descricao;
        
        public string descricao
        {
            get{ return _descricao;}
            set{ _descricao = value;}
        }
        private int _id_curso;
        
        public int id_curso
        {
            get{ return _id_curso;}
            set{ _id_curso = value;}
        }
        private int _id_instituto;
        
        public int id_instituto
        {
            get{ return _id_instituto;}
            set{ _id_instituto = value;}
        }
    }
    public class TB_FUNCAO_USUARIO 
    {
        private int _id_funcao_usuario;
        
        public int id_funcao_usuario
        {
            get{ return _id_funcao_usuario;}
            set{ _id_funcao_usuario = value;}
        }
        private string _funcao;
        
        public string funcao
        {
            get{ return _funcao;}
            set{ _funcao = value;}
        }
    }
    public class TB_INSTITUTO 
    {
        private int _id_instituto;
        
        public int id_instituto
        {
            get{ return _id_instituto;}
            set{ _id_instituto = value;}
        }
        private string _nome_instituto;
        
        public string nome_instituto
        {
            get{ return _nome_instituto;}
            set{ _nome_instituto = value;}
        }
    }
    public class TB_SITUACAO_APROV 
    {
        private string _id_situacao_aprov;
        
        public string id_situacao_aprov
        {
            get{ return _id_situacao_aprov;}
            set{ _id_situacao_aprov = value;}
        }
        private string _nome_situacao_aprov;
        
        public string nome_situacao_aprov
        {
            get{ return _nome_situacao_aprov;}
            set{ _nome_situacao_aprov = value;}
        }
    }
    public class TB_USUARIOS 
    {
        private int _id_user;
        
        public int id_user
        {
            get{ return _id_user;}
            set{ _id_user = value;}
        }
        private string _nome_user;
        
        public string nome_user
        {
            get{ return _nome_user;}
            set{ _nome_user = value;}
        }
        private string _pass_user;
        
        public string pass_user
        {
            get{ return _pass_user;}
            set{ _pass_user = value;}
        }
        private int _id_funcao_usuario;
        
        public int id_funcao_usuario
        {
            get{ return _id_funcao_usuario;}
            set{ _id_funcao_usuario = value;}
        }
    }    
}
