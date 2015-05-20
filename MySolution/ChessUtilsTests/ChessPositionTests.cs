using System;
using NUnit.Framework;
using MySolution.ChessUtils;

namespace MySolution.ChessUtilsTests
{
    [TestFixture]
    public class ChessPositionTests
    {
        [Test]
        public void TestParse()
        {
            var value = ChessPosition.Parse("H2");
            Assert.AreEqual(8, value.X);
            Assert.AreEqual(2, value.Y);
        }

        [Test]
        public void TestParseEmpty()
        {
            var value = ChessPosition.Parse("");
            Assert.AreEqual(0, value.X);
            Assert.AreEqual(0, value.Y);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestParseInvalid()
        {
            ChessPosition.Parse("I5");
        }

        [Test]
        public void TestToString()
        {
            var value = new ChessPosition(4, 6).ToString();
            Assert.AreEqual("D6", value);
        }
    }
}
