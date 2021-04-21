// Base class for all pieces
public abstract class Piece
{
	// Get the piece color
	public abstract Color GetColor();
	// Move the piece on the board
	public abstract void Move(Point from, Point to);

	// NOTE: Depending on how you would like to implement the move feature this is also valid
	// You do not need to use bool Move(Point from, Point to);
	// public abstract bool ValidateMove(Point from, Point to);
}
