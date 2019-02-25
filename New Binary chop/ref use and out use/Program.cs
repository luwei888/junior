using System;

namespace ref_use_and_out_use
{
    class Program
    {

        static void Main(string[] args)
        {
            float A = 6.66f;
            float B = 8.88f;
            Swap(ref A, ref B);
            Console.WriteLine("A=" + A + " B=" + B);
            Console.ReadLine();
        }
        static void Swap(ref float A, ref float B)
        {
            float temp;
            temp = A;
            A = B;
            B = temp;
        }

        //static void Main()
        //{
        //    bool result;
        //    Console.WriteLine("输入一个数：");
        //    int i = Convert.ToInt32(Console.ReadLine());
        //    Double(ref i, out result);
        //    Console.WriteLine(i);
        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}
        //static int Double(ref int i, out bool result)
        //{
        //    if (i > 0)
        //    {

        //        i = i * 2;
        //        result = true;
        //    }
        //    else
        //    {
        //        i = 0;
        //        result = false;
        //    }

        //    return i;
        //}

    }
}
