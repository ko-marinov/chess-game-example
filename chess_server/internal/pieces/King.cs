using System;

public class King : Piece
{
	private Board _board;
	private Color _color;

	public King(Board board, Color color)
	{
		_board = board;
		_color = color;
	}

	public override Color GetColor() => _color;

	public override void Move(Point from, Point to)
	{
		throw new NotImplementedException();
	}

	// ToString override to display board characters
	public override string ToString()
	{
		return _color == Color.White ? "K" : "k";
	}
}
