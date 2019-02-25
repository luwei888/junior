using System;

namespace Try
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("运行return：");
            Return();
            Console.WriteLine();
            Console.WriteLine("运行break：");
            Break();
            Console.ReadLine();
        }
        static void Return()
        {
            for (int i = 0; i < 10; i++)
            {
                return;
            }
            Console.WriteLine("return");
        }

        static void Break()
        {
            int[] array = new int[10];
            for (int i = 0; i < 5; i++)
            {
                break;
            }
            Console.WriteLine("break");
        }
    }
}
