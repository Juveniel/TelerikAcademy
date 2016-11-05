using Memento.Models;

namespace Memento
{
    public class Startup
    {
        public static void Main()
        {
            var salesProspect = new SalesProspect
            {
                Name = "Noel van Halen",
                Phone = "(412) 256-0990",
                Budget = 25000.0
            };

            var prospectMemory = new ProspectMemory
            {
                Memento = salesProspect.SaveMemento()
            };

            // Continue changing originator
            salesProspect.Name = "Leo Welch";
            salesProspect.Phone = "(310) 209-7111";
            salesProspect.Budget = 1000000.0;

            // Restore saved state
            salesProspect.RestoreMemento(prospectMemory.Memento);
        }
    }
}
