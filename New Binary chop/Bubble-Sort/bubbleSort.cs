using System;
using System.Collections.Generic;
using System.Text;

namespace Bubble_Sort
{
   public  class BubbleSort
    {

        

        public static void Swap(ref int A, ref int B)
        {
            int temp;
            temp = A;
            A = B;
            B = temp;
        }

        public void Sort(int length)
        {
            int lengt =length;
            int time = 0;
            RandomArray bubble = new RandomArray(lengt);
            for (bool seek = true; seek == true;)
            {
                seek = false;
                for (int i = 1; i < lengt; i++)
                {
                    if (bubble.array[i] < bubble.array[i - 1])
                    {
                        Swap(ref bubble.array[i], ref bubble.array[i - 1]);
                        time++;
                        seek = true;
                    }
                }
            }

            for (int j = 0; j < lengt; j++)
            {
                Console.WriteLine(bubble.array[j] + " ");
            }
            Console.WriteLine(time);
            Console.ReadLine();
        }


    }
}
