using System;

namespace Recursion
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("输入N的值：");
            
        }

        public int F(int n)
        {
            int result;
            if (n == 1)
            {
                return 1;
            }
            else
                result = F(n - 1) * n;
            return result;
        }
    }
}
