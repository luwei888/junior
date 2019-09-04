using System;
using System.Collections;
using System.Collections.Generic;

namespace HelloGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Apple() { Color = "red" };
            var book = new Book() { Name = "new book" };

            var box1 = new Box<Apple> { Cargo = apple };
            var box2 = new Box<Book> { Cargo = book };
            Console.WriteLine(box1.Cargo.Color);
            Console.WriteLine(box2.Cargo.Name);
        }
    }

    internal class Apple
    {
        public string Color { get; set; }
    }

    internal class Book
    {
        public string Name { get; set; }
    }

    internal class Box<T>
    {
        public T Cargo { get; set; }
    }

}
