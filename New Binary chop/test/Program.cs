using System;

namespace test
{

    class Person
    {
        public void Add()
        {
            Console.WriteLine("666");
        }

        public virtual void get()
        {
            Console.WriteLine("888");
        }
    }

    class Man : Person
    {
        public new void Add()
        {
            Console.WriteLine("子类666");
        }
        public override void get()
        {
            Console.WriteLine("子类888");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person();
            Person b = new Man();
            Man d = new Man();
            Man c = b as Man;

            a.Add();
            a.get();

            b.Add();
            b.get();

            c.Add();
            c.get();

            d.Add();
            d.get();

            Console.Read();
        }
    }
}
