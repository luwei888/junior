using System;

namespace IspExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new Driver(new Tank());
            driver.Drive();
            Console.Read();
        }
    }


    class Driver
    {
        private IVehicle _vehicle;
        public Driver(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void Drive()
        {
            _vehicle.run();
        }

    }

    interface IVehicle
    {
        void run();
    }

    class Car : IVehicle
    {
        public void run()
        {
            Console.WriteLine("Car is running!");
        }
    }

    class Truck : IVehicle
    {
        public void run()
        {
            Console.WriteLine("Truck is running");
        }
    }

    class Tank : IVehicle
    {
        public void run()
        {
            Console.WriteLine("Tank is running");
        }
    }

}
