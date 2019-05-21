using System;
using System.Collections.Generic;
using System.Text;

namespace Bubble_Sort
{
    class QuickSort
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

    }
}
