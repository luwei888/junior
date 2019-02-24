using System;

namespace binary_chop
{
    class Program
    {
        static void Seek(int variable)
        {
            int[] array = new int[variable];
            array[0] = 0;
            //int number=0;
            Console.WriteLine("得到的随机数组为：");
            Console.Write(array[0]+" ");
            for (int i = 1; i < variable; i++)
            {
                //int random = new Random().Next(1, 20);
                //number += new Random().Next(1, 5);
                array[i] = array[i - 1] + new Random().Next(1, 10);
                Console.Write(array[i] + " ");
                //array[i] = array[i - 1] + new Random().Next(1, 5);
            }
            int time = 0;
            int index = array.Length / 2;
            int left = 0;
            int right = array.Length;
            Console.WriteLine("请输入要查找的数：");
            int input = Convert.ToInt32(Console.ReadLine());
            bool success = false;
            while (!success)
            {
                if (input == array[index - 1])
                {
                    Console.WriteLine();
                    Console.WriteLine($"找到了,共查找了{time + 1}次，位置在{index}：数字为：{input}");
                    success = true;
                }
                else
                {
                    Console.WriteLine($"第{time + 1}次查找，取第{index + 1}位值为{array[index]}");
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
                        Console.WriteLine($"找到了,共查找了{time + 1}次，位置在{index + 1}：数字为：{input}");
                        break;
                    }
                    if (((right - left) / 2) == 0)
                    {
                        success = true;
                    }
                    time++;
                }
            }
            if (((right - left) / 2) == 0)
            {
                Console.WriteLine("找不到，假数据！！");
            }
           
            Console.ReadLine();
        }
        static void Main()
        {
            Console.WriteLine("输入数组大小：");
            Seek(Convert.ToInt32(Console.ReadLine()));
        }
    }
}