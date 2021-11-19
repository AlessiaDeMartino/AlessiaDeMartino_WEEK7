using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UtenteNonTrovato
{
    class UtenteNonTrovatoException: Exception
    {
       public UtenteNonTrovatoException()
        {

        }

        public UtenteNonTrovatoException(string messaggio) : base(messaggio)
        {

        }

        public UtenteNonTrovatoException(string messaggio, Exception innerException) : base(messaggio, innerException)
        {

        }

        protected UtenteNonTrovatoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }

    }
}
