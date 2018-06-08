using System;

namespace BinaryTree
{
    internal class Tree
    {
        private Node root;

        public Tree()
        {
            root = null;
        }

        public void AddNode(int nodeData)
        {
            if (root == null)
            {
                root = new Node(nodeData);
            }
            else
                root.AddNode(nodeData);
        }

        public void DeleteNode(int nodeData)
        {
        }

        public void ShowTree()
        {
            if (root == null)
            {
                Console.WriteLine("There in no tree");
            }
            else
                root.PrintNode();
        }

        public void ClearTree()
        {
            root = null;
        }

        private struct NodePosition { private int x, y; }
    }
}