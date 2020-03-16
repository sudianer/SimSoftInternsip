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

        public DishController(IDish iDish)
        {
            _dish = iDish;
        }
        
        public ViewResult List()
        {
            DishListViewModel dvm = new DishListViewModel();
            dvm.getAllDishes = _dish.Dishes;
            dvm.currMenu = "Основное меню";
            return View(dvm);
        }
    }
}
