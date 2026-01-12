using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateListingManagement
{
    public class RealEstateApp
    {
        private List<IRealEstateListing> listings = new List<IRealEstateListing>();
        public void AddListing(IRealEstateListing listing)
        {
            listings.Add(listing);
        }
        public bool RemoveListing(int listingID)
        {
            var listing = listings.FirstOrDefault(f => f.ID == listingID);
            if (listing != null)
            {
                listings.Remove(listing);
                return true;
            }
            return false;
        }
        public bool UpdateListing(IRealEstateListing listing)
        {
            var existing = listings.FirstOrDefault(f => f.ID == listing.ID);
            if(existing != null)
            {
                existing.Title = listing.Title;
                existing.Description = listing.Description;
                existing.Price = listing.Price;
                existing.Location = listing.Location;
                return true;
            }
            return false;
        }
        public List<IRealEstateListing> GetListings()
        {
            return listings;
        }
        public List<IRealEstateListing> GetListingsByLocation(string location)
        {
            return listings.Where(f => f.Location.Equals(location, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public List<IRealEstateListing> GetListingsByPriceRange(int minPrice, int maxPrice)
        {
            return listings.Where(f => f.Price >= minPrice && f.Price <= maxPrice).ToList();
        }
    }
}
