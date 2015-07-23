using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class NodeDictionary<T> : IDictionary<T,Node<T>>
    {
        protected Dictionary<T, Node<T>> nodeDict = new Dictionary<T,Node<T>>();

        public void Add(T key, Node<T> value)
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

        public bool TryGetValue(T key, out Node<T> value)
        {
            return nodeDict.TryGetValue(key,out value);
        }

        public ICollection<Node<T>> Values
        {
            get { return nodeDict.Values; }
        }

        public Node<T> this[T key]
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

        public void Add(KeyValuePair<T, Node<T>> item)
        {
            nodeDict[item.Key]=item.Value;
        }

        public void Clear()
        {
            nodeDict.Clear();
        }

        public bool Contains(KeyValuePair<T, Node<T>> item)
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

        public void CopyTo(KeyValuePair<T, Node<T>>[] array, int arrayIndex)
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

        public bool Remove(KeyValuePair<T, Node<T>> item)
        {
            return nodeDict.Remove(item.Key);
        }

        public IEnumerator<KeyValuePair<T, Node<T>>> GetEnumerator()
        {
            return nodeDict.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private static void Copy<T>(Dictionary<T, Node<T>> source, KeyValuePair<T, Node<T>>[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            if (arrayIndex < 0 || arrayIndex > array.Length)
                throw new ArgumentOutOfRangeException("arrayIndex");

            if ((array.Length - arrayIndex) < source.Count)
                throw new ArgumentException("Destination array is not large enough. Check array.Length and arrayIndex.");

            foreach (KeyValuePair<T,Node<T>> item in source)
                array[arrayIndex++] = item;
        }
    }
}
