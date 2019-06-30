using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeBFSDFS
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = Enumerable.Range(0, 10).ToArray();

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }

            Console.WriteLine("-----------------------------");
            var bst = GetTree(values, 0, values.Length-1);
            DFS(bst);
            Console.WriteLine("-----------------------------");
            BFS(bst);

            Console.Read();
        }

        static Node GetTree(int[] values, int li, int hi)
        {
            if (li > hi)
            {
                return null;
            }

            var mi = li + (hi - li) / 2;
            var node = new Node(values[mi]);
            node.Left = GetTree(values, li, mi - 1);
            node.Right = GetTree(values, mi + 1, hi);
            return node;
        }
        /// <summary>
        /// 深度优先搜索
        /// </summary>
        /// <param name="node"></param>
        static void DFS(Node node)
        {
            if (node == null)
            {
                return;
            }

            DFS(node.Left);
            Console.WriteLine(node.Value);
            DFS(node.Right);
        }

        /// <summary>
        /// 宽度优先搜索
        /// </summary>
        /// <param name="root"></param>
        static void BFS(Node root)
        {
            var q = new Queue<Node>();
            q.Enqueue(root);
            while (q.Count>0)
            {
                var node = q.Dequeue();
                Console.WriteLine(node.Value);
                if (node.Left != null)
                {
                    q.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    q.Enqueue(node.Right);
                }
            }
        }
    }

    class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}
