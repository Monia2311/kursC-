using ConsoleApp1.Lessons.M1.L2.Enums;

namespace ConsoleApp1.Lessons.M2.L2.Classes.Inheritance
{
    public abstract class ChessPiece //public abstract class ChessPiece
    {
        public ChessColor? Color { get; set; }//bez ? domyślnie wczytuje do konsoli PAWN bo jest pierwszy na liście figur
        public ChessFigureType? Type { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public bool IsAlive { get; set; }

        public ChessPiece()
        {
            IsAlive = true;
        }

        public void Move()
        {
            Console.WriteLine("Chess Piece is moving...");
        }

        public void Present()
        {
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Is it alive: {IsAlive}");
            Console.WriteLine($"X position: {XPosition}");
            Console.WriteLine($"Y position: {YPosition}");
        }
    }
}
