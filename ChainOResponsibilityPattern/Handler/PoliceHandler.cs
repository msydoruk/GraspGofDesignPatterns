using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOResponsibilityPattern.Handler
{
    internal class PoliceHandler : IHelpHandler
    {
        public string ProcessMessage(HelpCommand helpCommand)
        {
            return helpCommand == HelpCommand.Police
                ? "Response police information"
                : Constants.CannotProcessMessage;
        }
    }
}
