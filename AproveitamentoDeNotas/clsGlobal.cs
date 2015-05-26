using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AproveitamentoDeNotas
{
    public class clsGlobal
    {
        public static TB_USUARIOS UsuarioLogado {get;set;}
        public static string ConnectionString = @"server=localhost\sqlexpress;database=db_aproveitamento;user=sa;pwd=123456";
    }
}
