using Homework_set;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aotoganerate_array
{
    internal class FeiGeBinSeek:BinarySeek
    {


        internal override int Do(int[] array, int input)
        {
            
                FatherArray array1 = new FatherArray();
                array1.array = new int[length];
                int[] array2 = array1.array;
                int time = 0;
                index = array2.Length / 2;
                int left = 0;
                int right = array2.Length;

                Console.WriteLine("请输入要查找的数：");
                bool success = false;
                while (!success)
                {
                    if (input == array2[index - 1])
                    {
                        Console.WriteLine();
                        Console.WriteLine($"找到了,共查找了{time + 1}次，位置在{index}：数字为：{input}");
                        success = true;
                        return time;
                    }
                    else
                    {
                        Console.WriteLine($"第{time + 1}次查找，取第{index + 1}位值为{array2[index]}");
                        if (input > array2[index - 1])
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
                        if ((right - left) == 1 & (input == array2[index]))//数值为最后一位时，left right距离为1
                        {
                            return time;
                        }
                        if (((right - left) / 2) == 0)
                        {
                            success = true;
                        }
                        time++;
                        return time;
                    }
                }
                if (((right - left) / 2) == 0)
                {
                    Console.WriteLine("找不到，假数据！！");
                }
                Console.ReadLine();
                return time;
            }
        }
    }
}
