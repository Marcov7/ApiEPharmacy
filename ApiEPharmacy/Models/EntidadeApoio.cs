using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEPharmacy.Models
{
    public class EntidadeApoio
    {
        public int Id { get; set; }
        public DateTime? Data { get; set; }
        public string? EAN { get; set; }
        public string? Matricula { get; set; }
        public string? CPF { get; set; }
        public int? MedicamentoId { get; set; }
        public int? PacienteId { get; set; }
        public int? ConvenioId { get; set; }
        public int? StatusId { get; set; }
        public string? Bairro { get; set; }
        public string? Zona { get; set; }
        public int? TipoReceitaId { get; set; }

        /*
                txtId.Text = Id.ToString();
                txtEAN.Text = EAN;
                txtMatricula.Text = matricula;
                txtCPF.Text = CPF;
                cboMedicamento.SelectedValue = medicamentoId;
                cboPaciente.SelectedValue = pacienteId;

                cboConvenio.SelectedValue = convenioId;
                cboStatus.SelectedValue = statusId;

                cboBairro.SelectedValue = bairro;
                cboZona.SelectedValue = zona;
                cboTipoReceita.SelectedValue = tipoReceitaId;
        */
    }
}
