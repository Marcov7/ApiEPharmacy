namespace ApiEPharmacy.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? NomeSocial { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string CPF { get; set; }

        public string Sexo { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }

        public string Municipio { get; set; }
        public string ? Complemento { get; set; }
        public string Uf { get; set; }
        public string CEP { get; set; }
        public string ? Zona { get; set; }

        public string? Telefone { get; set; }
        public string? Celular { get; set; }
        public string Email { get; set; }

        public DateTime? DataPrimeiroAtendimento { get; set; }

        public DateTime? DataInclusaoConvenio { get; set; }
        public int? ModalidadeEntregaId { get; set; }

        public int? ConvenioId { get; set; }
        public string? Matricula { get; set; }
        public string? Carteirinha { get; set; }
        public DateTime? Validade { get; set; }
        public string? Autorizacao { get; set; }
        public int? TipoEntregaId { get; set; }
        public bool? Ativo {  get; set; }    

        public DateTime DataCadastro { get; set; }
        public int Usuario { get; set; }
    }
}

