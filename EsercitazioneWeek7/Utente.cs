using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneWeek7
{
    class Utente
    {
        public int CodiceCliente { get; set; } //codice cliente
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public List<Conto> Conti { get; set; } = new List<Conto>();

        public Utente ()
        {

        }
    }
}
