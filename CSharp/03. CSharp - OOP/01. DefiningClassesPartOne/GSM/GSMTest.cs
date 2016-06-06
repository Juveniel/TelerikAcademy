namespace _01.DefineClass
{
    using System;

    public class GSMTest
    {
        internal static void Main()
        {
            /* Create new instance */
              GSM huawei = new GSM
              {
                  Model = "P8",
                  Manufacturer = "Huawei",
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
              };

            Console.WriteLine(huawei.ToString());

            /* Test call history */
            huawei.AddCall(new DateTime(2016, 5, 1), "0885000011", new TimeSpan(0, 30, 10));
            huawei.AddCall(new DateTime(2016, 6, 1), "0885000022", new TimeSpan(0, 20, 10));
            huawei.AddCall(new DateTime(2016, 7, 1), "0889030303", new TimeSpan(0, 10, 20));
            huawei.AddCall(new DateTime(2016, 8, 1), "0889040404", new TimeSpan(0, 10, 30));
            huawei.PrintCallHistory();
            Console.WriteLine(huawei.CalculateCallPrice(0.37));

            huawei.RemoveCall();
            huawei.PrintCallHistory();
            Console.WriteLine(huawei.CalculateCallPrice(0.37));

            huawei.ClearCallHistory();
            huawei.PrintCallHistory();
        }
    }
}
