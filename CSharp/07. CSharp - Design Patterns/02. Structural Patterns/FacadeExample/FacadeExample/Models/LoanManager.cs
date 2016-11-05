using System;
using FacadeExample.Contracts;

namespace FacadeExample.Models
{
    public class LoanManager : ILoanManager
    {
        public void GetLoanApplicationAssessment()
        {
            Console.WriteLine("Receive loan application report.");
        }

        public void AuthorizeLoan()
        {
            Console.WriteLine("Authorize loan.");
        }
    }
}
