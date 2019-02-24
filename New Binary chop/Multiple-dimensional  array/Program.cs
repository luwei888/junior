using System;

namespace Multiple_dimensional__array
{
    class Program
    {
        static int[,] MultipleDimensionalArray(int x,int y)
        {
            //int add1 = 1;
            int[,] array = new int[x, y];
            Console.WriteLine("创建一个数组：");
            for (int i = 0; i < x; i++)
            {
                //int add2 = i;
                //add2 = add2 + add1;
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    //add2 += add2;
                    //array[i, j] = add2;
                    array[i, j] = i + j;
                    Console.Write($"{array[i,j]}"+"     ");
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            int x = 5;
            int y = 5;
            int[,] array = MultipleDimensionalArray(x,y);
            //Console.WriteLine("输出数组："+array);
            //for (int i = 0; i < variable; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            Console.ReadLine();
        }
//        Console.WriteLine();
//            Console.WriteLine("输入一个坐标查找数据：") ;
//            Console.Write("横坐标为：");
//            int index1 = Convert.ToInt32(Console.ReadLine());
//        Console.Write("纵坐标为：");
//            int index2 = Convert.ToInt32(Console.ReadLine());
//            if (index1<=x&index2<=y)
//            {
//                Console.WriteLine($"找到啦！数据为：{array[index1 - 1, index2 - 1]}");
//            }
//            else
//            {
//                Console.WriteLine("错误，找不到！！");
//            }
//Console.ReadLine();
    }
}
