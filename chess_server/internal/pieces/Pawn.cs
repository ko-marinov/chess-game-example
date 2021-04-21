using System;

public class Pawn : Piece
{
	public Pawn(Color color, Board board = null) : base(color, board)
	{
	}

	public override void Move(Point from, Point to)
	{
		throw new NotImplementedException();
	}

	// ToString override to display board characters
	public override string ToString()
	{
		return Color == Color.White ? "P" : "p";
	}
}
