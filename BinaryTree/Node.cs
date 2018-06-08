using System;

namespace BinaryTree
{
    public class Node
    {
        public int NodeData { get; set; }
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }

        public Node(int nodeData)
        {
            NodeData = nodeData;
        }

        public void AddNode(int nodeData)
        {
            if (nodeData < NodeData)
            {
                if (LeftNode == null)
                { LeftNode = new Node(nodeData); }
                else
                {
                    LeftNode.AddNode(nodeData);
                }
            }
            else
            {
                if (RightNode == null)
                { RightNode = new Node(nodeData); }
                else
                {
                    RightNode.AddNode(nodeData);
                }
            }
        }

        public void PrintNode()
        {
            if ((this.LeftNode != null) & (this.RightNode != null))
                Console.WriteLine(NodeData.ToString() + " (" + this.LeftNode.NodeData.ToString() + " " +
                    this.RightNode.NodeData.ToString() + ")");
            else if (this.LeftNode != null)
                Console.WriteLine(NodeData.ToString() + " (" + this.LeftNode.NodeData.ToString() + "  )");
            else if (this.RightNode != null)
                Console.WriteLine(NodeData.ToString() + " (  " + this.RightNode.NodeData.ToString() + ")");
            else
                Console.WriteLine(NodeData.ToString() + " (   )");

            if (LeftNode != null)
            { LeftNode.PrintNode(); }
            if (RightNode != null)
            { RightNode.PrintNode(); }
        }

        public void DeleteNode(int nodeData)
        {
        }
    }
}