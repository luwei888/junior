using System;

namespace Bubble_Sort
{

    public class RandomArray
    {
        public int[] array;

        public RandomArray(int length)
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
        public static void Swap(ref int A, ref int B)
        {
            int temp;
            temp = A;
            A = B;
            B = temp;
        }


        static void Main(string[] args)
        {
            int length = 20;
            RandomArray bubble = new RandomArray(length);
            for (bool seek = true; seek == true;)
            {
                seek = false;
                for (int i = 1; i < length; i++)
                {
                    if (bubble.array[i] < bubble.array[i - 1])
                    {
                        Swap(ref bubble.array[i], ref bubble.array[i - 1]);
                        seek = true;
                    }
                }
            }

            for (int j = 0; j < length; j++)
            {
                Console.WriteLine(bubble.array[j] + " ");
            }

            Console.ReadLine();
        }
    }
}
