using System.Collections.Generic;

namespace GraphAlgorithms.AdjacencyListGraph
{
    public interface IGridFormatter
    {
        List<string> Format(List<string> dataList);
        string[,] GetStringMatrix(List<string> dataList);
        int[,] GetIntegerMatrix(string[,] stringMatrix);
        Node[,] GetNodeMatrix(int[,] valueMatrix);

        int Rows { get; set; }
        int Columns { get; set; }
    }
}