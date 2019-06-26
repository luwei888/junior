using System;
using System.Threading;
using System.Threading.Tasks;

namespace Threadplace
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread);
            var current = Thread.CurrentThread;
            Console.ReadLine();
        }
    }
}
