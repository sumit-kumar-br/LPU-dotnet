using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp10FeaturesDemo
{
    internal class NullParamCheckDemo
    {
        // Old Code
        //public void UpdateAddress(int invoiceNumber, Address newAddress)
        //{
            
        //    if (newAddress == null)
        //    {
        //        throw new ArgumentNullException("newAddress");
        //    }

        //}

      


        //In C# 10, if you add !! to the end of your parameter (newAddress in the example below) 
        //then it automatically does the null checking for you.

        public void UpdateAddress(int invoiceNumber, HomeAddress newAddress!!)
        {

            ArgumentNullException.ThrowIfNull(newAddress);          
            Console.WriteLine($"Home Address : {newAddress}");
        }

    }

    public class HomeAddress
    {
        public int FlatNo { get; set; }
        public string Apartment { get; set; }
        public string Locality { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }
}
