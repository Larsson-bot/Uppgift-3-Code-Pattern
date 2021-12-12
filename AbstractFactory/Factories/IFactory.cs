using Assignment2.AbstractFactory.Interfaces;
using Assignment2.AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory.Factories
{
    public interface IFactory
    {
        IAnimal CreateAnimal(string name);
    }
}
