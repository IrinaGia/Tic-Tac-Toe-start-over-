using System;

class TicTacToe
{
    static void Main(string[] args)
    {
        const int ROWS = 3;
        const int COLS = 3;
        string[,] grid = new string[ROWS, COLS];
        string currentPlayer = "X";
        int moves = 0;

        // Initialize grid with numbers 1–9
        int cellNumber = 1;
        for (int i = 0; i < ROWS; i++)
        {
            for (int j = 0; j < COLS; j++)
            {
                grid[i, j] = cellNumber.ToString();
                cellNumber++;
            }
        }

        // Game loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Tic Tac Toe");
            PrintGrid(grid);

            Console.Write($"\nPlayer {currentPlayer}, choose a cell (1-9): ");
            string input = Console.ReadLine();


            if (moves == 9)
            {
                Console.Clear();
                PrintGrid(grid);
                Console.WriteLine("\nIt's a draw!");
                break;
            }

            currentPlayer = currentPlayer == "X" ? "O" : "X";
        }
    }

    static void PrintGrid(string[,] grid)
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < 3; j++)
            {
                Console.Write(" " + grid[i, j] + " ");
                if (j < 2) Console.Write("|");
            }
            if (i < 2)
                Console.WriteLine("\n---+---+---");
        }
    }
}
