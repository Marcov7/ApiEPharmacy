using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEPharmacy.Models
{
    public class Lista
    {
        public int Id { get; set; }
        public string Descricao { get; set; }


        // Método para retornar a lista de Lista 
        public static List<Lista> ObterTodosListas()
        {
            return new List<Lista>
            {
                new Lista { Id = 0, Descricao = "Selecione" },
                new Lista { Id = 1, Descricao = "Positiva" },
                new Lista { Id = 2, Descricao = "Negativa" },
                new Lista { Id = 3, Descricao = "Neutra" },
            };
        }

        public static Lista ObterLista(int? ListaId)
        {
            Lista lista = new Lista();
            if (ListaId == 1) lista.Descricao = "Positiva";
            if (ListaId == 2) lista.Descricao = "Negativa";
            if (ListaId == 3) lista.Descricao = "Neutra";
            return lista;
        }
    }
}

