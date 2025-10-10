namespace ApiEPharmacy.Models
{
    public class ReceitaItens
    {
        public int Id { get; set; }
        public int ReceitaId { get; set; }
        public int MedicamentoId { get; set; }
        public DateTime? DataReceitaAnterior { get; set; }
        public int PeriodicidadeRefilId { get; set; }
        public int StatusId { get; set; }
        public int? Qtdd { get; set; }
        public string? Obs { get; set; }

        public DateTime? Refil1 { get; set; }
        public DateTime? Refil2 { get; set; }
        public DateTime? Refil3 { get; set; }
        public DateTime? Refil4 { get; set; }
        public DateTime? Refil5 { get; set; }
        public DateTime? Refil6 { get; set; }
        public DateTime? RefilExtra { get; set; }
        public bool? Ativo { get; set; }

        public DateTime DataCadastro { get; set; }
        public int Usuario { get; set; }
    }
}
