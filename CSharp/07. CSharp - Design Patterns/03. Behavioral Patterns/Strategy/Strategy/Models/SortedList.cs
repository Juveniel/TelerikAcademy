using System;
using System.Collections.Generic;
using Strategy.Models.Abstract;

namespace Strategy.Models
{
	public class SortedList
	{
		private readonly List<string> list = new List<string>();

		private SortStrategy sortStrategy;

		public void SetSortStrategy(SortStrategy sortStrategy)
		{
			this.sortStrategy = sortStrategy;
		}

		public void Add(string name)
		{
			list.Add(name);
		}

		public void Sort()
		{
			sortStrategy.Sort(list);

			foreach (var name in list)
			{
				Console.WriteLine(" " + name);
			}

			Console.WriteLine();
		}
	}
}
