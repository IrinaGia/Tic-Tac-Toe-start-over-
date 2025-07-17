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
            int choice = 0;

            if (!int.TryParse(input, out choice) || choice < 1 || choice > 9) // For myself: this condition should validate the user input. TryParse helps to convert int into string.
            {
                Console.WriteLine("Invalid input. Press any key to try again.");
                Console.ReadKey(); // reads what button user presses
                continue;
            }

            /* next row and col are kinda converting user choise into grid's cell
            that is set as 2d array. So if user chooses 9, then: 
            row= (9 - 1) / 3 = 2, col = (9 - 1) % 3 = 2. Cell is grid[2, 2] 
            I found this solution from the internet. And i liked it.*/

            int row = (choice - 1) / 3;
            int col = (choice - 1) % 3;

            grid[row, col] = currentPlayer; // we assign this cell choice to a user
            moves++;

            if (moves == 9) // when there is no any win
            {
                Console.Clear();
                PrintGrid(grid);
                Console.WriteLine("\nIt's a draw!");
                break;
            }

            // switches from one player to another
            if (currentPlayer == "X")
            {
                currentPlayer = "O";
            }
            else
            {
                currentPlayer = "X";
            }
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
