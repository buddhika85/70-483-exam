using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }

        string Breath();
        string Eat();
        string Walk();
        string WareCloths();
    }
}
