using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using DataStructures;

namespace UnitTests_CoreAlgorithms
{
    [TestFixture]
    public class HeapTests
    {
        Random rand = new Random();
        
        [Test]
        public void MaxHeap_AddRange_CountOfTen()
        {
            List<int> testNumbers = GetTestNumbers();            
            HeapBase<int> heap = new MaxHeap<int>();
            
            heap.AddRange(testNumbers);
            
            Assert.AreEqual(10, heap.Count);
        }

        
        [Test]
        public void MaxHeap_ExtractRoot_ReturnsMax()
        {
            List<int> testNumbers = GetTestNumbers();
            MaxHeap<int> heap = new MaxHeap<int>();
            heap.AddRange(testNumbers);
            int expected = testNumbers.Max();

            int max = heap.ExtractRoot();

            Assert.AreEqual(expected, max);
        }

        [Test]
        public void MinHeap_ExtractRoot_ReturnsMax()
        {
            List<int> testNumbers = GetTestNumbers();
            MinHeap<int> heap = new MinHeap<int>();
            heap.AddRange(testNumbers);
            int expected = testNumbers.Min();

            int min = heap.ExtractRoot();

            Assert.AreEqual(expected, min);
        }

        private List<int> GetTestNumbers()
        {
            List<int> result = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                int num = rand.Next(1000);
                result.Add(num);
            }

            return result;
        }
    }
}
