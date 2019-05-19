using System;

namespace reviewDemo
{
    class Program
    {
        public struct liu
        {

        }

        static void Main(string[] args)
        {
            var tuple = (old: 38, name: "feige"); 
            Console.WriteLine(default(int));
            Console.WriteLine(tuple.old);
            string a = "\\\u0086";
            Console.WriteLine(a);
            Console.Read();
        }
    }
}
