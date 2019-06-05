using System;

namespace Interface
{
    interface ISampleInterface
    {
        void SampleMethod();
    }

    class ISampleClass : ISampleInterface
    {
        void ISampleInterface.SampleMethod()
        {

        }

        static void Main(string[] args)
        {
            String six = "666";
            string eight = "888";
            ISampleInterface obj = new ISampleClass();
            obj.SampleMethod();
            Console.WriteLine(six);
            Console.WriteLine(eight);
            Console.Read();
        }

    }


}
