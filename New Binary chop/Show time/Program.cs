using System;

namespace Show_time
{
    class Program
    {
        static void ValueType(ref int refnumber)
        {
            refnumber++;
        }
        static void ValueType(int valueType)
        {
            valueType++;
        }

        static  void RefTyp(ref RefType refType)
        {
            refType.value++;
        }

        static void RefTyp(RefType refType)
        {
            refType.value++;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("值类型的值传递："); 

            int valueType = 1;
            Console.WriteLine("传递前valueType="+valueType);

            ValueType(valueType);
            Console.WriteLine("传递后valueType="+valueType);
            

            Console.WriteLine();
            Console.WriteLine("值类型的引用传递：");

            int refnumber = 5;
            Console.WriteLine("传递前refnumber ="+refnumber);

            ValueType(ref refnumber);
            Console.WriteLine("传递后refnumber ="+refnumber);


            
            Console.WriteLine();
            Console.WriteLine("引用类型的值传递：");

            RefType refType = new RefType();
            Console.WriteLine("传递前refType.value =" + refType.value);

            RefTyp( refType);
            Console.WriteLine("传递后valueType =" + refType.value);

            

            Console.WriteLine();
            Console.WriteLine("引用类型的引用传递：");

            RefType refType2 = new RefType();
            Console.WriteLine("传递前refnumber =" + refType2.value);

            RefTyp(ref refType2);
            Console.WriteLine("传递后refnumber =" + refType2.value);
            Console.ReadLine();
        }
    }
    class RefType
    {
        public int value=1;
    }
}
