using Assignment2.StateCommandMemento.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    class MachineManager
    {
      

        private Machine Machine { get; set; }


        public MachineManager(Machine machine)
        {
            Machine = machine;

        }


        public void Execute(string text)
        {
            ICommand command = new MachineCommand(Machine,text);
            if(Machine.MachineState is  MachineOffState)
            {
                Machine.Commands.Add(command);
            }
            else
            {
                command.Execute();
            }
        }

        //public void ExecuteSavedCommands()
        //{
        //    if(Machine.Commands.Count != 0)
        //    {
        //        Console.WriteLine("Executing saved commands.");
        //        foreach (var item in Commands)
        //        {
        //            item.Execute();
        //        }
        //    }
          
        //}

    }
}
