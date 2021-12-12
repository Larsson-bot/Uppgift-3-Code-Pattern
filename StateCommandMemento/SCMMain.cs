using Assignment2.StateCommandMemento.Command;
using Assignment2.StateCommandMemento.Memento;
using Assignment2.StateCommandMemento.State;
using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */

        public void Run()
        {
            Machine machine = new Machine();
            MachineManager machineManager = new MachineManager(machine);
            MachineMemento machineMemento = machine.CreateMemento();

            bool loop = true;

            while (loop)
            {
                Console.WriteLine("1: Turn on / Turn off Machine");
                Console.WriteLine("2: Add and print out message");
                Console.WriteLine("3: Reset and turn off");
                Console.WriteLine("X: Stop Application");

                char userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case '1':
                        Console.Clear();
                        //Console.SetCursorPosition(0, Console.CursorTop - 1);
                        if (machine.MachineState is MachineOffState)
                        {
                            Console.WriteLine("Turning machine on!");
                            if(machine.Commands.Count != 0)
                            {
                                foreach (var item in machine.Commands)
                                {
                                    item.Execute();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Turning machine off!");
                        }
                        Console.WriteLine("Press any key to return to menu.");
                        Console.ReadKey();
                        machine.PowerSwitch();
                        Console.Clear();
                        break;

                    case '2':
                        Console.Clear();
                        Console.WriteLine("Please write the message you wanna print out!");
                        var message = Console.ReadLine();
                        Console.WriteLine("\n");
                        if (machine.MachineState is MachineOffState)
                        {
                            Console.WriteLine("Machine is off. WIll execute message when machine is turned on.");
                            machine.Commands.Add(new MachineCommand(machine, message));
                         
                        }
                        else
                        {
                            machineManager.Execute(message);
                        }
                        Console.WriteLine("Press any key to return to menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                

                    case '3':
                        machineMemento.Restore();
                        Console.WriteLine("Machine reset complete. Machine is in off mode.");
                        Console.WriteLine("Press any key to return to menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 'x' or 'X':
                        loop = false;
                        Console.Clear();
                        break;
                }
            }
        }
    }
}