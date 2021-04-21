using System;

namespace interview_test
{
	class Program
	{
		static void Main(string[] args)
		{
			Board b = new Board();

			// Biegler vs Peperle 1952 game. 22 Moves
			Move[] game = new Move[] {
				new Move { From=new Point {X=3, Y=1}, To=new Point {X=3, Y=3}}, // WPawn
				new Move { From=new Point {X=6, Y=7}, To=new Point {X=5, Y=5}}, // BKnight
				new Move { From=new Point {X=2, Y=1}, To=new Point {X=2, Y=3}}, // WPawn
				new Move { From=new Point {X=4, Y=6}, To=new Point {X=4, Y=4}}, // BPawn
				new Move { From=new Point {X=3, Y=3}, To=new Point {X=3, Y=4}}, // WPawn
				new Move { From=new Point {X=5, Y=7}, To=new Point {X=2, Y=4}}, // BBishop
				new Move { From=new Point {X=7, Y=1}, To=new Point {X=7, Y=2}}, // WPawn
				new Move { From=new Point {X=2, Y=4}, To=new Point {X=5, Y=1}}, // BBishop
				new Move { From=new Point {X=4, Y=0}, To=new Point {X=5, Y=1}}, // WKing
				new Move { From=new Point {X=5, Y=5}, To=new Point {X=4, Y=3}}, // BKnight
				new Move { From=new Point {X=5, Y=1}, To=new Point {X=5, Y=2}}, // WKing
				new Move { From=new Point {X=3, Y=7}, To=new Point {X=7, Y=3}}, // BQueen
				new Move { From=new Point {X=6, Y=1}, To=new Point {X=6, Y=2}}, // WPawn
				new Move { From=new Point {X=7, Y=3}, To=new Point {X=6, Y=2}}, // BQueen
				new Move { From=new Point {X=5, Y=2}, To=new Point {X=4, Y=3}}, // WKing
				new Move { From=new Point {X=5, Y=6}, To=new Point {X=5, Y=4}}, // BPawn
				new Move { From=new Point {X=4, Y=3}, To=new Point {X=5, Y=4}}, // WKing
				new Move { From=new Point {X=3, Y=6}, To=new Point {X=3, Y=5}}, // BPawn
				new Move { From=new Point {X=5, Y=4}, To=new Point {X=4, Y=3}}, // WKing
				new Move { From=new Point {X=2, Y=7}, To=new Point {X=5, Y=4}}, // BBishop
				new Move { From=new Point {X=4, Y=3}, To=new Point {X=5, Y=4}}, // WKing
				new Move { From=new Point {X=6, Y=2}, To=new Point {X=6, Y=5}}, // BQueen Checkmate
			};

			// Print out the game turns to console
			Console.WriteLine("Sample Chess Game");
			b.PrintBoard();
			Console.WriteLine();

			// TODO: Update however is required to PrintBoard for each turn
			for (int i = 0; i < game.Length; i++)
			{
				Move move = game[i];
				Command.MovePiece(b, move.From, move.To);
				b.PrintBoard();
			}
		}
	}
}
