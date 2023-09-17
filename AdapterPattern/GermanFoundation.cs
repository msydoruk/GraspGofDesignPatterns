using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.TaxAPI;

namespace AdapterPattern
{
    public class GermanFoundation : IFoundation
    {
        private readonly GermanFoundationAPI foundationAPI = new();

        public object GetMembers()
        {
            return foundationAPI.TeilnehmerErhalten();
        }

        public object GetNumberInvestments()
        {
            return foundationAPI.AnzahlDerAnhngeAbrufen();
        }

        public object GetBudget()
        {
            return foundationAPI.HolenSieSicEeinBudget();
        }
    }
}
