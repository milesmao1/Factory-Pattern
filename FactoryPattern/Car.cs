﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public Car()
        {
            Console.WriteLine("Building a new Car!\n");
        }


        public void Drive()
        {
            Console.WriteLine("The Car Drives! That's What's Up!\n");
        }
    }
}
