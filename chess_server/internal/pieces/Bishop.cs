using System;

public class Bishop : Piece
{
	public Bishop(Color color, Board board = null) : base(color, board)
	{
	}

	public override void Move(Point from, Point to)
	{
		Board.BoundsCheck(from.X, from.Y);
		Board.BoundsCheck(to.X, to.Y);

		if (Math.Abs(from.X - to.X) != Math.Abs(from.Y - to.Y))
		{
			throw new ArgumentException($"Invalid move: Bishop ({from.X}, {from.Y}) -> ({to.X}, {to.Y})");
		}

		CheckTargetSquare(to.X, to.Y);

		int dirX = to.X > from.X ? 1 : -1;
		int dirY = to.Y > from.Y ? 1 : -1;

		int i = from.X + dirX;
		int j = from.Y + dirY;
		for (; i != to.X; i += dirX, j += dirY)
		{
			Piece p = Board.GetPlayerPiece(i, j);
			if (p == null)
			{
				continue;
			}

			Board.SetPlayerPiece(i, j, p);
			throw new Exception($"Invalid move: Bishop can't move through piece at ({i}, {j})");
		}
	}

	// ToString override to display board characters
	public override string ToString()
	{
		return Color == Color.White ? "B" : "b";
	}
}
