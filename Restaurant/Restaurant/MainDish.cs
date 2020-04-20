using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class MainDish:Product
    {
        public double Calories 
        {
            get { return Weight*1; }
            set {Calories=Weight*1; } 
        }
    }
}
