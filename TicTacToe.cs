using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game
{
    class TicTacToe
    {
        private int[,] board;  
        public TicTacToe()
        {
            board = new int[3, 3]
            {
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 }
            };
        }
        public void PrintBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == 0)
                        Console.Write(" . ");
                    else if (board[i, j] == 1)
                        Console.Write(" X ");
                    else
                        Console.Write(" O ");
                }
                Console.WriteLine();
            }
        }
        public bool MakeMove(int x, int y, int player)
        {
            if (x >= 0 && x < 3 && y >= 0 && y < 3)
            {
                if (board[x, y] == 0)
                {
                    board[x, y] = player;
                    return true;
                }
                else
                {
                    Console.WriteLine("This cell is already occupied. Try again.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Invalid move. Coordinates must be between 0 and 2.");
                return false;
            }
        }

        public int CheckWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != 0)
                    return board[i, 0];
            }

            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == board[1, j] && board[1, j] == board[2, j] && board[0, j] != 0)
                    return board[0, j];
            }

            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != 0)
                return board[0, 0];
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != 0)
                return board[0, 2];

            return 0;
        }
    }
}
