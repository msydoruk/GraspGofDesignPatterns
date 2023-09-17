using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.TaxAPI
{
    public class GermanFoundationAPI
    {
        public object TeilnehmerErhalten()
        {
            return "Teilnehmer Erhalten";
        }

        public object AnzahlDerAnhngeAbrufen()
        {
            return "Anzahl Der Anhnge Abrufen";
        }

        public object HolenSieSicEeinBudget()
        {
            return "Holen Sie Sic Eein Budget";
        }
    }
}
