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

            graph.AddNode(1);
            graph.AddNode(2);

            GraphNodeDictionary<int> gNodes = graph.Nodes;

            graph.AddDirectedEdge(gNodes[1], gNodes[2]);
        }
    }
}
