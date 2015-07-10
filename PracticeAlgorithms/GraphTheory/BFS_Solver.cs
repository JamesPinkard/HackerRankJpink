using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory
{
    class BFS_Solver
    {
        static void Solve(string[] args)
        {
            int numberOfTestcases = Convert.ToInt32(Console.ReadLine());
            BreadthFirstSearch<int> bfs = new BreadthFirstSearch<int>();

            for (int i = 0; i < numberOfTestcases; i++)
            {
                int[] nodeEdges = ReadStringIntoNumArray(Console.ReadLine());
                int numOfNodes = nodeEdges[0];
                int numOfEdges = nodeEdges[1];

                Graph<int> myGraph = new Graph<int>();

                for (int j = 0; j < numOfNodes; j++)
                {
                    myGraph.AddNode(j + 1);
                }

                GraphNodeDictionary<int> nodes = myGraph.Nodes;

                for (int k = 0; k < numOfEdges; k++)
                {
                    int[] edgeVertices = ReadStringIntoNumArray(Console.ReadLine());
                    int from = edgeVertices[0];
                    int to = edgeVertices[1];
                    myGraph.AddUndirectedEdge(nodes[from], nodes[to], 6);
                }
                int startIndex = Convert.ToInt32(Console.ReadLine());
                GraphNode<int> startNode = nodes[startIndex];
                List<int> distances = bfs.GetDistances(myGraph, startNode);
                string result = String.Join(" ", distances);
                Console.WriteLine(result);
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
