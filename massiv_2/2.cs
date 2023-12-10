using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Исходный массив:");
        PrintMatrix(matrix);

        SwapRows(matrix, 0, matrix.GetLength(0) - 1);

        Console.WriteLine("\nМассив после замены:");
        PrintMatrix(matrix);
    }

    static void SwapRows(int[,] matrix, int row1, int row2)
    {
        int cols = matrix.GetLength(1);
        for (int col = 0; col < cols; col++)
        {
            int temp = matrix[row1, col];
            matrix[row1, col] = matrix[row2, col];
            matrix[row2, col] = temp;
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
