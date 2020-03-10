using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntTask.Data.Models;

namespace IntTask.Data.Interfaces
{
    public interface IDish
    {
        public IEnumerable<Dish> Dishes { get; }
        
    }
}
