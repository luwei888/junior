using System;

namespace 数据类型
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("A/B="+divide(10,2));
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        static float divide (float A,float B)
        {
            float number= A / B;
            return number ;
        }
    }
}
