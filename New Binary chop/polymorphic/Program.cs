using System;

namespace polymorphic
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new Vehicle();
            var c = new Car();
        }
    }

    class Vehicle
    {
        public virtual void Run()
        {
            Console.WriteLine("I'm running");
        }
    }

    class Car:Vehicle
    {
        public int Speed { get; set; }
        public override void Run()
        {
            Console.WriteLine("Car is running");
        }
    }
}
