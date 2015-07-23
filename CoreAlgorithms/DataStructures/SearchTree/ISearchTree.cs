using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public interface ISearchTree<T> 
    {
        void Search(T element);
        T Minimum();
        T Maximum();
        T Predecessor(T element);
        T Successor(T element);
        void Add(T element);
        void Remove(T element);
    }
}
