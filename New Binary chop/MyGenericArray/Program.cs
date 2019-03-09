using System;

namespace MyGenericArray
{

    internal class GenericArray<T>
    {
        private T[] array;
        internal GenericArray(int size)
        {
            array = new T[size + 1];
        }
        internal T GetItem(int index)
        {
            return array[index];
        }
        internal void SetItem(int index, T value)
        {
            array[index] = value;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericArray<int> intArray = new GenericArray<int>(12);
            //设置array值
            for (int i = 0; i < 12; i++)
            {
                intArray.SetItem(i, i);
            }
            //提取array值
            for (int j = 0; j < 12; j++)
            {
                Console.WriteLine(intArray.GetItem(j));
            }
            Console.WriteLine();

            GenericArray<string> strArray = new GenericArray<string>(13);
            for (int i = 0; i < 12; i++)
            {
                strArray.SetItem(i, Convert.ToString(i));
            }
            //提取array值
            for (int j = 0; j < 12; j++)
            {
                Console.WriteLine(strArray.GetItem(j));
            }
            Console.ReadLine();
        }
    }
}
