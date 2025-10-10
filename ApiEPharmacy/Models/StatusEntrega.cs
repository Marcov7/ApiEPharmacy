using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEPharmacy.Models
{
    public class StatusEntrega
    {
        public int Id { get; set; }
        public string? Sigla { get; set; }
        public string? Descricao { get; set; }
        //public string? SiglaDescricao { get { return Sigla + Descricao; } set { }}
        public string? Observacao { get; set; }  
    }
}
