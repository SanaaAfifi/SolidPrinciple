using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.InterfaceSegregationPrinciple
{
    //If we want to add more functionality, don't add to existing interfaces, segregate them out.

    /*no code should be forced to depend on methods it does not use.
    ISP splits interfaces that are very large into smaller and more specific ones 
    so that clients will only have to know about the methods that are of interest to them.
    */
    /* refrence https://stackify.com/interface-segregation-principle/ */
    interface ICoffeeMachine
    {
        void addGroundCoffee();
    }
    interface IBrewFilter : ICoffeeMachine
    {
        void brewFilterCoffee();
    }
    interface IEspressoFilter : ICoffeeMachine
    {
        void brewEspresso();
    }
    class BasicCoffeeMachine : IBrewFilter
    {
        /*The BasicCoffeeMachine class now implements the FilterCoffeeMachine interface,
      * which only defines the addGroundCoffee and the brewFilterCoffee methods.*/
        public void brewFilterCoffee()
        {
            Console.WriteLine("BasicCoffeeMachine.brewFilterCoffee");
        }
        public void addGroundCoffee()
        {
            Console.WriteLine("BasicCoffeeMachine.addGroundCoffee");
        }
    }

    class EsperssoCoffeeMachine : IEspressoFilter
    {
        public void addGroundCoffee()
        {
            Console.WriteLine("EsperssoCoffeeMachine.addGroundCoffee");
        }
        public void brewEspresso()
        {
            Console.WriteLine("brewEspresso.addGroundCoffee");
        }
    }
}
