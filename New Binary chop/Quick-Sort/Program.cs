using System;

namespace Quick_Sort
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

        static void AnotherSort(int[] arr, int low, int height)
        {
            if (low >= height)
            {
                return;
            }

            int left = low;
            int right = height;
            int baseNum = arr[low];

            while (left < right)
            {

                while (arr[right] > baseNum && left < right)
                {
                    right--;
                }
                while (arr[left] <= baseNum && left < right)
                {
                    left++;
                }
                Swap(ref arr[left], ref arr[right]);
            }

            if (left == right)
            {
                Swap(ref arr[low], ref arr[left]);
            }

            //对基准左侧排序
            AnotherSort(arr, low, left - 1);

            //对基准右侧排序
            AnotherSort(arr, left + 1, height);

        }



        static void Sort(int[] arr, int low, int hight)
        {
            if (low >= hight)
            {
                return;
            }

            int left = low;
            int right = hight;
            int baseNum = arr[low];

            while (left < right)
            {
                while (arr[right] >= baseNum && left < right)
                {
                    right--;
                }
                Swap(ref arr[left], ref arr[right]);

                while (arr[left] <= baseNum && left < right)
                {
                    left++;
                }
                Swap(ref arr[left], ref arr[right]);

                //对基准左侧重复操作
                Sort(arr, low, left - 1);

                //对基准右侧重复操作
                Sort(arr, left + 1, hight);
            }
        }

        static void Main(string[] args)
        {
            //RandomArray quickSort = new RandomArray(20);

            //Sort(quickSort.array, 0, quickSort.array.Length - 1);

            //for (int i = 0; i < quickSort.array.Length; i++)
            //{
            //    Console.WriteLine(quickSort.array[i]);
            //}

            //Console.WriteLine();

            //RandomArray quickSort2 = new RandomArray(5);

            int[] array = new int[] { 23, 56, 12, 8, 9, 76, 18, 32, 42, 15, 5, 26, 26 };
            AnotherSort(array, 0, array.Length - 1);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }

            Console.ReadLine();
        }
    }
}
