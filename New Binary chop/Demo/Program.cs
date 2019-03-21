using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string str1 = "[He2@l3l%o Wo$rl@d,大^家!好，我是$路%炜！]";
            str1 = str1.Replace("^a-zA-Z_\u4e00-\u9fa5", " ");
            Console.WriteLine(str1);
            Console.ReadLine();
            int[,] a = new int[1, 3] { {1, 5, 5 } };
        }
    }
}
