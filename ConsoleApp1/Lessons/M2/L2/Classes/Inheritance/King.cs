using ConsoleApp1.Lessons.M1.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lessons.M2.L2.Classes.Inheritance
{
    public class King : ChessPiece
    {
        public bool Checked { get; set; }

        public King() : base()
        {
            Checked = false;
            Type = ChessFigureType.KING;
        }

        //override
        public void Move()
        {
            Console.WriteLine("The King is moving...");
        }
    }
}
