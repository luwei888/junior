using System;

namespace binary_chop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 8, 13, 14, 25, 26, 37, 68, 99, 100, 110, 123, 136, 314, 415, 685, 752, 850, 920 };
            Console.WriteLine("现有数组：1, 8, 13, 14, 25, 26, 37, 68, 99, 100, 110, 123, 136, 314, 415, 685, 752, 850, 920 ");

            int index = array.Length / 2;
            int left = 0;
            int right = array.Length;

            Console.WriteLine("请输入要查找的数：");
            int input = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (((right-left)/2)!=0)
            {
                if (input == array[index - 1])
                {
                    Console.WriteLine();
                    Console.WriteLine($"找到了,共查找了{i + 1}次，位置在{index}：数字为：{input}");
                    break;
                }
                else
                {
                    Console.WriteLine($"第{i + 1}次查找，取第{index + 1}位值为{array[index]}");
                    if (input > array[index - 1])
                    {
                        left = index;
                    }
                    else
                    {
                        right = index;
                    }
                    index = (left + right) / 2;
                    Console.WriteLine($"设下一次查找位置为第{index + 1}位");
                    Console.WriteLine();
                    if ((right - left) == 1 & (input == array[index]))//数值为最后一位时，left right距离为1
                    {
                        Console.WriteLine($"找到了,共查找了{i + 1}次，位置在{index + 1}：数字为：{input}");
                        break;
                    }
                    i++;
                }
            }
            if (((right - left) / 2) == 0)
            {
                Console.WriteLine("找不到，假数据！！");
            }
            Console.ReadLine();
        }
    }
}