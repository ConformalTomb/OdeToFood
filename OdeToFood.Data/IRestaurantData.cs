using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantByName(String name);
        Restaurant GetRestaurantById(int id);
    }

    public class InMemoryData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant() {Id=1,Name="Tangra Masala",Location="New York", Cusine=CusineType.Indian},
                new Restaurant() {Id=2, Name="Dominos", Location="Delhi", Cusine=CusineType.Indian},
                new Restaurant() {Id=3, Name="Hudson Chopsticks",Location="Hudson Lane",Cusine=CusineType.Mexican}
            };

        }

        public IEnumerable<Restaurant> GetRestaurantByName(String name) => from r in restaurants where String.IsNullOrEmpty(name) || r.Name.StartsWith(name) orderby r.Name select r;

        public Restaurant GetRestaurantById(int id) => restaurants.SingleOrDefault(r => r.Id == id);
    }
}
