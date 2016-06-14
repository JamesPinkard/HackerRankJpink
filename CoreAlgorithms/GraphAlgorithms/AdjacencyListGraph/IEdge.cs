namespace GraphAlgorithms.AdjacencyListGraph
{
    public interface IEdge
    {
        Node FromNode { get; }
        Node ToNode { get; }
    }
}