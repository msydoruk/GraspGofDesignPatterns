using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class WaiterTouchTablet
    {
        private readonly List<ICommand> commands = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }
    }
}
