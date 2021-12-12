using Assignment2.StateCommandMemento.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    class MachineCommand : ICommand
    {
        public MachineCommand(Machine machine, string textFromUser)
        {
            Machine = machine;
            TextFromUser = textFromUser;
        }

        private Machine Machine { get; set; }
        private string TextFromUser { get; set; }

        public void Execute()
        {
            Machine.Print(TextFromUser);
        }
    }
}
