using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOResponsibilityPattern.Handler
{
    internal class MedicalAssistanceHandler : IHelpHandler
    {
        public string ProcessMessage(HelpCommand helpCommand)
        {
            return helpCommand == HelpCommand.MedicalAssistance
                ? "Response medical assistance information"
                : Constants.CannotProcessMessage;
        }
    }
}
