using System;
using System.Collections.Generic;

namespace Sort_binary_tree_by_levels
{
    internal class Program
    {
        private static Queue<Node> queue = new Queue<Node>();
        //https://www.codewars.com/kata/52bef5e3588c56132c0003bc/train/csharp
        public static List<int> TreeByLevels(Node node)
        {
            SortTree(node);
            return new List<int>();
        }

        public static void SortTree(Node node)
        {
            if (node != null)
            {
                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
                
            }
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine(TreeByLevels(new Node(new Node(null, new Node(null, null, 4), 2), new Node(new Node(null, null, 5), new Node(null, null, 6), 3), 1)));
        }
    }
    public class Node
    {
        public Node Left;
        public Node Right;
        public int Value;
    
        public Node(Node l, Node r, int v)
        {
            Left = l;
            Right = r;
            Value = v;
        }
    }
}