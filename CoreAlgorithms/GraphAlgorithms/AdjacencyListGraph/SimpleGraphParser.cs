using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.AdjacencyListGraph
{
    class SimpleGraphParser : IGraphParser
    {
        public IEnumerable<Node> Parse(IEnumerable<string> nodeData)
        {
            List<string> dataList = nodeData.ToList();

            _rows = Convert.ToInt32(dataList[0]);
            _columns = Convert.ToInt32(dataList[1]);

            List<string> datarows = dataList.GetRange(2, dataList.Count - 2);
            Node[,] nodeMatrix = CreateNodeMatrix(datarows);

            List<Node> graphNodes = assignNodeNeighbors(nodeMatrix);
            return graphNodes;
        }

        public Node[,] CreateNodeMatrix(List<string> datarows)
        {
            var stringMatrix = getStringMatrix(datarows.GetRange(2, datarows.Count - 2));
            int[,] valueMatrix = getIntegerMatrix(stringMatrix);
            Node[,] nodeMatrix = makeNodeMatrix(valueMatrix);
            return nodeMatrix;
        }

        private List<Node> assignNodeNeighbors(Node[,] nodeMatrix)
        {
            List<Node> nodes = new List<Node>();

            for (int ri = 0; ri < _rows; ri++)
            {
                for (int ci = 0; ci < _columns; ci++)
                {
                    List<GridIndex> neighborIndices = getNeighborCells(ri, ci);
                    var thisNode = nodeMatrix[ri, ci];

                    foreach (var index in neighborIndices)
                    {
                        var neigbor = nodeMatrix[index.Row, index.Column];
                        thisNode.AddNeighbor(neigbor);
                        nodes.Add(thisNode);
                    }
                }
            }

            return nodes;
        }

        private List<GridIndex> getNeighborCells(int ri, int ci)
        {
            List<GridIndex> indices = new List<GridIndex>
            {
                new GridIndex(ri-1, ci-1),
                new GridIndex(ri-1, ci),
                new GridIndex(ri-1, ci+1),
                new GridIndex(ri, ci-1),
                new GridIndex(ri, ci+1),
                new GridIndex(ri+1, ci-1),
                new GridIndex(ri+1, ci),
                new GridIndex(ri+1, ci+1)
            };

            return indices.Where(index => ValidIndex(index)).ToList();
        }

        private bool ValidIndex(GridIndex index)
        {
            return (index.Row >= 0 && index.Row < _rows && index.Column >= 0 && index.Column < _columns);
        }

        private Node[,] makeNodeMatrix(int[,] valueMatrix)
        {               
            Node[,] nodeMatrix = new Node[_rows,_columns];

            for (int ri = 0; ri < _rows; ri++)
            {
                for (int ci = 0; ci < _columns; ci++)
                {
                    Node node = new Node(valueMatrix[ri, ci]);
                    nodeMatrix[ri, ci] = node;
                }
            }
            return nodeMatrix;
        }

        private int[,] getIntegerMatrix(string[,] stringMatrix)
        {
            int[,] matrix = new int[_rows, _columns];

            for (int ri = 0; ri < _rows; ri++)
            {
                for (int ci = 0; ci < _columns; ci++)
                {
                    matrix[ri, ci] = Convert.ToInt32(stringMatrix[ri, ci]);
                }
            }
            return matrix;
        }

        private string[,] getStringMatrix(List<string> dataList)
        {
            string[,] stringMatrix = new string[_rows, _columns];

            for (int ri = 0; ri < dataList.Count; ri++)
            {
                string[] entries = dataList[ri].Split();

                for (int ei = 0; ei < entries.Length; ei++)
                {
                    stringMatrix[ri, ei] = entries[ei];
                }
            }
            return stringMatrix;
        }

        private int _rows;
        private int _columns;
    }
}
