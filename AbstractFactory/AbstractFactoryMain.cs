using Assignment2.AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på en sträng parameter
        
        public void Run()
        {
            var loop = true;
           
            FactoryBuilder factoryBuilder = new FactoryBuilder();
            Console.WriteLine("What factory do you want to create?");
            Console.WriteLine("Cat or a dog factory?");
            while (loop)
            {
                var factory = factoryBuilder.GetFactory(Console.ReadLine());
                if(factory == null)
                {
                    Console.WriteLine("Please write cat or dog.");
                }
                else
                {
                    Console.WriteLine("What´s your animals name?");
                    var animal = factory.CreateAnimal(Console.ReadLine());
                    Console.WriteLine($"{animal.Name} is a {animal.GetType().Name}");
                    Console.WriteLine("Press any key to return to PatternMenu");
                    Console.ReadKey();
                    loop = false;
                    Console.Clear();
                }
            }
           
           
        }
    }
}
