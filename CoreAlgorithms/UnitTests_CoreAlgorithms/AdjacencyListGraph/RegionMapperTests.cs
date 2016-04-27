using NUnit.Framework;
using GraphAlgorithms.AdjacencyListGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.AdjacencyListGraph.Tests
{
    [TestFixture()]
    public class RegionMapperTests
    {
        public IEnumerable<Node> SetupGraph()
        {
            /* Setup Graph like this
            1 1 0
            1 1 1 */

            List<Node> nodes = new List<Node>
            {
                new Node(1),
                new Node(1),
                new Node(0),
                new Node(1),
                new Node(1),
                new Node(1)
            };

            IEnumerable<Node> nodeZeroNeighbors = new Node[] { nodes[1], nodes[3], nodes[4] };
            IEnumerable<Node> nodeOneNeighbors = new Node[] { nodes[0], nodes[2], nodes[3], nodes[4], nodes[5] };
            IEnumerable<Node> nodeTwoNeighbors = new Node[] { nodes[1], nodes[4], nodes[5] };
            IEnumerable<Node> nodeThreeNeighbors = new Node[] { nodes[0], nodes[1], nodes[4] };
            IEnumerable<Node> nodeFourNeighbors = new Node[] { nodes[0], nodes[1], nodes[2], nodes[3], nodes[5] };
            IEnumerable<Node> nodeFiveNeighbors = new Node[] { nodes[1], nodes[2], nodes[4] };

            nodes[0].ExtendNeighbors(nodeZeroNeighbors);
            nodes[1].ExtendNeighbors(nodeOneNeighbors);
            nodes[2].ExtendNeighbors(nodeTwoNeighbors);
            nodes[3].ExtendNeighbors(nodeThreeNeighbors);
            nodes[4].ExtendNeighbors(nodeFourNeighbors);
            nodes[5].ExtendNeighbors(nodeFiveNeighbors);

            return nodes;
        }
        public IEnumerable<Node> Setup3x3Graph()
        {
            /* Setup Graph like this
            1 1 0
            1 1 1
            1 1 1 */

            List<Node> nodes = new List<Node>
            {
                new Node(1),
                new Node(1),
                new Node(0),
                new Node(1),
                new Node(1),
                new Node(1),
                new Node(1),
                new Node(1),
                new Node(1),
            };

            IEnumerable<Node> nodeZeroNeighbors = new Node[] { nodes[1], nodes[3], nodes[4] };
            IEnumerable<Node> nodeOneNeighbors = new Node[] { nodes[0], nodes[2], nodes[3], nodes[4], nodes[5] };
            IEnumerable<Node> nodeTwoNeighbors = new Node[] { nodes[1], nodes[4], nodes[5] };
            IEnumerable<Node> nodeThreeNeighbors = new Node[] { nodes[0], nodes[1], nodes[4], nodes[6], nodes[7] };
            IEnumerable<Node> nodeFourNeighbors = new Node[] { nodes[0], nodes[1], nodes[2], nodes[3], nodes[5], nodes[6], nodes[7], nodes[8] };
            IEnumerable<Node> nodeFiveNeighbors = new Node[] { nodes[1], nodes[2], nodes[4], nodes[7], nodes[8] };
            IEnumerable<Node> nodeSixNeighbors = new Node[] { nodes[3], nodes[4], nodes[7]};
            IEnumerable<Node> nodeSevenNeighbors = new Node[] { nodes[3], nodes[4], nodes[5], nodes[6], nodes[8] };
            IEnumerable<Node> nodeEightNeighbors = new Node[] { nodes[4], nodes[5], nodes[7] };


            nodes[0].ExtendNeighbors(nodeZeroNeighbors);
            nodes[1].ExtendNeighbors(nodeOneNeighbors);
            nodes[2].ExtendNeighbors(nodeTwoNeighbors);
            nodes[3].ExtendNeighbors(nodeThreeNeighbors);
            nodes[4].ExtendNeighbors(nodeFourNeighbors);
            nodes[5].ExtendNeighbors(nodeFiveNeighbors);
            nodes[6].ExtendNeighbors(nodeSixNeighbors);
            nodes[7].ExtendNeighbors(nodeSevenNeighbors);
            nodes[8].ExtendNeighbors(nodeEightNeighbors);

            return nodes;
        }

        [Test()]
        public void CollectNodesByRegionTest()
        {
            var nodes = SetupGraph();
            var mapper = new RegionMapper();

            var regions = mapper.CollectNodesByRegion(nodes);
            int maxSize = regions.Select(r => r.Count)
                .Max();

            Assert.That(maxSize, Is.EqualTo(5));
        }

        [Test()]
        public void CollectNodesByRegion_3x3()
        {
            var nodes = Setup3x3Graph();
            var mapper = new RegionMapper();

            var regions = mapper.CollectNodesByRegion(nodes);
            int maxSize = regions.Select(r => r.Count)
                .Max();

            Assert.That(maxSize, Is.EqualTo(8));
        }
    }
}