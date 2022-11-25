using ConsoleApp1.Lessons.M1.L2.Enums;
using ConsoleApp1.Lessons.M2.L2.Classes.Inheritance;


namespace ConsoleApp1.Lessons.M2.L2
{
    public class L2inheritance
    {
        public static void Run()
        {
            ChessPiece chessPiece = new King();//ChessPice chessPice=new ChessPice(); - ta linijka gdy nie ma abstract w ChessPiece
            chessPiece.XPosition = 1;
            chessPiece.YPosition = 1;
            chessPiece.Color = ChessColor.WHITE;
            chessPiece.Move();
            chessPiece.Present();
            ConfirmLiveness(chessPiece);

            ChessPiece king1 = new King();//ChessPice chessPice=new Queen(); - ta linijka gdy jest abstract w ChessPiece
            king1.XPosition = 1;
            king1.YPosition = 1;
            king1.Color = ChessColor.WHITE;
            king1.Move();
            king1.Present();
            ConfirmLiveness(king1);

            Queen queen = new Queen();
            queen.Move();
            queen.XPosition = 1;
            queen.YPosition = 1;
            queen.Color = ChessColor.WHITE;
            queen.Present();
            ConfirmLiveness(queen);

            King king = new King();
            king.Move();
            king.XPosition = 1;
            king.YPosition = 1;
            king.Color = ChessColor.WHITE;
            king.Present();
            ConfirmLiveness(king);

            Knight knight = new Knight();
            knight.Move();
            knight.XPosition = 1;
            knight.YPosition = 1;
            knight.Color = ChessColor.WHITE;
            knight.Present();
            ConfirmLiveness(knight);

            Bishop bishop = new Bishop();
            bishop.Move();
            bishop.XPosition = 1;
            bishop.YPosition = 1;
            bishop.Color = ChessColor.WHITE;
            bishop.Present();
            ConfirmLiveness(bishop);

        }

        public static void ConfirmLiveness(ChessPiece chessPiece)
        {
            if (chessPiece.IsAlive)
            {
                Console.WriteLine("The piece is alive.");
            }
            else
            {
                Console.WriteLine("The piece is not alive.");
            }
        }
    }
}
