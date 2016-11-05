using System;
using System.Collections.Generic;
using Strategy.Models.Abstract;

namespace Strategy.Models
{
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); 
            Console.WriteLine("QuickSorted list");
        }
    }
}
