using System;
using System.Collections.Generic;
using System.Text;

namespace Aotoganerate_array
{
    internal class LWBinSeek:BinarySeek
    {


        internal override int Do(int[] array, int input)
        {
            //throw new NotImplementedException();
            
                //TODO: Math.Log(array.Length, 2) + 1
                for (int i = 0; i < Math.Log(array2.Length, 2) + 1; i++)
                {
                    if (input == array2[index])
                    {
                        Console.WriteLine();
                        seek = true;
                        Console.WriteLine($"找到了,共查找了{i + 1}次，位置在{index + 1}：数字为：{input}");
                        return time;
                    }
                    else
                    {
                        Console.WriteLine($"第{i + 1}次查找，取第{index + 1}位值为{array2[index]}");
                        if (input > array2[index])
                        {
                            index += array2.Length / (2 * (i + 1));
                        }
                        else
                        {
                            index -= (array2.Length - 1) / (2 * (i + 1));
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
}
