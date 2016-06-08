namespace _01.DefineClass
{
    using System;

    public class CallHistoryTests
    {
        private GSM testPhone = new GSM("S7", "Samsung");
        
        public void DisplayInformation()
        {
            this.FillCallsList();

            Console.WriteLine("CALL HISTORY TESTS START: \r\n");
            this.testPhone.PrintCallHistory();
            Console.WriteLine(this.testPhone.CalculateCallPrice(0.37));

            this.testPhone.RemoveCall();
            this.testPhone.PrintCallHistory();
            Console.WriteLine(this.testPhone.CalculateCallPrice(0.37));

            this.testPhone.ClearCallHistory();
            this.testPhone.PrintCallHistory();
        }

        private void FillCallsList()
        {
            this.testPhone.AddCall(new DateTime(2016, 5, 1), "0885000011", new TimeSpan(0, 30, 10));
            this.testPhone.AddCall(new DateTime(2016, 6, 1), "0885000022", new TimeSpan(0, 20, 10));
            this.testPhone.AddCall(new DateTime(2016, 7, 1), "0889030303", new TimeSpan(0, 10, 20));
            this.testPhone.AddCall(new DateTime(2016, 8, 1), "0889040404", new TimeSpan(0, 10, 30));
        }
    }
}
