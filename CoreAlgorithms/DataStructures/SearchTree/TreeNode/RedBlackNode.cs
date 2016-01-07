using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public enum NodeColor { Red, Black };

    public class RedBlackNode<T> where T : IComparable<T>
    {

        public RedBlackNode<T> RightChild { get; set; }
        public RedBlackNode<T> LeftChild { get; set; }
        public RedBlackNode<T> Parent { get; set; }
        public T NodeValue { get; private set; }
        public NodeColor Color {get; set;}
        
        public RedBlackNode(T nodeValue, NodeColor color)
        {
            NodeValue = nodeValue;
            Color = color;
        }




    }
}
