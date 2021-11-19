using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneWeek7
{
    class Conto
    {
        public int NumeroConto { get; set; } //PK
        public decimal CreditoResiduo { get; set; } = 0;       
        public Utente Utente { get; set; } //Navigation property

        public Conto ()
        {

        }
        public Conto(int numeroConto, decimal creditoResiduo, Utente utente)
        {
            NumeroConto = numeroConto;
            CreditoResiduo = creditoResiduo;
            Utente = utente;
        }

    }
}
