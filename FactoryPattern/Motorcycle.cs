using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
            Console.WriteLine("Building a new Motorcycle\n");
        }

        public void Drive()
        {
            Console.WriteLine("The Motorcycle is revving up!");
        }

    }

}
