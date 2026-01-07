using System;

namespace MyRetailLogic
{
    public class RetailLogic
    {
        public int CalcDiscount(int amount)
        {
            int disc = amount*10/100;
            return disc;
        }
    }
}
