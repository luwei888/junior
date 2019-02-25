using System;

namespace Aotoganerate_array
{
    class Program
    {
        static int[] GetArray(int variable)
        {
            int[] array = new int[variable];
            array[0] = 0;
            //int number=0;
            Console.WriteLine("得到的随机数组为：");
            Console.Write(array[0] + " ");
            for (int i = 1; i < variable; i++)
            {
                //int random = new Random().Next(1, 20);
                //number += new Random().Next(1, 5);
                array[i] = array[i - 1] + new Random().Next(1, 10);
                Console.Write(array[i] + " ");
                //array[i] = array[i - 1] + new Random().Next(1, 5);
            }
            return array;
        }
        static int[,] GetDoubleDimensionalArray(int x, int y)
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
                    Console.Write($"{array[i, j]}" + "     ");
                }
            }
            return array;
        }
        static int BinaryChop(int length, int input, ref int index)
        {
            int[] array = GetArray(length);
            int time = 0;
            index = array.Length / 2;
            int left = 0;
            int right = array.Length;

            Console.WriteLine("请输入要查找的数：");
            bool success = false;
            while (!success)
            {
                if (input == array[index - 1])
                {
                    Console.WriteLine();
                    Console.WriteLine($"找到了,共查找了{time + 1}次，位置在{index}：数字为：{input}");
                    success = true;
                    return time;
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
        static int BinaryChop2(int length, int input, ref int index)
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
        static void MiniGame(int guess)
        {
            int random = new Random().Next(500);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("请输入一个数：");
                if (guess == random)
                {
                    Console.WriteLine("恭喜你答对了！");
                    break;
                }
                else if (guess > random)
                {
                    Console.WriteLine($"太大了，继续猜！只剩{9 - i}次了哦！");
                }
                else
                    Console.WriteLine($"太小了，继续猜！只剩{9 - i}次了哦！");
            }
            if (guess != random)
            {
                Console.WriteLine($"你太菜啦！这都不会，正确答案是{random}");
            }
            Console.ReadLine();
        }
        static int[] GetAotoArray(int length = 10, int step = 5, int first = 10)
        {
            int[] array = new int[step];
            array[0] = first;
            Console.Write("   " + array[0]);
            for (int i = 1; i < step; i++)
            {
                array[i] = array[i - 1] + length;
                Console.Write("  " + array[i]);
            }
            return array;
        }
        static void Swap(ref float A, ref float B)
        {
            float temp;
            temp = A;
            A = B;
            B = temp;
        }
        static int Recursion(int n)
        {
            int result;
            if (n == 1)
            {
                return 1;
            }
            else
                result = Recursion(n - 1) * n;
            return result;
        }

        static void Main(string[] args)
        {
            float A = 888.88f;
            float B = 666.66f;
            Console.WriteLine("A=" + A + "  B=" + B);
            Swap(ref A, ref B);
            Console.WriteLine("转换后：");
            Console.WriteLine("A=" + A + "  B=" + B);
            Console.ReadLine();
        }
    }
}
