using System.Collections.Generic;

namespace Strategy.Models.Abstract
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
