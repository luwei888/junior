using System;
using System.Threading;
using System.Threading.Tasks;

namespace Threadplace
{
    class Program
    {
        static void Main(string[] args)
        {

             Action getup = () =>
            {
                Console.WriteLine($"Task-{Task.CurrentId}起床啦！...." +
                    $"ThreadId:{Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine();
            };


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"第{i+1}次");

                Task t = new Task(getup);
                t.Start();
            }

            Console.ReadLine();

        }
    }
}
