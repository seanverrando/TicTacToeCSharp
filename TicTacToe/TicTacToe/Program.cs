using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nWelcome to C# Tic Tac Toe");

            PrintBoard board = new PrintBoard();
            board.MakeBoard();
            PlayerMove move = new PlayerMove();
            move.PlayerChioce();
        }
    }
}
