using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeOnRent_App
{
    public interface IBikeRepository
    {
        void AddBike(Bike bike);
        SortedDictionary<int, Bike> GetAllBikes();
    }
}
