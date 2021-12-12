using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory.Factories
{
    public class FactoryBuilder
    {
        public FactoryBuilder()
        {

        }
        
        internal IFactory GetFactory(string factoryType)
        {
            if(factoryType.ToLower() == "dog")
            {
                return new DogFactory();
            }
            if(factoryType.ToLower() == "cat")
            {
                return new CatFactory();
            }
            return null;
        }
    }
}
