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
    
    public partial class tb_instituto_curso
    {
        public tb_instituto_curso()
        {
            this.tb_disciplina = new HashSet<tb_disciplina>();
        }
    
        public int id_inst_curso { get; set; }
        public int id_instituo { get; set; }
        public int id_curso { get; set; }
    
        public virtual tb_curso tb_curso { get; set; }
        public virtual ICollection<tb_disciplina> tb_disciplina { get; set; }
        public virtual tb_instituto tb_instituto { get; set; }
    }
}
