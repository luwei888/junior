using System;

namespace Aotoganerate_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable = 5;
            int[] array2 = Array(variable);
            Console.WriteLine("输出数组：");
            for (int i = 0; i < variable; i++)
            {
                Console.Write(array2[i]+" ");
            }
            Console.ReadLine();
        }
        static int[] Array(int A)
        {
            int[] array = new int[A];
            array[0] = 0;
            //int number=0;
            Console.WriteLine("得到的随机数组为：");
            for (int i = 1; i < A; i++)
            {
                //int random = new Random().Next(1, 20);
                //number += new Random().Next(1, 5);
                array[i] = array[i - 1] + new Random().Next(1, 5);
               
                //array[i] = array[i - 1] + new Random().Next(1, 5);
            }
            return array;
        }
       
        
    }
}
