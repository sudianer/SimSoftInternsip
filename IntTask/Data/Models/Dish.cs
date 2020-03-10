using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntTask.Data.Models
{
    public class Dish
    {
        public int id { get; set; }
        public string creationDate { get; }
        public string title { get; set; }
        public List<string> contains { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int weight { get; set; }
        public int calories { get; set; }
        public int timeToMake { get; set; }

    }
}
