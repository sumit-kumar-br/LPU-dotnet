using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeOnRent_App
{
    public class BikeService
    {
        private readonly IBikeRepository _repo;

        public BikeService(IBikeRepository repo)
        {
            _repo = repo;
        }

        public void AddBike(string model, string brand, int price)
        {
            _repo.AddBike(new Bike
            {
                Model = model,
                Brand = brand,
                PricePerDay = price
            });
        }

        public SortedDictionary<string, List<Bike>> GroupByBrand()
        {
            return new SortedDictionary<string, List<Bike>>(
                _repo.GetAllBikes().Values
                .GroupBy(b => b.Brand)
                .ToDictionary(g => g.Key, g => g.ToList())
            );
        }

        public List<Bike> FilterByMaxPrice(int maxPrice)
        {
            return _repo.GetAllBikes().Values
                .Where(b => b.PricePerDay <= maxPrice)
                .OrderBy(b => b.PricePerDay)
                .ToList();
        }

        public List<Bike> SearchByModel(string keyword)
        {
            return _repo.GetAllBikes().Values
                .Where(b => b.Model.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public SortedDictionary<string, int> CountByBrand()
        {
            return new SortedDictionary<string, int>(
                _repo.GetAllBikes().Values
                .GroupBy(b => b.Brand)
                .ToDictionary(g => g.Key, g => g.Count())
            );
        }

        public List<Bike> SortByPrice(bool asc)
        {
            var bikes = _repo.GetAllBikes().Values;
            return asc
                ? bikes.OrderBy(b => b.PricePerDay).ToList()
                : bikes.OrderByDescending(b => b.PricePerDay).ToList();
        }

        public Bike GetCheapestBike()
        {
            return _repo.GetAllBikes().Values
                .OrderBy(b => b.PricePerDay)
                .FirstOrDefault();
        }

        public Bike GetCostliestBike()
        {
            return _repo.GetAllBikes().Values
                .OrderByDescending(b => b.PricePerDay)
                .FirstOrDefault();
        }

        public List<string> GetDistinctBrands()
        {
            return _repo.GetAllBikes().Values
                .Select(b => b.Brand)
                .Distinct()
                .OrderBy(b => b)
                .ToList();
        }
    }
}
