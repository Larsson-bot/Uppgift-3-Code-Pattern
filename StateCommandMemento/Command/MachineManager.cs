using Assignment2.StateCommandMemento.State;

namespace Assignment2.StateCommandMemento.Command
{
    internal class MachineManager
    {
        private Machine Machine { get; set; }

        public MachineManager(Machine machine)
        {
            Machine = machine;
        }

        public void Execute(string text)
        {
            ICommand command = new MachineCommand(Machine, text);
            if (Machine.MachineState is MachineOffState)
            {
                Machine.Commands.Add(command);
            }
            else
            {
                command.Execute();
            }
        }
    }
}