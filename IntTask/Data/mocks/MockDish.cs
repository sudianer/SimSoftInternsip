using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntTask.Data.Interfaces;
using IntTask.Data.Models;

namespace IntTask.Data.mocks
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
                        title = "carbonara",
                        price = 300,
                        contains = {"pasta", "eggs", "bacon", "cheese"},
                        calories = 400,
                        description="most popular pasta in our menu",
                        timeToMake = 10,
                        weight = 300
                    },

                     new Dish { 
                        title = "bolognese",
                        price = 250,
                        contains = {"pasta", "tomato sauce", "grounded beef", "cheese"},
                        calories = 400,
                        description="famous italian pasta",
                        timeToMake = 10,
                        weight = 350
                    }
                };
            }
        }
    }
}
