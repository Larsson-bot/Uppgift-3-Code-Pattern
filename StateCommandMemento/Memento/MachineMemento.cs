using Assignment2.StateCommandMemento.Command;
using Assignment2.StateCommandMemento.State;
using System.Collections.Generic;

namespace Assignment2.StateCommandMemento.Memento
{
    public class MachineMemento
    {
        public Machine Machine { get; set; }
        public IMachineState MachineState { get; set; }
        public List<ICommand> Commands { get; set; }

        public MachineMemento(Machine machine, IMachineState machineState, List<ICommand> commands)
        {
            Machine = machine;
            MachineState = machineState;
            Commands = commands;
        }

        public void Restore()
        {
            Machine.MachineState = MachineState;
            Machine.Commands.Clear();
        }
    }
}