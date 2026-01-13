public class Khata
{
    public Dictionary<string, int> Record { get; set; }
    public Khata(Dictionary<string,int> record)
    {
        Record = record;
    }
    public int getTotal()
    {
        int totalSum = 0;
        foreach(var item in Record)
        {
            totalSum += item.Value;
        }
        return totalSum;
    }
    public int getRepeatAmount()
    {
        // Dictionary<int,int> frequency = new Dictionary<int, int>();
        // foreach(var item in Record.Values)
        // {
        //     if(frequency.Keys.Contains(item))
        //     {
        //         frequency[item]++;
        //     }
        //     else
        //     {
        //         frequency.Add(item,1);
        //     }
        // }
        // int count = 0;
        // foreach(var item in frequency)
        // {
        //     if(item.Value > 1)
        //     {
        //         count++;
        //     }
        // }
        int count = Record.Values
                          .GroupBy(v=>v)
                          .Count(f=>f.Count()>1);
        return count;
    }
}