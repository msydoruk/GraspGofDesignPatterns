using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOResponsibilityPattern.Handler
{
    public class FireDepartmentHandler : IHelpHandler
    {
        public string ProcessMessage(HelpCommand helpCommand)
        {
            return helpCommand == HelpCommand.FireDepartment
                ? "Response fire department information"
                : Constants.CannotProcessMessage;
        }
    }
}
