using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory
{
    public class BreadthFirstSearch<T>
    {
        public List<int> GetDistances(Graph<T> graph, GraphNode<T> startNode)
        {
            List<int> distances = new List<int>();
            foreach (var node in graph)
            {
                node.Color = Color.White;
                node.Distance = -1;                
            }
            startNode.Color = Color.Grey;
            startNode.Distance = 0;
            Queue<GraphNode<T>> queue = new Queue<GraphNode<T>>();
            queue.Enqueue(startNode);
            while (queue.Count > 0)
            {
                GraphNode<T> currentNode = queue.Dequeue();
                List<int> costs = currentNode.Costs;
                int nIndex = 0;
                foreach (GraphNode<T> adjacentNode in currentNode.Neighbors)
                {
                    if (adjacentNode.Color == Color.White)
                    {
                        adjacentNode.Color = Color.Grey;
                        adjacentNode.Distance = currentNode.Distance + costs[nIndex];
                        adjacentNode.Predecessor = currentNode;
                        queue.Enqueue(adjacentNode);
                    }
                    nIndex++;
                }
                currentNode.Color = Color.Black;
            }

            foreach (GraphNode<T> node in graph)
            {
                if (node.Distance != 0)
                {
                    distances.Add(node.Distance);
                }
            }

            return distances;
        }

    }
}
