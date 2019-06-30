using System;
using System.Collections.Generic;
using System.Text;

namespace advanceGrammarDemo
{
    class Vehicle
    {
        public void Stop()
        {
            Console.WriteLine("Stop!");
        }
    }

    class Car:Vehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is running");
        }
    }

    class Truck:Vehicle
    {
        public void Run()
        {
            Console.WriteLine("Truck is running");
        }
    }
}
