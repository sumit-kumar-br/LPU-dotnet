using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateListingManagement
{
    public interface IRealEstateListing
    {
        int ID { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        int Price { get; set; }
        string Location { get; set; }
    }
}
