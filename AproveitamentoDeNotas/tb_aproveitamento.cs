//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AproveitamentoDeNotas
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_aproveitamento
    {
        public int id_aprov { get; set; }
        public System.DateTime dt_aprov { get; set; }
        public string ra_aluno { get; set; }
        public string nome_aluno { get; set; }
        public int id_curso_atual { get; set; }
        public int id_disciplina_atual { get; set; }
        public int cod_disciplina_origem { get; set; }
        public byte id_situacao_aprov { get; set; }
        public int id_usuario { get; set; }
    
        public virtual tb_situacao_aprov tb_situacao_aprov { get; set; }
        public virtual tb_usuarios tb_usuarios { get; set; }
    }
}