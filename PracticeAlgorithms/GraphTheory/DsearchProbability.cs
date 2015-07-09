using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory
{
    public class DsearchProbability
    {
        static void Solve(string[] args)
        {
            Graph<int> graph = new Graph<int>();

            GraphNode<int> node1 = new GraphNode<int>(1);
            GraphNode<int> node2 = new GraphNode<int>(2);

            graph.AddNode(node1);
            graph.AddNode(node2);

            graph.AddDirectedEdge(node1, node2);
        }
    }
}
