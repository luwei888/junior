using System;

namespace Aotoganerate_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable = 5;
            int[] array2 = Array(variable);
            Console.WriteLine("输出数组："+array2);
            
            Console.ReadLine();
        }
        static int[] Array(int variable)
        {
            int[] array = new int[variable];
            array[0] = 0;
            //int number=0;
            Console.WriteLine("得到的随机数组为：");
            for (int i = 1; i < variable; i++)
            {
                //int random = new Random().Next(1, 20);
                //number += new Random().Next(1, 5);
                array[i] = array[i - 1] + new Random().Next(1, 10);
                Console.Write(array[i-1] + " ");
                //array[i] = array[i - 1] + new Random().Next(1, 5);
            }
            return array;
        }
       
        
    }
}
