using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.AdjacencyListGraph
{
    public class RegionProcessor
    {
        public RegionProcessor(IDataReader dataReader, IGraphParser graphParser, IRegionMapper regionMapper)
        {
            this._dataReader = dataReader;
            this._graphParser = graphParser;
            this._regionMapper = regionMapper;
        }

        public int GetMaxRegionSize()
        {
            var lines = _dataReader.ReadAllLines();
            var graphNodes = _graphParser.Parse(lines);
            var regions = _regionMapper.CollectNodesByRegion(graphNodes);
            int maxSize = regions.Select(r => r.Count)
                .Max();

            return maxSize;
        }

        private IDataReader _dataReader;
        private IGraphParser _graphParser;
        private IRegionMapper _regionMapper;
    }
}
