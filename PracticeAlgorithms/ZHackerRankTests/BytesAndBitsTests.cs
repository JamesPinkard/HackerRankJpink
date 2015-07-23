using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using BytesAndBits;

namespace ZHackerRankTests
{
    [TestFixture]
    public class BytesAndBitsTests
    {
        [Test]
        public void FlipBits_One_Returns4294967294()
        {
            FlippingBits fb = new FlippingBits();
            uint input = 1;
            uint expected = 4294967294;

            uint result = fb.FlipInteger(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FlipBits_Zero_Returns4294967295()
        {
            FlippingBits fb = new FlippingBits();
            uint input = 0;
            uint expected = 4294967295;

            uint result = fb.FlipInteger(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FlipBits_2147483647_Returns2147483648()
        {
            FlippingBits fb = new FlippingBits();
            uint input = 2147483647;
            uint expected = 2147483648;

            uint result = fb.FlipInteger(input);

            Assert.AreEqual(expected, result);
        }
    }
}
