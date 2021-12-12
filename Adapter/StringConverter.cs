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

        public StringConverter()
        {
            PrintingInts = new PrintingInts();
        }


        //public void ConvertStringToInt(string strings)
        //{
        //    var convertedString = Convert.ToInt32(strings);
        //    PrintingInts.Print(convertedString);
        //}
        public int ConvertStringToInt(string strings)
        {
            var convertedString = Convert.ToInt32(strings);
            return convertedString;
        }
    }
}
