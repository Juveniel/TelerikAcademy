using ChainOfResponsibility.Models;
using ChainOfResponsibility.Models.Abstract;

namespace ChainOfResponsibility
{
    public class Startup
    {
        internal static void Main()
        {
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            // Generate and process purchase requests
            var purchase = new Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(purchase);

            purchase = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(purchase);

            purchase = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(purchase);
        }
    }
}
