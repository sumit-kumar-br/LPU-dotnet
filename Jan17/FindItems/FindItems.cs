namespace FindItems
{
	public class Program
	{
		public static SortedDictionary<string, long> itemDetails = new SortedDictionary<string, long>();
		
		public SortedDictionary<string, long> FindItemDetails(long soldCount)
		{
			var result = new SortedDictionary<string, long>();
			foreach(var item in itemDetails)
			{
				if(item.Value == soldCount)
				{
					result.Add(item.Key, item.Value);
				}
			}
			return result;
		}
		public List<string> FindMinandMaxSolditems()
		{
			var result = new List<string>();
			long min = itemDetails.Values.Min();
			long max = itemDetails.Values.Max();
			string mini = itemDetails.FirstOrDefault(s=>s.Value == min);
			string maxi = itemDetails.FirstOrDefault(s=>s.Value == max);
			result.Add(mini);
			result.Add(maxi);
			return result;
		}
		public Dictionary<string, long> SortByCount()
		{
			var query = itemDetails.OrderBy(s=>s.Value).toDictionary(s => s.Key, s => s.Value);
			return query;
		}
		public static void Main(string[] args)
		{
			Program obj = new Program();
			var result = obj.FindItemDetails();
			if(result.Count==0)
			{
				Console.WriteLine("Invalid sold count");
			}
			else
			{
				foreach(var item in result)
				{
					Console.WriteLine(item.Key + " : " + item.Value);
				}
			}
			var minMax = obj.FindMinandMaxSolditems();
			Console.WriteLine("Minimum sold items: " + minMax[0]);
			Console.WriteLine("Maximum sold items: " + minMax[1]);
			var sorted = obj.SortByCount();
			foreach(var item in sorted)
			{
				Console.WriteLine(item.Key + " : " + item.Value);
			}

		}
	}
}