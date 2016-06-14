using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.AdjacencyListGraph
{
    public class Node
    {
        public int Value { get; set; }
        public ConsoleColor Color { get; set; }
        public int Degree { get; set; }

        public List<IEdge> NeighborEdges { get { return _neighborNodes; } }

        public Node(int nodeValue)
        {
            this.Value = nodeValue;            
        }        

        public void AddNeighbor(Node neighborNode)
        {
            var edge = new Edge(this, neighborNode);
            _neighborNodes.Add(edge);            
        }
                
        public void ExtendNeighbors(IEnumerable<Node> neighbors)
        {
            foreach (var node in neighbors)
            {
                AddNeighbor(node);
            }
        }

        private List<IEdge> _neighborNodes = new List<IEdge>();
    }
}
