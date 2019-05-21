using System;

namespace virtualLearn
{
    using System;

    class A

    {

        public A()
        {
            PrintFields();
        }
        public virtual void PrintFields() { }
    }


    class B : A
    {
        int x = 1;
        int y;
        public B() { y = -1; }


        public override void PrintFields()
        { Console.WriteLine("x={0},y={1}", x, y); }

    }


    class Program
    {
        static void Main(string[] args)
        {
            B six = new B();
            Console.Read();
        }
    }
}
