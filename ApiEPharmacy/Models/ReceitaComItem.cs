using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEPharmacy.Models
{
    public class ReceitaComItem
    {
        public Receita Receita { get; set; }
        public ReceitaItens ReceitaItens { get; set; }
    }
}
