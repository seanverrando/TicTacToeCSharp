using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class CheckForWinner
    {
        public int ResultsOfGame(char[,] position)
        {
			//PrintBoard board = new PrintBoard();
			//char[,] position = board.boardPositions;

			if (position[0, 0] == position[0, 1] && position[0, 1] == position[0, 2])
			{
				return 1;
			}
			else if (position[1,0] == position[1,1] && position[1,1] == position[1,2])
				return 1;
			else if (position[2,0] == position[2,1] && position[2,1] == position[2,2])
				return 1;
			else if (position[0,0] == position[1,0] && position[1,0] == position[2,0])
				return 1;
			else if (position[0,1] == position[1,1] && position[1,1] == position[2,1])
				return 1;
			else if (position[0,2] == position[1,2] && position[1,2] == position[2,2])
				return 1;
			else if (position[0,0] == position[1,1] && position[1,1] == position[2,2])
				return 1;
			else if (position[0,2] == position[1,1] && position[1,1] == position[2,0])
				return 1;
			else if (position[0,0] != '1' && position[0,1] != '2' && position[0,2] != '3' && position[1,0] != '4' &&
				position[1,1] != '5' && position[1,2] != '6' && position[2,0] != '7' && position[2,1] != '8' && position[2,2] != '9')
				return 0;
			else
				return -1;
		}
    }
}
