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

        int minSumRowIndex = FindRowWithMinSum(matrix);

        Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRowIndex}");
    }

    static int FindRowWithMinSum(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int minSum = int.MaxValue;
        int minSumRowIndex = -1;

        for (int row = 0; row < rows; row++)
        {
            int rowSum = 0;
            for (int col = 0; col < cols; col++)
            {
                rowSum += matrix[row, col];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRowIndex = row;
            }
        }

        return minSumRowIndex;
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
