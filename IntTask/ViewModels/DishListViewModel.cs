using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntTask.Data.Models;

namespace IntTask.ViewModels
{
    public class DishListViewModel
    {
        public IEnumerable<Dish> AllDishes { get; set; }

        public string CurrentMenu { get; set; }

    }
}
