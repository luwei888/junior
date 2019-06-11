using System;
using System.Collections.Generic;
using System.Text;

namespace advanceGrammarDemo
{

    class DoubleLinked<T>
    {
        private int _count=0;
        internal int Count
        {
            get { return _count; }
        }

        internal Node<T> Head;
        internal Node<T> Tail;

        public void Add(Node<T> node)
        {
            if (_count == 0)
            {
                Head = node;
                Tail = node;
                node.Prev = Head;
                node.Next = Tail;
                _count++;
            }
            else
            {
                node.Prev = Tail;
                node.Next = node;
                Tail = node;
                node.Prev.Next = node;
                _count++;
            }
        }



        List<Node<T>> nodelist = new List<Node<T>>();
        internal Node<T> this[int index]
        {
            get
            {
                Node<T> temp;
                if (index >= 0 && index <= _count - 1)
                {
                    temp = nodelist[index];
                    return temp;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }

            set
            {
                if (index >= 0 && index <= _count - 1)
                {
                    nodelist[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        internal void AddAfter(Node<T> node,Node<T> beAdded)
        {
            int indexer = nodelist.BinarySearch(node);
            nodelist[indexer].Next = node;
            nodelist[indexer + 1].Prev = node;
        }

    }

    class Node<T>
    {
        public Node<T> Prev { get; set; }
        public Node<T> Next { get; set; }
        public T Content { get; set; }
    }


    class CreatDoubleLink
    {
        internal static DoubleLinked<DateTime> Call()
        {
            DoubleLinked<DateTime> dl = new DoubleLinked<DateTime>();

            Node<DateTime> node_1 = new Node<DateTime> { Content = new DateTime(2019, 2, 18) };
            dl.Add(node_1);
            //case-1 => 1
            Console.WriteLine(dl.Count);
            //case-1 => true
            Console.WriteLine(node_1 == dl.Head);
            //case-1 => true
            Console.WriteLine(node_1 == dl.Tail);
            Console.WriteLine();


            Node<DateTime> node_2 = new Node<DateTime> { Content = new DateTime(2019, 2, 18) };
            dl.Add(node_2);
            //case-2 =>node_2 的上一个节点是链表的头结点;True
            Console.WriteLine(node_2.Prev == dl.Head);
            //case-2 =>node_1 的下一个节点是node_2;True
            Console.WriteLine(node_1.Next == node_2);
            //case-2 => 2
            Console.WriteLine(dl.Count);
            //case-2 => true
            Console.WriteLine(node_1 == dl.Head);
            //case-2 => tail is node_2 True
            Console.WriteLine(node_2 == dl.Tail);
            Console.WriteLine();


            Node<DateTime> node_3 = new Node<DateTime> { Content = new DateTime(2019, 3, 7) };
            dl.Add(node_3);
            //case-3 =>node_3 的上一个节点是node_2;
            Console.WriteLine(node_3.Prev == node_2);
            //case-3 =>node_2 的下一个节点是node_3;
            Console.WriteLine(node_2.Next == node_3);
            //case-3 => 3
            Console.WriteLine(dl.Count);
            //case-3 => true
            Console.WriteLine(node_1 == dl.Head);
            //case-3 => tail is node_3
            Console.WriteLine(node_3 == dl.Tail);
            //case-3 => node_2 isn't tail  
            Console.WriteLine(node_2 != dl.Tail);

            Console.Read();
            return dl;
        }



    }
}
