using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntTask.Data.Interfaces;
using IntTask.Data.Models;

namespace IntTask.Data.Mocks
{
    public class MockDish : IDish
    {
        public IEnumerable<Dish> Dishes
        {
            get
            {
                return new List<Dish>
                {
                    new Dish { 
                        Title = "carbonara",
                        Price = 300,
                        Ingredients = {"pasta", "eggs", "bacon", "cheese"},
                        Calories = 400,
                        Description="most popular pasta in our menu",
                        TimeToMake = 10,
                        Weight = 300
                    },

                     new Dish { 
                        Title = "bolognese",
                        Price = 250,
                        Ingredients = {"pasta", "tomato sauce", "grounded beef", "cheese"},
                        Calories = 400,
                        Description="famous italian pasta",
                        TimeToMake = 10,
                        Weight = 350
                    }
                };
            }
        }
    }
}
