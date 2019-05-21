using System;

namespace reviewDemo
{
    class Program
    {
        public static int Fibonacci(int value)
        {
            if (value <= 0)
            {
                return 0;
            }
            else if (value > 0 && value <= 2)
            {
                return 1;
            }
            else { return Fibonacci(value - 1) + Fibonacci(value - 2); }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(9));
            Console.Read();
        }
    }
}
