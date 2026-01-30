using System;
using System.Collections.Generic;
using System.Linq;

namespace FindItems
{
	public class Program
	{
		public static SortedDictionary<string, long> itemDetails =
			new SortedDictionary<string, long>
			{
				{ "Pen", 150 },
				{ "Notebook", 300 },
				{ "Pencil", 100 },
				{ "Eraser", 50 }
			};
		
		public SortedDictionary<string, long> FindItemDetails(long soldCount)
		{
			var result = new SortedDictionary<string, long>(itemDetails
					.Where(item => item.Value == soldCount)
					.ToDictionary(item => item.Key, item => item.Value));
			// foreach(var item in itemDetails)
			// {
			// 	if(item.Value == soldCount)
			// 	{
			// 		result.Add(item.Key, item.Value);
			// 	}
			// }
			return result;
		}

		public List<string> FindMinandMaxSolditems()
		{
			var result = new List<string>();
			long min = itemDetails.Values.Min();
			long max = itemDetails.Values.Max();
			string mini = itemDetails.FirstOrDefault(s => s.Value == min).Key;
			string maxi = itemDetails.FirstOrDefault(s => s.Value == max).Key;
			result.Add(mini);
			result.Add(maxi);
			return result;
		}

		public Dictionary<string, long> SortByCount()
		{
			var query = itemDetails.OrderBy(s => s.Value)
			                       .ToDictionary(s => s.Key, s => s.Value);
			return query;
		}

		public static void Main(string[] args)
		{
			Program obj = new Program();
			long soldCount = 100;

			var result = obj.FindItemDetails(soldCount);
			if (result.Count == 0)
			{
				Console.WriteLine("Invalid sold count");
			}
			else
			{
				foreach (var item in result)
				{
					Console.WriteLine(item.Key + " : " + item.Value);
				}
			}

			var minMax = obj.FindMinandMaxSolditems();
			Console.WriteLine("Minimum sold items: " + minMax[0]);
			Console.WriteLine("Maximum sold items: " + minMax[1]);

			var sorted = obj.SortByCount();
			foreach (var item in sorted)
			{
				Console.WriteLine(item.Key + " : " + item.Value);
			}
		}
	}
}
