using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    class FacadeMain
    {
       public void Run()
        {


            FacadeService facadeService = new FacadeService();
            facadeService.Save();

            facadeService.Load();
            Console.WriteLine("Press any key to return to PatternMenu");
            Console.ReadKey();
  
            Console.Clear();
           
        }
    }
}
