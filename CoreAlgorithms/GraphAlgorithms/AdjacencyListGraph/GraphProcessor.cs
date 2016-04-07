using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.AdjacencyListGraph
{
    class GraphProcessor
    {
        public GraphProcessor(IDataReader dataReader, IGraphParser graphParser)
        {
            this.dataReader = dataReader;
            this.graphParser = graphParser;
        }

        private IDataReader dataReader;
        private IGraphParser graphParser;
    }
}
