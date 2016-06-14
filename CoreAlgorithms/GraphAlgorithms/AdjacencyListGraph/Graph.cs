using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GraphAlgorithms.AdjacencyListGraph
{
    class Graph
    {
        public IList<Node> Nodes { get { return _nodes; } }
                
        public Graph(List<Node> nodes)
        {
            this._nodes = nodes.ToList();
        }

        public void AddNode(Node node)
        {
            _nodes.Add(node);
        }

        public void RemoveNode(Node node)
        {
            _nodes.Remove(node);
        }

        List<Node> _nodes; 
    }
}
