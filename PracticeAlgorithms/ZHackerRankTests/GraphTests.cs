using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
