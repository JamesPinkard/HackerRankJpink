using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NUnit.Framework;

using GraphTheory;

namespace ZHackerRankTests
{
    [TestFixture]
    public class GraphTests
    {

        [Test]
        public void BreadthFirstSearch_FourNodesStartNodeOne_Returns661()
        {
            int numberOfTestcases = 1;
            int[] nodes_and_edges = new int[2] { 4, 2 };
            int[] firstEdge = new int[2] { 1, 2 };
            int[] secondEdge = new int[2] { 1, 3 };
            int startNode = 1;
            Graph<int> graph = new Graph<int>();
            for (int i = 0; i < 4; i++)
            {
                graph.AddNode(i + 1);
            }
            GraphNodeDictionary<int> nodes = graph.Nodes;
            graph.AddUndirectedEdge(nodes[1], nodes[2], 6);
            graph.AddUndirectedEdge(nodes[1], nodes[3], 6);
            BreadthFirstSearch<int> bfs = new BreadthFirstSearch<int>();

            List<int> distances = bfs.GetDistances(graph, graph.Nodes[startNode]);
            string result = String.Join(" ", distances);

            Assert.AreEqual("6 6 -1", result);
        }

        [Test]
        public void BreadthFirstSearch_TextReturnsOutput()
        {
            BreadthFirstSearch<int> bfs = new BreadthFirstSearch<int>();
            
            using (StringReader sr = new StringReader(myText.input))
            {
                int numberOfTestcases = Convert.ToInt32(sr.ReadLine());
                int[] nodeEdges = ReadStringIntoNumArray(sr.ReadLine());

                int numOfNodes = nodeEdges[0];
                int numOfEdges = nodeEdges[1];

                Graph<int> myGraph = new Graph<int>();

                for (int j = 0; j < numOfNodes; j++)
                {
                    myGraph.AddNode(j + 1);
                    Console.WriteLine(j+1);
                }

                GraphNodeDictionary<int> nodes = myGraph.Nodes;

                for (int k = 0; k < numOfEdges; k++)
                {
                    Console.WriteLine("at edge " + k);
                    int[] edgeVertices = ReadStringIntoNumArray(sr.ReadLine());
                    int from = edgeVertices[0];
                    int to = edgeVertices[1];
                    Console.WriteLine(from + " " + to);
                    myGraph.AddUndirectedEdge(nodes[from], nodes[to], 6);
                }
                int startIndex = Convert.ToInt32(sr.ReadLine());
                GraphNode<int> startNode = nodes[startIndex];
                List<int> bfs_distance = bfs.GetDistances(myGraph, startNode);
                List<int> distances = new List<int>();
                for (int n = 0; n < nodes.Count; n++)
                {
                    Console.WriteLine(n);
                    distances.Add(nodes[n+1].Distance);
                }
                string result = String.Join(" ", bfs_distance);
                Assert.AreEqual(result, "6 6 6 6 12 6 12 6 12 12 6 6 6 6 6 12 12 6 6 6 6 12 6 12 6 12 6 12 12 12 12 6 12 12 6 12 12 6 12 6 12 6 12 12 6 6 12 6 6 6 6 12 12 12 12 6 6 6 12 6 6 12 12 12 12 12 12 6 6");
            }
        }

        public static int[] ReadStringIntoNumArray(string numString)
        {
            string[] mySplit = numString.TrimEnd().Split();
            int[] numArray = new int[mySplit.Length];
            for (int j = 0; j < mySplit.Length; j++)
            {
                int num = Convert.ToInt32(mySplit[j]);
                numArray[j] = num;
            }
            return numArray;
        }        
    }
}
