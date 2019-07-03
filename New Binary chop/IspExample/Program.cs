using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace IspExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var driver = new Driver(new HeavyTank());
            //driver.Drive();

            //Console.WriteLine("华丽的分割线----------");
            ////未封装的反射
            //ITank heavyTank = new HeavyTank();
            //var t = heavyTank.GetType();
            //object o = Activator.CreateInstance(t);
            //MethodInfo fireMi = t.GetMethod("fire");
            //MethodInfo runMi = t.GetMethod("run");
            //fireMi.Invoke(o, null);
            //runMi.Invoke(o, null);
            //Console.Read();

            var sc = new ServiceCollection();
            sc.AddScoped(typeof(ITank), typeof(HeavyTank));
            var sp = sc.BuildServiceProvider();
            //--------------------------------
            ITank tank = sp.GetService<ITank>();
            tank.fire();
            tank.run();
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

    interface ITank
    {
        void fire();
        void run();
    }

    class HeavyTank : IVehicle, ITank
    {
        public void fire()
        {
            Console.WriteLine("tank is fire");
        }

        public void run()
        {
            Console.WriteLine("Tank is running");
        }
    }

}
