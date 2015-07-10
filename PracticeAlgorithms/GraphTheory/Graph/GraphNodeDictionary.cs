using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory
{
    public class GraphNodeDictionary<T> : IDictionary<T, GraphNode<T>>
    {
        protected Dictionary<T, GraphNode<T>> nodeDict = new Dictionary<T, GraphNode<T>>();

        public void Add(T key, GraphNode<T> value)
        {
            nodeDict.Add(key, value);
        }

        public bool ContainsKey(T key)
        {
            return nodeDict.ContainsKey(key);
        }

        public ICollection<T> Keys
        {
            get { return nodeDict.Keys; }
        }

        public bool Remove(T key)
        {
            return nodeDict.Remove(key);
        }

        public bool TryGetValue(T key, out GraphNode<T> value)
        {
            return nodeDict.TryGetValue(key, out value);
        }

        public ICollection<GraphNode<T>> Values
        {
            get { return nodeDict.Values; }
        }

        public GraphNode<T> this[T key]
        {
            get
            {
                return nodeDict[key];
            }
            set
            {
                nodeDict[key] = value;
            }
        }

        public void Add(KeyValuePair<T, GraphNode<T>> item)
        {
            nodeDict[item.Key] = item.Value;
        }

        public void Clear()
        {
            nodeDict.Clear();
        }

        public bool Contains(KeyValuePair<T, GraphNode<T>> item)
        {
            if (nodeDict.ContainsKey(item.Key))
            {
                return nodeDict[item.Key] == item.Value;
            }
            else
            {
                return false;
            }
        }

        public void CopyTo(KeyValuePair<T, GraphNode<T>>[] array, int arrayIndex)
        {
            Copy(nodeDict, array, arrayIndex);
        }

        public int Count
        {
            get { return nodeDict.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(KeyValuePair<T, GraphNode<T>> item)
        {
            return nodeDict.Remove(item.Key);
        }

        public IEnumerator<KeyValuePair<T, GraphNode<T>>> GetEnumerator()
        {
            return nodeDict.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private static void Copy<T>(Dictionary<T, GraphNode<T>> source, KeyValuePair<T, GraphNode<T>>[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            if (arrayIndex < 0 || arrayIndex > array.Length)
                throw new ArgumentOutOfRangeException("arrayIndex");

            if ((array.Length - arrayIndex) < source.Count)
                throw new ArgumentException("Destination array is not large enough. Check array.Length and arrayIndex.");

            foreach (KeyValuePair<T, GraphNode<T>> item in source)
                array[arrayIndex++] = item;
        }
    }
}
