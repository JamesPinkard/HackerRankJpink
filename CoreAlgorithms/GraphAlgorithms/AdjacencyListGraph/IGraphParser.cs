using System.Collections.Generic;

namespace GraphAlgorithms.AdjacencyListGraph
{
    public interface IGraphParser
    {
        IEnumerable<Node> Parse(IEnumerable<string> nodeData);
    }
}