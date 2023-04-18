using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe_SolidPrinciple.SingleResponsibility
{
    interface ICoffeOrder
    {
        void MakeOrder();
        void Pay(); //The Payment should be seperated in another class
    }
    class CoffeOrder : ICoffeOrder
    {
        public void MakeOrder()
        {
            Console.WriteLine("CoffeOrder.MakeOrder");
        }

        public void Pay()
        {
            Console.WriteLine("CoffeOrder.Pay");
        }
    }
}
