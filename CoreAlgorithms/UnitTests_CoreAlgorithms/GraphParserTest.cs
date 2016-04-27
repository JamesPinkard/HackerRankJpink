using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GraphAlgorithms.AdjacencyListGraph;
using NUnit.Framework;

namespace UnitTests_CoreAlgorithms
{
    [TestFixture]
    class GraphParserTest
    {
        [Test]
        public void Parse_3x3grid_ReturnsGraph()
        {
            List<string> gridInput = new List<string>
            {
                "3",
                "3",
                "1 0 1",
                "0 1 0",
                "1 0 1"
            };
            IGraphParser parser = new SimpleGraphParser();

            IEnumerable<Node> nodes = parser.Parse(gridInput);

            Assert.That(nodes, Is.All.Not.Null);
        }

        [Test]
        public void Parse_3x3grid_ThereAreFiveOnes()
        {
            List<string> gridInput = new List<string>
            {
                "3",
                "3",
                "1 0 1",
                "0 1 0",
                "1 0 1"
            };
            IGraphParser parser = new SimpleGraphParser();

            IEnumerable<Node> nodes = parser.Parse(gridInput);
            var mynodes = nodes.ToList();
            var values = nodes.Select(n => n.Value)
                .Where(v => v == 1);

            Assert.That(values.Count(), Is.EqualTo(5));
        }

        [Test]
        public void Parse_3x3grid_NodesHaveNeighbors()
        {
            List<string> gridInput = new List<string>
            {
                "3",
                "3",
                "1 0 1",
                "0 1 0",
                "1 0 1"
            };
            IGraphParser parser = new SimpleGraphParser();

            IEnumerable<Node> nodes = parser.Parse(gridInput);
            var neighbors = nodes.Select(node => node.NeighborEdges);

            Assert.That(neighbors, Is.All.Not.Empty);
        }

        [Test]
        public void Parse_3x3grid_NodeCountIs9()
        {
            List<string> gridInput = new List<string>
            {
                "3",
                "3",
                "1 0 1",
                "0 1 0",
                "1 0 1"
            };
            IGraphParser parser = new SimpleGraphParser();

            IEnumerable<Node> nodes = parser.Parse(gridInput);
            Assert.That(nodes.Count(), Is.EqualTo(9));
        }

        [Test]
        public void Parse_3x3grid_NodeNeigborCountIs3()
        {
            List<string> gridInput = new List<string>
            {
                "3",
                "3",
                "1 0 1",
                "0 1 0",
                "1 0 1"
            };
            IGraphParser parser = new SimpleGraphParser();

            IEnumerable<Node> nodes = parser.Parse(gridInput);
            var neighbors = nodes.First().NeighborEdges;

            Assert.That(neighbors.Count(), Is.EqualTo(3));
        }

        [Test]
        public void Parse_3x3grid_FourNodesHaveThreeNeigbors()
        {
            List<string> gridInput = new List<string>
            {
                "3",
                "3",
                "1 0 1",
                "0 1 0",
                "1 0 1"
            };
            IGraphParser parser = new SimpleGraphParser();

            IEnumerable<Node> nodes = parser.Parse(gridInput);
            var cornerNodes = nodes.Where(n => n.NeighborEdges.Count() == 3);
                

            Assert.That(cornerNodes.Count(), Is.EqualTo(4));
        }

        [Test]
        public void Parse_3x3grid_FourNodesHaveFiveNeigbors()
        {
            List<string> gridInput = new List<string>
            {
                "3",
                "3",
                "1 0 1",
                "0 1 0",
                "1 0 1"
            };
            IGraphParser parser = new SimpleGraphParser();

            IEnumerable<Node> nodes = parser.Parse(gridInput);
            var sideNodes = nodes.Where(n => n.NeighborEdges.Count() == 5);


            Assert.That(sideNodes.Count(), Is.EqualTo(4));
        }

        [Test]
        public void Parse_3x3grid_OneNodeHaveEightNeigbors()
        {
            List<string> gridInput = new List<string>
            {
                "3",
                "3",
                "1 0 1",
                "0 1 0",
                "1 0 1"
            };
            IGraphParser parser = new SimpleGraphParser();

            IEnumerable<Node> nodes = parser.Parse(gridInput);
            var sideNodes = nodes.Where(n => n.NeighborEdges.Count() == 8);


            Assert.That(sideNodes.Count(), Is.EqualTo(1));
        }
    }
}
