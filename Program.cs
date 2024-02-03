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
                Console.WriteLine("Player " + player + ", enter the row (0, 1, or 2)");
                string rowInput = Console.ReadLine();
                
                Console.WriteLine("Player " + player + ", enter the column (0, 1, or 2)");
                
                string columnInput = Console.ReadLine();

                int row;                 
                int column; 
                
                if ((rowInput == "0" || rowInput == "1" || rowInput == "2") && (columnInput == "0" || columnInput == "1" || columnInput == "2"))
                {
                    // Both conversions were successful
                    row = int.Parse(rowInput);
                    column =  int.Parse(columnInput);

                    Console.WriteLine("Row: " + row);
                    Console.WriteLine("Column: " + column);
                }
                else
                {
                    // At least one conversion failed
                    Console.WriteLine("Invalid input. Please enter valid integer values for row and column.");
                    continue; 
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
                            wn.PrintBoard(board);
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
                            wn.PrintBoard(board);
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
