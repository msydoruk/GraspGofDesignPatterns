using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOResponsibilityPattern.Handler;

namespace ChainOResponsibilityPattern
{
    public interface IHelpService
    {
        string ProcessMessageFromEmployee(HelpCommand helpCommand);

        List<IHelpHandler> GetHelpHandlersFromConfiguration();
    }
}
