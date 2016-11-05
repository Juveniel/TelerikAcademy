using System;
using ChainOfResponsibility.Models.Abstract;

namespace ChainOfResponsibility.Models
{
    internal class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                Console.WriteLine($"{this.GetType().Name} approved request# {purchase.Number}");
            }
            else
            {
                Console.WriteLine( $"Request# {purchase.Number} requires an executive meeting!");
            }
        }
    }
}
