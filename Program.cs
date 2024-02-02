// See https://aka.ms/new-console-template for more information

using Mission4;

internal class Program
{
    static void Main(string[] args)
    {
        Winner wn;
        wn = new Winner();
        
        static void InitializeBoard(char[,] board)
        {
            // Created the 2D array and filled the intersections with empty strings
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    board[row, column] = ' ';
                }
            }
        }

        int PlayerTurn(char[,] board, int player)
        {
            while (true)
            {
                // Ask the player to make a move
                Console.WriteLine("Player " + player + ", enter the row (0, 1, or 2) and column (0, 1, or 2) of your move: ");
                // Read the player's move
                int row = int.Parse(Console.ReadLine());
                int column = int.Parse(Console.ReadLine());
        
                // Check for invalid entries
                if (row < 0 || row > 2 || column < 0 || column > 2)
                {
                    Console.WriteLine("Invalid move. Please try again.");
                    continue; // Restart the loop to prompt the player again
                }

                // Check if the move is valid
                if (board[row, column] == ' ')
                {
                    // If the move is valid, fill the intersection with the player's symbol
                    if (player == 1)
                    {
                        board[row, column] = 'X';
                        // Check if the player has won
                        if (wn.CheckForWinner(board, 'X'))
                        {
                            Console.WriteLine("Player 1 wins!");
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                    else
                    {
                        board[row, column] = 'O';
                        // Check if the player has won
                        if (wn.CheckForWinner(board, 'O'))
                        {
                            Console.WriteLine("Player 2 wins!");
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
                else
                {
                    // If the move is invalid, inform the player and continue the loop
                    Console.WriteLine("Invalid move. Please try again.");
                }
            }
        }



        Console.WriteLine("Welcome to Tic-Tac-Toe!\n");

        // Create a 3x3 game board
        char[,] board = new char[3, 3];

        // Pass the game board to the initialize board function to fill it with empty strings
        InitializeBoard(board);
        
        // Ask each player in turn to make a move
        int player = 1;
        
        while (player != 0)
        {
            wn.PrintBoard(board);
            player = PlayerTurn(board, player);
        }
    }    
}
