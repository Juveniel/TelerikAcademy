using System;
using FacadeExample.Contracts;

namespace FacadeExample.Models
{
    public class RiskConsultat : IRiskConsultant
    {
        public void GetLoanApplication()
        {
            Console.WriteLine("Receive loan application.");
        }

        public void AssessRisk()
        {
            Console.WriteLine("Make risk assesment.");
        }

        public void SendReportToManager()
        {
            Console.WriteLine("Send report to the manager.");
        }
    }
}
