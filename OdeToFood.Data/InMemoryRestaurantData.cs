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
                new Restaurant{Id = 1, Name = "Jerk Pork Spot",Cuisine = CuisineType.Jamaican,Location ="Kingston"},
                new Restaurant{Id = 1, Name = "Chillingz Spot",Cuisine = CuisineType.Italian,Location ="Saint Catherine"}

            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }

}
