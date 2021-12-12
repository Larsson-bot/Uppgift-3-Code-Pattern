using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    class StringConverter : IStringConverter
    {

        public PrintingInts PrintingInts { get; set; }
        public ReturningStrings ReturningStrings { get; set; }


        public StringConverter()
        {
            PrintingInts = new PrintingInts();
            ReturningStrings = new ReturningStrings();
        }


        //public void ConvertStringToInt(string strings)
        //{
        //    var convertedString = Convert.ToInt32(strings);
        //    PrintingInts.Print(convertedString);
        //}
        public int ConvertStringToInt(string strings)
        {
            Console.WriteLine($"Converting {strings} to int.");
            var convertedString = Convert.ToInt32(strings);
            return convertedString;
        }

        public int ConvertStringToInt2()
        {
            Console.WriteLine($"Converting {ReturningStrings} to int.");
            var convertedString = Convert.ToInt32(ReturningStrings);
            return convertedString;
        }
        public void Print()
        {
            PrintingInts.Print(ConvertStringToInt2());
        }
    }
}
