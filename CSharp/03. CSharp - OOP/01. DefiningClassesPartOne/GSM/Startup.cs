namespace _01.DefineClass
{
    public class Startup
    {
        internal static void Main()
        {
            /* 1. Test gsm collection */
            var gsmTest = new GSMTest();
            gsmTest.DisplayGsmCollection();

            /* 2. Test Calls history */
            var callHistoryTests = new CallHistoryTests();
            callHistoryTests.DisplayInformation();
        }
    }
}
