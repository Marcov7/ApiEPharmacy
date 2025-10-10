using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApiEPharmacy.Models
{


    // ViewModel para retorno da consulta com dados relacionados
    public class MedicamentoPrecoViewModel
    {   
        public int ReceitaItensId { get; set; }
        public int PacienteId { get; set; }
        public string Matricula { get; set; }
        public int? ConvenioId { get; set; }
        public string? Convenio { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public int? StatusId { get; set; }
        public string? Status { get; set; }
        //public DateTime? DataInclusaoConvenio { get; set; }
        public DateTime? DataPrimeiroAtendimento { get; set; }
        public int MedicamentoId { get; set; }
        public string EAN { get; set; }
        public string Produto { get; set; }
        public int? Qtdd { get; set; }
        //public decimal Total { get { return Qtdd * PrecoAcordado; } }
        public decimal PrecoAcordado { get; set; }
        public string Total { get; set; }

        public int ReceitaId { get; set; }
        public string ReceitaDescricao { get; set; }
        public DateTime? DataReceitaAnterior { get; set; } 
        public DateTime DataReceita { get; set; }
        public int? PeriodicidadeId { get; set; }
        public string Periodicidade { get; set; }
        /*public int ClasseTerapeuticaId { get; set; }

        public int FabricanteId { get; set; }
        public int SubstanciaId { get; set; }
        public int MedicamentoPrecoId { get; set; }*/

        public DateTime? Refil1 { get; set; }
        public DateTime? Refil2 { get; set; }
        public DateTime? Refil3 { get; set; }
        public DateTime? Refil4 { get; set; }
        public DateTime? Refil5 { get; set; }
        public DateTime? Refil6 { get; set; }
        public DateTime? RefilExtra { get; set; }

        public int TipoReceitaId { get; set; }
        public string TipoReceita { get; set; }
        // Campos das tabelas relacionadas

        public string? Obs { get; set; }

        public string Celular { get; set; }
        public string Telefone { get; set; }

        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Zona { get; set; }
        public string ? Modalidade { get; set; }
        public string ? TipoEntrega { get; set; }
        public string Autorizacao { get; set; }

        public string ClasseTerapeutica { get; set; }

        public string Fabricante { get; set; }
        public string Substancia { get; set; }

    }


    //Pedido
    public class PedidoViewModel
    {   
        public int ReceitaItensId { get; set; }
        public int PacienteId { get; set; }

        public int? ReceitaItensEntregaId { get; set; }
        public DateTime? DataEntrega { get; set; }
        public string Zona { get; set; }
        public string Matricula { get; set; }
        public int? ConvenioId { get; set; }
        public string? Convenio { get; set; }

        public string CPF { get; set; }
        public string Nome { get; set; }
        public int MedicamentoId { get; set; }
        public string EAN { get; set; }
        public string Produto { get; set; }


        public int? Qtdd { get; set; }
        public int? Real { get; set; }
        public decimal PrecoAcordado { get; set; }
        public string Total { get; set; }


        public string? NotaFiscal { get; set; }
        public int? StatusEntregaId { get; set; }
        public string? StatusEntrega { get; set; }
        public string? Lote { get; set; }


        public string? Obs { get; set; }
        public int? PeriodicidadeId { get; set; }
        public string Periodicidade { get; set; }
        public int TipoReceitaId { get; set; }
        public string TipoReceita { get; set; }


        public string Celular { get; set; }
        public string Telefone { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string CEP { get; set; }

        public string? Modalidade { get; set; }
        public string? TipoEntrega { get; set; }


        public int? RefilId { get; set; }
        public string? Refil { get; set; }
        public int? StatusId { get; set; }
        public string Status { get; set; }
        public DateTime DataInclusaoConvenio { get; set; }
        //public decimal Total { get { return Qtdd * PrecoAcordado; } }
        public int ReceitaId { get; set; }
        public string ReceitaDescricao { get; set; }
        public DateTime? DataReceitaAnterior { get; set; } 
        public DateTime DataReceita { get; set; }

        /*public int ClasseTerapeuticaId { get; set; }

        public int FabricanteId { get; set; }
        public int SubstanciaId { get; set; }
        public int MedicamentoPrecoId { get; set; }*/

        public DateTime? Refil1 { get; set; }
        public DateTime? Refil2 { get; set; }
        public DateTime? Refil3 { get; set; }
        public DateTime? Refil4 { get; set; }
        public DateTime? Refil5 { get; set; }
        public DateTime? Refil6 { get; set; }
        public DateTime? RefilExtra { get; set; }
        // Campos das tabelas relacionadas
        public string Autorizacao { get; set; }
        public string ClasseTerapeutica { get; set; }
        public string Fabricante { get; set; }
        public string Substancia { get; set; }

    }



    // não usada
    public class BaseCadastral
    {
        public int Id { get; set; } 
        public int PacienteId { get; set; }    
        public string Matricula { get; set; }     
        public string ConvenioId { get; set; }      
        public string CPF { get; set; }
        public string Nome { get; set; }
        public int Status { get; set; }
        public DateTime DataInclusao { get; set; }
        public int MedicamentoId { get; set; }
        public string EAN { get; set; }
        //public string MedicamentoId { get; set; }
        public string Produto { get; set; }
        public int ? Qtdd { get; set; }
        public int MedicamentoPrecoId { get; set; }
        public decimal PrecoAcordado { get; set; }     //PRICE    
        public decimal Total { get; set; }
        public int ReceitaId { get; set; }
        public DateTime DataRecVenc { get; set; } 
        public DateTime DataReceita { get; set; }      
        public string PeriodicidadeRefilId { get; set; }
        public string Refil1 { get; set; }
        public string Refil2 { get; set; }
        public string Refil3 { get; set; }
        public string Refil4 { get; set; }  
        public string Refil5 { get; set; }
        public string Refil6 { get; set; }
        public string RefilExtra { get; set; } 
        public string TipoReceitaId { get; set; }       //RECEITA
        public string? Obs { get; set; }     
        public string Celular { get; set; }      
        public string Logradouro { get; set; }      //ENDEREÇO 
        public string Bairro { get; set; }      
        public string Localidade { get; set; }      
        public string CEP { get; set; }
        public string ModalidadeId { get; set; }     //MODALIDADE
        public string TipoEntregaId { get; set; }       //ENTREGA
        public string Zona { get; set; } 
        public string Autorizacao { get; set; }          
        public string Generico { get; set; }
        public Int64 Soma { get; set; }
        public string TUSS { get; set; }
        
    }



}
