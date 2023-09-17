using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.TaxAPI;

namespace AdapterPattern
{
    public class ItalianFoundation : IFoundation
    {
        private readonly ItalianFoundationAPI foundationAPI = new();

        public object GetMembers()
        {
            return foundationAPI.OttenereMembri();
        }

        public object GetNumberInvestments()
        {
            return foundationAPI.OttenereNumeroDiAllegati();
        }

        public object GetBudget()
        {
            return foundationAPI.OttenereBudget();
        }
    }
}
