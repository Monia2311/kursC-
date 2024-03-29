﻿using ConsoleApp1.Lessons.M1.L2.Enums;


namespace ConsoleApp1.Lessons.M2.L2.Classes.Inheritance
{
    public class Pawn : ChessPiece
    {
        public Pawn() : base()
        {
            Type = ChessFigureType.PAWN;
        }

        //override
        public void Move()
        {
            Console.WriteLine("The Pawn is moving...");
        }
    }
}
