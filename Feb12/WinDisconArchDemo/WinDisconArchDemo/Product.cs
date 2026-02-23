using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDisconArchDemo
{
    /// <summary>
    /// Entity class Product
    /// </summary>
    public class Product
    {
        #region Fields
            int prodID;
            //string prodName;
            //int price;
            //string desc;
        #endregion

        #region Properties
        // CLR Properties
        public int ProdID
        {
            get { return prodID; }
            set
            {
                if(value<=0 || value >= 999)
                {
                    throw new MyCustomException("Product ID connot be below 0 or above 999");
                }
                else
                {
                    prodID = value;
                }
            }
        }
        #endregion

        public string ProdName { get; set; }
        public float Price { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

    }
}
