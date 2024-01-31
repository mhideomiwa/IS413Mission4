// See https://aka.ms/new-console-template for more information

internal class Program
{
    static void Main(string[] args)
    {
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
    }    
}
