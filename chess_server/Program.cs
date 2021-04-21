using System;

namespace interview_test
{
	class Program
	{
		static void Main(string[] args)
		{
			Board b = new Board();

			// Biegler vs Peperle 1952 game. 22 Moves
			//Move[] game = new Move[] {
			//	new Move { From=new Point {X=3, Y=1}, To=new Point {X=3, Y=3}}, // WPawn
			//	new Move { From=new Point {X=6, Y=7}, To=new Point {X=5, Y=5}}, // BKnight
			//	new Move { From=new Point {X=2, Y=1}, To=new Point {X=2, Y=3}}, // WPawn
			//	new Move { From=new Point {X=4, Y=6}, To=new Point {X=4, Y=4}}, // BPawn
			//	new Move { From=new Point {X=3, Y=3}, To=new Point {X=3, Y=4}}, // WPawn
			//	new Move { From=new Point {X=5, Y=7}, To=new Point {X=2, Y=4}}, // BBishop
			//	new Move { From=new Point {X=7, Y=1}, To=new Point {X=7, Y=2}}, // WPawn
			//	new Move { From=new Point {X=2, Y=4}, To=new Point {X=5, Y=1}}, // BBishop
			//	new Move { From=new Point {X=4, Y=0}, To=new Point {X=5, Y=1}}, // WKing
			//	new Move { From=new Point {X=5, Y=5}, To=new Point {X=4, Y=3}}, // BKnight
			//	new Move { From=new Point {X=5, Y=1}, To=new Point {X=5, Y=2}}, // WKing
			//	new Move { From=new Point {X=3, Y=7}, To=new Point {X=7, Y=3}}, // BQueen
			//	new Move { From=new Point {X=6, Y=1}, To=new Point {X=6, Y=2}}, // WPawn
			//	new Move { From=new Point {X=7, Y=3}, To=new Point {X=6, Y=2}}, // BQueen
			//	new Move { From=new Point {X=5, Y=2}, To=new Point {X=4, Y=3}}, // WKing
			//	new Move { From=new Point {X=5, Y=6}, To=new Point {X=5, Y=4}}, // BPawn
			//	new Move { From=new Point {X=4, Y=3}, To=new Point {X=5, Y=4}}, // WKing
			//	new Move { From=new Point {X=3, Y=6}, To=new Point {X=3, Y=5}}, // BPawn
			//	new Move { From=new Point {X=5, Y=4}, To=new Point {X=4, Y=3}}, // WKing
			//	new Move { From=new Point {X=2, Y=7}, To=new Point {X=5, Y=4}}, // BBishop
			//	new Move { From=new Point {X=4, Y=3}, To=new Point {X=5, Y=4}}, // WKing
			//	new Move { From=new Point {X=6, Y=2}, To=new Point {X=6, Y=5}}, // BQueen Checkmate
			//};

			// Print out the game turns to console
			Console.WriteLine("Simple Chess Game");
			b.PrintBoard();
			Console.WriteLine();

			Color currentPlayer = Color.White;
			bool isGameOver = false;

			while (!isGameOver)
			{
				Console.Write($"{currentPlayer} turn: ");
				string command_string = Console.ReadLine();
				try
				{
					// TODO: command parsing
					// Move command expected in format: "B1 C3"
					string[] tokens = command_string.Split(" ");
					if (tokens.Length != 2)
					{
						Console.WriteLine("Wrong format, try something like \"B1 C3\"");
						continue;
					}

					Point from = ParsePointFromString(tokens[0]);
					Point to = ParsePointFromString(tokens[1]);
					if (from == null || to == null)
					{
						Console.WriteLine("Wrong format, try something like \"B1 C3\"");
						continue;
					}

					Command.MovePiece(b, from, to);

					// If we got here, move was completed, so next player's turn
					currentPlayer = NextPlayerTurn(currentPlayer);
					b.PrintBoard();
					Console.WriteLine();
					// TODO: Update game status
					// isGameOver = IsGameOver(b, currentPlayer);
				}
				catch(Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
		}

		private static Point ParsePointFromString(string s)
		{
			Point point = null;
			if (s.Length != 2)
			{
				return point;
			}

			if (s[0] < 'A' || s[0] > 'H' || s[1] < '1' || s[1] > '8')
			{
				return point;
			}

			point = new Point() { X = s[0] - 'A', Y = s[1] - '1' };
			return point;
		}

		private static Color NextPlayerTurn(Color currentPlayer)
		{
			return (Color)(((int)(currentPlayer) + 1) % 2);
		}

		private static bool IsGameOver(Board board, Color currentPlayer)
		{
			throw new NotImplementedException();
		}
	}
}
