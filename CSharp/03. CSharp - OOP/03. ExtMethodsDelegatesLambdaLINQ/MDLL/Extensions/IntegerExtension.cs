namespace MDLL.Extensions
{
    using System.Linq;

    public static class IntegerExtension
    {
        public static int[] DivisibleBy7and3(this int[] numbers)
        {
            var queryNumbers = numbers.Where(x => x % 3 == 0 && x % 7 == 0).ToArray();

            return queryNumbers;
        }
    }
}
