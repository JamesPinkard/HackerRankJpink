using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public abstract class SearchTreeBase<T> : ISearchTree<T>
    {
        private List<T> _elements;

        public void Search(T element)
        {
            throw new NotImplementedException();
        }

        public T Minimum()
        {
            throw new NotImplementedException();
        }

        public T Maximum()
        {
            throw new NotImplementedException();
        }

        public T Predecessor(T element)
        {
            throw new NotImplementedException();
        }

        public T Successor(T element)
        {
            throw new NotImplementedException();
        }

        public void Add(T element)
        {
            throw new NotImplementedException();
        }

        public void Remove(T element)
        {
            throw new NotImplementedException();
        }
    }
}
