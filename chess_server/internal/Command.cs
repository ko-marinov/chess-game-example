using System;

// Command class is a place holder for a webserver call handler.
public class Command
{
	// MovePiece on the board
	public static void MovePiece(Board board, Point from, Point to)
	{
		try
		{
			board.BoundsCheck(from.X, from.Y);
			board.BoundsCheck(to.X, to.Y);

			// Get piece to work with
			Piece piece = board.GetPlayerPiece(from.X, from.Y);
			if (piece == null)
			{
				throw new Exception($"Piece at ({from.X}, {from.Y}) not found.");
			}

			try
			{
				// TODO: Check which player's turn now

				// Check is move valid
				piece.Move(from, to);

				// TODO: Check current player's king is not in check after move
			}
			catch (Exception)
			{
				// Put piece back if something went wrong
				board.SetPlayerPiece(from.X, from.Y, piece);
				throw;
			}

			board.SetPlayerPiece(to.X, to.Y, piece);

			// TODO: Write move to somewhere (log, db, etc.)
			// TODO: Next player's turn
		}
		catch (Exception e)
		{
			// Bury the exception for testing all pieces and log to console
			Console.WriteLine(e.Message);
		}
	}
}
