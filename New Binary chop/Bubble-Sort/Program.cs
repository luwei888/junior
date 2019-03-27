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

        static void Main(string[] args)
        {

            //冒泡排序
            BubbleSort BubSort = new BubbleSort();

            BubSort.Sort(20);

            //快速排序
            QuickSort quiSort = new QuickSort();




        }



    }
}
