using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Desert:Product
    {
        public double Calories
        {
            get { return Weight * 3; }
            set { Calories = Weight * 3; }
        }
    }
}
