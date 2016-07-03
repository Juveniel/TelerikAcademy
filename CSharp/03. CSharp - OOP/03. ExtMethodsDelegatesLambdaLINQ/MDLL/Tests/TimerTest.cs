namespace MDLL.Tests
{
    using MDLL.TimerEvent;

    public class TimerTest
    {
        public static void Test()
        {
            Timer tm = new Timer(1000);
            Subscriber sub1 = new Subscriber(1, "subscriber1", tm);

            tm.InformAboutNewSubscription();
        }
    }
}
