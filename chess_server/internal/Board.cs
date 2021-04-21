using System;

// Board class - Handles getting and setting a piece on the board
public class Board
{
	public const int SideLength = 8;

	public const int BoardSize = SideLength * SideLength;

	private Piece[] _board;

	// When no board is provided initialise the default board
	public Board() : this(CreateDefaultBoard())
	{
	}

	// Initialise the board with a predefined layout
	public Board(Piece[] board)
	{
		if (board.Length != BoardSize)
		{
			throw new ArgumentException($"Predefined board size is incorrect: {BoardSize} expected, but got {board.Length}");
		}
		_board = board;
		foreach (var piece in _board)
		{
			if (piece != null)
			{
				piece.Board = this;
			}
		}
	}

	// PrintBoard writes the board out to the console
	public void PrintBoard()
	{
		// _board[0] = A1
		// _board[1] = B1
		// and so on...
		Console.WriteLine("   ----------------");
		for (int row = 7; row >= 0; row--)
		{
			Console.Write($"{row + 1} |");
			for (int col = 0; col <= 7; col++)
			{
				var piece = _board[GetIndexByCoords(col, row)];
				Console.Write($"{piece?.ToString() ?? " "} ");
			}
			Console.WriteLine("|");
		}
		Console.WriteLine("   ----------------");
		Console.WriteLine("   A B C D E F G H");
	}

	// Get a piece from the array
	public Piece GetPlayerPiece(int x, int y)
	{
		BoundsCheck(x, y);
		int index = GetIndexByCoords(x, y);
		Piece piece = _board[index];
		_board[index] = null;
		return piece;
	}

	// Set a piece in the array
	public void SetPlayerPiece(int x, int y, Piece p)
	{
		BoundsCheck(x, y);
		if (p == null)
		{
			throw new ArgumentNullException("Piece is null");
		}
		_board[GetIndexByCoords(x, y)] = p;
		p.Board = this;
	}

	// Make sure the X and Y are not outside the array bounds
	public void BoundsCheck(int x, int y)
	{
		if (x < 0 || x >= SideLength || y < 0 || y >= SideLength)
		{
			throw new ArgumentOutOfRangeException($"Point is out of range: ({x}, {y})");
		}
	}

	private int GetIndexByCoords(int x, int y)
	{
		return y * SideLength + x;
	}

	private static Piece[] CreateDefaultBoard()
	{
		Piece[] board = new Piece[BoardSize];

		board[0] = new Rook(Color.White);
		board[1] = new Knight(Color.White);
		board[2] = new Bishop(Color.White);
		board[3] = new Queen(Color.White);
		board[4] = new King(Color.White);
		board[5] = new Bishop(Color.White);
		board[6] = new Knight(Color.White);
		board[7] = new Rook(Color.White);

		board[56] = new Rook(Color.Black);
		board[57] = new Knight(Color.Black);
		board[58] = new Bishop(Color.Black);
		board[59] = new Queen(Color.Black);
		board[60] = new King(Color.Black);
		board[61] = new Bishop(Color.Black);
		board[62] = new Knight(Color.Black);
		board[63] = new Rook(Color.Black);

		for (int i = 8; i < 16; i++)
		{
			board[i] = new Pawn(Color.White);
			board[^(i + 1)] = new Pawn(Color.Black);
		}

		return board;
	}
}
