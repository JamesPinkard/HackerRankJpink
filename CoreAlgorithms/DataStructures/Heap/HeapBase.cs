using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public abstract class HeapBase<T> : IHeap<T>        
    {        
        
        private List<T> _elements = new List<T>();

        protected abstract bool ElementCompare(T x, T y);

        public T ExtractRoot()
        {
            T root = this.Root;
            if (!isEmpty())
            {
                _elements.RemoveAt(0);
            }
            return root;
        }

        

        // Methods
        public void Add(T element)
        {
            _elements.Add(element);
            int index = _elements.Count - 1;            
            FloatUp(index);
        }

        public void AddRange(IEnumerable<T> elements)
        {
            foreach (var e in elements)
            {                
                Add(e);
            }
        }

        protected void FloatUp(int index)
        {       
            int parent = Parent(index);            
            while (index > 0 && !ElementCompare(_elements[parent],_elements[index]))
            {
                swap(index, parent);
                index = parent;
                parent = Parent(index);
            }
        }

        public void Clear()
        {
            _elements.Clear();
        }

        public void Remove(T element)
        {
            _elements.Remove(element);
        }

        public bool Contains(T element)
        {
            return _elements.Contains(element);
        }

        protected void FloatDown(int current)
        {
            int left = Left(current);
            int right = Right(current);

            int selected = selectTopIndex(left, current);
            selected = selectTopIndex(right, selected);

            if (selected != current)
            {
                swap(current, selected);
                FloatDown(selected);
            }
        }

        private void swap(int current, int other)
        {
            T temp = _elements[current];
            _elements[current] = _elements[other];
            _elements[other] = temp;
        }

        private int selectTopIndex(int left, int right)
        {
            int child = Math.Max(left, right);
            int parent = Math.Min(left, right);

            T childElement = _elements[child];
            T parentElement = _elements[parent];

            if (child <= _elements.Count && ElementCompare(childElement, parentElement))
            {
                return child;
            }
            else
            {
                return parent;
            }
            
        }

        protected int Parent(int index)
        {
            return index / 2;
        }

        protected int Left(int index)
        {
            return index * 2;
        }

        protected int Right(int index)
        {
            return (index * 2) + 1;
        }

        private bool isEmpty()
        {
            return _elements.Count <= 0;
        }        

        // Properties
        public T Root
        {
            get
            {
                T result = default(T);
                if (!isEmpty())
                {
                    result = _elements[0];
                }
                return result;
            }
        }

        public int Count
        {
            get { return _elements.Count; }
        }


    }
}
