using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntTask.Data.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string CreationDate { get; }
        public string Title { get; set; }
        public List<string> Ingredients { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Weight { get; set; }
        public int Calories { get; set; }
        public int TimeToMake { get; set; }

    }
}
