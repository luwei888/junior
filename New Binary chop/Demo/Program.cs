using System;

namespace Demo
{

    class Program
    {

        static (string Name, int Age, bool Marry) littleSister(string name, int age, bool marry)
        {
            string Name = name;

            int Age = age;

            bool Marry = marry;

            return (Name, Age, Marry);

        }

        static void Main(string[] args)
        {
            var beauty = littleSister("莎莎", 18, false);

            Console.WriteLine($"{beauty.Name}小姐姐芳龄{beauty .Age}岁，婚否？{beauty .Marry} ");

            Console.ReadLine();

        }
    }
}
