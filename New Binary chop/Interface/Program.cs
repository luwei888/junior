using System;
using System.Collections.Generic;

namespace Interface
{
    interface ISampleInterface
    {
        void SampleMethod();
    }

    class Derived :Base
    {

    }

    class Base
    {

    }

    class ISampleClass : ISampleInterface
    {
        void ISampleInterface.SampleMethod()
        {

        }

        static void Main(string[] args)
        {
            IEnumerable<Derived> d = new List<Derived>();
            IEnumerable<Base> b = d;
        }

    }

}
