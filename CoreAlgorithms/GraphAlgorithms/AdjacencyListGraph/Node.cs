using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.AdjacencyListGraph
{
    public class Node
    {
        public int NodeValue { get; set; }           

        private List<Edge> _neighborNodes = new List<Edge>();

        public Node(int nodeValue)
        {
            this.NodeValue = nodeValue;            
        }        

        public void AddNeighbor(Node node)
        {
            var edge = new Edge(this, node);
            _neighborNodes.Add(edge);            
        }

        
    }
}
