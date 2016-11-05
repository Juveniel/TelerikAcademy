using System;
using ChainOfResponsibility.Models.Abstract;

namespace ChainOfResponsibility.Models
{
    internal class VicePresident : Approver
    {

        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000.0)
            {
                Console.WriteLine($"{this.GetType().Name} approved request# {purchase.Number}");
            }
            else
            {
                Successor?.ProcessRequest(purchase);
            }
        }
    }
}
