using System;

// Command class is a place holder for a webserver call handler.
public class Command
{
	// MovePiece on the board
	public static void MovePiece(Board board, Point from, Point to)
	{
		try
		{
			// TODO: Move piece as required
			throw new NotImplementedException();
		}
		catch (Exception e)
		{
			// Bury the exception for testing all pieces and log to console
			Console.WriteLine(e.Message);
		}
	}
}
