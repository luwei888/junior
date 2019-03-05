using Homework_set;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aotoganerate_array
{
    abstract internal class BinarySeek
    {
        internal  void BinaryChop2(int length, int input, ref int index)
        {
           FatherArray array = new FatherArray();
            array.array = new int[length];
            int[] array2 = array.array;
            int time = 1;
            bool seek = false;
            index = array2.Length - 1;
            Console.WriteLine("请输入要查找的数：");

            Console.WriteLine();

        }
    }
}
