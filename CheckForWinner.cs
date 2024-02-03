using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4
{
    internal class Winner
    {
        public bool CheckForWinner(char[,] board, char player)
        {
            // Check rows, columns, and diagonals
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == player && board[i, 1] == player && board[i, 2] == player) ||
                    (board[0, i] == player && board[1, i] == player && board[2, i] == player))
                {
                    return true; // Winner
                }
            }

            if ((board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) ||
                (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player))
            {
                return true; // Winner
            }

            return false; //No Winner
        }
        public void PrintBoard(char[,] board)
        {
            //Print Rows
            for (int i = 0;i < 3;i++)
            {
                //Print Columns
                for(int j = 0;j < 3;j++)
                {
                    Console.Write(board[i,j] + " ");
                }
                
                Console.WriteLine();
            }
        }
    }
}
