using System;

namespace Aotoganerate_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array =new int [30];
            int number=0;
            Console.WriteLine("得到的随机数组为：");
            for (int i = 0; i < array.Length; i++)
            {
                int random = new Random().Next(10);
                number += random;
                array[i] = number;
                Console.Write(" "+array[i]);
            }
            Console.ReadLine();
        }
    }
}
