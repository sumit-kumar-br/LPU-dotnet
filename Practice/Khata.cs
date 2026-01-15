using System;
namespace KhataDemo
{
class Khata
    {
        public Dictionary<string, int> record = new Dictionary<string, int>();

        public Khata(Dictionary<string, int> record)
        {
            this.record = record;
        }

        public int getTotal()
        {
            int total = 0;
            foreach (var item in record)
            {
                total = total + item.Value;
            }
            return total;
        }
        public int getRepeatAmount()
        {
            int repeatAmtCount = 0;
            int selectedAmt = 0, compareAmt = 0, uniqueAmtCount = 0;
            for (int i = 0; i < record.Count; i++)
            {
                var itemI = record.ElementAt(i);
                selectedAmt = itemI.Value;
                for (int j = 0; j < record.Count; j++)
                {
                    var itemJ = record.ElementAt(j);
                    compareAmt = itemJ.Value;
                    if (selectedAmt == compareAmt)
                    {
                        repeatAmtCount++;
                        j = record.Count;
                    }
                }
            }
            uniqueAmtCount = record.Count - repeatAmtCount;
            return uniqueAmtCount;
        }


    }
    class Total
    {
        //public static void Main(string[] args)
        //{
        //    Dictionary<string, int> record = new Dictionary<string, int>();
        //    record.Add("milk", 100);
        //    record.Add("tea", 50);

        //    Khata khata = new Khata(record);
        //    Console.WriteLine(khata.getRepeatAmount());
        //    Console.WriteLine(khata.getTotal());
        //}
    }
}