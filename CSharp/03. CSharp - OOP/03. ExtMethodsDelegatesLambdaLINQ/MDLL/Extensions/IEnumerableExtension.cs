namespace MDLL.Extensions
{
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtension
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            dynamic sum = 0;

            foreach (var item in collection)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            dynamic product = 1;

            foreach (var item in collection)
            {
                product *= item;
            }

            return product;
        }
        
        public static T Min<T>(this IEnumerable<T> collection)
        {
            dynamic min = collection.ElementAt(0);

            foreach (var item in collection)
            {
                if (min > item)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
        {
            dynamic max = collection.ElementAt(0);

            foreach (var item in collection)
            {
                if (max < item)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> collection)
        {
            dynamic sum = 0;

            foreach (var item in collection)
            {
                sum += item;
            }

            return sum / collection.Count();
        }
    }
}
