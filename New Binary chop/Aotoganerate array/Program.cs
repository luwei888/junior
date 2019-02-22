using System;

namespace Aotoganerate_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array =new int [20];
            array[0] = 0;
            //int number=0;
            Console.WriteLine("得到的随机数组为：");
            for (int i = 1; i < 15; i++)
            {
                //int random = new Random().Next(1, 20);
                //number += new Random().Next(1, 5);
                array[i] = array[i-1]+new Random().Next(1,5);

                //array[i] = array[i - 1] + new Random().Next(1, 5);
                Console.Write(" " + array[i-1]);
            }
            Console.ReadLine();
        }
    }
}
