namespace _01.DefineClass
{
    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        private List<GSM> gsmList = new List<GSM>()
        {
            new GSM("G18", "Samsung", 10, "Pesho", new Battery("EX", BatteryType.LiIon, 15, 30), new Display(10, 16000000)),
            new GSM("G16", "Sony", 10, "Gosho", new Battery("NOKIA", BatteryType.LiIon, 5, 30), new Display(20, 16000000)),
            new GSM("E20", "HTC", 10, "Ivanka", new Battery("NOKIA", BatteryType.LiIon, 15, 30), new Display(30, 16000000)),
            new GSM("P18", "ALC", 10, "Draganka", new Battery("NOKIA", BatteryType.LiIon, 5, 30), new Display(40, 16000000))
        };
        
        public void DisplayGsmCollection()
        {
            Console.WriteLine("GSM Collection: ");
            foreach (var gsm in this.gsmList)
            {
                Console.WriteLine(gsm.ToString());
            }
        }                               
    }
}
