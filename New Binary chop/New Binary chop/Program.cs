using System;

namespace binary_chop
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        static int BinaryChop(int length, int input, ref int index)
        {
            int[] array = GetArray(length);
            int time = 1;
            bool seek = false;
            index = array.Length - 1;
            Console.WriteLine("请输入要查找的数：");
            
            Console.WriteLine();
            //TODO: Math.Log(array.Length, 2) + 1
            for (int i = 0; i < Math.Log(array.Length, 2) + 1; i++)
            {
                if (input == array[index])
                {
                    Console.WriteLine();
                    seek = true;
                    Console.WriteLine($"找到了,共查找了{i + 1}次，位置在{index + 1}：数字为：{input}");
                    return time;
                }
                else
                {
                    Console.WriteLine($"第{i + 1}次查找，取第{index + 1}位值为{array[index]}");
                    if (input > array[index])
                    {
                        index += array.Length / (2 * (i + 1));
                    }
                    else
                    {
                        index -= (array.Length - 1) / (2 * (i + 1));
                    }
                    Console.WriteLine($"设下一次查找位置为第{index + 1}位");
                    Console.WriteLine();
                }
                time++;
            }
            if (seek == false)
                Console.WriteLine("找不到呀，假数据吧！！");
            Console.ReadLine();
            return time;
        }
    }
}

