using System;
using System.Collections.Generic;

namespace Sort_binary_tree_by_levels
{
    internal class Program
    {
        //https://www.codewars.com/kata/52bef5e3588c56132c0003bc/train/csharp
        public static List<int> TreeByLevels(Node node)
        {
            if (node == null)
            {
                return null;
            }
            var nodeL = node.Left;
            var nodeR = node.Right;
            var listOfNodesValues = new List<int>();
            var listOfNodes = new List<Node>();
            var list = TreeLevel(node, listOfNodes);
            foreach (var nodes in list)
            {
                listOfNodesValues.Add(nodes.Value);
            }
            return listOfNodesValues;
        }

        public static List<Node> TreeLevel(Node node, List<Node> listOfNodes)
        {
            var nodeL = node.Left;
            var nodeR = node.Right;
            if (node != null)
            {
                if (nodeL != null)
                {
                    listOfNodes.Add(nodeL);
                    TreeLevel(nodeL,listOfNodes);
                }
                if (nodeR != null) 
                {
                    listOfNodes.Add(nodeR);
                    TreeLevel(nodeR,listOfNodes);
                }
            }

            
            // TreeLevel(nodeL.Left, nodeR.Right, listOfNodes);
            return listOfNodes;
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