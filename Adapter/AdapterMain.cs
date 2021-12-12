using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    class AdapterMain
    {
        public void Run()
        {
          

            ReturningStrings returningStrings = new();
            IStringConverter stringConverter = new StringConverter();
            PrintingInts printingInts = new();
            printingInts.Print(stringConverter.ConvertStringToInt(returningStrings.ReturnString()));

            Console.WriteLine("Press any key to return to PatternMenu");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
