using System;
using System.Collections;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList num1 = new ArrayList { 1, 3, 5, 6 };
            Sum(num1);
            Console.Read();
        }

        static void Sum(ICollection nums)
        {
            foreach (var item in nums)
            {
                Console.WriteLine(item.GetType());
            }
        }
    }
}
