using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe_SolidPrinciple.InterfaceSegregationPrinciple
{
    interface ICoffeeMachine
    {
        void brewFilterCoffee();
        void addGroundCoffee();
        void brewEspresso(); // Espresso machine need this function 
    }
    class BasicCoffeeMachine : ICoffeeMachine
    {
        public void brewFilterCoffee()
        {
            Console.WriteLine("BasicCoffeeMachine.brewFilterCoffee");
        }
        public void addGroundCoffee()
        {
            Console.WriteLine("BasicCoffeeMachine.addGroundCoffee");
        }

        /* brewEspresso should be implmented (while it is not used) on the BasicCoffeeMachine class because
          it’s defined by the CoffeeMachine interface*/
        public void brewEspresso()
        {
            throw new NotImplementedException();
        }
    }

    class EsperssoCoffeeMachine : ICoffeeMachine
    {
        public void brewFilterCoffee()
        {
            Console.WriteLine("EsperssoCoffeeMachine.brewFilterCoffee");
        }
        public void addGroundCoffee()
        {
            Console.WriteLine("EsperssoCoffeeMachine.addGroundCoffee");
        }
        public void brewEspresso()
        {
            Console.WriteLine("EsperssoCoffeeMachine.addGroundCoffee");
        }
    }
}
