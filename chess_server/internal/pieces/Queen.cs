using System;

public class Queen : Piece
{
	public Queen(Color color, Board board = null) : base(color, board)
	{
	}

	public override void Move(Point from, Point to)
	{
		throw new NotImplementedException();
	}

	// ToString override to display board characters
	public override string ToString()
	{
		return Color == Color.White ? "Q" : "q";
	}
}
