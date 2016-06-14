using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.AdjacencyListGraph
{
    public class RegionMapper : IRegionMapper
    {
        public IEnumerable<HashSet<Node>> CollectNodesByRegion(IEnumerable<Node> nodes)
        {
            _nodes.AddRange(nodes);
            foreach (var node in _nodes)
            {                
                DepthFirstSearch(node);
            }
            return RegionDictionary.Values;
        }

        private void DepthFirstSearch(Node sourceNode)
        {
            stack.Push(sourceNode);
            

            while (stack.Count != 0)
            {
                var currentNode = stack.Pop();
                if (currentNode.Value ==0)
                {
                    visited.Add(currentNode);                    
                }
                if (visited.Contains(currentNode))
                {                    
                    continue;
                }

                if (!RegionDictionary.ContainsKey(sourceNode))
                {
                    RegionDictionary[sourceNode] = new HashSet<Node>();
                }
                                
                RegionDictionary[sourceNode].Add(currentNode);
                visited.Add(currentNode);
                foreach (var neighborEdge in currentNode.NeighborEdges)
                {
                    stack.Push(neighborEdge.ToNode);
                }
            }
        }

        Dictionary<Node, HashSet<Node>> RegionDictionary = new Dictionary<Node, HashSet<Node>>();
        Stack<Node> stack = new Stack<Node>();
        HashSet<Node> visited = new HashSet<Node>();
        List<Node> _nodes = new List<Node>();
    }
}
