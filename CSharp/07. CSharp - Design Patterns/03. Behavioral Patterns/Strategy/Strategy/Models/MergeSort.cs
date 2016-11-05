using System;
using System.Collections.Generic;
using Strategy.Models.Abstract;

namespace Strategy.Models
{
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented
            Console.WriteLine("MergeSorted list ");
        }
    }
}
