using System;

namespace optional_paremeter
{
    class Program
    {
        
        static int[] AotoArray(int length=10,int step=5 ,int first = 10)
        {
            int[] array = new int[step];
            array[0] = first;
            Console.Write("   "+array[0]);
            for (int i = 1; i < step; i++)
            {
                array[i] = array[i - 1]+length;
                Console.Write("  "+array[i]);
            }
            return array;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("输入数组长度：");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入元素间距：");
            int step = Convert.ToInt32(Console.ReadLine());
            
            AotoArray(length,step);
            Console.ReadLine();
            
        }

      
    }
}
