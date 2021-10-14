using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nWelcome to C# Tic Tac Toe");
            Console.WriteLine("\nSelect which mode you would like to play\nSelect the number that applies: ");
            Console.WriteLine("\t1 Player vs Player");
            Console.WriteLine("\t2 Player vs Computer");
            string userInput = Console.ReadLine();
            int userChoice = int.Parse(userInput);
            if (userChoice == 1)
            {
                PrintBoard board = new PrintBoard();
                board.MakeBoard();
                PlayerMove move = new PlayerMove();
                move.PlayerChioce();
            }
            if (userChoice == 2)
            {
                PrintBoard board = new PrintBoard();
                board.MakeBoard();
                PlayerVsComputer playComputer = new PlayerVsComputer();
                playComputer.PlayerComputer();
            }
        }
    }
}
