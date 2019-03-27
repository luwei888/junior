using System;

namespace Binary_Tree
{
    public class BinarySearchTree
    {
        public Node rootNode = null;

        public void Insert(int date)
        {
            Node Parent;
            //将所需插入的数据包装进节点
            Node newNode = new Node
            {
                date = date
            };

            //如果为空树，则插入根节点
            if (rootNode == null)
            {
                rootNode = newNode;
            }
            //否则找到合适叶子节点位置插入
            else
            {
                Node Current = rootNode;
                while (true)
                {
                    Parent = Current;
                    if (newNode.date < Current.date)
                    {
                        Current = Current.left;
                        if (Current == null)
                        {
                            Parent.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        Current = Current.right;
                        if (Current == null)
                        {
                            Parent.right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        //中序遍历
        public void InOrder(Node theRoot)
        {
            if (theRoot != null)
            {
                InOrder(theRoot.left);
                theRoot.DisplayDate();
                InOrder(theRoot.right);
            }
        }

        //找到最大节点
        public void FindMax()
        {
            Node current = rootNode;
            while (current.right != null)
            {
                current = current.right;
            }
            Console.WriteLine("\n最大节点为：" + current.date);
        }

    }

    public class Node
    {
        //节点本身数据
        public int date;

        //左孩子
        public Node left;

        //右孩子
        public Node right;

        public void DisplayDate()
        {
            Console.Write(date+" ");
        }
    }


    class Program
    {
        
        static void Main(string[] args)
        {
            BinarySearchTree b = new BinarySearchTree();
            //插入数据
            b.Insert(15);
            b.Insert(55);
            b.Insert(35);
            b.Insert(24);
            b.Insert(65);
            b.Insert(52);
            b.Insert(21);
            b.Insert(5);
            b.Insert(18);
            b.Insert(8);
            b.Insert(66);
            b.Insert(46);
            b.Insert(75);
            b.Insert(85);
            b.Insert(94);

            //堆二叉树进行中序遍历
            Console.WriteLine("中序遍历为:");

            b.InOrder(b.rootNode);

            b.FindMax();

            Console.ReadLine();











        }
    }
}
