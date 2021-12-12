using Assignment2.AbstractFactory;
using Assignment2.Adapter;
using Assignment2.Facade;
using Assignment2.StateCommandMemento;

using System;

namespace Assignment2
{
    internal class Program
    {
        private static void Main(string[] args)
        {


            bool loop = true;

            while (loop)
            {

                Console.WriteLine("1: Abstract Factory");
                Console.WriteLine("2: Facade");
                Console.WriteLine("3: Adapter");
                Console.WriteLine("4: State Command Memento");
                char userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case '1':
                        Console.Clear();
                        AbstractFactoryMain abstractFactory = new();
                        abstractFactory.Run();
                        break;
                    case '2':
                        Console.Clear();
                        FacadeMain facadeMain = new();
                        facadeMain.Run();
                        break;
                    case '3':
                        Console.Clear();
                        AdapterMain adapterMain = new();
                        adapterMain.Run();
                        break;
                    case '4':
                        Console.Clear();
                        SCMMain scmMain = new();
                        scmMain.Run();
                  
                        break;
                    case 'X' or 'x':
                        loop = false;
                        Console.WriteLine("Exiting program!");
                        break;
                    default:
                        Console.WriteLine("Incorrect input.");
                        break;
                }

            }
        }
    }
}