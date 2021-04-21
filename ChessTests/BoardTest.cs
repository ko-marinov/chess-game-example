using System;
using Xunit;

namespace ChessTests
{
    public class BoardTest
    {
        [Theory]
        [InlineData(0, 0, false)]
        [InlineData(-1, 0, true)]
        [InlineData(1, -1, true)]
        [InlineData(1, 7, false)]
        [InlineData(8, 8, true)]
        [InlineData(-8, 1, true)]
        public void BoundsCheckTest(int x, int y, bool isThrow)
        {
            // Arrange
            Board b = new Board();

            // Act & Assert
            if (isThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => b.BoundsCheck(x, y));
            }
            else
            {
                var ex = Record.Exception(() => b.BoundsCheck(x, y));
                Assert.Null(ex);
            }
        }
    }
}
