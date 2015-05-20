using NUnit.Framework;
using MySolution.ChessUtils;

namespace MySolution.ChessUtilsTests
{
    [TestFixture]
    public class MoveCalculatorTests
    {
        [Test]
        public void TestGetKnightMovesEmpty()
        {
            var calculator = new MoveCalculator();
            var values = calculator.GetKnightMoves(ChessPosition.Empty);

            Assert.AreEqual(0, values.Length);
        }

        [Test]
        public void TestGetKnightMovesCenter()
        {
            var calculator = new MoveCalculator();
            var values = calculator.GetKnightMoves(new ChessPosition(4, 4));

            Assert.AreEqual(8, values.Length);
            Assert.Contains(new ChessPosition(5, 6), values);
            Assert.Contains(new ChessPosition(6, 5), values);
            Assert.Contains(new ChessPosition(6, 3), values);
            Assert.Contains(new ChessPosition(5, 2), values);
            Assert.Contains(new ChessPosition(3, 2), values);
            Assert.Contains(new ChessPosition(2, 3), values);
            Assert.Contains(new ChessPosition(2, 5), values);
            Assert.Contains(new ChessPosition(3, 6), values);
        }

        [Test]
        public void TestGetKnightMovesCorner()
        {
            var calculator = new MoveCalculator();
            var values = calculator.GetKnightMoves(new ChessPosition(8, 1));

            Assert.AreEqual(2, values.Length);
            Assert.Contains(new ChessPosition(6, 2), values);
            Assert.Contains(new ChessPosition(7, 3), values);
        }
    }
}
