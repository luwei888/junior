﻿using System;

namespace Multiple_dimensional__array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int add1 = 1;
            int[,] array = new int[8, 8];
            Console.WriteLine("创建一个数组：");
            for (int i = 0; i < 5; i++)
            {
                //int add2 = i;
                //add2 = add2 + add1;
                Console.WriteLine();
                for (int j = 0; j < 5; j++)
                {
                    //add2 += add2;
                    //array[i, j] = add2;
                    array[i, j] = i + j;
                    Console.Write($"{array[i,j]}"+"     ");
                }
            }

            Console.WriteLine();

            Console.WriteLine("输入一个坐标查找数据：") ;
            Console.Write("横坐标为：");
            int index1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("纵坐标为：");
            int index2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"找到啦！数据为：{array[index1-1,index2-1]}");
            Console.ReadLine();
        }
    }
}
