using System;

namespace BinaryTree
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("dataNode");

            Tree MyTree = new Tree();
            MyTree.AddNode(4);
            MyTree.AddNode(1);
            MyTree.AddNode(7);
            MyTree.AddNode(2);
            MyTree.AddNode(6);
            MyTree.AddNode(-5);
            MyTree.AddNode(12);
            MyTree.ShowTree();

            Console.ReadLine();
        }
    }
}