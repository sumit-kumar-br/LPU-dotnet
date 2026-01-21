using System;
namespace SampleApp
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
           //Implement Your code here
           foreach(var item in record) {
            total += item.Value;
           }
            return total;
        }
        public int getRepeatAmount()
        {
            int repeatAmtCount = 0;
            int selectedAmt = 0, compareAmt = 0, uniqueAmtCount = 0;
            //Implement Your code here
            uniqueAmtCount = record
                        .GroupBy(s=>s.Value)
                        .Count(g=>g.Count()>1);
            return uniqueAmtCount;
        }


    }
    class Total
    {
         public static void Main(string[] args)
         {
            Dictionary<string, int> record = new Dictionary<string, int>
                {
                    { "Milk", 100 },
                    { "Tea", 50 },
                    { "Coffee", 100 },
                    { "Sugar", 50 },
                    { "Salt", 200 }
                };


            Khata khata = new Khata(record);
            Console.WriteLine(khata.getRepeatAmount());
            Console.WriteLine(khata.getTotal());
        }
    }
}