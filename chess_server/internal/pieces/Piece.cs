using System;

// Base class for all pieces
public abstract class Piece
{
	public Board Board { get; set; }
	public Color Color { get; private set; }

	public Piece(Color color, Board board)
	{
		Board = board;
		Color = color;
	}

	// Move the piece on the board
	public abstract void Move(Point from, Point to);

	protected virtual void CheckTargetSquare(int x, int y)
	{
		Piece piece = Board.GetPlayerPiece(x, y);
		if (piece != null)
		{
			Board.SetPlayerPiece(x, y, piece);
			if (piece.Color == Color)
			{
				throw new Exception($"Invalid move: Ally piece at target position ({x}, {y})");
			}
		}
	}

	// NOTE: Depending on how you would like to implement the move feature this is also valid
	// You do not need to use bool Move(Point from, Point to);
	// public abstract bool ValidateMove(Point from, Point to);
}
