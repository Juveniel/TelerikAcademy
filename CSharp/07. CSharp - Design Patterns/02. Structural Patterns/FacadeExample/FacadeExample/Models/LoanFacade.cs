using FacadeExample.Contracts;

namespace FacadeExample.Models
{
    public class LoanFacade
    {
        private readonly ILoanManager manager;
        private readonly IRiskConsultant consultant;

        public LoanFacade(ILoanManager manager, IRiskConsultant consultant)
        {
            this.manager = manager;
            this.consultant = consultant;
        }

        public void ProcessLoanApplication()
        {
            consultant.GetLoanApplication();
            consultant.AssessRisk();
            consultant.SendReportToManager();
            manager.GetLoanApplicationAssessment();
            manager.AuthorizeLoan();
        }
    }
}
