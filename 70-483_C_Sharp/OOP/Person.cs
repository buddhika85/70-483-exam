using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Person : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Breath()
        {
            return "Person breaths";
        }

        public string Eat()
        {
            return "Person eats";
        }

        public string Walk()
        {
            return "Person walks";
        }

        public string WareCloths()
        {
            return "Person ware cloths";
        }

        public virtual string Work()
        {
            return "Virtual method - that should be overriden";
        }
        
    }
}
