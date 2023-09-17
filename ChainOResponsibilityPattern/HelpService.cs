using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOResponsibilityPattern.Handler;

namespace ChainOResponsibilityPattern
{
    public class HelpService : IHelpService
    {
        private readonly List<IHelpHandler> helpHandlers;

        public HelpService()
        {
            this.helpHandlers = GetHelpHandlersFromConfiguration();
        }

        public string ProcessMessageFromEmployee(HelpCommand helpCommand)
        {
            if (helpHandlers.Count == 0)
                throw new Exception("No handler is registered.");

            string responseMessage = null!;
            foreach (var helpHandler in helpHandlers)
            {
                responseMessage = helpHandler.ProcessMessage(helpCommand);
                if (responseMessage == Constants.CannotProcessMessage)
                    continue;
                else
                    return responseMessage;
            }

            return responseMessage;
        }

        public List<IHelpHandler> GetHelpHandlersFromConfiguration()
        {
            return new List<IHelpHandler>
            {
                new FireDepartmentHandler(),
                new MedicalAssistanceHandler(),
                new PoliceHandler(),
                new ErrorHandler()
            };
        }
    }
}
