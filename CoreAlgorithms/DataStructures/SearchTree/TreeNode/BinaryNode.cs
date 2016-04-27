using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BinaryNode<T> where T : IComparable<T>
    {
        public BinaryNode<T> RightChild { get; set; }
        public BinaryNode<T> LeftChild { get; set; }
        public T NodeValue { get; private set; }
        public List<T> TreeListing { get; private set; }
        public BinaryNode(T nodeValue)
        {
            NodeValue = nodeValue;
            TreeListing = new List<T>();
        }

        public void TraverseInorderRecursively()
        {
            // Section 1
            if (LeftChild != null) { LeftChild.TraverseInorderRecursively(); }
            //Console.WriteLine(NodeValue.ToString());

            // Section 2
            if (RightChild != null) { RightChild.TraverseInorderRecursively(); }

            // Section 3
        }

        public void TraverseInorder()
        {
            Stack<int> sections = new Stack<int>();
            Stack<BinaryNode<T>> nodes = new Stack<BinaryNode<T>>();

            int section = 1;
            BinaryNode<T> node = this;

            while (section > 0)
            {
                if (section == 1)
                {
                    //Console.WriteLine("Section 1: Node {0}", node.NodeValue);
                    section += 1;
                    if (node.LeftChild != null)
                    {
                        sections.Push(section);
                        nodes.Push(node);
                        node = node.LeftChild;
                        section = 1;
                    }
                }
                else if (section == 2)
                {
                    //Console.WriteLine("Section 2: Node {0}", node.NodeValue);
                    section += 1;
                    TreeListing.Add(node.NodeValue);
                    if (node.RightChild != null)
                    {
                        sections.Push(section);
                        nodes.Push(node);
                        node = node.RightChild;
                        section = 1;
                    }                                       
                }
                else if (section == 3)
                {
                    // Return from recursion
                    // If there's nothing to pop, we're at the top.
                    //Console.WriteLine("Section 3: Node {0}", node.NodeValue);
                    if (sections.Count == 0) { section = -1; }
                    else
                    {
                        section = sections.Pop();
                        node = nodes.Pop();
                    }
                }
            }
        }

        public void AddNode(T value)
        {
            if (value.CompareTo(NodeValue) < 0)
            {
                if (LeftChild == null) { LeftChild = new BinaryNode<T>(value); }
                else { LeftChild.AddNode(value); }
            }
            else
            {
                if (RightChild == null) { RightChild = new BinaryNode<T>(value); }
                else { RightChild.AddNode(value); }
            }
        }
    }
}
