using System;
using CQ = China.ChongQing.pretty;
using TW = China.Taiwanese.pretty;
namespace Homework_set
{

    public class ImitateStack
    {
        /// <summary>
        /// 出/入栈检查
        /// </summary>
        /// <param name="index">出入栈数量</param>
        static void Check(int index)
        {
            if (index > 10)
            {
                Console.WriteLine("栈溢出将会报错");
                Console.ReadLine();
            }
            else if (index < 0)
            {
                Console.WriteLine("栈已空将会报错");
                Console.ReadLine();
            }
        }
        /// <summary>
        /// 遍历显示数组
        /// </summary>
        /// <param name="array">数组</param>
        static void Arrayshow(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + "  ");
            }
        }

        internal int[] stack = new int[10];
        internal int top = 0;
        int checkIndex = 0;

        /// <summary>
        /// 单个数据入栈
        /// </summary>
        /// <param name="value">单数据</param>
        internal void Push(int value)
        {
            checkIndex++;
            Console.WriteLine();
            Console.WriteLine($"{value}入栈");
            Check(checkIndex);
            stack[top] = value;
            top++;
            Arrayshow(stack);
            Console.WriteLine();
        }

        /// <summary>
        /// 多数据入栈
        /// </summary>
        /// <param name="value">以数组形式入栈</param>
        internal void Push(int[] value)
        {
            checkIndex += value.Length;
            Console.WriteLine();
            Arrayshow(value);
            Console.WriteLine($"入栈");
            Check(checkIndex);
            for (int i = 0; i < value.Length; i++)
            {
                stack[top] = value[i];
                top++;
            }
            Arrayshow(stack);
            Console.WriteLine();
        }

        /// <summary>
        /// 单数据出栈
        /// </summary>
        /// <param name="value">单数据</param>
        internal void Pop(int value)
        {
            checkIndex--;
            Console.WriteLine();
            Console.WriteLine($"{value}出栈");
            Check(checkIndex);
            stack[top - 1] = 0;
            top--;
            Arrayshow(stack);
            Console.WriteLine();
        }

        /// <summary>
        /// 多数据出栈
        /// </summary>
        /// <param name="value">以数组形式出栈</param>
        internal void Pop(int[] value)
        {
            checkIndex -= value.Length;
            Console.WriteLine();
            Arrayshow(value);
            Console.WriteLine($"出栈");
            Check(checkIndex);
            for (int i = 0; i < value.Length; i++)
            {
                stack[top - 1] = 0;
                top--;
            }
            Arrayshow(stack);
            Console.WriteLine();
        }
    }
    
    public class HomeworkFunction
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

        static int[] GetAutoArray(int length = 10, int step = 5, int first = 10)
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

        static void BeautyCall()
        {
            CQ.Pretty liuxiaoqing = new CQ.Pretty(168, 58, "liuxiaoqing", true);
            Console.WriteLine("Pretty women name:" + liuxiaoqing.Name + " \n  身高 " + liuxiaoqing.Height + " \n  婚否？  " + liuxiaoqing.Marry);
            Console.WriteLine();
            TW.Pretty lingzhiling = new TW.Pretty(173, 65, "lingzhiling", false);
            Console.WriteLine("Pretty women name:" + lingzhiling.Name + " \n  身高 " + lingzhiling.Height + " \n  婚否？  " + lingzhiling.Marry);
            Console.Write("\n输入回车键退出");
            Console.ReadLine();
        }

        static void DateTime(int year, int month, int day)
        {
            DateTime date = new DateTime(year, month, day);
            Console.WriteLine("第1周： 2018年12月31日 - 2019年 1月 6日");
            int week = 1;
            bool success = true;
            while (success)
            {
                Console.WriteLine();
                Console.Write($"第{ week + 1}周：");
                DateTime dateToDisplay = date.AddDays(week * 7 - 6);
                Console.Write($" 2019年 {dateToDisplay.Month}月 {dateToDisplay.Day}日");
                dateToDisplay = date.AddDays((week + 1) * 7);
                Console.Write($" - 2019年 {dateToDisplay.Month}月 {dateToDisplay.Day}日");
                Console.WriteLine();
                week++;
                if (dateToDisplay.Year != 2019)
                {
                    success = false;
                }
            }
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("模拟深度为10的栈");
            int[] array = { 2, 5, 9 };
            int[] array2 = { 1, 6, 8, 5 };
            ImitateStack imitateStack = new ImitateStack();

            imitateStack.Push(10);
            imitateStack.Push(array);
            imitateStack.Push(15);
            imitateStack.Pop(15);
            imitateStack.Pop(array);
            imitateStack.Push(array2);
            imitateStack.Push(array2);
            imitateStack.Push(array2);

            Console.ReadLine();
        }
    }
}

namespace China.Taiwanese.pretty
{
    struct Pretty
    {
        public int Height;
        private int Weight;
        public string Name;
        internal bool Marry;

        public Pretty(int height, int weight, string name, bool marry)
        {
            Height = height;
            Weight = weight;
            Name = name;
            Marry = marry;
        }

    }
}
namespace China.ChongQing.pretty
{
    struct Pretty
    {
        public int Height;
        private int Weight;
        public string Name;
        internal bool Marry;

        public Pretty(int height, int weight, string name, bool marry)
        {
            Height = height;
            Weight = weight;
            Name = name;
            Marry = marry;
        }
    }
}
