using System;
using System.Threading;
using System.Threading.Tasks;

namespace Threadplace
{
    class Program
    {
        public void Test()
        {
            ThreadStart threadStart = new ThreadStart(Calculate);
            Thread thread = new Thread(threadStart);
            thread.Start();
        }

        public void Calculate()
        {
            double Diameter = 0.5;
            Console.Write("The perimeter Of Circle with a Diameter of {0} is {1}", Diameter, Diameter * Math.PI);
        }

        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}
