using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    class Adaptr
    {
        public int ConvertStringToInt(string value)
        {
            return Convert.ToInt32(value);
        }
    }
}
