using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public interface IHeap<T>
        where T : class
    {
        // Methods
        T ExtractRoot();
        
        void Insert(T element);
        void Clear();
        void Remove(T element);
        bool Contains(T element);

        // Properties
        T Root { get; }
        int Count { get; }

    }
}
