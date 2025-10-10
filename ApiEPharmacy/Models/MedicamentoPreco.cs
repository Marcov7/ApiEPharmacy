namespace ApiEPharmacy.Models
{
    public class MedicamentoPreco
    {
        public int Id { get; set; }
        public int MedicamentoId { get; set; }
        public decimal PrecoFabrica { get; set; }
        public decimal PrecoPmcBrasindice { get; set; }
        public decimal PrecoAcordado { get; set; }
        public int? UnidadesCaixa { get; set; }
        public decimal? PrecoUnitario { get; set; }
        public bool? Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Usuario { get; set; }
    }
}
