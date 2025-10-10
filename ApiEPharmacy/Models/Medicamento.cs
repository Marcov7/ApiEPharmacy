namespace ApiEPharmacy.Models
{
    public class Medicamento
    {
        public int Id { get; set; }
        public string EAN { get; set; }
        public string Produto { get; set; }
        public int? ClasseTerapeuticaId { get; set; }
        public int? TipoReceitaId { get; set; }
        public int? FabricanteId { get; set; }
        public int? SubstanciaId { get; set; }
        public string? TUSS { get; set; }
        public int? NcmId { get; set; }
        public int? ListaId { get; set; }
        public int? RegimeId { get; set; }

        public bool? Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Usuario { get; set; }
    }
}
