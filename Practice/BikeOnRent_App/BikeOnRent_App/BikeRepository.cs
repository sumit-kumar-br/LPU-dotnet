using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeOnRent_App
{
        public class BikeRepository : IBikeRepository
        {
            private readonly SortedDictionary<int, Bike> _store = new();

            public void AddBike(Bike bike)
            {
                _store.Add(_store.Count + 1, bike);
            }

            public SortedDictionary<int, Bike> GetAllBikes()
            {
                return _store;
            }
        }   
}
