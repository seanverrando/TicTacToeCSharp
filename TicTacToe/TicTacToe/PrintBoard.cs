using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class PrintBoard
    {
        public char[,] boardPositions = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        public void MakeBoard()
        {
            
            Console.WriteLine("\n\nPLAYER 1 is (X)\tPLAYER 2 is (O)\n\n");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + boardPositions[0,0] + "  |  " + boardPositions[0,1] + "  |  " + boardPositions[0,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + boardPositions[1, 0] + "  |  " + boardPositions[1, 1] + "  |  " + boardPositions[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + boardPositions[2, 0] + "  |  " + boardPositions[2, 1] + "  |  " + boardPositions[2, 2]);
            Console.WriteLine("     |     |     ");
        }
    }
}
