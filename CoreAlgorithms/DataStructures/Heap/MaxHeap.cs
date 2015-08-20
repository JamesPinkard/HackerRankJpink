﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class MaxHeap<T> : HeapBase<T>
    {
        public MaxHeap() { }
        
        
        public int Compare(T x, T y)
        {
            IComparable<T> myX = x as IComparable<T>;
            return myX.CompareTo(y);
        }

        protected override bool ElementCompare(T x, T y)
        {
            return Compare(x, y) > 0;
        }

    }
}