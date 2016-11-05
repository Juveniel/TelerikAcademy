using System;
using System.Collections.Generic;
using Strategy.Models.Abstract;

namespace Strategy.Models
{
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented
            Console.WriteLine("ShellSorted list ");
        }            
    }
}
