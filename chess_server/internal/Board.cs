using System;

// Board class - Handles getting and setting a piece on the board
public class Board
{
	private Piece[] _board;

	// When no board is provided initialise the default board
	public Board()
	{
		// TODO: Initial board configuration
	}

	// Initialise the board with a predefined layout
	public Board(Piece[] board)
	{
		_board = board;
	}

	// PrintBoard writes the board out to the console
	public void PrintBoard()
	{
		throw new NotImplementedException();
	}

	// Get a piece from the array
	public Piece GetPlayerPiece(int x, int y)
	{
		throw new NotImplementedException();
	}

	// Set a piece in the array
	public void SetPlayerPiece(int x, int y, Piece p)
	{
		throw new NotImplementedException();
	}

	// Make sure the X and Y are not outside the array bounds
	public void BoundsCheck(int x, int y)
	{
		throw new NotImplementedException();
	}
}
