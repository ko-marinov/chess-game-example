using System;
using Xunit;

namespace ChessTests
{
    public class BishopMoveTest
    {
        private Board CreateBoard()
        {
            Piece[] predefinedBoard = new Piece[64];

            //WBishop C4
            predefinedBoard[26] = new Bishop(Color.White);
            //WPawn A2
            predefinedBoard[8] = new Pawn(Color.White);
            //BPawn F7
            predefinedBoard[53] = new Pawn(Color.Black);
            //BPawn E7
            predefinedBoard[52] = new Pawn(Color.Black);
            //BKnight E6
            predefinedBoard[44] = new Knight(Color.Black);
            //WBishop F1
            predefinedBoard[5] = new Bishop(Color.White);
            //BRook B5
            predefinedBoard[33] = new Rook(Color.Black);

            Board board = new Board(predefinedBoard);
            board.PrintBoard();

            return board;
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(5, 7)]
        public void MoveTest_ArgumentException(int toX, int toY)
        {
            // Arrange
            Board board = CreateBoard();
            Point from = new Point() { X = 2, Y = 3 };
            Point to = new Point() { X = toX, Y = toY };

            // Act & Assert
            Piece bishop = board.GetPlayerPiece(2, 3);
            Assert.Throws<ArgumentException>(() => bishop.Move(from, to));
        }

        [Theory]
        [InlineData(7, 8)]
        [InlineData(-1, 0)]
        public void MoveTest_ArgumentOutOfRangeException(int toX, int toY)
        {
            // Arrange
            Board board = CreateBoard();
            Point from = new Point() { X = 2, Y = 3 };
            Point to = new Point() { X = toX, Y = toY };

            // Act & Assert
            Piece bishop = board.GetPlayerPiece(2, 3);
            Assert.Throws<ArgumentOutOfRangeException>(() => bishop.Move(from, to));
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(0, 5)]
        [InlineData(5, 6)]
        [InlineData(5, 0)]
        public void MoveTest_Exception(int toX, int toY)
        {
            // Arrange
            Board board = CreateBoard();
            Point from = new Point() { X = 2, Y = 3 };
            Point to = new Point() { X = toX, Y = toY };

            // Act & Assert
            Piece bishop = board.GetPlayerPiece(2, 3);
            Assert.Throws<Exception>(() => bishop.Move(from, to));
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(1, 4)]
        [InlineData(4, 5)]
        [InlineData(3, 4)]
        [InlineData(3, 2)]
        [InlineData(4, 1)]
        public void MoveTest_NoException(int toX, int toY)
        {
            // Arrange
            Board board = CreateBoard();
            Point from = new Point() { X = 2, Y = 3 };
            Point to = new Point() { X = toX, Y = toY };

            // Act & Assert
            Piece bishop = board.GetPlayerPiece(2, 3);
            var ex = Record.Exception(() => bishop.Move(from, to));
            Assert.Null(ex);
        }
    }
}
