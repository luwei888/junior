using System;
using System.Collections;

namespace IspExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 1, 2, 3, 4, 5 };

            ArrayList num2 = new ArrayList { 1, 2, 3, 4, 5 };

            ReadOnlyCollection num3 = new ReadOnlyCollection(num1);

            foreach (var item in num3)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }

    public class ReadOnlyCollection : IEnumerable
    {
        public int[] _array;

        public ReadOnlyCollection(int[] array)
        {
            _array = array;
        }

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        public class Enumerator : IEnumerator
        {
            private ReadOnlyCollection _collection;
            private int _head;

            public Enumerator(ReadOnlyCollection collection)
            {
                _collection = collection;
                _head = -1;
            }

            public object Current
            {
                get
                {
                    object o = _collection._array[_head];
                    return o;
                }
            }

            public bool MoveNext()
            {
                if (++_head < _collection._array.Length)
                {
                    return true;
                }
                else return false;
            }

            public void Reset()
            {
                _head = -1;
            }
        }
    }
}
