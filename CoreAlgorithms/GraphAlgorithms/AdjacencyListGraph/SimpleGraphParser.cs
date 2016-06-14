using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.AdjacencyListGraph
{
    public class SimpleGraphParser : IGraphParser
    {
        public SimpleGraphParser()
        {
            _gridFormatter = new SimpleGridFormatter();
        }

        public IList<Node> Parse(IEnumerable<string> nodeData)
        {
            List<string> dataList = nodeData.ToList();
            
            Node[,] nodeMatrix = CreateNodeMatrix(dataList);

            List<Node> graphNodes = assignNodeNeighbors(nodeMatrix);
            return graphNodes;
        }



        public Node[,] CreateNodeMatrix(List<string> dataList)
        {
            _gridFormatter.Rows = Convert.ToInt32(dataList[0]);
            _gridFormatter.Columns = Convert.ToInt32(dataList[1]);
            List<string> datarows = _gridFormatter.Format(dataList);
            string[,] stringMatrix = _gridFormatter.GetStringMatrix(datarows);
            int[,] valueMatrix = _gridFormatter.GetIntegerMatrix(stringMatrix);
            Node[,] nodeMatrix = _gridFormatter.GetNodeMatrix(valueMatrix);
            return nodeMatrix;
        }        

        

        

        private List<Node> assignNodeNeighbors(Node[,] nodeMatrix)
        {
            List<Node> nodes = new List<Node>();

            for (int ri = 0; ri < _rows; ri++)
            {
                for (int ci = 0; ci < _columns; ci++)
                {
                    var thisNode = nodeMatrix[ri, ci];
                    nodes.Add(thisNode);
                    List<GridIndex> neighborIndices = getNeighborCells(ri, ci);

                    foreach (var index in neighborIndices)
                    {
                        var neigbor = nodeMatrix[index.Row, index.Column];
                        thisNode.AddNeighbor(neigbor);
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

        private int _rows;
        private int _columns;
        private IGridFormatter _gridFormatter;
    }
}
