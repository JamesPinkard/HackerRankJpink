using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.SearchTree.TreeNode
{
    public class BinaryNode<T>
    {
        public BinaryNode<T> RightChild { get; set; }
        public BinaryNode<T> LeftChild { get; set; }
        public T NodeValue { get; private set; }
        public BinaryNode(T nodeValue)
        {
            NodeValue = nodeValue;
        }

        
    }
}
