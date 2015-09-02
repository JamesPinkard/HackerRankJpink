using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class TreeNode<T>
    {
        public T NodeValue { get; private set; }
        public TreeNode(T nodeValue)
        {
            NodeValue = nodeValue;
        }

        public List<TreeNode<T>> GetChildren()
        {
            return _children.ToList();
        }

        public void AddChild(TreeNode<T> value)
        {
            _children.Add(value);
        }

        private List<TreeNode<T>> _children;


    }
}
