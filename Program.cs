using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToe newGame = new TicTacToe();
            int row;
            int column;
            int currentPlayer=1;
            int moveCount = 0;

            while (newGame.CheckWinner() == 0 && moveCount<9)
            {
                newGame.PrintBoard();
                if (moveCount % 2 == 0)
                {
                    currentPlayer = 1;
                }
                else if (moveCount % 2 !=0)
                {
                    currentPlayer = 2;
                }
                Console.WriteLine($"\nPlayer {currentPlayer} enter the row you want to play: ");
                row = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nPlayer {currentPlayer} enter the column you want to play: ");
                column = int.Parse(Console.ReadLine());
                newGame.MakeMove(row, column, currentPlayer);
                moveCount++;
            }
            int winner = newGame.CheckWinner();
            if (winner != 0) {
                Console.WriteLine($"Player{winner} won!");
            }
            else
            {
                Console.WriteLine("Its a draw!");
            }
            Console.ReadLine();

        }
    }
}
