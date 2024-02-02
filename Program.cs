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


        Console.WriteLine("Welcome to Tic-Tac-Toe!\n");

        // Create a 3x3 game board
        char[,] board = new char[3, 3];

        // Pass the game board to the initialize board function to fill it with empty strings
        InitializeBoard(board);
        
        // Ask each player in turn to make a move
        bool winner = false;
        int player = 1;
        
        
        while (!winner)
        {
            int row = 0;
            int column = 0;
            
            wn.PrintBoard(board);
            
            if (player == 1)
            {
                Console.WriteLine("Player 1, please enter the row and column where you want to place your X.");
                Console.WriteLine("Row: ");
                row = int.Parse(Console.ReadLine());
                Console.WriteLine("Column: ");
                column = int.Parse(Console.ReadLine());
                
                board[row, column] = 'X';
                
                if (wn.CheckForWinner(board, 'X'))
                {
                    Console.WriteLine("Player 1 wins!");
                    winner = true;
                }
                
                player = 2;
            }
            else
            {
                Console.WriteLine("Player 2, please enter the row and column where you want to place your O.");
                Console.WriteLine("Row: ");
                row = int.Parse(Console.ReadLine());
                Console.WriteLine("Column: ");
                column = int.Parse(Console.ReadLine());
                
                board[row, column] = 'O';
                
                if (wn.CheckForWinner(board, 'O'))
                {
                    Console.WriteLine("Player 2 wins!");
                    winner = true;
                }
                
                player = 1;
            }
        }
    }    
}
