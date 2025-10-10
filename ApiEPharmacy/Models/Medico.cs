using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiEPharmacy.Models
{
    public class Medico
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string CRM { get; set; } = string.Empty;

        public int EspecialidadeId { get; set; }

        [ForeignKey("EspecialidadeId")]
        public Especialidade? Especialidade { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public int Usuario { get; set; }

        public bool Ativo { get; set; } = true;
    }
}
