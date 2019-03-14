using System;

namespace BynaryAdd
{
    internal class RandomArray
    {
        internal int[] array;

        internal RandomArray(int length)
        {
            array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = new Random().Next(1, 200);
                Console.WriteLine(array[i]);
            }
        }
    }
    class Program
    {
        /// <summary>
        /// 减而治之
        /// </summary>
        /// <param name="array"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static int Sum(int[] array, int n)
        {
            if (n >= 1)
            {
                return Sum(array, n - 1) + array[n - 1];
            }
            else
                return 0;
        }
         
        /// <summary>
        /// 二分递归加法！
        /// </summary>
        /// <param name="array"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        /// <returns></returns>
        static int BynaryAdd(int[] array, int lo, int hi)
        {
            if (lo == hi)
            {
                Console.WriteLine(array[lo]);
                return array[lo];
            }
            int mi = (lo + hi) / 2;
            return BynaryAdd(array, lo, mi) + BynaryAdd(array, mi + 1, hi);
        }
        static void Main(string[] args)
        {
            int length = 10;
            RandomArray ranArray = new RandomArray(length);
            Console.WriteLine(Sum(ranArray.array, length));

            Console.WriteLine(BynaryAdd(ranArray.array,0,length-1));

            Console.ReadLine();
        }
    }
}
