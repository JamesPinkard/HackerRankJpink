using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public interface IHeap<T>        
    {
        // Methods
        T ExtractRoot();

        void AddRange(IEnumerable<T> elements);
        void Add(T element);
        void Clear();
        void Remove(T element);
        bool Contains(T element);

        // Properties
        T Root { get; }
        int Count { get; }

    }
}
