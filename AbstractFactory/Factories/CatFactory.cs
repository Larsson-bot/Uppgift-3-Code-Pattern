using Assignment2.AbstractFactory.Interfaces;
using Assignment2.AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory.Factories
{
    class CatFactory : ICatFactory
    {
        public IAnimal CreateAnimal(string name)
        {
            //ICat cat = new Cat(name);
            return new Cat(name);
        }
    }
}
