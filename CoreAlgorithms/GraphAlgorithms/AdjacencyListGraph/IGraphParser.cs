using System.Collections.Generic;

namespace GraphAlgorithms.AdjacencyListGraph
{
    public interface IGraphParser
    {
        IList<Node> Parse(IEnumerable<string> nodeData);
    }
}