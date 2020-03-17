using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IntTask.Data.Interfaces;
using IntTask.ViewModels;

namespace IntTask.Controllers
{
    public class DishController: Controller
    {
        private readonly IDish _dish;

        public DishController(IDish dish)
        {
            _dish = dish;
        }
        
        public ViewResult List()
        {
            DishListViewModel dvm = new DishListViewModel
            {
                AllDishes = _dish.Dishes,
                CurrentMenu = "Основное меню"
            };
            return View(dvm.AllDishes);
        }
    }
}
