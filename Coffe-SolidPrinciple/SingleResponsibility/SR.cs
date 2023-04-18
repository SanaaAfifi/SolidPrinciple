using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.SingleResponsibility
{
    //A module should be responsible to one, and only one

    interface ICoffeOrder
    {
        void MakeOrder();
    }
    interface IPayment
    {
        void Pay();
    }
    class Payment :  IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Payment.Pay");
        }
    }
    class CoffeOrder : ICoffeOrder
    {
        IPayment payment = new Payment();
        public void MakeOrder()
        {
            Console.WriteLine("CoffeOrder.MakeOrder");
            payment.Pay();
        }
    }
}
