using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public abstract class HeapBase<T> : IHeap<T>
        where T: class
    {/*
        private readonly Comparison<T> _keyCompareFunc;
        private readonly Func<T, T, bool> _elementCompareFunc;
        private List<T> _elements = new List<T>();

        protected HeapBase(Comparison<T> keyCompareFunc, Func<T, T, bool> elementCompareFunc)
        {
            _keyCompareFunc = keyCompareFunc;
            _elementCompareFunc = elementCompareFunc;
        }

        // Methods
        public virtual T ExtractRoot()
        {
            if (_elements.Count>0)
            {
                _elements.RemoveAt(0);
            }
            return this.Root;
        }

        public virtual void UpdateKey<TKey>(T element, Action<T, TKey> keyUpdateFunc, TKey newValue);
        public virtual void Insert(T element);
        public virtual void Clear();
        public virtual void Remove(T element);
        public virtual void Contains(T element);

        // Properties
        public virtual T Root { get; }
        public virtual int Count { get; }

        protected Comparison<T> KeyCompareFunc
        {
            get { return _keyCompareFunc; }
        }

        protected Func<T, T, bool> ElementCompareFunc
        {
            get { return _elementCompareFunc; }
        }*/
        public T ExtractRoot()
        {
            throw new NotImplementedException();
        }

        public void UpdateKey<TKey>(T element, Action<T, TKey> keyUpdateFunc, TKey newValue)
        {
            throw new NotImplementedException();
        }

        public void Insert(T element)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Remove(T element)
        {
            throw new NotImplementedException();
        }

        public void Contains(T element)
        {
            throw new NotImplementedException();
        }

        public T Root
        {
            get { throw new NotImplementedException(); }
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    }
}
