using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class PlayerMove
    {
        public void PlayerChioce()
        {
            char markX = 'X';
            char markO = 'O';
            int playerID = 1;
            int choice =0;
            int resultOfGame = -1;

            PrintBoard board = new PrintBoard();
            char[,] position = board.boardPositions;

            while (resultOfGame == -1)
            {
                if(resultOfGame != -1)
                {
                    break;
                }
                if (playerID == 1)
                {
                    Console.WriteLine("\n\nPlayer1 is X, enter the number for position on the board: ");
                    choice = int.Parse(Console.ReadLine());
                }
                else if (playerID == 2)
                {
                    Console.WriteLine("\n\nPlayer2 is O, enter number for position on the board: ");
                    choice = int.Parse(Console.ReadLine());
                }
                if (choice == 1 && position[0,0] == '1')
                {
                    if(playerID == 1)
                    {
                        position[0, 0] = markX;
                        playerID ++;
                    }
                    else
                    {
                        position[0, 0] = markO;
                        playerID--;
                    }
                }
                else if (choice == 2 && position[0, 1] == '2')
                {
                    if (playerID == 1)
                    {
                        position[0, 1] = markX;
                        playerID++;
                    }
                    else
                    {
                        position[0, 1] = markO;
                        playerID--;
                    }
                }
                else if (choice == 3 && position[0, 2] == '3')
                {
                    if (playerID == 1)
                    {
                        position[0, 2] = markX;
                        playerID++;
                    }
                    else
                    {
                        position[0, 2] = markO;
                        playerID--;
                    }
                }
                else if (choice == 4 && position[1, 0] == '4')
                {
                    if (playerID == 1)
                    {
                        position[1, 0] = markX;
                        playerID++;
                    }
                    else
                    {
                        position[1, 0] = markO;
                        playerID--;
                    }
                }
                else if (choice == 5 && position[1, 1] == '5')
                {
                    if (playerID == 1)
                    {
                        position[1, 1] = markX;
                        playerID++;
                    }
                    else
                    {
                        position[1, 1] = markO;
                        playerID--;
                    }
                }
                else if (choice == 6 && position[1, 2] == '6')
                {
                    if (playerID == 1)
                    {
                        position[1, 2] = markX;
                        playerID++;
                    }
                    else
                    {
                        position[1, 2] = markO;
                        playerID--;
                    }
                }
                else if (choice == 7 && position[2, 0] == '7')
                {
                    if (playerID == 1)
                    {
                        position[2, 0] = markX;
                        playerID++;
                    }
                    else
                    {
                        position[2, 0] = markO;
                        playerID--;
                    }
                }
                else if (choice == 8 && position[2, 1] == '8')
                {
                    if (playerID == 1)
                    {
                        position[2, 1] = markX;
                        playerID++;
                    }
                    else
                    {
                        position[2, 1] = markO;
                        playerID--;
                    }
                }
                else if (choice == 9 && position[2, 2] == '9')
                {
                    if (playerID == 1)
                    {
                        position[2, 2] = markX;
                        playerID++;
                    }
                    else
                    {
                        position[2, 2] = markO;
                        playerID--;
                    }
                }
                else
                {
                    Console.WriteLine("\n\n IVALID CHOICE");
                }
                Console.WriteLine("_______________________________________________________");
                board.MakeBoard();
                CheckForWinner results = new CheckForWinner();
                resultOfGame = results.ResultsOfGame(position);
                continue;
               
            }
            if(resultOfGame == 1)
            {
                Console.WriteLine("Player {0} is the Winner", --playerID);
                Console.WriteLine("GAME OVER");
            }
            else
            {
                Console.WriteLine("Tie game");
                Console.WriteLine("GAME OVER");

            }
        }
    }
}
