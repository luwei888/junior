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

    public class FatherArray
    {
        internal int[] array ;
        public  FatherArray()
        {
            Console.WriteLine("得到的随机数组为：");
            //Console.Write(faterArray[0] + " ");
            for (int i = 1; i < array.Length; i++)
            {
                //int random = new Random().Next(1, 20);
                //number += new Random().Next(1, 5);
                array[i] = array[i - 1] + new Random().Next(1, 10);
                Console.Write(array[i] + " ");
                //array[i] = array[i - 1] + new Random().Next(1, 5);
            }
        }
    }
    class SunArray:FatherArray
    {
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
    }
    class DoblueDmensionalArray:FatherArray
    {
        internal int[,] GetDoubleDimensionalArray(int x, int y)
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
    }

    public class HomeworkFunction
    {

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

        public void Swap(ref float A, ref float B)
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
            //CQ.Pretty liuxiaoqing = new CQ.Pretty(168, 58, "liuxiaoqing", true);
            //Console.WriteLine("Pretty women name:" + liuxiaoqing.Name + " \n  身高 " + liuxiaoqing.Height + " \n  婚否？  " + liuxiaoqing.Marry);
            //Console.WriteLine();
            //TW.Pretty lingzhiling = new TW.Pretty(173, 65, "lingzhiling", false);
            //Console.WriteLine("Pretty women name:" + lingzhiling.Name + " \n  身高 " + lingzhiling.Height + " \n  婚否？  " + lingzhiling.Marry);
            //Console.Write("\n输入回车键退出");
            //Console.ReadLine();
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

    public class FunctionCall
    {
        //Console.WriteLine("模拟深度为10的栈");
        //    int[] array = { 2, 5, 9 };
        //int[] array2 = { 1, 6, 8, 5 };
        //ImitateStack imitateStack = new ImitateStack();

        //imitateStack.Push(10);
        //    imitateStack.Push(array);
        //    imitateStack.Push(15);
        //    imitateStack.Pop(15);
        //    imitateStack.Pop(array);
        //    imitateStack.Push(array2);
        //    imitateStack.Push(array2);
        //    imitateStack.Push(array2);

        //    Console.ReadLine();
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

namespace China.Taiwanese.pretty
{
    class Pretty
    {
        private readonly int _age;
        
        private int _height;
        internal int Getheight()
        {
           return _height; 
        }

        private int _weight;
        internal int Weight
        {
            get { return _weight; }
            set
            {
                if (value >= 0)
                {
                    _weight = value;
                }
                else
                    _weight = 0;
            }
        }

        internal int FaceScore { get; set; } = 70;
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
