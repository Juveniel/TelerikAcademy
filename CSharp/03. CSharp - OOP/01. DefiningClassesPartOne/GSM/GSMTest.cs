namespace _01.DefineClass
{
    using System;

    public class GSMTest
    {
        internal static void Main()
        {
            /* Create new instance */
            GSM testPhone = new GSM("G18", "Samsung", 10, "Pesho", new Battery("NOKIA battery", BatteryType.LiIon, 5, 30), new Display(10, 16000000));

            /*GSM test2 = new GSM 
            { 
                Model = "asd",
                Manufacturer = "asd",
                Price = 10,
                Owner = "Pesho",
                Battery = new Battery
                {
                  BatteryModel = "NOKIA battery",
                    BatteryType = BatteryType.LiIon,
                    HoursIdle = 5,
                    HoursTalked = 30
                },
                Display = new Display
                {
                    Size = 10,
                    NumberOfColors = 16000000
                }
              };*/

            Console.WriteLine(testPhone.ToString());

            /* Test call history */
            testPhone.AddCall(new DateTime(2016, 5, 1), "0885000011", new TimeSpan(0, 30, 10));
            testPhone.AddCall(new DateTime(2016, 6, 1), "0885000022", new TimeSpan(0, 20, 10));
            testPhone.AddCall(new DateTime(2016, 7, 1), "0889030303", new TimeSpan(0, 10, 20));
            testPhone.AddCall(new DateTime(2016, 8, 1), "0889040404", new TimeSpan(0, 10, 30));
            testPhone.PrintCallHistory();
            Console.WriteLine(testPhone.CalculateCallPrice(0.37));

            testPhone.RemoveCall();
            testPhone.PrintCallHistory();
            Console.WriteLine(testPhone.CalculateCallPrice(0.37));

            testPhone.ClearCallHistory();
            testPhone.PrintCallHistory();
        }
    }
}
