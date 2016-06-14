using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.AdjacencyListGraph
{
    class Edge : IEdge
    {
        public Node FromNode { get; private set; }
        public Node ToNode { get; private set; }

        public Edge(Node fromNode, Node toNode)
        {
            FromNode = fromNode;
            ToNode = toNode;
        }
    }
}
