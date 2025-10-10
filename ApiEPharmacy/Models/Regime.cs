using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEPharmacy.Models
{
    public class Regime
    {
        public int Id { get; set; }
        public string Descricao { get; set; }


        // Método para retornar a lista de regimes
        public static List<Regime> ObterTodosRegimes()
        {
            return new List<Regime>
            {
                new Regime { Id = 0, Descricao = "Selecione" },
                new Regime { Id = 1, Descricao = "Monitorado" },
                new Regime { Id = 2, Descricao = "Liberado" },
            };
        }

        public static Regime ObterRegime(int? RegimeId)
        {
            Regime regime = new Regime();
            if (RegimeId == 1) regime.Descricao = "Monitorado";
            if (RegimeId == 2) regime.Descricao = "Liberado";
            return regime;
        }
    }
}
