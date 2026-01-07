using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec26b
{
    internal class DummyClass
    {
        void DummyClassDisplay()
        {
            Product pObj = new Product();
            Toys toyObj = new Toys();
            toyObj.Components = "Pencil";
            
            
        }
    }

    class Toys: Product
    {
        public string Components // Component is encapsulating ingridients
        {
            get
            {
                return Ingridients;
            }
            set
            {
                Ingridients = value; 
            }
        }
    }
}
