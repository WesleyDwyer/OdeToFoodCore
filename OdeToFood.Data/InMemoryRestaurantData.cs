using OdeToFood.Core;
using System;
using System.Linq;
using System.Collections.Generic;

namespace OdeToFood.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1, Name = "Chicken Spot",Cuisine = CuisineType.None,Location ="Spanish Town"},
                new Restaurant{Id = 2, Name = "Jerk Pork Spot",Cuisine = CuisineType.Jamaican,Location ="Kingston"},
                new Restaurant{Id = 3, Name = "Chillingz Spot",Cuisine = CuisineType.Italian,Location ="Saint Catherine"}

            };
        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }
        public IEnumerable<Restaurant> GetRestaurantByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }

}
