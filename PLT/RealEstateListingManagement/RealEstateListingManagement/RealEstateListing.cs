using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateListingManagement
{
    public class RealEstateListing: IRealEstateListing
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }
        public RealEstateListing(int id, string title, string description, int price, string location)
        {
            ID = id;
            Title = title;
            Description = description;
            Price = price;
            Location = location;
        }
    }
}
