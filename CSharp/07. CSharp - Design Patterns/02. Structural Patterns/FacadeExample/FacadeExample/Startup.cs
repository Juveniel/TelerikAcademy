using FacadeExample.Contracts;
using FacadeExample.Models;

namespace FacadeExample
{
    public class Startup
    {
        internal static void Main()
        {
            ILoanManager manager = new LoanManager();
            IRiskConsultant consultant = new RiskConsultat();

            var bank = new LoanFacade(manager, consultant);

            bank.ProcessLoanApplication();
        }
    }
}
