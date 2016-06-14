using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.AdjacencyListGraph
{
    class SimpleGridFormatter : IGridFormatter
    {     
        public int Rows
        {
            get
            {
                return _rows;
            }

            set
            {
                _rows = value;
            }
        }
        public int Columns
        {
            get
            {
                return _columns;
            }

            set
            {
                _columns = value;
            }
        }

        public List<string> Format(List<string> dataList)
        {
            List<string> datarows = dataList.GetRange(2, dataList.Count - 2);
            return datarows;
        }

        public string[,] GetStringMatrix(List<string> dataList)
        {
            string[,] stringMatrix = new string[Rows, Columns];

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

        public int[,] GetIntegerMatrix(string[,] stringMatrix)
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

        public Node[,] GetNodeMatrix(int[,] valueMatrix)
        {
            Node[,] nodeMatrix = new Node[_rows, _columns];

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

        private int _rows;
        private int _columns;
    }
}
