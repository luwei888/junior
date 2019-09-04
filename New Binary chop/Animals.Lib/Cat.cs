using BabyStoller.SDK;
using System;

namespace Animals.Lib
{
    [Unfinished]
    public class Cat:IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Meow!");
            }
        }
    }
}
