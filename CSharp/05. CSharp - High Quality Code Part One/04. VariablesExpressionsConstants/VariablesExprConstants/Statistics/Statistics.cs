namespace Statistics
{
    using System.Linq;
    using Contracts;

    public class Statistics
    {
        private readonly IPrinter printer;

        public Statistics(IPrinter printer)
        {
            this.printer = printer;
        }

        public void PrintStatistics(double[] input)
        {      
            var max = input.Max();
            var min = input.Min();
            var average = input.Average();
            
            this.printer.Print("Min value: ", min);
            this.printer.Print("Max value: ", max);
            this.printer.Print("Avg value: ", average);
        }
    }
}
