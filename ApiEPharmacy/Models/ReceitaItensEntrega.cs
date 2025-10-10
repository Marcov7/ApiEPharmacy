using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEPharmacy.Models
{
    public class ReceitaItensEntrega
    {
        public int Id { get; set; }
        public int ReceitaItensId { get; set; }
        public string? NumLote { get; set; }
        public string? NumNotaFiscal { get; set; }
        public int? Real { get; set; }
        public int? RefilId { get; set; }
        public DateTime? DataRefil { get; set; }
        public int? StatusEntregaId { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Usuario { get; set; }
    }
}
