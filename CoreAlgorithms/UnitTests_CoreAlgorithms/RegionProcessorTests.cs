using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GraphAlgorithms.AdjacencyListGraph;
using NUnit.Framework;
using NSubstitute;

namespace UnitTests_CoreAlgorithms
{
    [TestFixture]
    class RegionProcessorTests
    {        
        [Test]
        public void GetMaxRegionSize_3x3grid_Returns8()
        {
            List<string> gridInput = new List<string>
            {
                "3",
                "3",
                "1 1 1",
                "1 1 1",
                "1 1 0"
            };
            var consoleReader = Substitute.For<IDataReader>();
            consoleReader.ReadAllLines().Returns(gridInput);

            var parser = new SimpleGraphParser();
            var mapper = new RegionMapper();
            var regionProcessor = new RegionProcessor(consoleReader, parser, mapper);

            var maxSize = regionProcessor.GetMaxRegionSize();

            Assert.That(maxSize, Is.EqualTo(8));
        }

        [Test]
        public void GetMaxRegionSize_3x3grid_Returns6()
        {
            List<string> gridInput = new List<string>
            {
                "3",
                "3",
                "0 1 1",
                "1 0 1",
                "1 1 0"
            };
            var consoleReader = Substitute.For<IDataReader>();
            consoleReader.ReadAllLines().Returns(gridInput);

            var parser = new SimpleGraphParser();
            var mapper = new RegionMapper();
            var regionProcessor = new RegionProcessor(consoleReader, parser, mapper);

            var maxSize = regionProcessor.GetMaxRegionSize();

            Assert.That(maxSize, Is.EqualTo(6));
        }

        [Test]
        public void GetMaxRegionSize_3x3grid_Returns3()
        {
            List<string> gridInput = new List<string>
            {
                "3",
                "3",
                "1 1 1",
                "0 0 0",
                "1 1 0"
            };
            var consoleReader = Substitute.For<IDataReader>();
            consoleReader.ReadAllLines().Returns(gridInput);

            var parser = new SimpleGraphParser();
            var mapper = new RegionMapper();
            var regionProcessor = new RegionProcessor(consoleReader, parser, mapper);

            var maxSize = regionProcessor.GetMaxRegionSize();

            Assert.That(maxSize, Is.EqualTo(3));
        }
    }
}
