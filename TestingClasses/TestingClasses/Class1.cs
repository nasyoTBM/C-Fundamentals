using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingClasses
{
    public class BaseCat
    {
        private string _name = "Name-BaseCat";
        private string _color = "Color-BaseCat";
        public string Name
        {
            get { return _name; }
            set { } 
        }
        public string Color 
        {
            get { return _color; }
            set { } 
        }
    }
    
}
