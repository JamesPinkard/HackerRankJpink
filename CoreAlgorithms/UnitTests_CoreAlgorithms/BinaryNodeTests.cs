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
    public class BinaryNodeTests
    {
        [Test]
        public void InorderTraversal_PrintsList()
        {
            BinaryNode<int> root = new BinaryNode<int>(4);
            BinaryNode<int> node1 = new BinaryNode<int>(1);
            BinaryNode<int> node2 = new BinaryNode<int>(2);
            BinaryNode<int> node3 = new BinaryNode<int>(3);
            BinaryNode<int> node5 = new BinaryNode<int>(5);
            BinaryNode<int> node6 = new BinaryNode<int>(6);
            BinaryNode<int> node7 = new BinaryNode<int>(7);
            BinaryNode<int> node8 = new BinaryNode<int>(8);
            root.LeftChild = node2;
            root.RightChild = node5;
            node2.LeftChild = node1;
            node2.RightChild = node3;
            node5.RightChild = node7;
            node7.LeftChild = node6;
            node7.RightChild = node8;

            root.TraverseInorderRecursively();
            List<int> expected = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> dummy = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            Assert.AreEqual(expected, dummy);
        }

        [Test]
        public void InorderTraversal_SetsTreelisting()
        {
            BinaryNode<int> root = new BinaryNode<int>(4);
            BinaryNode<int> node1 = new BinaryNode<int>(1);
            BinaryNode<int> node2 = new BinaryNode<int>(2);
            BinaryNode<int> node3 = new BinaryNode<int>(3);
            BinaryNode<int> node5 = new BinaryNode<int>(5);
            BinaryNode<int> node6 = new BinaryNode<int>(6);
            BinaryNode<int> node7 = new BinaryNode<int>(7);
            BinaryNode<int> node8 = new BinaryNode<int>(8);
            root.LeftChild = node2;
            root.RightChild = node5;
            node2.LeftChild = node1;
            node2.RightChild = node3;
            node5.RightChild = node7;
            node7.LeftChild = node6;
            node7.RightChild = node8;

            root.TraverseInorder();
            List<int> expected = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            

            Assert.AreEqual(expected, root.TreeListing);
        }

        [Test]
        public void AddNode_AddEightRandomNumbers_OrderIsSorted()
        {
            BinaryNode<int> root = new BinaryNode<int>(4);
            List<int> expected = new List<int>() { 4 };
            Random rand = new Random();

            for (int i = 0; i < 8; i++)
            {
                int x = rand.Next(0, 100);
                root.AddNode(x);
                expected.Add(x);                
            }
            root.TraverseInorder();
            expected.Sort();

            Assert.AreEqual(expected, root.TreeListing);
        }
    }
}
