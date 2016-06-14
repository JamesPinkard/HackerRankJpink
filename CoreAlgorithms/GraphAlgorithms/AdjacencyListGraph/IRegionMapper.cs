using System.Collections.Generic;

namespace GraphAlgorithms.AdjacencyListGraph
{
    public interface IRegionMapper
    {
        IEnumerable<HashSet<Node>> CollectNodesByRegion(IEnumerable<Node> nodes);
    }
}