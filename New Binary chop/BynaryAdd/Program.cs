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
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray ranArray = new RandomArray(20);



        }
    }
}
