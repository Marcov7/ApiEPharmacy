using ApiEPharmacy.Models;
using System.ComponentModel.DataAnnotations;

namespace ApiEPharmacy.Models
{
    public class Especialidade
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Descricao { get; set; } = string.Empty;

        public bool Ativo { get; set; } = true;

        // Relacionamento 1:N -> Uma especialidade tem muitos médicos
        //public ICollection<Medico>? Medico { get; set; }
    }
}
