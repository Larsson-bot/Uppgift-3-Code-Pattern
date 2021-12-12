using Assignment2.AbstractFactory.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory.Models
{
    class Cat : ICat
    {
        public Cat(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

    }
}
