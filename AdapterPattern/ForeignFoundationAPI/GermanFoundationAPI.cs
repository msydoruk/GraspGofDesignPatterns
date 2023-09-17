using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.TaxAPI
{
    public class ItalianFoundationAPI
    {
        public object OttenereMembri()
        {
            return "Ottenere Membri";
        }

        public object OttenereNumeroDiAllegati()
        {
            return "Ottenere Numero Di Allegati";
        }

        public object OttenereBudget()
        {
            return "Ottenere Budget";
        }
    }
}
