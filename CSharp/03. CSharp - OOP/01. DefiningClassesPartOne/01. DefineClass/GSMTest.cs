using System;

namespace _01.DefineClass
{
    class GSMTest
    {
        static void Main()
        {
            /* Create new instance */
            GSM Huawei = new GSM
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

            /* Test call history */
            Huawei.AddCall(new DateTime(2016, 5, 1), "0885000011", new TimeSpan(0, 30, 10));
            Huawei.AddCall(new DateTime(2016, 6, 1), "0885000022", new TimeSpan(0, 20, 10));
            Huawei.AddCall(new DateTime(2016, 7, 1), "0889030303", new TimeSpan(0, 10, 20));
            Huawei.AddCall( new DateTime(2016,82, 1), "0889040404", new TimeSpan(0, 10, 30));
            Huawei.PrintCallHistory();
            Console.WriteLine(Huawei.CalculateCallPrice(0.37));

            Huawei.RemoveCall();
            Huawei.PrintCallHistory();
            Console.WriteLine(Huawei.CalculateCallPrice(0.37));

            Huawei.ClearCallHistory();
            Huawei.PrintCallHistory();
        }
    }
}
