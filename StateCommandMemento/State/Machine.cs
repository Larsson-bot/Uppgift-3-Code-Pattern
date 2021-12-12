using Assignment2.StateCommandMemento.Command;
using Assignment2.StateCommandMemento.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.State
{
    public class Machine : IMachineState
    {
        public IMachineState MachineState { get; set; }
        public List<ICommand> Commands { get; set; }
        public Machine()
        {
            MachineState = new MachineOffState();
            Commands = new();
        }

        public void PowerSwitch()
        {
            if(MachineState is MachineOffState)
            {
                MachineState = new MachineOnState();
            }
            else
            {
                MachineState = new MachineOffState();
            }
        }

        public void Print(string word)
        {
            Console.WriteLine("Executing Print!");
            Console.WriteLine(word);
        }

        public MachineMemento CreateMemento()
        {
            return new MachineMemento(this, MachineState, Commands);
        }

    }
}
