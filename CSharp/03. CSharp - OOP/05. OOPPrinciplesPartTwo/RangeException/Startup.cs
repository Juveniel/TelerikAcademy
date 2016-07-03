namespace RangeException
{
    using System;

    public class Startup
    {
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 20, 30, 40, 55, -20, 120 };

        private static DateTime[] dates =
        {
            new DateTime(2016, 01, 01),
            new DateTime(2015, 02, 02),
            new DateTime(2014, 03, 03),
            new DateTime(2010, 05, 06)
        };

        internal static void Main()
        {
            TestIntegerColection();

            TestDateTimeCollection();
        }

        private static void TestIntegerColection()
        {
            try
            {
                int start = 1;
                int end = 100;

                for (int i = start; i < end; i++)
                {
                    if (numbers[i] < start || numbers[i] > end)
                    {
                        throw new InvalidRangeException<int>(start, end, string.Format("Value {0} was not in the range of the collection", numbers[i]));
                    }
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Start: {0} End: {1} \r\n", ex.Start, ex.End);
            }
        }

        private static void TestDateTimeCollection()
        {
            try
            {
                DateTime start = new DateTime(2014, 01, 01);
                DateTime end = new DateTime(2015, 01, 01);

                for (int i = 0; i < dates.Length; i++)
                {
                    if (dates[i] < start || dates[i] > end)
                    {
                        throw new InvalidRangeException<DateTime>(start, end, string.Format("Value {0} was not in the range of the collection", dates[i]));
                    }
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Start: {0} End: {1}", ex.Start, ex.End);
            }
        }
    }
}
