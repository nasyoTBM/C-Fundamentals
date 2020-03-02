using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingClasses
{
    public class DerivedCat : BaseCat
    {
        private string _name = "Name-DerivedClass";
        private string _color = "ID-DerivedClass";

        new public string Name
        {
            get
            {
                return _name;
            }


            set
            {
                _name = value;
            }
        }
        // Using private on the following property hides it in the Main Cat.
        // Any assignment to the property will use Color in BaseCat.
        new private string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
    }
}
